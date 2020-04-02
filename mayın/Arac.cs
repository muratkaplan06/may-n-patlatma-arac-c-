using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mayın
{
    class Arac
    {
        public int x = 1;
        public int y = 1;
        public int skor = 0;
        
        public void ciz()
        {
           
            Console.Clear();
            Console.SetCursorPosition(x, y);
            Console.Write("A");
        }

        public void hareketEt(ConsoleKeyInfo tus)
        {
            
            if (tus.Key == ConsoleKey.RightArrow)
                x++;
            else if (tus.Key == ConsoleKey.LeftArrow)
                x--;
            else if (tus.Key == ConsoleKey.DownArrow)
                y++;
            else if (tus.Key == ConsoleKey.UpArrow)
                y--;

            if (x == 31)
                x = 1;
            if (x == 0)
                x = 30;
            if (y == 21)
                y = 1;
            if (y == 0)
                y = 20;
        }
        public bool mayini_patlattimi(Mayın oankibomb)
        {
            bool sonuc = false;
            if (((x-2 == oankibomb.x) && (y== oankibomb.y))||((x+2 == oankibomb.x) && (y == oankibomb.y))|| ((x== oankibomb.x) && (y-2== oankibomb.y))|| ((x== oankibomb.x) && (y+2 == oankibomb.y)))
            {
               
                 sonuc = true;
            }
            return sonuc;
        }
     }
}