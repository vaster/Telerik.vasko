using System;


    class MarkFirmEmployeesInfo
    {
        static void Main()
        {
            string firstName;
            string lastName;
            string age;
            char sex;
            int ID;
            bool condition;
            string uniqeNumber;

            Console.Write("Enter your First Name:");
            firstName = Console.ReadLine();
            Console.Write("Enter yout Family Name:");
            lastName = Console.ReadLine();
            Console.Write("Enter your age:");
            age = Console.ReadLine();
            do
            {
                Console.Write("Your gender('m' or 'f'):");
                sex = Console.ReadKey().KeyChar;
                condition = (sex == 'm') || (sex == 'f');
                Console.Write("\n");
            }
            while (!condition);

            do
            {
                Console.Write("ID:(between 27560000 and 27569999)");
                uniqeNumber = Console.ReadLine();
                ID = int.Parse(uniqeNumber);
                condition = (ID >= 27560000) && (ID <= 27569999);
            }
            while(!condition);

            Console.WriteLine("Information of currnet Employee:");
            Console.WriteLine("Name:{0} {1}",firstName,lastName);
            Console.WriteLine("Age:{0}",age);
            Console.WriteLine("Sex:{0}", sex);
            Console.WriteLine("ID:{0}", ID);
        }
    }

