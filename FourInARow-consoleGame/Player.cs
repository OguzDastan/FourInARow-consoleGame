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

        public int TakeTurn()
        {
            Console.WriteLine(Symbol + " please take your turn..");
            return Int32.Parse(Console.ReadLine());
        }
    }
}
