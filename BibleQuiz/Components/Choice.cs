using MySql.Connection;
using MySql.Data.MySqlClient;

namespace BibleQuiz.Components
{
    internal class Choice : Validation
    {

        /**************************************************
         ********** CONSTRUCTORS **************************
         **************************************************/

        internal Choice() 
        {
            this.ID = 0;
            this.Question = 0;
            this.Value = "";
            this.Answer = false;
        }

        internal Choice(long id, long question, string value, bool answer)
        {
            this.ID = id;
            this.Question = question;
            this.Value = value;
            this.Answer = answer;
        }

        /**************************************************
         ********** PROPERTIES ****************************
         **************************************************/

        internal long ID { get; set; }

        internal long Question { get; set; }

        internal string Value { get; set; }

        internal bool Answer { get; set; }

        /**************************************************
         ********** STATIC METHODS ************************
         **************************************************/

        /// <summary>
        /// Gets the Choice data by its ID
        /// </summary>
        /// <param name="id">ID of the Choice</param>
        /// <returns>Choice object</returns>
        internal static Choice GetByID(long id)
        {
            Choice choice = new Choice();
            try
            {
                string SQL = "SELECT * FROM [choices] WHERE [id] = @id";
                using (var con = new MySqlConnection(Builder.ConnectionString))
                {
                    using (var cmd = new MySqlCommand(SQL, con))
                    {
                        cmd.Parameters.AddWithValue("id", id);
                        con.Open();
                        using (var rdr = cmd.ExecuteReader())
                        {
                            if (rdr.HasRows)
                            {
                                choice = DataReader.ReadChoices(rdr)[0];
                            }
                        }
                    }
                }
            }
            catch (ComponentsException ex)
            {
                ErrorTrapper.Log(ex, LogOptions.PromptTheUser);
            }
            return choice;
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
            string SQL = "";
            Validate(this);
            if (ID > 0)
            {
                SQL = "UPDATE [choices] SET [question] = @question, [value] = @value, [answer] = @answer WHERE [id] = @id";
                using (var con = new MySqlConnection(Builder.ConnectionString))
                {
                    using (var cmd = new MySqlCommand(SQL, con))
                    {
                        cmd.Parameters.AddWithValue("question", Question);
                        cmd.Parameters.AddWithValue("value", Value);
                        cmd.Parameters.AddWithValue("answer", Answer);
                        cmd.Parameters.AddWithValue("id", ID);
                        con.Open();
                        saved = cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            else
            {
                SQL = "INSERT INTO [choices] ([question], [value], [answer]) VALUES (@question, @value, @answer)";
                using (var con = new MySqlConnection(Builder.ConnectionString))
                {
                    using (var cmd = new MySqlCommand(SQL, con))
                    {
                        cmd.Parameters.AddWithValue("question", Question);
                        cmd.Parameters.AddWithValue("value", Value);
                        cmd.Parameters.AddWithValue("answer", Answer);
                        con.Open();
                        saved = cmd.ExecuteNonQuery() > 0;
                        if (saved)
                        {
                            ID = cmd.LastInsertedId;
                        }
                    }
                }
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
                string SQL = "DELETE FROM [choices] WHERE [id] = @id";
                using (var con = new MySqlConnection(Builder.ConnectionString))
                {
                    using (var cmd = new MySqlCommand(SQL, con))
                    {
                        cmd.Parameters.AddWithValue("id", ID);
                        con.Open();
                        deleted = cmd.ExecuteNonQuery() > 0;
                    }
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
            if (obj != null && obj.GetType() == typeof(Choice))
            {
                Choice choice = (Choice)obj;
                return (ID == choice.ID) & 
                    (Question == choice.Question) &
                    (Value == choice.Value) & 
                    (Answer == choice.Answer);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return 0x110010;
        }

        public override string ToString()
        {
            return " [id]=" + ID +
                " [question]=" + Question +
                " [value]=" + Value +
                " [answer]=" + Answer;
        }

    }
}
