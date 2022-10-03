using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Helsinki2017
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //1.feladat
            string a = File.ReadAllText("donto.csv");
            string b = File.ReadAllText("rovidprogram.csv");

            string[] donto = a.Split(';');
            string[] rovid = b.Split(';');
            //2.feladat
            Console.WriteLine("2.Feladat \n A rövidprogramban:{0} indulo volt!",rovid.Length/4);
            //3.feladat
            bool be = false;
            for (int i = 0; i < donto.Length; i++)
            {
                if (donto[i] == "HUN")
                {
                    be = true;
                }
            }
            if (be == true)
            { 
                Console.WriteLine("3.Feladat \n A magyar versenyző bejutott a kűrbe!");
            }
            else {
                Console.WriteLine("3.Feladat \n A magyar versenyző nem jutott be a kűrbe!"); 
            }
            //4.feladat -
            Console.WriteLine("4.Feladat -");
            //5.feladat
            Console.WriteLine("Kérem a versenyzo nevét:");
            string nev = Console.ReadLine();
            bool nevker = false;
            for (int i = 0; i < rovid.Length; i++)
            {
                if (nev == rovid[i])
                {
                    nevker = true;
                }
                else { }
            }
            if (nevker == false)
            {
                Console.WriteLine("5.Feladat \n Ilyen nevu indulo nem volt!");
            }
            else { }

            

          Console.ReadLine();
        }
    }
}
