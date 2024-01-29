using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U1S1G1
{
    internal class Program
    {
        static void Main(string[] args) 
            //questo è il punto di accesso, che fa accadere cose nell'applicazione
        {
            Atleta atleta1 = new Atleta(); //istanzio classe - accedo alla proprietà //get
            atleta1.Nome = "Hubert van Innis"; //set - imposto il valore 

            Atleta atleta2 = new Atleta(); //get
            atleta2.Nome = "Edoardo Mangiarotti"; //set

            Console.WriteLine("Atleta1: " + atleta1.Nome); //combino stringa statica con stringa dinamica //GET
            Console.WriteLine("\n"); //new line in console
            Console.Write("Atleta2: " + atleta2.Nome);
            Console.WriteLine("\n");
            atleta1.Nome = "Ciccia Piccia";
            Console.WriteLine("Atleta1 aggiornato: " + atleta1.Nome);
            Console.WriteLine("\n");

            string Messaggio = atleta1.NumeroGoldMedaglie(58); //richiamo metodo passando valore
            Console.WriteLine("Medaglie d'oro: " + atleta1 + ": " + Messaggio);
            Console.WriteLine("\n");

            string altroMessaggio = atleta2.NumeroGoldMedaglie(9);
            Console.WriteLine("Medaglie d'oro: " + atleta2 + ": " + altroMessaggio);
            Console.ReadLine(); // attendo input - questo serve per visualizzare in console 
            Console.WriteLine("\n");
            
        }
    }
}
