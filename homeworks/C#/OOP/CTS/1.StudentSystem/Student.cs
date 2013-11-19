using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.StudentSystem
{
    public class Student : ICloneable, IComparable<Student>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private string address;
        private string email;
        private int ssn;
        private int phoneNumber;
        private int course;
        private University Uni;
        private Specialty Spec;
        private Faculty Facl;



        //constructor

        public Student(string fName, string mName, string lName, string address,
            string email, int ssn, int phoneNumber, int course, University uni, Specialty spec, Faculty facl)
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.MiddleName = mName;
            this.Address = address;
            this.Email = email;
            this.SSN = ssn;
            this.PhoneNumber = phoneNumber;
            this.Course = course;
            this.Uni = uni;
            this.Spec = spec;
            this.Facl = facl;
        }


        //methods
        public override string ToString()
        {
            return String.Format("Name: {0} {1} {2}{3}Address: {4}{5}Email: {6}{7}Social Security Number: {8}{9}Phone Number: {10}{11}University Course: {12}{13}University: {14}{15}Speciality: {16}{17}Faculty: {18}{19}",
                this.FirstName, this.MiddleName, this.LastName, Environment.NewLine,
                this.Address, Environment.NewLine,
                this.Email, Environment.NewLine,
                this.SSN, Environment.NewLine,
                this.PhoneNumber, Environment.NewLine,
                this.Course, Environment.NewLine,
                this.Uni, Environment.NewLine,
                this.Spec, Environment.NewLine,
                this.Facl, Environment.NewLine);
        }
        public object Clone()
        {
            object clonedStudent = new Student(FirstName, MiddleName, LastName, Address, Email, SSN,
                PhoneNumber, Course, Uni, Spec, Facl);
            return clonedStudent;
        }

        public int CompareTo(Student other)
        {
            if (this.Equals(other))
            {
                if (this.SSN == other.SSN)
                {
                    return 0;
                }
                else if (this.SSN > other.SSN)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
            if (this.FirstName.CompareTo(other.FirstName) > 0)
            {
                return 1;
            }

            return -1;
        }

        public override bool Equals(object param)
        {
            //sample comparer for two students by their full names
            Student comparedStudent = param as Student;
            if (this.FirstName.CompareTo(comparedStudent.FirstName) == 0
                && this.MiddleName.CompareTo(comparedStudent.MiddleName) == 0
                && this.LastName.CompareTo(comparedStudent.LastName) == 0)
            {
                return true;
            }

            return false;
        }

        public static bool operator ==(Student studentA, Student studentB)
        {
            //using 'Equals' implementation
            if (studentA.Equals(studentB))
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Student studentA, Student studentB)
        {
            if (!(studentA.Equals(studentB)))
            {
                return true;
            }
            return false;
        }
        /*
            A hash code is a numeric value that is used to identify an object during equality testing
            If two objects compare as equal, the GetHashCode method for each object must return the same value.
            However, if two objects do not compare as equal, the GetHashCode methods for the two object do not have to return different values.
            Becouse of this, is verry important when we ovveride 'Equals', to ovveride 'GetHashCode'
        */
        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();
        }

        //propertiese

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }
        public string MiddleName
        {
            get { return this.middleName; }
            set { this.middleName = value; }
        }
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }
        public int SSN
        {
            get { return this.ssn; }
            set
            { this.ssn = value; }
        }

        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }
        public string Email
        {
            get { return this.email; }
            set
            {
                char[] emailSymbolContainer = value.ToCharArray();
                bool isEmial = false;
                for (int i = 0; i < value.ToCharArray().Count(); i++)
                {
                    if (emailSymbolContainer[i] == '@')
                    {
                        isEmial = true;
                    }
                }
                if (!isEmial)
                {
                    throw new Exception("Not valid email -> " + value.ToString());
                }
                this.email = value;
            }
        }

        public int PhoneNumber
        {
            get { return this.phoneNumber; }
            set
            {
                if (value.ToString().ToCharArray().Count() < 2)
                {
                    Console.WriteLine(value.ToString());
                }
                this.phoneNumber = value;
            }
        }

        public int Course
        {
            get { return this.course; }
            set { this.course = value; }
        }


    }
}
