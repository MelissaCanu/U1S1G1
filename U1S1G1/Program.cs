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
            Console.WriteLine("Atleta2: " + atleta2.Nome);
            Console.WriteLine("\n");
            atleta1.Nome = "Ciccia Piccia";
            Console.WriteLine("Atleta1 aggiornato: " + atleta1.Nome);
            Console.WriteLine("\n");

            string Messaggio = atleta1.NumeroGoldMedaglie(58); //richiamo metodo passando valore
            Console.WriteLine("Medaglie d'oro: " + atleta1.Nome + ": " + Messaggio);
            Console.WriteLine("\n");

            string altroMessaggio = atleta2.NumeroGoldMedaglie(9);
            Console.WriteLine("Medaglie d'oro: " + atleta2.Nome + ": " + altroMessaggio);
            Console.WriteLine("\n");
            Console.WriteLine("\n");

            // animale

            Animale animale1 = new Animale();
            animale1.Razza = "American staffordshire terrier"; //set 

            Animale animale2 = new Animale();
            animale2.Razza = "Maltese"; //set 

            Console.WriteLine("Animale1: " + animale1.Razza);
            Console.WriteLine("\n");
            Console.WriteLine("Animale2: " + animale2.Razza);
            Console.WriteLine("\n");

            string Messaggio2 = animale1.PerditaPelo(2);
            Console.WriteLine("Perdita pelo: " + animale1.Razza + ": " + Messaggio2);
            Console.WriteLine("\n");

            string Messaggio3 = animale2.PerditaPelo(1);
            Console.WriteLine("Perdita pelo: " + animale2.Razza + ": " + Messaggio3);
            Console.WriteLine("\n");

            animale2.Razza = "Spitz tedeschi";
            Console.WriteLine("Animale2 aggiornato: " + animale2.Razza);
            Console.WriteLine("\n");

            string Messaggio4 = animale2.PerditaPelo(4);
            Console.WriteLine("Perdita pelo: " + animale2.Razza+ ": " + Messaggio4);
            Console.WriteLine("\n");
            Console.WriteLine("\n");

            // dipendente

            Dipendente dipendente1 = new Dipendente();
            dipendente1.Nome = "Paolo";
            dipendente1.Cognome = "Semerario";

            Dipendente dipendente2 = new Dipendente();
            dipendente2.Nome = "Melissa";
            dipendente2.Cognome = "Canu";

            Console.WriteLine("Dipendente1: " + dipendente1.Nome + " " + dipendente1.Cognome);
            Console.WriteLine("\n");
            Console.WriteLine("Dipendente2: " + dipendente2.Nome + " " + dipendente2.Cognome);
            Console.WriteLine("\n");

            string Messaggio5 = dipendente1.RendimentoLavoratore(10);
            Console.WriteLine("Rendimento lavoratore: " + dipendente1.Nome + " " + dipendente1.Cognome + ": " + Messaggio5);
            Console.WriteLine("\n");
            string Messaggio6 = dipendente2.RendimentoLavoratore(150);
            Console.WriteLine("Rendimento lavoratore: " + dipendente2.Nome + " " + dipendente2.Cognome + ": " + Messaggio6);
            Console.WriteLine("\n");
            Console.WriteLine("\n");

            // veicolo

            Veicolo veicolo1 = new Veicolo();
            veicolo1.Marca = "Toyota";
            veicolo1.Modello = "Corolla";
            
            Veicolo veicolo2 = new Veicolo();
            veicolo2.Marca = "Ford";
            veicolo2.Modello = "Mustang";

            Console.WriteLine("Veicolo1: " + veicolo1.Marca + " " + veicolo2.Modello);
            Console.WriteLine("\n");
            Console.WriteLine("Veicolo 2: " + veicolo2.Marca + " " + veicolo2.Modello);
            Console.WriteLine("\n");

            string Messaggio7 = veicolo1.MaxKmh("200");
            Console.WriteLine("Max km/h: " + veicolo1.Marca + " " + veicolo1.Modello + ": " + Messaggio7);
            Console.WriteLine("\n");

            string Messaggio8 = veicolo2.MaxKmh("250");
            Console.WriteLine("Max km/h: " + veicolo2.Marca + " " + veicolo2.Modello + ": " + Messaggio8);
            Console.WriteLine("\n");

            Console.ReadLine();
             

        }
    }
}
