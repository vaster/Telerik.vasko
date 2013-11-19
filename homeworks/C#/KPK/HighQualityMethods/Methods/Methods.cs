using System;

namespace Methods
{
    class Methods
    {

        // For CalculateTriangleArea(...):
        //  1.CalcTriangleArea(...) -> CalculateTriangleArea(...)
        //  2.Instead printing an Error on the console -> throw ArgumentOutOfRangeException(...)
        //  3.'s' -> 'perimeterHalf'
        static double CalculateTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentOutOfRangeException("No side of a triangle can be negative or equal to zero!");
            }

            double perimeterHalf = (a + b + c) / 2;
            double area = Math.Sqrt(perimeterHalf * (perimeterHalf - a) * (perimeterHalf - b) * (perimeterHalf - c));

            return area;
        }

        // For DigitAsWord(...):
        //  1.NumberToDigit(...) -> DigitAsWord(...)
        //  2.number -> digit
        //  3.Instead of return -> default: throw ArgumentOutOfRangeException(...)
        static string DigitAsWord(int digit)
        {
            switch (digit)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: throw new ArgumentOutOfRangeException("Possibly the number you enter is: " +
                                                                "1. Not a digit or can't be represented as a single digit " +
                                                                "2. Is negative. Input -> " + digit);
            }


        }


        // For FindMax(...):
        //  1.'elements' -> 'numbers'
        //  2.Instead return -> NullReferenceException(...).
        //  3.Logic changed to be more intuitive. Using new variable to perform needed actions.
        static int FindMax(params int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new NullReferenceException("");
            }

            int max = int.MinValue;

            for (int index = 0; index < numbers.Length; index++)
            {
                if (numbers[index] > max)
                {
                    max = numbers[index];
                }
            }
            return max;
        }

        // For  PrintNumberInSpecificFormat(...):
        //  1.PrintAsNumber(...) ->  PrintNumberInSpecificFormat(...)
        //  2.'number' type is kept as object(this allow as to use double, long etc.).
        //  3.If construction - > switch-case construction.
        //  4. Check for non-number type and not allowed format.
        static void PrintNumberInSpecificFormat(object number, string format)
        {
            if (number is string || number is char)
            {
                throw new ArgumentException("Not a valid type. Type: " + number.GetType().Name);
            }
            switch (format)
            {
                case "f":
                    Console.WriteLine("{0:f2}", number);
                    break;
                case "%":
                    Console.WriteLine("{0:p0}", number);
                    break;
                case "r":
                    Console.WriteLine("{0,8}", number);
                    break;
                default:
                    throw new FormatException("Not allowed format. Format: " + format);
            } 
        }

        // For  CalculateEuclideanDistance(...):
        //  1.CalcDistance(...) ->  CalculateEuclideanDistance(...)
        //  2.x,y coords -> pointACoord, pointBCoord.
        //  3.Formula represented as separete equations for better readability
        static double CalculateEuclideanDistance(double pointACoordX, double pointACoordY, double pointBCoordX, double pointBCoordY,
            out bool isHorizontal, out bool isVertical)
        {
            isHorizontal = (pointACoordY == pointBCoordY);
            isVertical = (pointACoordX == pointBCoordX);

            double distanceByXCoord = (pointBCoordX - pointACoordX) * (pointBCoordX - pointACoordX);
            double distanceByYCoord = (pointBCoordY - pointACoordY) * (pointBCoordY - pointACoordY);

            double euclideanDistance = Math.Sqrt(distanceByXCoord + distanceByYCoord);

            return euclideanDistance;
        }

        static void Main()
        {
            Console.WriteLine(CalculateTriangleArea(3, 4, 5));

            Console.WriteLine(DigitAsWord(5));

            Console.WriteLine(FindMax(5, -1, 3, 2, 14, 2, 3));

            PrintNumberInSpecificFormat(1.3, "f");
            PrintNumberInSpecificFormat(0.75, "%");
            PrintNumberInSpecificFormat(2.30, "r");

            bool horizontal, vertical;
            Console.WriteLine(CalculateEuclideanDistance(3, -1, 3, 2.5, out horizontal, out vertical));
            Console.WriteLine("Horizontal? " + horizontal);
            Console.WriteLine("Vertical? " + vertical);

            Student peter = new Student() { FirstName = "Peter", LastName = "Ivanov" };
            peter.OtherInfo = "From Sofia, born at 17.03.1992";

            Student stella = new Student() { FirstName = "Stella", LastName = "Markova" };
            stella.OtherInfo = "From Vidin, gamer, high results, born at 03.11.1993";

            Console.WriteLine("{0} older than {1} -> {2}",
                peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
