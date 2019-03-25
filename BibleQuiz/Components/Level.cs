using MySql.Data.MySqlClient;
using System.Collections.Generic;
using MySql.Connection;
using BibleQuiz.Components;

namespace BibleQuiz
{
    internal class Level : Validation
    {

        /**************************************************
         ********** CONSTRUCTORS **************************
         **************************************************/

        internal Level() 
        {
            this.ID = 0;
            this.Name = "";
            this.Score = 0;
            this.Special = 0;
        }

        /**************************************************
         ********** PROPERTIES ****************************
         **************************************************/

        internal long ID { get; set; }

        internal string Name { get; set; }

        internal short Score { get; set; }

        internal short Special { get; set; }

        /**************************************************
         ********** STATIC METHODS ************************
         **************************************************/

        /// <summary>
        /// Gets all Levels
        /// </summary>
        /// <returns>List of Levels</returns>
        internal static List<Level> GetAll()
        {
            List<Level> levels = new List<Level>();
            try
            {
                string SQL = "SELECT * FROM [levels]";
                using (MySqlConnection con = new MySqlConnection(Builder.ConnectionString))
                {
                    using (var cmd = new MySqlCommand(SQL, con))
                    {
                        con.Open();
                        using (var rdr = cmd.ExecuteReader())
                        {
                            if (rdr.HasRows)
                            {
                                levels = DataReader.ReadLevels(rdr);
                            }
                        }
                    }
                }
            }
            catch (ComponentsException ex)
            {
                ErrorTrapper.Log(ex, LogOptions.PromptTheUser);
            }
            return levels;
        }

        /// <summary>
        /// Gets the Level data by its ID
        /// </summary>
        /// <param name="id">ID of the Level</param>
        /// <returns>Level object</returns>
        internal static Level GetByID(long id)
        {
            Level level = new Level();
            try
            {
                string SQL = "SELECT * FROM [levels] WHERE [id] = @id";
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
                                level = DataReader.ReadLevels(rdr)[0];
                            }
                        }
                    }
                }
            }
            catch (ComponentsException ex)
            {
                ErrorTrapper.Log(ex, LogOptions.PromptTheUser);
            }
            return level;
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
                    string SQL = "UPDATE [levels] SET [name] = @name, [score] = @score, [special] = @special WHERE [id] = @id";
                    using (MySqlConnection con = new MySqlConnection(Builder.ConnectionString))
                    {
                        MySqlCommand cmd = new MySqlCommand(SQL, con);
                        cmd.Parameters.AddWithValue("name", Name);
                        cmd.Parameters.AddWithValue("score", Score);
                        cmd.Parameters.AddWithValue("special", Special);
                        cmd.Parameters.AddWithValue("id", ID);
                        con.Open();
                        saved = cmd.ExecuteNonQuery() > 0;
                    }
                }
                else
                {
                    string SQL = "INSERT INTO [levels] ([name], [score], [special]) VALUES (@name, @score, @special)";
                    using (MySqlConnection con = new MySqlConnection(Builder.ConnectionString))
                    {
                        MySqlCommand cmd = new MySqlCommand(SQL, con);
                        cmd.Parameters.AddWithValue("name", Name);
                        cmd.Parameters.AddWithValue("score", Score);
                        cmd.Parameters.AddWithValue("special", Special);
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
                string SQL = "DELETE FROM [levels] WHERE [id] = @id";
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
            if (obj != null && obj.GetType() == typeof(Level))
            {
                Level level = (Level)obj;
                return (ID == level.ID) & 
                    (Name == level.Name) & 
                    (Score == level.Score) & 
                    (Special == level.Special);
            }
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return 0x10101;
        }

        public override string ToString()
        {
            return " [id]=" + ID +
                " [name]=" + Name +
                " [score]=" + Score +
                " [special]=" + Special;
        }

    }
}
