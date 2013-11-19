using System;
using System.Threading;

class FallingRocks
{
    static int level = 0;
    static int speed = 2;
    static int collusion = 0;
    static int flag0 = 0;
    static int flag1 = 0;
    static int flag2 = 0;
    static int flag3 = 0;
    static int flag4 = 0;
    static int flag5 = 0;
    static int flag6 = 0;
    static int flag7 = 0;
    static int flag8 = 0;
    static int[] form = new int[9];
    static int dwarfPositionX = 0;
    static int dwarfPositionY = 0;
    static int[] rockPositionY = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    static int flag = 0;
    static Random rock = new Random();
    static int[] rockPositionX = new int[9];
    static string[] rocks = { "*", "^", "&", "+", "%", "$", "!", ".", ";" };
    static Random symbolGenerator = new Random();
    static Random Yposition = new Random();
    static int[] PositionY = new int[9];
    static int score = 1;
    /////////////////////////////////
    static void PrintPositionLevel(int x, int y, int level)
    {
        Console.SetCursorPosition(x, y);
        if (flag > 0)
        {
            level = 1;
        }
        if (flag > 100)
        {
            level = 2;
        }
        
        Console.Write(level);
    }
    ////////////////////////////////////

    static void End()
    {
        PrintPosition(Console.WindowWidth/2,Console.WindowHeight/2,"END");
    }
    
    ////////////////////////////////////
    
    static void Result()
    {
        
        
            PrintPosition(9, 0, "|");
            PrintPosition(9, 3, "|");
            PrintPosition(9, 6, "|");
            PrintPosition(9, 9, "|");
            PrintPosition(9, 12, "|");
            PrintPosition(9, 15, "|");
            PrintPosition(9, 18, "|");
            PrintPosition(9, 21, "|");
            PrintPosition(9, 23, "|");
            PrintPosition(0, Console.WindowHeight / 2, "Score");
            PrintPositionScore(6, Console.WindowHeight / 2, score);
            PrintPosition(0, Console.WindowHeight / 2 +1, "Level");
            PrintPositionLevel(6, ((Console.WindowHeight / 2)+1), level);

        
    }
    ////////////////////////////////////
    static void PositionYGenerator()
    {
        for (int i = 0; i < PositionY.Length; i++)
        {
            PositionY[i] = Yposition.Next(1, 30);
        }
    }
    ///////////////////////////////////

    static void FormGenerator()
    {
        for (int i = 0; i < 9; i++)
        {

            form[i] = symbolGenerator.Next(0, 9);
        }
    }


    /////////////////////////////////////////////////////

    static void Generator()
    {

        {
            if (rockPositionY[0] == 0)
                rockPositionX[0] = rock.Next(10, Console.WindowWidth);
            if (rockPositionY[1] == 0)
                rockPositionX[1] = rock.Next(10, Console.WindowWidth);
            if (rockPositionY[2] == 0)
                rockPositionX[2] = rock.Next(10, Console.WindowWidth);
            if (rockPositionY[3] == 0)
                rockPositionX[3] = rock.Next(10, Console.WindowWidth);
            if (rockPositionY[4] == 0)
                rockPositionX[4] = rock.Next(10, Console.WindowWidth);
            if (rockPositionY[5] == 0)
                rockPositionX[5] = rock.Next(10, Console.WindowWidth);
            if (rockPositionY[6] == 0)
                rockPositionX[6] = rock.Next(10, Console.WindowWidth);
            if (rockPositionY[7] == 0)
                rockPositionX[7] = rock.Next(10, Console.WindowWidth);
            if (rockPositionY[8] == 0)
                rockPositionX[8] = rock.Next(10, Console.WindowWidth);
        }
    }
    ////////////////////////////////////////////////////////////

