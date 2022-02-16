using System;
using System.Collections.Generic;
using System.Text;

namespace CNAAPrograme
{
    public class Question
    {
        public string QuestionData { get; set; }

        public List<string> Answers { get; set; }

        public string RightAnswer { get; set; }

        public Question(string q, List<string> a, string ra)
        {
            QuestionData = q;
            Answers = a;
            RightAnswer = ra;
        }
    }
}
