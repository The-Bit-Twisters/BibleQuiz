using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using MySql.Connection;

namespace BibleQuiz.Components
{
    internal class Question : Validation
    {

        /**************************************************
         ********** CONSTRUCTORS **************************
         **************************************************/

        internal Question() 
        {
            this.ID = 0;
            this.Game = 0;
            this.Level = 0;
            this.Sequence = 0;
            this.PassPlay = false;
            this.QuestionStatement = "";
            this.BibleReference = "";
            this.ChoicesLayout = "";
            this.Choices = new List<Choice>();
        }

        /**************************************************
         ********** PROPERTIES ****************************
         **************************************************/

        internal long ID { get; set; }

        internal long Game { get; set; }

        internal long Level { get; set; }

        internal short Sequence { get; set; }

        internal bool PassPlay { get; set; }

        internal string QuestionStatement { get; set; }

        internal string BibleReference { get; set; }

        internal string ChoicesLayout { get; set; }

        internal List<Choice> Choices { get; set; }

        /**************************************************
         ********** STATIC METHODS ************************
         **************************************************/

        /// <summary>
        /// Gets the Question data by its ID
        /// </summary>
        /// <param name="id">ID of the Question</param>
        /// <returns>Question object</returns>
        internal static Question GetByID(long id)
        {
            Question question = new Question();
            try
            {
                string SQL = "SELECT * FROM [questions] WHERE [id] = @id";
                using (MySqlConnection con = new MySqlConnection(Builder.ConnectionString))
                {
                    using (var cmd = new MySqlCommand(SQL, con))
                    {
                        cmd.Parameters.AddWithValue("id", id);
                        con.Open();
                        using (var rdr = cmd.ExecuteReader())
                        {
                            if (rdr.HasRows)
                            {
                                question = DataReader.ReadQuestions(rdr)[0];
                            }
                        }
                    }
                }
            }
            catch (ComponentsException ex)
            {
                ErrorTrapper.Log(ex, LogOptions.PromptTheUser);
            }
            return question;
        }

        internal static short GetNextSequence(long gameID)
        {
            short sequence = 0;
            try
            {
                string SQL = "SELECT MAX([sequence]) AS last FROM [questions] WHERE [game] = @game";
                using (MySqlConnection con = new MySqlConnection(Builder.ConnectionString))
                {
                    MySqlCommand cmd = new MySqlCommand(SQL, con);
                    cmd.Parameters.AddWithValue("game", gameID);
                    con.Open();
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        if (DBNull.Value != rdr["last"])
                        {
                            sequence = Convert.ToInt16(rdr["last"]);
                        }
                    }
                }
            }
            catch (ComponentsException ex)
            {
                ErrorTrapper.Log(ex, LogOptions.PromptTheUser);
            }
            return ++sequence;
        }

        /**************************************************
         ********** METHODS *******************************
         **************************************************/

        /// <summary>
        /// Saves the data
        /// </summary>
        /// <returns>True if saved successfully, otherwise false</returns>
        internal bool Save()
        {
            bool saved = false;
            try
            {
                Validate(this);
                if (ID > 0)
                {
                    string SQL = "UPDATE [questions] SET [game] = @game, [level] = @level, [sequence] = @sequence, [passplay] = @passplay, [question_statement] = @question_statement, [bible_reference] = @bible_reference, [choices_layout] = @choices_layout WHERE [id] = @id";
                    using (MySqlConnection con = new MySqlConnection(Builder.ConnectionString))
                    {
                        MySqlCommand cmd = new MySqlCommand(SQL, con);
                        cmd.Parameters.AddWithValue("game", Game);
                        cmd.Parameters.AddWithValue("level", Level);
                        cmd.Parameters.AddWithValue("sequence", Sequence);
                        cmd.Parameters.AddWithValue("passplay", PassPlay);
                        cmd.Parameters.AddWithValue("question_statement", QuestionStatement);
                        cmd.Parameters.AddWithValue("bible_reference", BibleReference);
                        cmd.Parameters.AddWithValue("choices_layout", ChoicesLayout);
                        cmd.Parameters.AddWithValue("id", ID);
                        con.Open();
                        saved = cmd.ExecuteNonQuery() > 0;
                    }
                }
                else
                {
                    string SQL = "INSERT INTO [questions] ([game], [level], [sequence], [passplay], [question_statement], [bible_reference], [choices_layout]) VALUES (@game, @level, @sequence, @passplay, @question_statement, @bible_reference, @choices_layout)";
                    using (MySqlConnection con = new MySqlConnection(Builder.ConnectionString))
                    {
                        MySqlCommand cmd = new MySqlCommand(SQL, con);
                        cmd.Parameters.AddWithValue("game", Game);
                        cmd.Parameters.AddWithValue("level", Level);
                        cmd.Parameters.AddWithValue("sequence", Sequence);
                        cmd.Parameters.AddWithValue("passplay", PassPlay);
                        cmd.Parameters.AddWithValue("question_statement", QuestionStatement);
                        cmd.Parameters.AddWithValue("bible_reference", BibleReference);
                        cmd.Parameters.AddWithValue("choices_layout", ChoicesLayout);
                        con.Open();
                        saved = cmd.ExecuteNonQuery() > 0;
                        if (saved)
                        {
                            ID = cmd.LastInsertedId;
                        }
                    }
                }
                if (saved)
                {
                    foreach (Choice choice in Choices)
                    {
                        choice.Question = ID;
                        saved = choice.Save();
                    }
                }
            }
            catch (ComponentsException ex)
            {
                saved = false;
                if (Delete())
                {
                    foreach (Choice choice in Choices)
                    {
                        if (choice.ID > 0)
                        {
                            choice.Delete();
                        }
                    }
                }
                ErrorTrapper.Log(ex, LogOptions.PromptTheUser);
            }
            return saved;
        }

