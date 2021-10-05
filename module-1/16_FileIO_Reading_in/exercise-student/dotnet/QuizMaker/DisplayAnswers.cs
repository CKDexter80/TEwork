using System;
using System.Collections.Generic;
using System.Text;

namespace QuizMaker
{
    public class DisplayAnswers
    {
        public static void ShowAnswers(Dictionary<int, string> answers)
        {
            foreach (KeyValuePair<int, string> answer in answers)
            {
                Outputs.AnswersWrite(answer.Key, answer.Value);
            }
        }
    }
}
