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
                Console.WriteLine(listOfQuizQuestions[i].Question);

                foreach (KeyValuePair<int, string> answer in listOfQuizQuestions[i].Answers)
                {
                    Console.WriteLine($"{answer.Key} {answer.Value}");
                }

                int answerToQuestion = Inputs.GetAnswer();


                if (listOfQuizQuestions[i].Answers[answerToQuestion] == listOfQuizQuestions[i].CorrectAnswer)
                {
                    Console.WriteLine($"RIGHT!");
                    questionsCorrect++;
                }
                else
                {
                    Console.WriteLine($"WRONG!");
                }
            }
            Console.WriteLine($"You got {questionsCorrect} answer(s) correct out of the {listOfQuizQuestions.Count} questions asked.");
            
        }
    }
}