        /// <summary>
        /// Deletes the data
        /// </summary>
        /// <returns>True if deleted successfully, otherwise false</returns>
        internal bool Delete()
        {
            bool deleted = false;
            try
            {
                string SQL = "DELETE FROM [questions] WHERE [id] = @id";
                using (MySqlConnection con = new MySqlConnection(Builder.ConnectionString))
                {
                    MySqlCommand cmd = new MySqlCommand(SQL, con);
                    cmd.Parameters.AddWithValue("id", ID);
                    con.Open();
                    deleted = cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (ComponentsException ex)
            {
                ErrorTrapper.Log(ex, LogOptions.PromptTheUser);
            }
            return deleted;
        }

        /**
         * */

        /// <summary>
        /// Gets all choices associated with the Question
        /// </summary>
        /// <param name="questionID">ID of the Question</param>
        /// <returns>List of Choices</returns>
        internal List<Choice> GetChoices()
        {
            List<Choice> choices = new List<Choice>();
            try
            {
                string SQL = "SELECT * FROM [choices] WHERE [question] = @question";
                using (MySqlConnection con = new MySqlConnection(Builder.ConnectionString))
                {
                    using (var cmd = new MySqlCommand(SQL, con))
                    {
                        cmd.Parameters.AddWithValue("question", ID);
                        con.Open();
                        using (var rdr = cmd.ExecuteReader())
                        {
                            if (rdr.HasRows)
                            {
                                choices = DataReader.ReadChoices(rdr);
                            }
                        }
                    }
                }
            }
            catch (ComponentsException ex)
            {
                ErrorTrapper.Log(ex, LogOptions.PromptTheUser);
            }
            return choices;
        }

        /**************************************************
         ********** OVERRIDE METHODS **********************
         **************************************************/

        public override bool Equals(object obj)
        {
            if (obj != null && obj.GetType() == typeof(Question))
            {
                Question question = (Question)obj;
                return (ID == question.ID) & 
                    (Game == question.Game) & 
                    (Level == question.Level) & 
                    (Sequence == question.Sequence) & 
                    (QuestionStatement == question.QuestionStatement) & 
                    (PassPlay == question.PassPlay) & 
                    (BibleReference == question.BibleReference) &
                    (ChoicesLayout == question.ChoicesLayout);
            }
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return 0x10011001;
        }

        public override string ToString()
        {
            string _question = " [id]=" + ID +
                " [game]=" + Game +
                " [level]=" + Level +
                " [sequence]=" + Sequence +
                " [passplay]=" + PassPlay +
                " [questionstatement]=" + QuestionStatement +
                " [bible_reference]=" + BibleReference +
                " [choices_layout]=" + ChoicesLayout;
            string _choices = "";
            foreach (var choice in Choices)
            {
                _choices += Environment.NewLine + "\t" + choice.ToString();
            }
            return  _question + " [choices]=" + _choices;
        }

    }
}
