using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2
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

            Biblioteca B1 = new Biblioteca("Oliver Bowden", "The Secret Crusade", "Amazon",29.5);
            string s_2 = B1.Info();
            Console.WriteLine(s_2+"\n");
            Console.ReadKey();
        }
    }
}
