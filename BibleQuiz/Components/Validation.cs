namespace BibleQuiz.Components
{
    internal class Validation
    {

        private ComponentsException ex;

        /// <summary>
        /// Validates Game object before it can be saved
        /// </summary>
        /// <param name="game">Game object</param>
        internal void Validate(Game game)
        {
            string message = "";
            if (game.Sequence <= 0)
            {
                message = "Sequence is invalid";
            }
            if (!string.IsNullOrEmpty(message))
            {
                ex = new ComponentsException(game, message);
                throw ex;
            }
        }

        /// <summary>
        /// Validates Level object before it can be saved
        /// </summary>
        /// <param name="level">Level object</param>
        internal void Validate(Level level)
        {
            string message = "";
            if (string.IsNullOrWhiteSpace(level.Name))
            {
                message = "Name is invalid";
            }
            else if (level.Score <= 0)
            {
                message = "Score is invalid";
            }
            else if (level.Special <= 0)
            {
                message = "Pass Or Play Score is invalid";
            }
            if (!string.IsNullOrEmpty(message))
            {
                ex = new ComponentsException(level, message);
                throw ex;
            }
        }

        /// <summary>
        /// Validates Question object before it can be saved
        /// </summary>
        /// <param name="question">Question object</param>
        internal void Validate(Question question)
        {
            string message = "";
            if (question.Game <= 0)
            {
                message = "Game ID is invalid";
            }
            else if (question.Level <= 0)
            {
                message = "Level ID is invalid";
            }
            else if (question.Sequence <= 0)
            {
                message = "Sequence is invalid";
            }
            else if (string.IsNullOrWhiteSpace(question.QuestionStatement))
            {
                message = "Question is empty";
            }
            else if (!(question.ChoicesLayout == Models.Layout.Choices.OneByOne | question.ChoicesLayout == Models.Layout.Choices.OneByTwo | question.ChoicesLayout == Models.Layout.Choices.OneByFour | question.ChoicesLayout == Models.Layout.Choices.TwoByTwo | question.ChoicesLayout == Models.Layout.Choices.FourByOne))
            {
                message = "Choices/Answer Layout is invalid";
            }
            else if (question.Choices.Count <= 0)
            {
                message = "Choices or Answer is empty";
            }
            else
            {
                bool hasAnswer = false;
                foreach (var choice in question.Choices)
                {
                    if (!hasAnswer)
                    {
                        hasAnswer = choice.Answer;
                    }
                }
                if (!hasAnswer)
                {
                    message = "No selected choice as answer";
                }
            }
            if (!string.IsNullOrEmpty(message))
            {
                ex = new ComponentsException(question, message);
                throw ex;
            }
        }

        /// <summary>
        /// Validates Choice object before it can be saved
        /// </summary>
        /// <param name="choice">Choice object</param>
        internal void Validate(Choice choice)
        {
            string message = "";
            if (string.IsNullOrWhiteSpace(choice.Value))
            {
                message = "Choice or Answer is empty";
            }
            if (!string.IsNullOrEmpty(message))
            {
                ex = new ComponentsException(choice, message);
                throw ex;
            }
        }

        /// <summary>
        /// Validates Group object before it can be saved
        /// </summary>
        /// <param name="group">Group object</param>
        internal void Validate(Group group)
        {
            string message = "";
            if (string.IsNullOrWhiteSpace(group.Name))
            {
                message = "Name is empty";
            }
            if (!string.IsNullOrEmpty(message))
            {
                ex = new ComponentsException(group, message);
                throw ex;
            }
        }

        /// <summary>
        /// Validates Member object before it can be saved
        /// </summary>
        /// <param name="member">Member object</param>
        internal void Validate(Member member)
        {
            string message = "";
            if (member.Group <= 0)
            {
                message = "Group ID is invalid";
            }
            else if (string.IsNullOrWhiteSpace(member.Name))
            {
                message = "Name is empty";
            }
            if (!string.IsNullOrEmpty(message))
            {
                ex = new ComponentsException(member, message);
                throw ex;
            }
        }

        /****************************************************************************************************
        ******************** CUSTOM EXCEPTION CLASS *********************************************************
        ****************************************************************************************************/

        [System.Serializable]
        public sealed class ComponentsException : System.Exception
        {

            internal ComponentsException(object obj, string message)
            {
                this.obj = obj;
                this.message = message;
            }

            private ComponentsException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamigContext) { }

            private object obj;
            private string message;

            public override string Message
            {
                get { return message; }
            }

            public override string Source
            {
                get { return obj.GetType().Name; }
                set { base.Source = value; }
            }

            public override string ToString()
            {
                return base.ToString() + System.Environment.NewLine + 
                    "\tDATA:" + obj.ToString();
            }

        }

    }
}
