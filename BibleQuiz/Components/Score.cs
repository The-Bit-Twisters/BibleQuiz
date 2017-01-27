using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using MySql.Connection;

namespace BibleQuiz.Components
{
    internal class Score
    {

        /**************************************************
         ********** CONSTRUCTORS **************************
         **************************************************/

        private Score(long groupID, long questionID, short score)
        {
            this.group = groupID;
            this.question = questionID;
            this.score = score;
            this.saved = false;
        }

        /**************************************************
         ********** PROPERTIES ****************************
         **************************************************/

        private long group;
        private long question;
        private short score;
        private bool saved;

        /**************************************************
         ********** STATIC METHODS ************************
         **************************************************/

        /// <summary>
        /// Gets the total Score of the Group for all Games
        /// </summary>
        /// <param name="groupID">ID of the Group</param>
        /// <returns>Score number</returns>
        internal static short GetTotal(long groupID)
        {
            return ComputeScore(0, groupID);
        }

        /// <summary>
        /// Gets the total Score of the Group for the Game
        /// </summary>
        /// <param name="gameID">ID of the Game</param>
        /// <param name="groupID">ID of the Group</param>
        /// <returns>Score number</returns>
        internal static short GetGame(long gameID, long groupID)
        {
            return ComputeScore(gameID, groupID);
        }

        /// <summary>
        /// Saves the score of the Groups with Question
        /// </summary>
        /// <param name="question">Question</param>
        /// <param name="correctGroups">List of ID of the Groups that has correct answer</param>
        /// <param name="incorrectGroups">List of ID of the Groups that has incorrect answer</param>
        /// <param name="passGroups">List of ID of the Groups that passed with the Question</param>
        internal static void QuestionSave(Question question, List<long> correctGroups, List<long> incorrectGroups)
        {
            Level level = Level.GetByID(question.Level);
            short correctScore = (question.PassPlay) ? (short)(level.Special * 3) : level.Score;
            short incorrectScore = (question.PassPlay) ? (short)(level.Special * -2) : (short)0;
            foreach (long groupID in correctGroups)
            {
                Score groupscore = new Score(groupID, question.ID, correctScore);
                groupscore.Insert();
                if (!groupscore.saved)
                {
                    groupscore.Update();
                }
            }
            foreach (long groupID in incorrectGroups)
            {
                if (incorrectScore < 0)
                {
                    Score groupscore = new Score(groupID, question.ID, incorrectScore);
                    groupscore.Insert();
                    if (!groupscore.saved)
                    {
                        groupscore.Update();
                    }
                }
            }
        }

        /// <summary>
        /// Checks if the Group have answered correctly the Question
        /// </summary>
        /// <param name="groupID">ID of the Group</param>
        /// <param name="questionID">ID of the Question</param>
        /// <returns></returns>
        internal static short CheckScore(long groupID, long questionID)
        {
            Score score = new Score(groupID, questionID, 0);
            score.Check();
            return score.score;
        }

        /**************************************************
         ********** PRIVATE METHODS ***********************
         **************************************************/

        /// <summary>
        /// Computes the total Score of the Group for the Game. If the given GameID is equal to 0, the score will be computed for all Games.
        /// </summary>
        /// <param name="gameID">ID of the Game</param>
        /// <returns>Score number</returns>
        private static short ComputeScore(long gameID, long groupID)
        {
            string SQL = "SELECT SUM([score]) AS 'score' FROM [scores] JOIN [questions] ON [scores].[question] = [questions].[id] WHERE [group] = @group";
            if (gameID > 0)
            {
                SQL += " AND [questions].[game] = @game";
            }
            short score = 0;
            try
            {
                using (MySqlConnection con = new MySqlConnection(Builder.ConnectionString))
                {
                    using (var cmd = new MySqlCommand(SQL, con))
                    {
                        cmd.Parameters.AddWithValue("group", groupID);
                        if (gameID > 0)
                        {
                            cmd.Parameters.AddWithValue("game", gameID);
                        }
                        con.Open();
                        using (var rdr = cmd.ExecuteReader())
                        {
                            while (rdr.Read())
                            {
                                if (rdr["score"] != DBNull.Value)
                                {
                                    score = Convert.ToInt16(rdr["score"]);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorTrapper.Log(ex, LogOptions.LogToFile);
            }
            return score;
        }

        /// <summary>
        /// Checks the data
        /// </summary>
        private void Check()
        {
            try
            {
                string SQL = "SELECT [score] FROM [scores] WHERE [group] = @group AND [question] = @question";
                using (MySqlConnection con = new MySqlConnection(Builder.ConnectionString))
                {
                    using (var cmd = new MySqlCommand(SQL, con))
                    {
                        cmd.Parameters.AddWithValue("group", group);
                        cmd.Parameters.AddWithValue("question", question);
                        con.Open();
                        using (var rdr = cmd.ExecuteReader())
                        {
                            while (rdr.Read())
                            {
                                if (DBNull.Value != rdr["score"])
                                {
                                    score = Convert.ToInt16(rdr["score"]);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorTrapper.Log(ex, LogOptions.LogToFile);
            }
        }

        /// <summary>
        /// Saves the Score data
        /// </summary>
        private void Insert()
        {
            try
            {
                string SQL = "INSERT INTO [scores] ([group], [question], [score]) VALUES (@group, @question, @score)";
                using (MySqlConnection con = new MySqlConnection(Builder.ConnectionString))
                {
                    using (var cmd = new MySqlCommand(SQL, con))
                    {
                        cmd.Parameters.AddWithValue("group", group);
                        cmd.Parameters.AddWithValue("question", question);
                        cmd.Parameters.AddWithValue("score", score);
                        con.Open();
                        saved = cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorTrapper.Log(ex, LogOptions.LogToFile);
            }
        }

        private void Update()
        {
            try
            {
                string SQL = "UPDATE [scores] SET [score] = @score WHERE [group] = @group AND [question] = @question";
                using (MySqlConnection con = new MySqlConnection(Builder.ConnectionString))
                {
                    using (var cmd = new MySqlCommand(SQL, con))
                    {
                        cmd.Parameters.AddWithValue("group", group);
                        cmd.Parameters.AddWithValue("question", question);
                        cmd.Parameters.AddWithValue("score", score);
                        con.Open();
                        saved = cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorTrapper.Log(ex, LogOptions.LogToFile);
            }
        }

    }
}
