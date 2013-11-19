using System;
using System.Linq;
using System.Collections.Generic;

public class Student
{
    // No inline properties. All excaption handling is moved to non - inline properties.
    private string firstName;
    private string lastName;
    private IList<Exam> exams;

    // construcotor
    public Student(string firstName, string lastName, IList<Exam> exams = null)
    {       
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Exams = exams;
    }

    // methods
    public IList<ExamResult> CheckExams()
    {
       
        IList<ExamResult> results = new List<ExamResult>();
        for (int i = 0; i < this.Exams.Count; i++)
        {
            results.Add(this.Exams[i].Check());
        }
        return results;
    }

    public double CalcAverageExamResultInPercents()
    {
        double[] examScore = new double[this.Exams.Count];
        IList<ExamResult> examResults = CheckExams();
        for (int i = 0; i < examResults.Count; i++)
        {
            examScore[i] =
                ((double)examResults[i].Grade - examResults[i].MinGrade) /
                (examResults[i].MaxGrade - examResults[i].MinGrade);
        }

        return examScore.Average();
    }

    // properties
    public string FirstName
    {
        get
        {
            return this.firstName;
        }
        private set
        {
            if (value == null || value == String.Empty)
            {
                throw new NullReferenceException("FirstName can't be blank!");
            }
            this.firstName = value;
        }
    }

    public string LastName
    {
        get
        {
            return this.lastName;
        }
        private set
        {
            if (value == null || value == String.Empty)
            {
                throw new NullReferenceException("LirstName can't be blank!");
            }
            this.lastName = value;
        }
    }
    public IList<Exam> Exams
    {
        get
        {
            return this.exams;
        }
        private set
        {

            if (value == null)
            {
                throw new NullReferenceException("The List of Exams is not created!");
            }

            if (value.Count == 0)
            {
                throw new ArgumentException("There are no exams that students can participate in!");
            }
            this.exams = value;
        }
    }
}
