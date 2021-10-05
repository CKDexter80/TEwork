using System;
using System.Collections.Generic;
using System.Text;

namespace QuizMaker
{
    class GetRightQuizAnswer : QuizListSorter
    {
        public GetRightQuizAnswer(string[] quizListItem) : base(quizListItem) { }

        public static string GetRightAnswer(string[] quizListItem)
        {
            string rightAnswer = "";
            foreach (string item in quizListItem)
            {
                if (item.Contains('*'))
                {
                    rightAnswer = item.Substring(0, item.Length - 1);
                }
            }
            return rightAnswer;
        }
    }
}
