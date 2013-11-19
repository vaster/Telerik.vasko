using System;



class FighterAttack
{
    static void Main()
    {
        int px1;
        int px2;
        int py1;
        int py2;
        int fx;
        int fy;
        int d;

        int damagey = 0;
        int damagex = 0;
        int temp;


        do
        {
            px1 = int.Parse(Console.ReadLine());
        }while(px1<-100000 || px1>100000);
        do
        {
            py1 = int.Parse(Console.ReadLine());
        }while(py1<-100000 || py1>100000);
        do
        {
            px2 = int.Parse(Console.ReadLine());
        } while (px2 < -100000 || px2 > 100000);
        do
        {
            py2 = int.Parse(Console.ReadLine());
        } while (py2 < -100000 || py2 > 100000);

        do
        {
            fx = int.Parse(Console.ReadLine());
        } while (fx < -100000 || fx > 100000);
        do
        {
            fy = int.Parse(Console.ReadLine());
        } while (fy < -100000 || fy > 100000);

        do
        {
            d = int.Parse(Console.ReadLine());
        } while (d < -100000 || d > 100000);

        
        if (py1 <= py2)
        {
            temp = py1;
            py1 = py2;
            py2 = temp;
        }
        if (px1 <= px2)
        {
            temp = px1;
            px1 = px2;
            px2 = temp;
        }

       
        {
            if (py1 - fy >= 1 && ((fx) + d >= px2 && (fx)+d<=px1))
            {
                damagey = 50;
            }
            if (fy - py2 >= 1 && ((fx) + d >= px2 && (fx)+d<=px1))
            {
                damagey = damagey + 50;
            }
            
            if (((fx) + d >= (px2-1) && (fx) + d <= px1 - 1) && fy<=py1 && fy>=py2 )
            {
                damagex = 75;
            }
            if (((fx) + d>= (px2) && (fx) + d<= px1) && fy <= py1 && fy >= py2)
            {
                damagex = damagex + 100;
            }
        }



        Console.WriteLine("{0}%", damagex + damagey);
    }
}
