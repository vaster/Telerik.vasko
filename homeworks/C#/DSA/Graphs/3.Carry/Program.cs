using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Carry
{
    public class Program
    {
        static void Main(string[] args)
        {
            int backpackVolume = int.Parse(Console.ReadLine());

            int countOfRooms = int.Parse(Console.ReadLine());

            string[] roomsVolues = Console.ReadLine().Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries);

            int firstRoom = int.Parse(roomsVolues[0]);

            List<int> sortedRooms = new List<int>(roomsVolues.Length - 1);

            for (int i = 1; i < roomsVolues.Length; i++)
            {
                sortedRooms.Add(int.Parse(roomsVolues[i]));
            }

            //sortedRooms.Sort();

            int passes = 1;
            int currBackPackVolue = firstRoom;

            foreach (int room in sortedRooms)
            {
                currBackPackVolue = currBackPackVolue + room;
                if (currBackPackVolue > backpackVolume)
                {
                    break;
                }

                passes++;
            }

            Console.WriteLine(passes);
        }
    }
}
