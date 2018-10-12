using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourInARow_consoleGame
{
    class Logic
    {
        private Player p1, p2;
        private FourInARow board;
        private bool gameOver;

        public Logic(FourInARow f)
        {
            this.board = f;
            this.p1 = new Player(this, 'G');
            this.p2 = new Player(this, 'R');

            RunGame();
        }

        public void RunGame()
        {
            gameOver = false;
            while (!gameOver)
            {
                board.printBoardToScreen();
                board.setSingleValue(0, p1.TakeTurn(), p1.Symbol);
                board.FixBoard();
            }

        }
    }
}