    static void MoveRocks()
    {


        {
            if (flag % speed == 0)
            {
                if (flag % PositionY[0] == 0 || flag0 > 0)
                {
                    flag0++;
                    rockPositionY[0]++;
                }
                if (flag % PositionY[1] == 0 || flag1 > 0)
                {
                    flag1++;
                    rockPositionY[1]++;
                }
                if (flag % PositionY[2] == 0 || flag2 > 0)
                {
                    flag2++;
                    rockPositionY[2]++;
                }
                if (flag % PositionY[3] == 0 || flag3 > 0)
                {
                    flag3++;
                    rockPositionY[3]++;
                }
                if (flag % PositionY[4] == 0 || flag4 > 0)
                {
                    flag4++;
                    rockPositionY[4]++;
                }
                if (flag % PositionY[5] == 0 || flag5 > 0)
                {
                    flag5++;
                    rockPositionY[5]++;
                }
                if (flag % PositionY[6] == 0 || flag6 > 0)
                {
                    flag6++;
                    rockPositionY[6]++;
                }
                if (flag % PositionY[7] == 0 || flag7 > 0)
                {
                    flag7++;
                    rockPositionY[7]++;
                }
                if (flag % PositionY[8] == 0 || flag8 > 0)
                {
                    flag8++;
                    rockPositionY[8]++;
                }
            }

        }
        if (rockPositionY[0] == dwarfPositionY + 1)
        {

            rockPositionY[0] = 0;
            form[0] = symbolGenerator.Next(0, 9);

        }
        if (rockPositionY[1] == dwarfPositionY + 1)
        {

            form[1] = symbolGenerator.Next(0, 9);
            rockPositionY[1] = 0;


        }
        if (rockPositionY[2] == dwarfPositionY + 1)
        {

            rockPositionY[2] = 0;
            form[2] = symbolGenerator.Next(0, 9);

        }
        if (rockPositionY[3] == dwarfPositionY + 1)
        {

            rockPositionY[3] = 0;
            form[3] = symbolGenerator.Next(0, 9);

        }
        if (rockPositionY[4] == dwarfPositionY + 1)
        {

            rockPositionY[4] = 0;
            form[4] = symbolGenerator.Next(0, 9);

        }
        if (rockPositionY[5] == dwarfPositionY + 1)
        {

            rockPositionY[5] = 0;
            form[5] = symbolGenerator.Next(0, 9);

        }
        if (rockPositionY[6] == dwarfPositionY + 1)
        {

            rockPositionY[6] = 0;
            form[6] = symbolGenerator.Next(0, 9);

        }
        if (rockPositionY[7] == dwarfPositionY + 1)
        {

            rockPositionY[7] = 0;
            form[7] = symbolGenerator.Next(0, 9);

        }
        if (rockPositionY[8] == dwarfPositionY + 1)
        {

            rockPositionY[8] = 0;
            form[8] = symbolGenerator.Next(0, 9);

        }
    }
    ////////////////////////////////////////////////
    static void Collusion()
    {
        if ((rockPositionY[0] == dwarfPositionY) && (rockPositionX[0] == dwarfPositionX) || (rockPositionY[0] == dwarfPositionY) && (rockPositionX[0] - 1 == dwarfPositionX || (rockPositionY[0] == dwarfPositionY) && (rockPositionX[0] - 2 == dwarfPositionX)))
        {

            collusion = 1;
            End();

        }
        if ((rockPositionY[1] == dwarfPositionY) && (rockPositionX[1] == dwarfPositionX) || (rockPositionY[1] == dwarfPositionY) && (rockPositionX[1] - 1 == dwarfPositionX || (rockPositionY[1] == dwarfPositionY) && (rockPositionX[1] - 2 == dwarfPositionX)))
        {

            collusion = 1;
            End();


        }
        if ((rockPositionY[2] == dwarfPositionY) && (rockPositionX[2] == dwarfPositionX) || (rockPositionY[2] == dwarfPositionY) && (rockPositionX[2] - 1 == dwarfPositionX || (rockPositionY[2] == dwarfPositionY) && (rockPositionX[2] - 2 == dwarfPositionX)))
        {

            collusion = 1;
            End();

        }
        if ((rockPositionY[3] == dwarfPositionY) && (rockPositionX[3] == dwarfPositionX) || (rockPositionY[3] == dwarfPositionY) && (rockPositionX[3] - 1 == dwarfPositionX || (rockPositionY[3] == dwarfPositionY) && (rockPositionX[3] - 2 == dwarfPositionX)))
        {

            collusion = 1;
            End();

        }
        if ((rockPositionY[4] == dwarfPositionY) && (rockPositionX[4] == dwarfPositionX) || (rockPositionY[4] == dwarfPositionY) && (rockPositionX[4] - 1 == dwarfPositionX || (rockPositionY[4] == dwarfPositionY) && (rockPositionX[4] - 2 == dwarfPositionX)))
        {

            collusion = 1;
            End();

        }
        if ((rockPositionY[5] == dwarfPositionY) && (rockPositionX[5] == dwarfPositionX) || (rockPositionY[5] == dwarfPositionY) && (rockPositionX[5] - 1 == dwarfPositionX || (rockPositionY[5] == dwarfPositionY) && (rockPositionX[5] - 2 == dwarfPositionX)))
        {

            collusion = 1;
            End();

        }
        if ((rockPositionY[6] == dwarfPositionY) && (rockPositionX[6] == dwarfPositionX) || (rockPositionY[6] == dwarfPositionY) && (rockPositionX[6] - 1 == dwarfPositionX || (rockPositionY[6] == dwarfPositionY) && (rockPositionX[6] - 2 == dwarfPositionX)))
        {

            collusion = 1;
            Console.WriteLine("End");
        }
        if ((rockPositionY[7] == dwarfPositionY) && (rockPositionX[7] == dwarfPositionX) || (rockPositionY[7] == dwarfPositionY) && (rockPositionX[7] - 1 == dwarfPositionX || (rockPositionY[7] == dwarfPositionY) && (rockPositionX[7] - 2 == dwarfPositionX)))
        {

            collusion = 1;
            End();

        }
        if ((rockPositionY[8] == dwarfPositionY) && (rockPositionX[8] == dwarfPositionX) || (rockPositionY[8] == dwarfPositionY) && (rockPositionX[8] - 1 == dwarfPositionX || (rockPositionY[8] == dwarfPositionY) && (rockPositionX[8] - 2 == dwarfPositionX)))
        {

            collusion = 1;
            End();
        }

    }
    ////////////////////////////////////////////////////////////
    static void DrawRocks()
    {


        PrintPosition(rockPositionX[0], rockPositionY[0], rocks[form[0]]);
        PrintPosition(rockPositionX[1], rockPositionY[1], rocks[form[1]]);
        PrintPosition(rockPositionX[2], rockPositionY[2], rocks[form[2]]);
        PrintPosition(rockPositionX[3], rockPositionY[3], rocks[form[3]]);
        PrintPosition(rockPositionX[4], rockPositionY[4], rocks[form[4]]);
        PrintPosition(rockPositionX[5], rockPositionY[5], rocks[form[5]]);
        PrintPosition(rockPositionX[6], rockPositionY[6], rocks[form[6]]);
        PrintPosition(rockPositionX[7], rockPositionY[7], rocks[form[7]]);
        PrintPosition(rockPositionX[8], rockPositionY[8], rocks[form[8]]);

    }

