using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelecommmmmProvider
{
    class Sim
    {


        List<Telefonata> registroChiamate = new List<Telefonata>();
        public string numeroTelefonico { get; }
        public float creditoResiduo { get; }

        public Sim(string numeroTelefonico, float creditoResiduo, List<Telefonata> registroChiamate)
        {
            this.numeroTelefonico = numeroTelefonico;
            this.creditoResiduo = creditoResiduo;
            this.registroChiamate = registroChiamate;
        }

        public int calcoloDurata()
        {
            Console.WriteLine("Quanto è durata la chiamata?");
            int durata = int.Parse(Console.ReadLine());
            return durata; //crea una funzione che calcoli la durata, a partire da ora di inizio e fine chiamata
        }

        public Telefonata inserimentoTelefonata()
        {
            Console.WriteLine("Inserisci il numero che hai chiamato");
            string numeroDestinatario = Console.ReadLine();
            int durata = calcoloDurata();
            var chiamata = new Telefonata(numeroDestinatario, durata);
            return chiamata;
        }


        public void stampaDatiSim()
        { //aaa 
            Console.WriteLine("\nNumero della sim: " + numeroTelefonico);
            Console.WriteLine("\nIl credito residuo è di " + creditoResiduo + " euro.");

            Console.WriteLine("\nHai effettuato le seguenti chiamate");
            int i = 0;
            foreach (Telefonata telefonata in registroChiamate)
            {
                Console.WriteLine($"Chiamata {i}:" + "\nHai chiamato il numero: "
                    + telefonata.numeroDestinatario + " per una durata di "
                    + telefonata.durataChiamata + " minuti.");
            }



        }


    }
}
