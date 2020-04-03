using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema4
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Instantierea unui obiect de tip biblioteca fara parametri

            var m_1 = new Biblioteca();
            string s_1 = m_1.Info();
            Console.WriteLine(s_1+"\n");
            ///Instantierea unui obiect de tip biblioteca cu parametri
            Biblioteca B1 = new Biblioteca("Oliver Bowden", "The Secret Crusade", "Amazon", 60.8, "Spita Mihai");
            string s_2 = B1.Info();
            Console.WriteLine(s_2 + "\n");

            ///Instantiere unui obiect de tip Biblioteca cu sir de caractere
            var m_2 = new Biblioteca("Jack London, Colt Alb ,eMag,Radu", 10);
            string s_3 = m_2.Info();
            Console.WriteLine(s_3);
            ///Instantierea unui obicet de tip biblioteca cu parametri de la tastatura
            var m_3 = new Biblioteca();

            string s_4 = m_3.Info();

            Console.WriteLine(s_4 + "\n");

            Console.WriteLine("\n"+"Scrieti Numele Autorului: "+"\n");
            m_3.Autor = Console.ReadLine();

            Console.WriteLine("\n" + "Scrieti Numele Titlul Carti: " + "\n");
            m_3.Titlul = Console.ReadLine();

            Console.WriteLine("\n" + "Scrieti Numele Edituri: " + "\n");
            m_3.Editura = Console.ReadLine();

            Console.WriteLine("\n" + "Scrieti Valoarea Pretului : "  + "\n");
            string numere = Console.ReadLine();
            m_3.Pret = Convert.ToDouble(numere);

            Console.WriteLine("\n" + "Scrieti Numele Cititorului: " + "\n");
            m_3.Cititor = Console.ReadLine();

           /// Console.WriteLine("{0}", m_3.autor); protected level error

            

            string s_5 = m_3.Info();
            Console.WriteLine(s_5 + "\n");



            Console.ReadKey();
        }
    }
}
