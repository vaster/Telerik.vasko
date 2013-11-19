using System;

namespace Methods
{
    // 1.'10' - > DATE_LENGTH
    // 2.other -> comparedStudent
    // 3.Try - catch for invalid date
    class Student
    {
        private const int DATE_LENGTH = 10;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OtherInfo { get; set; }

        public bool IsOlderThan(Student other)
        {
            DateTime thisBirthDate;
            DateTime otherBirthDate;

            try
            {
                thisBirthDate =
                    DateTime.Parse(this.OtherInfo.Substring(this.OtherInfo.Length + 1 - DATE_LENGTH));

                otherBirthDate =
                    DateTime.Parse(other.OtherInfo.Substring(other.OtherInfo.Length + 1 - DATE_LENGTH));
            }
            catch (FormatException fe)
            {
                throw new FormatException("Invalid Date Format! " + fe);
            }

            bool isOlder = thisBirthDate > otherBirthDate;

            return isOlder;
        }
    }
}
