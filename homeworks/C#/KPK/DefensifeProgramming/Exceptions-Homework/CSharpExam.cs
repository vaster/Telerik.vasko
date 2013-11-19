using System;

public class CSharpExam : Exam
{
    // No inline properties. All excaption handling is moved to non - inline properties.
    private int score;

    // constructor
    public CSharpExam(int score)
    {
        this.Score = score;
    }

    // methods
    public override ExamResult Check()
    {
        if (Score < 0 || Score > 100)
        {
            // changed exception from NullReference -> ArgumentOutOfRange for negative or bigger than 100 value.
            throw new ArgumentOutOfRangeException(String.Format("'Score' can't be a negative or greater than 100 points! 'Score' = {0}", this.Score));
        }
        else
        {
            return new ExamResult(this.Score, 0, 100, "Exam results calculated by score.");
        }
    }

    // properties
    public int Score
    {
        get
        {
            return this.score;
        }
        private set
        {
            if (value < 0)
            {
                // changed exception from NullReference -> ArgumentOutOfRange for negative value.
                throw new ArgumentOutOfRangeException(String.Format("'score' must be postivie. 'score' = {0}", value));
            }

            this.score = value;
        }
    }
}
