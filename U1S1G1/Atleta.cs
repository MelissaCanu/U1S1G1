using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U1S1G1
{
    public class Atleta
    {
        private string _nome; //proprietà di tipo stringa _example 

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string NumeroGoldMedaglie(int attuale)
        {
            if (attuale > 10)
            {
                return "many medaglie";
            }
            else
            {
                {
                    return "dai che ce la fai";
                }
            }
        }
    }
}

// commento 
