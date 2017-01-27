using MySql.Connection;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace BibleQuiz.Components
{
    internal class Attendance
    {

        /**************************************************
         ********** CONSTRUCTORS **************************
         **************************************************/

        private Attendance(long gameID, long groupID)
        {
            this.game = gameID;
            this.group = groupID;
        }

        /**************************************************
         ********** PROPERTIES ****************************
         **************************************************/

        private long game;
        private long group;

        /**************************************************
         ********** STATIC METHODS ************************
         **************************************************/

        /// <summary>
        /// Gets all the Groups that were present during the Game
        /// </summary>
        /// <param name="gameID">ID of the Game</param>
        /// <returns>List of Groups</returns>
        internal static List<Group> GetPresent(long gameID)
        {
            List<Group> groups = new List<Group>();
            try
            {
                string SQL = "SELECT [groups].[id], [groups].[name] FROM [groups] JOIN [attendance] ON [groups].[id] = [attendance].[group] WHERE [attendance].[game] = @game AND [groups].[active] = @active ORDER BY [groups].[name] ASC";
                using (var con = new MySqlConnection(Builder.ConnectionString))
                {
                    using (var cmd = new MySqlCommand(SQL, con))
                    {
                        cmd.Parameters.AddWithValue("game", gameID);
                        cmd.Parameters.AddWithValue("active", true);
                        con.Open();
                        using (var rdr = cmd.ExecuteReader())
                        {
                            while (rdr.Read())
                            {
                                Group group = new Group();
                                group.ID = Convert.ToInt64(rdr["id"], CultureInfo.CurrentCulture);
                                group.Name = rdr["name"].ToString();
                                group.Members = Member.GetGroupMembers(group.ID);
                                groups.Add(group);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorTrapper.Log(ex, LogOptions.PromptTheUser);
            }
            return groups;
        }

        /// <summary>
        /// Saves the attendance for the Game
        /// </summary>
        /// <param name="gameID"></param>
        internal static void Save(long gameID, List<long> presentGroups, List<long> absentGroups)
        {
            foreach (long groupID in presentGroups)
            {
                Attendance attendance = new Attendance(gameID, groupID);
                attendance.Present();
            }
            foreach (long groupID in absentGroups)
            {
                Attendance attendance = new Attendance(gameID, groupID);
                attendance.Absent();
            }
        }

        /**************************************************
         ********** PRIVATE METHODS ***********************
         **************************************************/

        private void Present()
        {
            try
            {
                string SQL = "INSERT INTO [attendance] ([game], [group]) VALUES (@game, @group)";
                using (var con = new MySqlConnection(Builder.ConnectionString))
                {
                    using (var cmd = new MySqlCommand(SQL, con))
                    {
                        cmd.Parameters.AddWithValue("game", game);
                        cmd.Parameters.AddWithValue("group", group);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorTrapper.Log(ex, LogOptions.LogToFile);
            }
        }

        private void Absent()
        {
            try
            {
                string SQL = "DELETE FROM [attendance] WHERE [game] = @game AND [group] = @group";
                using (var con = new MySqlConnection(Builder.ConnectionString))
                {
                    using (var cmd = new MySqlCommand(SQL, con))
                    {
                        cmd.Parameters.AddWithValue("game", game);
                        cmd.Parameters.AddWithValue("group", group);
                        con.Open();
                        cmd.ExecuteNonQuery();
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
