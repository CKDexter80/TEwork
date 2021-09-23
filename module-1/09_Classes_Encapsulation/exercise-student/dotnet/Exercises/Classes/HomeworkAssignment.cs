namespace Exercises.Classes
{
    public class HomeworkAssignment
    {
        public HomeworkAssignment(int possibleMarks, string submitterName)
        {
            PossibleMarks = possibleMarks;
            SubmitterName = submitterName;
        }

        public int EarnedMarks { get; set; }
        public int PossibleMarks { get; private set; }
        public string SubmitterName { get; private set; }

        public int GradeAsInt
        {
            get
            {
                return (int)((double)EarnedMarks / (double)PossibleMarks * 100);
            }
        }
        
        public string LetterGrade {
            get
            {
                if (GradeAsInt  >= 90 )
                {
                    return "A";
                }
                else if (GradeAsInt <= 89 && GradeAsInt >= 80)
                {
                    return "B";
                }
                else if (GradeAsInt <= 79 && GradeAsInt >= 70)
                {
                    return "C";
                }
                else if (GradeAsInt <= 69 && GradeAsInt >= 60)
                {
                    return "D";
                }
                else
                {
                    return "F";
                }
            }
        }

        
    }
}
