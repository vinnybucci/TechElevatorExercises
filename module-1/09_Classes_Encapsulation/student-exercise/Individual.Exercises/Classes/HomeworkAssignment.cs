using System.Dynamic;

namespace Individual.Exercises.Classes
{
    public class HomeworkAssignment
    {

        private int possibleMarks;
        private string submitterName;
        private int earnedMarks;
        private string letterGrade;

        public int EarnedMarks
        {
            get
            {
                return EarnedMarks;
            }
            set
            {
                EarnedMarks = value;
            }
        }
        public int PossibleMarks { get; private set; }
        
        
      public string SubmitterName { get; private set;  }
        public string LetterGrade
        {
            get
            {
                return GetLetterGrade(possibleMarks, earnedMarks);
            }
        }
        public HomeworkAssignment(int possibleMarks, string submitterName)
        {
            PossibleMarks = possibleMarks;
            this.submitterName = submitterName;
        }
        public string GetLetterGrade(int possibleMarks, int totalMarks)
        {
            int percentageGrade = (int)((double)EarnedMarks / (double)PossibleMarks * 100.00);

            letterGrade = " ";

            if (percentageGrade >= 90)
            {
                letterGrade = "A";
            }
            if ((percentageGrade >= 80) && (percentageGrade < 90))
            {
                letterGrade = "B";
            }
            if ((percentageGrade >= 70) && (percentageGrade < 80))
            {
                letterGrade = "C";
            }
            if ((percentageGrade >= 60) && (percentageGrade < 70))
            {
                letterGrade = "D";
            }
            else if (percentageGrade < 60)
            {
                letterGrade = "F";
            }
            return letterGrade;
        }
    }
}
