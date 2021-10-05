using System;
using System.Collections.Generic;
using System.Text;

namespace QuizMaker
{
    public class QuizPopulator
    {
        public static List<Quiz> QuizPopulation(List<Array> quizHolder)
        {
            List<Quiz> listOfQuiz = new List<Quiz>();
            foreach (string[] quiz in quizHolder)
            {
                listOfQuiz.Add(new Quiz
                    (
                    GetQuizQuestion.GetQuestion(quiz),
                    GetPossibleQuizAnswers.GetPossibleAnswers(quiz),
                    GetRightQuizAnswer.GetRightAnswer(quiz)
                    )
                    );
            }
            return listOfQuiz;
        }
    }
}