    //////////////////////////////////////////////////////////////

    static void MoveDwarfLeft()
    {
        if (dwarfPositionX > 10)
        {
            dwarfPositionX--;
        }
    }

    /////////////////////////////////////////////////////////////

    static void MoveDwarfRight()
    {
        if (dwarfPositionX < Console.WindowWidth - 4)
        {
            dwarfPositionX++;
        }
    }


    /////////////////////////////////////////////////////////////
    static void DrawDwarf()
    {
        PrintPosition(dwarfPositionX, dwarfPositionY, "(0)");
    }
    /////////////////////////////////////////////////////////////
    static void PrintPosition(int x, int y, string symbol)
    {
        Console.SetCursorPosition(x, y);
        Console.Write(symbol);
    }
    //////////////////////////////////////////////////////////////
    static void PrintPositionScore(int x, int y, int score)
    {
        Console.SetCursorPosition(x, y);
        score = score + flag / 15;
        Console.Write(score);
    }
    //////////////////////////////////////////////////////////////    

    static void SetInitialPosition()
    {
        dwarfPositionX = Console.WindowWidth / 2;
        dwarfPositionY = Console.WindowHeight - 2;

    }
    /////////////////////////////////////////////////////////////
    static void RemoveScrollBars()
    {
        Console.BufferHeight = Console.WindowHeight;
        Console.BufferWidth = Console.WindowWidth;
    }
    /////////////////////////////////////////////////////////////

    static void Main()
    {
        SetInitialPosition();
        RemoveScrollBars();
        do
        {
            
            if (flag > 100)
            {
                speed = 1;
            }
           
            if (flag == 0)
            {
                PositionYGenerator();
                FormGenerator();


            }
            if (flag % 4 == 0)
            {
                Generator();
            }
            flag++;
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.LeftArrow)
                {
                    MoveDwarfLeft();
                }
                if (keyInfo.Key == ConsoleKey.RightArrow)
                {
                    MoveDwarfRight();
                }
            }

            Console.Clear();
            MoveRocks();
            Collusion();
            Result();
            DrawDwarf();
            DrawRocks();
            Thread.Sleep(150);
        } while (true && collusion == 0);

    }
}

