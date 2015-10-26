using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Points
{
    class Points
    {
        static bool isReverse = false;
        static int xCoordinate;
        static int yCoordinate;

        static void Reverse()
        {
            isReverse = true;
        }

        static void IncreaseX(bool isReverse)
        {
            if (isReverse)
            {
                xCoordinate--;
            }
            else
            {
                xCoordinate++;
            }
        }

        static void DecreaseX(bool isReverse)
        {
            if (isReverse)
            {
                xCoordinate++;
            }
            else
            {
                xCoordinate--;
            }
        }

        static void IncreaseY(bool isReverse)
        {
            if (isReverse)
            {
                yCoordinate++;
            }

            else
            {
                yCoordinate--;
            }
        }

        static void DecreaseY(bool isReverse)
        {
            if (isReverse)
            {
                yCoordinate--;
            }
            else
            {
                yCoordinate++;
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Starting point: ");
<<<<<<< HEAD
            string startingPoint = Console.ReadLine();      
=======
            string startingPoint = Console.ReadLine();      //User enters the coordinates of the starting point in format (x, y)
>>>>>>> f10519fed55fefa32e8099b5562e9de914720559

            string[] splittedStartingPoint = startingPoint.Split(new char[] { '(', ')', ',' }, StringSplitOptions.RemoveEmptyEntries);
            Console.Write("Enter the directions:");
            string directions = Console.ReadLine();

            xCoordinate = int.Parse(splittedStartingPoint[0]);
            yCoordinate = int.Parse(splittedStartingPoint[1]);

            for (int i = 0; i < directions.Length; i++)
            {
                if (directions[i] == '~')
                {
                    Reverse();
                }

                else if (directions[i] == '>')
                {
                    IncreaseX(isReverse);
                }

                else if (directions[i] == '<')
                {
                    DecreaseX(isReverse);
                }

                else if (directions[i] == '^')
                {
                    DecreaseY(isReverse);
                }

                else if (directions[i] == 'v')
                {
                    IncreaseY(isReverse);
                }
            }

            Console.WriteLine("({0},{1})", xCoordinate, yCoordinate);
        }
    }
}
