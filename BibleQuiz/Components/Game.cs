using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using MySql.Connection;

namespace BibleQuiz.Components
{
    internal class Game : Validation
    {

        /**************************************************
         ********** ENUMERATORS ***************************
         **************************************************/

        internal enum Filter
        {
            All = 1, Finished = 2, Unfinished = 3
        }

        /**************************************************
         ********** CONSTRUCTORS **************************
         **************************************************/

        internal Game() 
        {
            this.ID = 0;
            this.Sequence = 0;
            this.Date = DateTime.Today;
            this.Finished = false;
        }

        internal Game(long id, short sequence, DateTime date, bool finished)
        {
            this.ID = id;
            this.Sequence = sequence;
            this.Date = date;
            this.Finished = finished;
        }

        /**************************************************
         ********** PROPERTIES ****************************
         **************************************************/

        internal long ID { get; set; }

        internal short Sequence { get; set; }

        internal DateTime Date { get; set; }

        internal bool Finished { get; set; }

        internal List<Question> Questions
        {
            get { return GetQuestions(); }
        }

        /**************************************************
         ********** STATIC METHODS ************************
         **************************************************/

        /// <summary>
        /// Gets all Games
        /// </summary>
        /// <returns>List of Games</returns>
        internal static List<Game> GetAll(Filter filter)
        {
            List<Game> games = new List<Game>();
            try
            {
                string SQL = "SELECT * FROM [games]";
                switch (filter) 
                {
                    case Filter.Finished:
                    case Filter.Unfinished:
                        SQL += " WHERE [finished] = @finished";
                        break;
                }
                using (var con = new MySqlConnection(Builder.ConnectionString))
                {
                    using (var cmd = new MySqlCommand(SQL, con))
                    {
                        switch (filter)
                        {
                            case Filter.Finished:
                                cmd.Parameters.AddWithValue("finished", true);
                                break;
                            case Filter.Unfinished:
                                cmd.Parameters.AddWithValue("finished", false);
                                break;
                        }
                        con.Open();
                        using (var rdr = cmd.ExecuteReader())
                        {
                            if (rdr.HasRows)
                            {
                                games = DataReader.ReadGames(rdr);
                            }
                        }
                    }
                }
            }
            catch (ComponentsException ex)
            {
                ErrorTrapper.Log(ex, LogOptions.PromptTheUser);
            }
            return games;
        }

