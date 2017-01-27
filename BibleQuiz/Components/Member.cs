using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using MySql.Connection;

namespace BibleQuiz.Components
{
    internal class Member : Validation
    {

        /**************************************************
         ********** CONSTRUCTORS **************************
         **************************************************/

        internal Member() 
        {
            this.ID = 0;
            this.Group = 0;
            this.Name = "";
        }

        /**************************************************
         ********** PROPERTIES ****************************
         **************************************************/

        internal long ID { get; set; }

        internal long Group { get; set; }

        internal string Name { get; set; }

        /**************************************************
         ********** STATIC METHODS ************************
         **************************************************/

        /// <summary>
        /// Gets all Members associated with the Group
        /// </summary>
        /// <param name="groupID">ID of the Group</param>
        /// <returns>List of Members</returns>
        internal static List<Member> GetGroupMembers(long groupID)
        {
            List<Member> members = new List<Member>();
            try
            {
                string SQL = "SELECT * FROM [members] WHERE [group] = @group";
                using (MySqlConnection con = new MySqlConnection(Builder.ConnectionString))
                {
                    using (var cmd = new MySqlCommand(SQL, con))
                    {
                        cmd.Parameters.AddWithValue("group", groupID);
                        con.Open();
                        using (var rdr = cmd.ExecuteReader())
                        {
                            if (rdr.HasRows)
                            {
                                members = DataReader.ReadMembers(rdr);
                            }
                        }
                    }
                }
            }
            catch (ComponentsException ex)
            {
                ErrorTrapper.Log(ex, LogOptions.PromptTheUser);
            }
            return members;
        }

        /// <summary>
        /// Gets the Member data by its ID
        /// </summary>
        /// <param name="id">ID of the Member</param>
        /// <returns>Member object</returns>
        internal static Member GetByID(long id)
        {
            Member member = new Member();
            try
            {
                string SQL = "SELECT * FROM [members] WHERE [id] = @id";
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
                                member = DataReader.ReadMembers(rdr)[0];
                            }
                        }
                    }
                }
            }
            catch (ComponentsException ex)
            {
                ErrorTrapper.Log(ex, LogOptions.PromptTheUser);
            }
            return member;
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
                    string SQL = "UPDATE [members] SET [group] = @group, [name] = @name WHERE [id] = @id";
                    using (MySqlConnection con = new MySqlConnection(Builder.ConnectionString))
                    {
                        MySqlCommand cmd = new MySqlCommand(SQL, con);
                        cmd.Parameters.AddWithValue("group", Group);
                        cmd.Parameters.AddWithValue("name", Name);
                        cmd.Parameters.AddWithValue("id", ID);
                        con.Open();
                        saved = cmd.ExecuteNonQuery() > 0;
                    }
                }
                else
                {
                    string SQL = "INSERT INTO [members] ([group], [name]) VALUES (@group, @name)";
                    using (MySqlConnection con = new MySqlConnection(Builder.ConnectionString))
                    {
                        MySqlCommand cmd = new MySqlCommand(SQL, con);
                        cmd.Parameters.AddWithValue("group", Group);
                        cmd.Parameters.AddWithValue("name", Name);
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
                string SQL = "DELETE FROM [members] WHERE [id] = @id";
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
            if (obj != null && obj.GetType() == typeof(Member))
            {
                Member member = (Member)obj;
                return (ID == member.ID) & 
                    (Group == member.Group) & 
                    (Name == member.Name);
            }
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return 101101;
        }

        public override string ToString()
        {
            return " [id]=" + ID +
                " [group]=" + Group +
                " [name]=" + Name;
        }

    }
}
