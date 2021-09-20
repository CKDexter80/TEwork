﻿namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string, return a new string made of every other char starting with the first, so "Hello" yields "Hlo".
        StringBits("Hello") → "Hlo"
        StringBits("Hi") → "H"
        StringBits("Heeololeo") → "Hello"
        */
        public string StringBits(string str)
        {
            string newStringHolder = "";
            for (int i = 0; i < str.Length; i+=2)
            {
                newStringHolder += str[i];
            }
            return newStringHolder;
        }
    }
}
