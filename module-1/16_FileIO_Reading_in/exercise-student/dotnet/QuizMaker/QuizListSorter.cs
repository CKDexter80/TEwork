using System;
using System.Collections.Generic;
using System.Text;

namespace QuizMaker
{
    public class QuizListSorter
    {
        public QuizListSorter(string[] quizListItem)
        {
            QuizListItem = quizListItem;
        }

        public string[] QuizListItem { get; private set; }

        public string GetQuestion(string[] quizListItem)
        {
            string question = quizListItem[0];
            return question;
        }

        public Dictionary<int, string> GetPossibleAnswers(string[] quizListItem)
        {
            Dictionary<int, string> possibleAnswers = new Dictionary<int, string>();

            for (int i = 1; i < quizListItem.Length; i++)
            {
                if (quizListItem[i].Contains('*'))
                {
                    possibleAnswers.Add(i, quizListItem[i].Substring(0, quizListItem.Length - 1));
                }
                else
                {
                    possibleAnswers.Add(i, quizListItem[i]);
                }
            }
            return possibleAnswers;
        }

        public string GetRightAnswer(string[] quizListItem)
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
