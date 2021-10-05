using System;
using System.Collections.Generic;
using System.IO;

namespace QuizMaker
{
    public class Program
    {
        static void Main(string[] args)
        {
            //get file path
            string filePath = Inputs.GetFilePath();

            //extract quiz info from text file
            List<Array> quizHolder = QuizExtractor.QuizExtraction(filePath);

            //populate list of quiz classes
            List<Quiz> listOfQuizQuestions = QuizPopulator.QuizPopulation(quizHolder);

            //take the quiz!
            int questionsCorrect = 0;

            for (int i = 0; i < listOfQuizQuestions.Count; i++)
            {
                Outputs.QuestionWrite(listOfQuizQuestions[i].Question);

                DisplayAnswers.ShowAnswers(listOfQuizQuestions[i].Answers);

                int answerToQuestion = Inputs.GetAnswer();

                int count = RightOrWrongAnswer.RightOrWrong(listOfQuizQuestions[i].CorrectAnswer, listOfQuizQuestions[i].Answers[answerToQuestion]);
                
                questionsCorrect += count;
            }

            //see how you did
            Outputs.FinalTally(questionsCorrect, listOfQuizQuestions.Count);
        }
    }
}
