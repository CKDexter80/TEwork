using System;
using System.Collections.Generic;

namespace Exercises
{
    public partial class Exercises
    {
        /*
        Given two lists of Integers, interleave them beginning with the first element in the first list followed
        by the first element of the second. Continue interleaving the elements until all elements have been interwoven.
        Return the new list. If the lists are of unequal lengths, simply attach the remaining elements of the longer
        list to the new list before returning it.
        DIFFICULTY: HARD
        InterleaveLists( [1, 2, 3], [4, 5, 6] )  ->  [1, 4, 2, 5, 3, 6]
        */
        public List<int> InterleaveLists(List<int> listOne, List<int> listTwo)
        {
            List<int> interwovenList = new List<int>();

            int shorterOfTwoCount = 0;
            int shorterOfTwoList = 0;

            if (listOne.Count <= listTwo.Count)
            {
                shorterOfTwoCount = listOne.Count;
                shorterOfTwoList = 1;
            }
            else
            {
                shorterOfTwoCount = listTwo.Count;
                shorterOfTwoList = 2;
            }

            for (int i = 0; i < shorterOfTwoCount; i++)
            {
                interwovenList.Add(listOne[i]);
                interwovenList.Add(listTwo[i]);
            }

            if (shorterOfTwoList == 2)
            {
                for (int i = shorterOfTwoCount; i < listOne.Count; i++)
                {
                    interwovenList.Add(listOne[i]);
                }
            }
            else if (shorterOfTwoList == 1)         
            {
                for (int i = shorterOfTwoCount; i < listTwo.Count; i++)
                {
                    interwovenList.Add(listTwo[i]);
                }
            }

            return interwovenList;
        }
    }
}
