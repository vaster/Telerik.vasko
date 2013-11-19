using System;

public class ExamResult
{
    // No inline properties. All excaption handling is moved to non - inline properties.
    private int grade;
    private int minGrade;
    private int maxGrade;
    private string comments;

    // constructor
    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }

    // properties
    public int Grade
    {
        get
        {
            return this.grade;
        }
        private set
        {
            if (value < 0)
            {
                // changed exception from Exception -> ArgumentOutOfRange for negative value.
                throw new ArgumentOutOfRangeException(String.Format("'grade' must be positive value!'grade' = {0}", grade));
            }
            this.grade = value;
        }
    }

    public int MinGrade
    {
        get
        {
            return this.minGrade;
        }
        private set
        {
            if (value < 0)
            {
                // changed exception from Exception -> ArgumentOutOfRange for negative value.
                throw new ArgumentOutOfRangeException(String.Format("'minGrade' must be positive value!'minGrade = {0}'", minGrade));
            }
            this.minGrade = value;
        }
    }

    public int MaxGrade
    {
        get
        {
            return this.maxGrade;
        }
        private set
        {
            if (value <= this.MinGrade)
            {
                // changed exception from Exception -> ArgumentOutOfRange for logic promblem.
                throw new ArgumentOutOfRangeException(String.Format("'maxGrade'({0}) can't be lower or equal to 'minGrade'{1}", maxGrade, minGrade));
            }
            this.maxGrade = value;
        }
    }

    public string Comments
    {
        get
        {
            return this.comments;
        }
        private set
        {
            if (value == null || value == String.Empty)
            {
                // changed exception from Exception -> NullReference for blank comment.
                throw new NullReferenceException(String.Format("ExamResult comment can't be blank! You must leave comment on your Exam Result!"));
            }
            this.comments = value;
        }
    }
}
