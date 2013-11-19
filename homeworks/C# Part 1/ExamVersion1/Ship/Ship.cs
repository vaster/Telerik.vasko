using System;

class Ship
{
    static void Main()
    {
        int sX1;
        int sY1;
        int sX2;
        int sY2;
        int h;
        int cX1;
        int cY1;
        int cX2;
        int cY2;
        int cX3;
        int cY3;
        int temp;
        int damageC1 = 0;
        int damageC2 = 0;
        int damageC3 = 0;

        sX1 = int.Parse(Console.ReadLine());
        sY1 = int.Parse(Console.ReadLine());
        sX2 = int.Parse(Console.ReadLine());
        sY2 = int.Parse(Console.ReadLine());
        h = int.Parse(Console.ReadLine());
        cX1 = int.Parse(Console.ReadLine());
        cY1 = int.Parse(Console.ReadLine());
        cX2 = int.Parse(Console.ReadLine());
        cY2 = int.Parse(Console.ReadLine());
        cX3 = int.Parse(Console.ReadLine());
        cY3 = int.Parse(Console.ReadLine());

        if (sX2 > sX1)
        {
            temp = sX1;
            sX1 = sX2;
            sX2 = temp;
        }

        if (sY2 > sY1)
        {
            temp = sY1;
            sY1 = sY2;
            sY2 = temp;
        }

        if (cX1 == sX1 || cX1 == sX2)
        {

            if ((Math.Abs(h - cY1) < Math.Abs(h - sY1)) && (Math.Abs(h - cY1) > Math.Abs(h - sY2)))
            {
                damageC1 = 50 + damageC1;
                //Console.WriteLine("{0}",damageC1);
            }

            if ((Math.Abs(h - cY1) == Math.Abs(h - sY1)) || (Math.Abs(h - cY1) == Math.Abs(h - sY2)))
            {
                damageC1 = 25 + damageC1;
                //Console.WriteLine("{0}", damageC1);
            }
        }

        if (cX1 < sX1 && cX1 > sX2)
        {
            if ((Math.Abs(h - cY1) == Math.Abs(h - sY1)) || (Math.Abs(h - cY1) == Math.Abs(h - sY2)))
            {
                damageC1 = 50 + damageC1;
                //Console.WriteLine("{0}", damageC1);
            }

            if ((Math.Abs(h - cY1) < Math.Abs(h - sY1)) && (Math.Abs(h - cY1) > Math.Abs(h - sY2)))
            {
                damageC1 = 100 + damageC1;
                //Console.WriteLine("{0}", damageC1);
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////////

        if (cX2 == sX1 || cX2 == sX2)
        {

            if ((Math.Abs(h - cY2) < Math.Abs(h - sY1)) && (Math.Abs(h - cY2) > Math.Abs(h - sY2)))
            {
                damageC2 = 50 + damageC2;
                //Console.WriteLine("{0}", damageC2);
            }

            if ((Math.Abs(h - cY2) == Math.Abs(h - sY1)) || (Math.Abs(h - cY2) == Math.Abs(h - sY2)))
            {
                damageC2 = 25 + damageC2;
                //Console.WriteLine("{0}", damageC2);
            }
        }

        if (cX2 < sX1 && cX2 > sX2)
        {
            if ((Math.Abs(h - cY2) == Math.Abs(h - sY1)) || (Math.Abs(h - cY2) == Math.Abs(h - sY2)))
            {
                damageC2 = 50 + damageC2;
                //Console.WriteLine("{0}", damageC2);
            }

            if ((Math.Abs(h - cY2) < Math.Abs(h - sY1)) && (Math.Abs(h - cY2) > Math.Abs(h - sY2)))
            {
                damageC2 = 100 + damageC2;
                //Console.WriteLine("{0}", damageC2);
            }
        }
        
        //////////////////////////////////////////////////////////////////////////////////////

        if (cX3 == sX1 || cX3 == sX2)
        {

            if ((Math.Abs(h - cY3) < Math.Abs(h - sY1)) && (Math.Abs(h - cY3) > Math.Abs(h - sY2)))
            {
                damageC3 = 50 + damageC3;
                //Console.WriteLine("{0}", damageC3);
            }

            if ((Math.Abs(h - cY3) == Math.Abs(h - sY1)) || (Math.Abs(h - cY3) == Math.Abs(h - sY2)))
            {
                damageC3 = 25 + damageC3;
                //Console.WriteLine("{0}", damageC3);
            }
        }

        if (cX3 < sX1 && cX3 > sX2)
        {
            if ((Math.Abs(h - cY3) == Math.Abs(h - sY1)) || (Math.Abs(h - cY3) == Math.Abs(h - sY2)))
            {
                damageC3 = 50 + damageC3;
                //Console.WriteLine("{0}", damageC3);
            }

            if ((Math.Abs(h - cY3) < Math.Abs(h - sY1)) && (Math.Abs(h - cY3) > Math.Abs(h - sY2)))
            {
                damageC3 = 100 + damageC3;
                //Console.WriteLine("{0}", damageC3);
            }
        }

        Console.WriteLine("{0}%", damageC1+damageC2+damageC3);


    }
}

