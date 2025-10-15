using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XoX_Game
{
    class Display
    {
        public void board(char[] cells)
        {
            for (int i = 0; i < 9; i += 3)
            {
                Console.WriteLine($" {(cells[i] == ' ' ?
                    i.ToString() : cells[i].ToString())} | {(cells[i + 1] == ' ' ? 
                    (i + 1).ToString() : cells[i + 1].ToString())} | {(cells[i + 2] == ' ' ? 
                    (i + 2).ToString() : cells[i + 2].ToString())}");
                if (i < 6)
                    Console.WriteLine("---|---|---");
            }
        }


        public void entryScreen()
        {
            Console.WriteLine("Welcome to the XoX Game!\n**Please press Enter to Continue**");
            Console.ReadLine();            
        }
        

    }
}
