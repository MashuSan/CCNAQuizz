using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CNAAPrograme
{
    public static class QuestionSet
    {

        private static int numberOfQuestions = 20;

        public static List<Question> CCNA1Questions()
        {
            var qs = new List<Question>();

            string[] lines = System.IO.File.ReadAllLines(@"../questionFile.txt");

            for (int i = 0; i < numberOfQuestions * 3; i = i + 3)
            {
                var question = lines[i].Split("\"")[1];
                //var answers = lines[i + 1].Split(",").Select(x => x.Trim('\"'));
                var temp = lines[i + 1].Split("\"");
                var answers = new List<string>();
                for (int j = 0; j < temp.Count(); j++)
                {
                    if (j % 2 == 1)
                    {
                        answers.Add(temp[j]);
                    }
                }
                qs.Add(new Question(question, answers.Take(answers.Count() - 1).ToList(), answers.Last()));
            }

            return qs;
        }

        public static List<Question> CCNA2Questions()
        {
            var qs = new List<Question>();

            string[] lines = System.IO.File.ReadAllLines(@"../questionFile.txt");

            for (int i = numberOfQuestions * 3; i < numberOfQuestions * 6; i = i + 3)
            {
                var question = lines[i].Split("\"")[1];
                //var answers = lines[i + 1].Split(",").Select(x => x.Trim('\"'));
                var temp = lines[i + 1].Split("\"");
                var answers = new List<string>();
                for (int j = 0; j < temp.Count(); j++)
                {
                    if (j % 2 == 1)
                    {
                        answers.Add(temp[j]);
                    }
                }
                qs.Add(new Question(question, answers.Take(answers.Count() - 1).ToList(), answers.Last()));
            }

            return qs;
        }


        public static List<Question> CCNA3Questions()
        {
            var qs = new List<Question>();

            string[] lines = System.IO.File.ReadAllLines(@"../questionFile.txt");

            for (int i = numberOfQuestions * 6; i < 180; i = i + 3)
            {
                var question = lines[i].Split("\"")[1];
                //var answers = lines[i + 1].Split(",").Select(x => x.Trim('\"'));
                var temp = lines[i + 1].Split("\"");
                var answers = new List<string>();
                for (int j = 0; j < temp.Count(); j++)
                {
                    if (j % 2 == 1)
                    {
                        answers.Add(temp[j]);
                    }
                }
                qs.Add(new Question(question, answers.Take(answers.Count() - 1).ToList(), answers.Last()));
            }

            return qs;

        }
    }
}