        /// <summary>
        /// Gets the Game data by its ID
        /// </summary>
        /// <param name="id">ID of the Game</param>
        /// <returns>Game object</returns>
        internal static Game GetByID(long id)
        {
            Game game = new Game();
            try
            {
                string SQL = "SELECT * FROM [games] WHERE [id] = @id";
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
                                game = DataReader.ReadGames(rdr)[0];
                            }
                        }
                    }
                }
            }
            catch (ComponentsException ex)
            {
                ErrorTrapper.Log(ex, LogOptions.PromptTheUser);
            }
            return game;
        }

        /// <summary>
        /// Gets the Game data by its Sequence
        /// </summary>
        /// <param name="sequence">Sequence of the Game</param>
        /// <returns>Game object</returns>
        internal static Game GetBySequence(short sequence)
        {
            Game game = new Game();
            try
            {
                string SQL = "SELECT * FROM [games] WHERE [sequence] = @sequence";
                using (MySqlConnection con = new MySqlConnection(Builder.ConnectionString))
                {
                    using (var cmd = new MySqlCommand(SQL, con))
                    {
                        cmd.Parameters.AddWithValue("sequence", sequence);
                        con.Open();
                        using (var rdr = cmd.ExecuteReader())
                        {
                            if (rdr.HasRows)
                            {
                                game = DataReader.ReadGames(rdr)[0];
                            }
                        }
                    }
                }
            }
            catch (ComponentsException ex)
            {
                ErrorTrapper.Log(ex, LogOptions.PromptTheUser);
            }
            return game;
        }

        /// <summary>
        /// Gets the Sequence of the last Game
        /// </summary>
        /// <returns>Sequence number</returns>
        internal static int GetLastSequence()
        {
            string SQL = "SELECT MAX([sequence]) AS 'last' FROM [games]";
            int sequence = 0;
            try
            {
                using (MySqlConnection con = new MySqlConnection(Builder.ConnectionString))
                {
                    MySqlCommand cmd = new MySqlCommand(SQL, con);
                    con.Open();
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        if (DBNull.Value != rdr["last"])
                        {
                            sequence = Convert.ToInt32(rdr["last"]);
                        }
                    }
                }
            }
            catch (ComponentsException ex)
            {
                ErrorTrapper.Log(ex, LogOptions.PromptTheUser);
            }
            return sequence;
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
                    string SQL = "UPDATE [games] SET [sequence] = @sequence, [date] = @date, [finished] = @finished WHERE [id] = @id";
                    using (MySqlConnection con = new MySqlConnection(Builder.ConnectionString))
                    {
                        MySqlCommand cmd = new MySqlCommand(SQL, con);
                        cmd.Parameters.AddWithValue("sequence", Sequence);
                        cmd.Parameters.AddWithValue("date", Date);
                        cmd.Parameters.AddWithValue("finished", Finished);
                        cmd.Parameters.AddWithValue("id", ID);
                        con.Open();
                        saved = cmd.ExecuteNonQuery() > 0;
                    }
                }
                else
                {
                    string SQL = "INSERT INTO [games] ([sequence], [date]) VALUES (@sequence, @date)";
                    using (MySqlConnection con = new MySqlConnection(Builder.ConnectionString))
                    {
                        MySqlCommand cmd = new MySqlCommand(SQL, con);
                        cmd.Parameters.AddWithValue("sequence", Sequence);
                        cmd.Parameters.AddWithValue("date", Date);
                        con.Open();
                        saved = cmd.ExecuteNonQuery() > 0;
                        if (saved)
                        {
                            ID = cmd.LastInsertedId;
                        }
                    }
                }
            }
            catch (ComponentsException ex)
            {
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
                string SQL = "DELETE FROM [games] WHERE [id] = @id";
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

        /**************************************************
         ********** OVERRIDE METHODS **********************
         **************************************************/

        public override bool Equals(object obj)
        {
            if (obj != null && obj.GetType() == typeof(Game))
            {
                Game game = (Game)obj;
                return (ID == game.ID) &
                    (Sequence == game.Sequence) & 
                    (Date == game.Date) & 
                    (Finished == game.Finished);
            }
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return 0x1010;
        }

        public override string ToString()
        {
            return " [id]=" + ID + 
                " [sequence]=" + Sequence +
                " [date]=" + Date.ToString("dd/MM/yy") +
                " [finished]=" + Finished;
        }

        /**************************************************
         ********** PRIVATE METHODS ***********************
         **************************************************/

        /// <summary>
        /// Gets all the Questions associated with the Game
        /// </summary>
        /// <param name="gameID">ID of the Game</param>
        /// <returns>List of Questions</returns>
        private List<Question> GetQuestions()
        {
            List<Question> questions = new List<Question>();
            try
            {
                string SQL = "SELECT * FROM [questions] WHERE [game] = @game";
                using (MySqlConnection con = new MySqlConnection(Builder.ConnectionString))
                {
                    using (var cmd = new MySqlCommand(SQL, con))
                    {
                        cmd.Parameters.AddWithValue("game", ID);
                        con.Open();
                        using (var rdr = cmd.ExecuteReader())
                        {
                            if (rdr.HasRows)
                            {
                                questions = DataReader.ReadQuestions(rdr);
                            }
                        }
                    }
                }
            }
            catch (ComponentsException ex)
            {
                ErrorTrapper.Log(ex, LogOptions.PromptTheUser);
            }
            return questions;
        }

    }
}
