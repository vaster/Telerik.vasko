using System;

    class DSKBank
    {
        static void Main()
        {
            string firstName = "Vasil";
            string middleName = "Valentinov";
            string lastName = "Oreshenski";
            string bankName = "DSK Bank";
            string iban = "BG 31 STSA 9790 АB51 VOI3 77";
            string bic = "STSA";
            decimal balance =9473834.389029m;
            ulong cardNumberOne = 9999999999999999999;
            ulong cardNumberTwo = 8888888888888888888;
            ulong cardNumberThree = 7777777777777777777;

            Console.WriteLine("Name of the owner:{0} {1} {2}",firstName,middleName,lastName);
            Console.WriteLine("Bank Name:{0}",bankName);
            Console.WriteLine("IBAN:{0}",iban);
            Console.WriteLine("BIC:{0}",bic);
            Console.WriteLine("Banlance:{0}",balance);
            Console.WriteLine("Associeted credit cards with this account:");
            Console.WriteLine("{0}",cardNumberOne);
            Console.WriteLine("{0}", cardNumberTwo);
            Console.WriteLine("{0}", cardNumberThree);
        }
    }

