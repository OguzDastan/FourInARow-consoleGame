using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourInARow_consoleGame
{
    class Player
    {
        private Logic logic;
        public char Symbol { get; set; }

        public Player(Logic l, char c)
        {
            this.logic = l;
            Symbol = c;
        }

        public void TakeTurn()
        {
            Console.Clear();
            logic.board.printBoardToScreen();
            Console.WriteLine(Symbol + " please take your turn..");

            int x = Int32.Parse(Console.ReadLine())-1;
            while (!logic.board.setSingleValue(0, x, Symbol))
            {
                Console.Clear();
                logic.board.printBoardToScreen();
                Console.WriteLine("can't place piece at "+x);
                Console.WriteLine(Symbol + " please take your turn..");
                x = Int32.Parse(Console.ReadLine());
            }
            logic.board.FixBoard();
        }
    }
}