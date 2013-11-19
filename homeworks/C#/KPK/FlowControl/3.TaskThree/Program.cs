using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.TaskThree
{
    class Program
    {
        static void VisitCell()
        {
            //TODO:
        }

        static void Main(string[] args)
        {
            //Sample variables
            int x = 10;
            int y = 15;
            bool shouldVisitCell = true;

            const int MIN_X = 0;
            const int MAX_X = 100;
            const int MIN_Y = 0;
            const int MAX_Y = 50;

            // when use '&&' order variables so 'x' is between MIN and MAX, like drawing them on a paper.
            bool isXinRange = (MIN_X <= x && x <= MAX_X);
            bool isYinRange = (MIN_Y <= y && y <= MAX_Y);

            if (isXinRange && isXinRange)
            {
                // use positive logic.
                if(shouldVisitCell)
                {
                   VisitCell();
                }
            }
        }
    }
}
