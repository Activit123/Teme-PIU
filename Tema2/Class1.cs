using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2
{
    public class Biblioteca
    {
        string autor;
        string titlul;
        string editura;
        double pret;


        ///constructor fara parametri
        public Biblioteca()
        {
            autor = string.Empty;
            titlul = string.Empty;
            editura = string.Empty;
            pret = 0.0;

        }

        /// constructor cu parametri

        public Biblioteca(string _autor,string _titlul,string _editura,double _pret)
        {

            autor = _autor;
            titlul = _titlul;
            editura = _editura;
            pret = _pret;

        }
        public string Info()
        {
            return string.Format("Editura este: {0} .\n Autorul este: {1} .\n Titlul carti este {2} .\n In cazul in care doriti sa o achizitionezi cartea pretul este: {3}",editura,autor,titlul,pret);
        }
    }

}
