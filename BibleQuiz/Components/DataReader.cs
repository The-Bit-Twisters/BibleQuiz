using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Globalization;

namespace BibleQuiz.Components
{
    internal abstract class DataReader
    {

        internal static string ReadAnswer(MySqlDataReader rdr)
        {
            string answer = "";
            while (rdr.Read())
            {
                answer = Convert.ToString(rdr["answer"], CultureInfo.CurrentCulture);
            }
            return answer;
        }

        internal static List<Choice> ReadChoices(MySqlDataReader rdr)
        {
            List<Choice> choices = new List<Choice>();
            while (rdr.Read())
            {
                Choice choice = new Choice();
                choice.ID = Convert.ToInt64(rdr["id"], CultureInfo.CurrentCulture);
                choice.Question = Convert.ToInt64(rdr["question"], CultureInfo.CurrentCulture);
                choice.Value = Convert.ToString(rdr["value"], CultureInfo.CurrentCulture);
                choice.Answer = Convert.ToBoolean(rdr["answer"], CultureInfo.CurrentCulture);
                choices.Add(choice);
            }
            return choices;
        }

        internal static List<Game> ReadGames(MySqlDataReader rdr)
        {
            List<Game> games = new List<Game>();
            while (rdr.Read())
            {
                Game game = new Game();
                game.ID = Convert.ToInt64(rdr["id"], CultureInfo.CurrentCulture);
                game.Sequence = Convert.ToInt16(rdr["sequence"], CultureInfo.CurrentCulture);
                game.Date = Convert.ToDateTime(rdr["date"], CultureInfo.CurrentCulture);
                game.Finished = Convert.ToBoolean(rdr["finished"], CultureInfo.CurrentCulture);
                games.Add(game);
            }
            return games;
        }

        internal static List<Group> ReadGroups(MySqlDataReader rdr)
        {
            List<Group> groups = new List<Group>();
            while (rdr.Read())
            {
                Group group = new Group();
                group.ID = Convert.ToInt64(rdr["id"], CultureInfo.CurrentCulture);
                group.Name = Convert.ToString(rdr["name"], CultureInfo.CurrentCulture);
                group.Members = Member.GetGroupMembers(group.ID);
                groups.Add(group);
            }
            return groups;
        }

        internal static List<Level> ReadLevels(MySqlDataReader rdr)
        {
            List<Level> levels = new List<Level>();
            while (rdr.Read())
            {
                Level level = new Level();
                level.ID = Convert.ToInt64(rdr["id"], CultureInfo.CurrentCulture);
                level.Name = Convert.ToString(rdr["name"], CultureInfo.CurrentCulture);
                level.Score = Convert.ToInt16(rdr["score"], CultureInfo.CurrentCulture);
                level.Special = Convert.ToInt16(rdr["special"], CultureInfo.CurrentCulture);
                levels.Add(level);
            }
            return levels;
        }

        internal static List<Member> ReadMembers(MySqlDataReader rdr)
        {
            List<Member> members = new List<Member>();
            while (rdr.Read())
            {
                Member member = new Member();
                member.ID = Convert.ToInt64(rdr["id"], CultureInfo.CurrentCulture);
                member.Group = Convert.ToInt64(rdr["group"], CultureInfo.CurrentCulture);
                member.Name = Convert.ToString(rdr["name"], CultureInfo.CurrentCulture);
                members.Add(member);
            }
            return members;
        }

        internal static List<Question> ReadQuestions(MySqlDataReader rdr)
        {
            List<Question> questions = new List<Question>();
            while (rdr.Read())
            {
                Question question = new Question();
                question.ID = Convert.ToInt64(rdr["id"], CultureInfo.CurrentCulture);
                question.Game = Convert.ToInt64(rdr["game"], CultureInfo.CurrentCulture);
                question.Level = Convert.ToInt64(rdr["level"], CultureInfo.CurrentCulture);
                question.Sequence = Convert.ToInt16(rdr["sequence"], CultureInfo.CurrentCulture);
                question.PassPlay = Convert.ToBoolean(rdr["passplay"], CultureInfo.CurrentCulture);
                question.QuestionStatement = Convert.ToString(rdr["question_statement"], CultureInfo.CurrentCulture);
                question.BibleReference = Convert.ToString(rdr["bible_reference"], CultureInfo.CurrentCulture);
                question.Choices = question.GetChoices();
                question.ChoicesLayout = Convert.ToString(rdr["choices_layout"], CultureInfo.CurrentCulture);
                questions.Add(question);
            }
            return questions;
        }

    }
}
