using System;

namespace XoX_Game
{
    class ScreenController
    {
        private Display display = new Display();
        private GameController game;

        public ScreenController()
        {
            game = new GameController(display); 
        }

        public void Start()
        {
            display.entryScreen();

            game.setupPlayers();

            game.startGame();
        }
    }
}
