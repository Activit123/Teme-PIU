using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema4
{
    public class Biblioteca
    {
        string autor;
        string titlul;
        string editura;
        double pret;
        string cititor;

        /// 
        /// GET AND SET
        ///
        public string Autor {
            get { return autor; }
            set {autor=value; } 
        }
        public string Titlul {
            get {return titlul; }
            set {titlul=value; }
        }
        public string Editura {
            get {return editura; }
            set {editura=value; }
        }
        public double Pret {
            get {return pret; }
            set {pret=value; }
        }
        public string Cititor {
            get {return cititor; }
            set {cititor=value; }
        }
        
        


        ///constructor fara parametri
        public Biblioteca()
        {
            autor = string.Empty;
            titlul = string.Empty;
            editura = string.Empty;
            pret = 0.0;

            cititor = string.Empty;

        }

        /// constructor cu parametri

        public Biblioteca(string _autor,string _titlul,string _editura,double _pret,string _cititor)
        {

            autor = _autor;
            titlul = _titlul;
            editura = _editura;
            pret = _pret;

            cititor = _cititor;

        }
        public string Info()
        {
            if(cititor!="")
            return string.Format("Editura este: {0} .\n Autorul este: {1} .\n Titlul carti este {2} .\n In cazul in care doriti sa o achizitionezi cartea pretul este: {3}.\nCititorulu este : {4}",editura,autor,titlul,pret,cititor);
            else
                return string.Format("Editura este: {0} .\n Autorul este: {1} .\n Titlul carti este {2} .\n In cazul in care doriti sa o achizitionezi cartea pretul este: {3}.\nCartea este disponibila", editura, autor, titlul, pret);

        }
        public Biblioteca(string date,double value)
        {
            string [] buff = date.Split(',');
            autor =buff[0];
            titlul = buff[1];
            editura = buff[2];
            cititor = buff[3];
            pret = value;
            

        }
    }

}
