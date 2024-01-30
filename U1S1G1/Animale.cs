using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U1S1G1
{
    public class Animale
    {
        private string _razza;
        public string Razza
        {
            get { return _razza; }
            set { _razza = value; }
        }
        public string PerditaPelo(int valore)
        {
            if (valore > 3)
            {
                return "perde molto pelo";
            }
            else
            {
                    return "perde poco pelo";
            }
        }
    }
}
