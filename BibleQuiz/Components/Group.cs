using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using MySql.Connection;

namespace BibleQuiz.Components
{
    internal class Group : Validation
    {

        /**************************************************
         ********** CONSTRUCTORS **************************
         **************************************************/

        internal Group() 
        {
            this.ID = 0;
            this.Name = "";
            this.Members = new List<Member>();
        }

        /**************************************************
         ********** PROPERTIES ****************************
         **************************************************/

        internal long ID { get; set; }

        internal string Name { get; set; }

        internal List<Member> Members { get; set; }

        /**************************************************
         ********** STATIC METHODS ************************
         **************************************************/

        /// <summary>
        /// Gets all Groups
        /// </summary>
        /// <returns>List of Groups</returns>
        internal static List<Group> GetAll()
        {
            List<Group> groups = new List<Group>();
            try
            {
                string SQL = "SELECT * FROM [groups] WHERE [active] = @active ORDER BY [name] ASC";
                using (MySqlConnection con = new MySqlConnection(Builder.ConnectionString))
                {
                    using (var cmd = new MySqlCommand(SQL, con))
                    {
                        cmd.Parameters.AddWithValue("active", true);
                        con.Open();
                        using (var rdr = cmd.ExecuteReader())
                        {
                            if (rdr.HasRows)
                            {
                                groups = DataReader.ReadGroups(rdr);
                            }
                        }
                    }
                }
            }
            catch (ComponentsException ex)
            {
                ErrorTrapper.Log(ex, LogOptions.PromptTheUser);
            }
            return groups;
        }

        /// <summary>
        /// Gets the Group data by its ID
        /// </summary>
        /// <param name="id">ID of the Group</param>
        /// <returns>Group object</returns>
        internal static Group GetByID(long id)
        {
            Group group = new Group();
            try
            {
                string SQL = "SELECT * FROM [groups] WHERE [id] = @id";
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
                                group = DataReader.ReadGroups(rdr)[0];
                            }
                        }
                    }
                }
            }
            catch (ComponentsException ex)
            {
                ErrorTrapper.Log(ex, LogOptions.PromptTheUser);
            }
            return group;
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
                    string SQL = "UPDATE [groups] SET [name] = @name WHERE [id] = @id";
                    using (MySqlConnection con = new MySqlConnection(Builder.ConnectionString))
                    {
                        MySqlCommand cmd = new MySqlCommand(SQL, con);
                        cmd.Parameters.AddWithValue("name", Name);
                        cmd.Parameters.AddWithValue("id", ID);
                        con.Open();
                        saved = cmd.ExecuteNonQuery() > 0;
                    }
                }
                else
                {
                    string SQL = "INSERT INTO [groups] ([name]) VALUES (@name)";
                    using (MySqlConnection con = new MySqlConnection(Builder.ConnectionString))
                    {
                        MySqlCommand cmd = new MySqlCommand(SQL, con);
                        cmd.Parameters.AddWithValue("name", Name);
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
                    List<Member> oldMembers = Member.GetGroupMembers(ID);
                    foreach (Member oldMember in oldMembers)
                    {
                        if (!Members.Contains(oldMember))
                        {
                            oldMember.Delete();
                        }
                    }
                    foreach (Member member in Members)
                    {
                        member.Group = ID;
                        member.Save();
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
                string SQL = "DELETE FROM [groups] WHERE [id] = @id";
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

        internal string GetQuestionAnswer(long questionID)
        {
            string answer = "";
            try
            {
                string SQL = "SELECT [answer] FROM [answers] WHERE [question] = @question AND [group] = @group";
                using (MySqlConnection con = new MySqlConnection(Builder.ConnectionString))
                {
                    using (var cmd = new MySqlCommand(SQL, con))
                    {
                        cmd.Parameters.AddWithValue("question", questionID);
                        cmd.Parameters.AddWithValue("group", ID);
                        con.Open();
                        using (var rdr = cmd.ExecuteReader())
                        {
                            if (rdr.HasRows)
                            {
                                answer = DataReader.ReadAnswer(rdr);
                            }
                        }
                    }
                }
            }
            catch (ComponentsException ex)
            {
                ErrorTrapper.Log(ex, LogOptions.PromptTheUser);
            }
            return answer;
        }

        /**************************************************
         ********** OVERRIDE METHODS **********************
         **************************************************/

        public override bool Equals(object obj)
        {
            if (obj != null && obj.GetType() == typeof(Group))
            {
                Group group = (Group)obj;
                return (ID == group.ID) & 
                    (Name == group.Name);
            }
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return 0x11001;
        }

        public override string ToString()
        {
            string _group = "[id]=" + ID +
                "[name]=" + Name;
            string _members = "";
            foreach (var member in Members)
            {
                _members += Environment.NewLine + "\t" + member.ToString();
            }
            return _group + " [members]=" + _members;
        }

    }
}
