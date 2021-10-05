using System;
using System.Collections.Generic;
using System.Text;

namespace QuizMaker
{
    class GetPossibleQuizAnswers : GetRightQuizAnswer
    {
        public GetPossibleQuizAnswers(string[] quizListItem) : base(quizListItem) { }
        public static Dictionary<int, string> GetPossibleAnswers(string[] quizListItem)
        {
            Dictionary<int, string> possibleAnswers = new Dictionary<int, string>();

            for (int i = 1; i < quizListItem.Length; i++)
            {
                if (quizListItem[i].Contains('*'))
                {
                    possibleAnswers.Add(i, GetRightAnswer(quizListItem));
                }
                else
                {
                    possibleAnswers.Add(i, quizListItem[i]);
                }
            }
            return possibleAnswers;
        }
    }
}
