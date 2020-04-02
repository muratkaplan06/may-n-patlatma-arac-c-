using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mayın
{
    class Program
    {
        static void Main(string[] args)
        {
            Arac zırhlı = new Arac();
            Mayın bomb = new Mayın();
           
            
            ConsoleKeyInfo basilantus;
            
            
                bomb.uret();
                bomb.ciz();
            

            
                do
                {
                basilantus = Console.ReadKey();
                zırhlı.hareketEt(basilantus);
                zırhlı.ciz();
                bomb.ciz();
                
                
                    if (zırhlı.mayini_patlattimi(bomb) == true)
                    {
                    bomb.ciz();
                        zırhlı.ciz();
                    if(basilantus.Key==ConsoleKey.B)
                     bomb.Ociz();
                    }

               
                

                } while (basilantus.Key != ConsoleKey.Escape);
        }
    }
}
