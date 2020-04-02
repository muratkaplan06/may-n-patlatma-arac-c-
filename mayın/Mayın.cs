using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mayın
{
    class Mayın
    {
        public int x;
        public int y;

        public void uret()
        {
            Random sayiGen = new Random();
            
                x= sayiGen.Next(1, 31);
                y= sayiGen.Next(1, 21);
            
        }
        public void ciz()
        {
            
            
                Console.SetCursorPosition(x, y);
            //mayını gosterebilmek icin * yazdım bunu kaldırdıgımda gorunmez olacak
                Console.Write("*");
            
            for (int i = 1; i < 32; i++)
            {
                Console.SetCursorPosition(i, 1);
                Console.Write(".");
                Console.SetCursorPosition(i, 22);
                Console.Write(".");
            }
            for (int j = 1; j <22; j++)
            {
                Console.SetCursorPosition(0, j);
                Console.WriteLine(".");
                Console.SetCursorPosition(32, j);
                Console.WriteLine(".");
            }
         }
        public void Ociz()
        {
            Console.SetCursorPosition(x, y);
            Console.Write("0");
            Console.SetCursorPosition(1, 33);
            Console.WriteLine("mayın bulundu");
            Console.Beep(2000, 2000);
        }
    }
}
