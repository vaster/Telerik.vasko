using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    public class Student
    {
        private const int UNIQE_NUMBER_BOTTOM_LIMIT = 10000;
        private const int UNIQE_NUMBER_UPPER_LIMIT = 99999;

        private string name;
        private int uniqeNumber;

        // constructor
        public Student(string name, int schoolNumber)
        {
            this.Name = name;

            if (School.CheckForTrueUniqeNumber(schoolNumber))
            {
                this.UniqeNumber = schoolNumber;
            }
            else
            {
                throw new ArgumentException(String.Format(
                    "Studnet with {0} school number allready exist! School number must be uniqe!",
                    schoolNumber));
            }
        }
        // methods

        // properties
        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new NullReferenceException("Name of the student can't be blank!");
                }
                this.name = value;
            }
        }
        public int UniqeNumber
        {
            get
            {
                return this.uniqeNumber;
            }
            set
            {
                if (value < Student.UNIQE_NUMBER_BOTTOM_LIMIT || value > Student.UNIQE_NUMBER_UPPER_LIMIT)
                {
                    throw new ArgumentOutOfRangeException(
                        String.Format("Number of a student should be from {0} to {1}. Uniqe number = {2}.",
                            Student.UNIQE_NUMBER_BOTTOM_LIMIT,
                            Student.UNIQE_NUMBER_UPPER_LIMIT,
                            value));
                }
                this.uniqeNumber = value;
            }
        }
    }
}
