using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U1S1G1
{
    public class Dipendente
    {
        private string _nome;
        private string _cognome;
        public string Nome
        {
            get { return _nome; } 
            set { _nome = value;}
        }
        public string Cognome
        {
            get { return _cognome; }
            set { _cognome = value;}
        }

        public string RendimentoLavoratore (int valore)
        {
            if (valore > 100)
            {
                return "premio di fine anno";
            }
            else
            {
                    return "corso di aggiornamento";
            }
        }
    }
}
