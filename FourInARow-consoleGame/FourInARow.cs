using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourInARow_consoleGame
{
    class FourInARow
    {
        char[,] twoDimensionalArray = new char[6, 6];
        private char empt = ' ';
        /// <summary>
        /// Initializes a new instance of the <see cref="FourInARow"/> class.
        /// </summary>
        public FourInARow()
        {
            //populate the array
            for (int i = 0; i < twoDimensionalArray.GetLength(0); i++)
            {
                for (int j = 0; j < twoDimensionalArray.GetLength(1); j++)
                {
                    twoDimensionalArray[i, j] = empt;
                }
            }

            Logic l = new Logic(this);
        }

        public void printBoardToScreen()
        {
            Console.Clear();
            for (int x = 0; x < twoDimensionalArray.GetLength(0); x++)
            {
                Console.Write("|");
                for (int y = 0; y < twoDimensionalArray.GetLength(1); y++)
                {
                    Console.Write(twoDimensionalArray[x, y]+"|");
                }
                Console.WriteLine();
            }
        }

        public void FixBoard()
        {
            for (int x = 0; x < twoDimensionalArray.GetLength(0); x++)
            {
                for (int y = 0; y < twoDimensionalArray.GetLength(1); y++)
                {
                    if (getSingleValue(x, y) != empt)
                    {
                        if (canMoveDown(x, y))
                        {
                            moveDown(x, y);
                        }
                    }
                }
            }
        }

        private void moveDown(int x, int y)
        {
            twoDimensionalArray[x + 1, y] = twoDimensionalArray[x, y];
            twoDimensionalArray[x, y] = empt;
        }

        private bool canMoveDown(int x, int y)
        {
            if (x + 2 <= twoDimensionalArray.GetLength(0))
            {
                return (getSingleValue(x + 1, y) == empt);
            }
            return false;
        }

        /// <summary>
        /// get a singel value from our two dimensional array
        /// </summary>
        /// <param name="x">x axis</param>
        /// <param name="y">y axis</param>
        /// <returns></returns>
        public char getSingleValue(int x, int y)
        {
            return twoDimensionalArray[x, y];
        }

        /// <summary>
        /// Set a single value our two dimensional array
        /// </summary>
        /// <param name="x">x axis position</param>
        /// <param name="y">y axis position</param>
        /// <param name="value">the char you want to set</param>
        /// <returns></returns>
        public bool setSingleValue(int x, int y, char value)
        {
            if (twoDimensionalArray[x, y] == empt)
            {
                twoDimensionalArray[x, y] = value;
                return true;
            }
            else
            {
                Console.WriteLine("Du må ikke sætte en brik her");
                return false;
            }
        }
    }
}
