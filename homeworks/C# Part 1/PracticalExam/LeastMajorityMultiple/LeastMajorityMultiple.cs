using System;

    class LeastMajorityMultiple
    {
        static void Main()
        {
            int a;
            int b;
            int c;
            int d;
            int e;

            int subsetA = 0;
            int subsetB = 0;
            int subsetC = 0;
            int subsetD = 0;
            int subsetE = 0;
            int min = 0;

            int abc = 1;
            int abd = 1;
            int abe = 1;
            int acd = 1;
            int ace = 1;
            int ade = 1;
            int bcd = 1;
            int bce = 1;
            int bde = 1;
            int cde = 1;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
            e = int.Parse(Console.ReadLine());

            do
            {
                subsetA =abc%a;
                subsetB =abc%b;
                subsetC =abc%c;
                abc++;
            }while(subsetA!=0 || subsetB!=0 || subsetC!=0);
            abc--;
            min = abc;
            do
            {
                subsetA = abd % a;
                subsetB = abd % b;
                subsetD = abd % d;
                abd++;
            } while (subsetA != 0 || subsetB != 0 || subsetD != 0);
            abd--;
            if (abd < min)
            {
                min = abd;
            }
            do
            {
                subsetA = abe % a;
                subsetB = abe % b;
                subsetE = abe % e;
                abe++;
            } while (subsetA != 0 || subsetB != 0 || subsetE != 0);
            abe--;
            if (abe < min)
            {
                //abe = min;
                min = abe;
            }
            do
            {
                subsetA = acd % a;
                subsetC = acd % c;
                subsetD = acd % d;
                acd++;
            } while (subsetA != 0 || subsetC != 0 || subsetD != 0);
            acd--;
            if (acd < min)
            {
                //acd = min;
                min = acd;
            }
            do
            {
                subsetA = ace % a;
                subsetC = ace % c;
                subsetE = ace % e;
                ace++;
            } while (subsetA != 0 || subsetC != 0 || subsetE != 0);
            ace--;
            if (ace < min)
            {
                //ace = min;
                min = ace;
            }
            do
            {
                subsetA = ade % a;
                subsetD = ade % d;
                subsetE = ade % e;
                ade++;
            } while (subsetA != 0 || subsetD != 0 || subsetE != 0);
            ade--;
            if (ade < min)
            {
                //ade = min;
                min = abe;
            }
            do
            {
                subsetB = bcd % b;
                subsetC = bcd % c;
                subsetD = bcd % d;
                bcd++;
            } while (subsetB != 0 || subsetC != 0 || subsetD != 0);
            bcd--;
            if (bcd < min)
            {
                //bcd = min;
                min = bcd;
            }
            do
            {
                subsetB = bce % b;
                subsetC = bce % c;
                subsetE = bce % e;
                bce++;
            } while (subsetB != 0 || subsetC != 0 || subsetE != 0);
            bce--;
            if (bce < min)
            {
                //bce = min;
                min = bce;
            }
            do
            {
                subsetB = bde % b;
                subsetD = bde % d;
                subsetE = bde % e;
                bde++;
            } while (subsetB != 0 || subsetD != 0 || subsetE != 0);
            bde--;
            if (bde < min)
            {
                //bde = min;
                min = bde;
            }
            do
            {
                subsetC = cde % c;
                
                subsetD = cde % d;
                
                subsetE = cde % e;
               
                cde++;
            } while (subsetC != 0 || subsetD != 0 || subsetE != 0);
            cde--;
           
            if (cde < min)
            {
                //cde = min;
                min = cde;
            }






           
           

            Console.WriteLine("{0}",min);
        }
    }

