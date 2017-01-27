using MySql.Data.MySqlClient;
using System;
using System.Linq;
using System.Windows.Forms;
using MySql.Connection;
using BibleQuiz.Components;

namespace BibleQuiz.Settings
{

    /****************************************************************************************************
     ******************** DISPLAY ***********************************************************************
     ****************************************************************************************************/

    internal abstract class Display
    {

        /// <summary>
        /// Primary Screen
        /// </summary>
        private static Screen Primary
        {
            get { return Screen.PrimaryScreen; }
        }

        /// <summary>
        /// Projector Screen - the secondary screen
        /// </summary>
        private static Screen Projector
        {
            get { return Screen.AllScreens.FirstOrDefault(s => !s.Primary) ?? Primary; }
        }

        /// <summary>
        /// Sets a form to display in the Projector
        /// </summary>
        /// <param name="form">Form object</param>
        internal static void Project(Form form)
        {
            form.SetDesktopLocation(Projector.Bounds.X, Projector.Bounds.Y);
        }

    }

    /****************************************************************************************************
     ******************** CLASS CURRENT *****************************************************************
     ****************************************************************************************************/

    internal abstract class Current
    {

        /// <summary>
        /// Current Question that is saved for future reference
        /// </summary>
        internal static Question Question
        {
            get { return GetQuestion(); }
            set { SetQuestion(value.ID); }
        }

        /// <summary>
        /// Sets the current Question
        /// </summary>
        /// <param name="questionID">ID of the Question</param>
        private static void SetQuestion(long questionID)
        {
            string SQL = "UPDATE [current] SET [name] = @name, [value] = @value";
            try
            {
                using (MySqlConnection con = new MySqlConnection(Builder.ConnectionString))
                {
                    using (var cmd = new MySqlCommand(SQL, con))
                    {
                        cmd.Parameters.AddWithValue("name", "Question");
                        cmd.Parameters.AddWithValue("value", questionID);
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

        /// <summary>
        /// Gets the Current Question
        /// </summary>
        /// <returns>Question object</returns>
        private static Question GetQuestion()
        {
            string SQL = "SELECT * FROM [current] WHERE [name] = @name";
            Question question = new Question();
            try
            {
                using (MySqlConnection con = new MySqlConnection(Builder.ConnectionString))
                {
                    using (var cmd = new MySqlCommand(SQL, con))
                    {
                        cmd.Parameters.AddWithValue("name", "Question");
                        con.Open();
                        using (var rdr = cmd.ExecuteReader())
                        {
                            while (rdr.Read())
                            {
                                if (DBNull.Value != rdr["value"])
                                {
                                    question = Question.GetByID(Convert.ToInt64(rdr["value"]));
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
            return question;
        }

    }
}
