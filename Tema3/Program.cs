using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema3
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Instantierea unui obiect de tip biblioteca fara parametri

            var m = new Biblioteca();
            string s_1 = m.Info();
            Console.WriteLine(s_1+"\n");

            ///Instantierea unui obiect de tip biblioteca cu parametri

            Biblioteca B1 = new Biblioteca("Oliver Bowden", "The Secret Crusade", "Amazon",60.8,"Spita Mihai");
            string s_2 = B1.Info();
            Console.WriteLine(s_2+"\n");

            ///Instantiere unui obiect de tip Biblioteca cu sir de caractere
            var m_2 = new Biblioteca("Jack London, Colt Alb ,eMag,Radu", 10);
            string s_3 = m_2.Info();
            Console.WriteLine(s_3);


            Console.ReadKey();
        }
    }
}
