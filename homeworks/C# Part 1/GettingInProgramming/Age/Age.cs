using System;


    class Age
    {
        static void Main()
        {
            string age;
            int intAge;
            int yearOfBirth;
            int ageIn10Years;
            

            Console.Write("What is your Age? ");
            age = Console.ReadLine();
            intAge = int.Parse(age);
            System.DateTime nowaDays = System.DateTime.Now;
            yearOfBirth = nowaDays.Year - intAge;
            System.DateTime in10Years = System.DateTime.Now.AddYears(10);
            ageIn10Years = in10Years.Year - yearOfBirth;
            Console.WriteLine("In Ten years you will be " + ageIn10Years +" years old");
        }
    }

