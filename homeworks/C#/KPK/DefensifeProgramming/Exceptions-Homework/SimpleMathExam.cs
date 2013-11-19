using System;

public class SimpleMathExam : Exam
{
    // No inline properties. All excaption handling is moved to non - inline properties.
    public int problemsSolved;

    // constructor
    public SimpleMathExam(int problemsSolved)
    { 
        this.ProblemsSolved = problemsSolved;
    }

    // methods
    public override ExamResult Check()
    {
        if (ProblemsSolved == 0)
        {
            return new ExamResult(2, 2, 6, "Bad result: nothing done.");
        }
        else if (ProblemsSolved == 1)
        {
            return new ExamResult(4, 2, 6, "Average result: nothing done.");
        }
        else if (ProblemsSolved == 2)
        {
            return new ExamResult(6, 2, 6, "Average result: nothing done.");
        }

        return new ExamResult(0, 0, 0, "Invalid number of problems solved!");
    }

    // properties
    public int ProblemsSolved
    {
        get
        {
            return this.problemsSolved;
        }
        private set
        {
            if (problemsSolved < 0)
            {
                throw new ArgumentOutOfRangeException(String.Format("Problems that are solved can't be negative value! 'problemSolved' = {0}", problemsSolved));
            }
            if (problemsSolved > 10)
            {
                throw new ArgumentOutOfRangeException(String.Format("Problems that are solved can't be bigger than 10! 'problemSolved' = {0}", problemsSolved));
            }
            this.problemsSolved = value;
        }
    }
}
