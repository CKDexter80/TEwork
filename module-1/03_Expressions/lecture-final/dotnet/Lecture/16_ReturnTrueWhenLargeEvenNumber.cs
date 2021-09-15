﻿namespace Lecture
{
    public partial class LectureExample
    {
        /*
        16. Return "Big Even Number" 
        when number is even, larger than 100, 
        and a multiple of 5.
            Return "Big Number" if the number is just larger than 100.
        Return empty string for everything else.
            TOPIC: Complex Expression
        */
        public string ReturnBigEvenNumber(int number)
        {
            string output = "";

            bool isEven = number % 2 == 0;

            if (number % 2 == 0 && number > 100 && number % 5 == 0)
            {
                output = "Big Even Number";
            }
            else if(number > 100)
            {
                output = "Big Number";
            }

            return output;
        }
    }
}
