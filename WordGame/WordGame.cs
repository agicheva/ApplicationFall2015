using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordGame
{
    class WordGame
    {
        static void Main(string[] args)
        {
            char[,] myMatrix = { 
                { 'i', 'v', 'a', 'n'},
                { 'e', 'v', 'n', 'h'},
                { 'i', 'n', 'a', 'v'},
                { 'n', 'v', 'v', 'n'},
                { 'r', 'r', 'i', 't'}
            };                          

            string myWord = "ivan";

            for (int i = 0; i < myMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < myMatrix.GetLength(1); j++)
                {
                    checkForWordRight(i, j , myMatrix, myWord);
                    checkForWordLeft(i, j, myMatrix, myWord);
                    checkForWordUp(i, j, myMatrix, myWord);
                    checkForWordDown(i, j, myMatrix, myWord);
                    checkForWordDiagonalUp(i, j, myMatrix, myWord);
                    checkForWordDiagonalDown(i, j, myMatrix, myWord);
                }
               
            }
            Console.WriteLine(counter);
        }

        static int counter = 0;

        static void checkForWordRight(int row, int col, char[,] matrix, string word)
        {
            Boolean isFound = true;
            for (int i = 0; i < word.Length; i++)
            {
                try
                {
                    if (word[i] != matrix[row, col + i])
                    {
                        isFound = false;
                        break;
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    isFound = false;
                }
            }

            if (isFound)
            {
                counter++;
            }
        }

        static void checkForWordLeft(int row, int col, char[,] matrix, string word)
        {
            Boolean isFound = true;
            for (int i = 0; i < word.Length; i++)
            {
                try
                {
                    if (word[i] != matrix[row, col - i])
                    {
                        isFound = false;
                        break;
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    isFound = false;
                }
            }

            if (isFound)
            {
                counter++;
            }
        }

        static void checkForWordUp(int row, int col, char[,] matrix, string word)
        {
            Boolean isFound = true;
            for (int i = 0; i < word.Length; i++)
            {
                try
                {
                    if (word[i] != matrix[row + i, col])
                    {
                        isFound = false;
                        break;
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    isFound = false;
                }
            }

            if (isFound)
            {
                counter++;
            }
        }

        static void checkForWordDown(int row, int col, char[,] matrix, string word)
        {
            Boolean isFound = true;
            for (int i = 0; i < word.Length; i++)
            {
                try
                {
                    if ( word[i] != matrix[row - i, col])
                    {
                        isFound = false;
                        break;
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    isFound = false;
                }
            }

            if (isFound)
            {
                counter++;
            }
        }

        static void checkForWordDiagonalUp(int row, int col, char[,] matrix, string word)
        {
            Boolean isFound = true;
            for (int i = 0; i < word.Length; i++)
            {
                try
                {
                    if ( word[i] != matrix[row + i, col + i])
                    {
                        isFound = false;
                        break;
                    }
                }
                catch (Exception)
                {
                    isFound = false;

                }
            }

            if (isFound)
            {
                counter++;
            }
        }

        static void checkForWordDiagonalDown(int row, int col, char[,] matrix, string word)
        {
            Boolean isFound = true;
            for (int i = 0; i < word.Length; i++)
            {
                try
                {
                    if ( word[i] != matrix[row - i, col - i])
                    {
                        isFound = false;
                        break;
                    }
                }
                catch (IndexOutOfRangeException e)
                {
                    isFound = false;
                }                
            }

            if (isFound)
            {
                counter++;
            }
        }

    }
}
