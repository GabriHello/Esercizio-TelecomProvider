using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelecommmmmProvider
{
    class Program
    {
        static void Main(string[] args)
        {
            string numeroChiamato1 = "33312340101";
            int durata1 = 15;
            Telefonata chiamata1 = new Telefonata("", 15);



            /*int ciao = telefonata1.MinutiChiamata();
            Console.WriteLine($"\n La chiamata è durata {ciao} minuti");*/

            Console.WriteLine("Inserisci numero SIM1");
            string numeroTelefonico = Console.ReadLine();
            Console.WriteLine("Inserisci credito residuo SIM1");
            int creditoResiduo = int.Parse(Console.ReadLine());
            List<Telefonata> registroSim1 = new List<Telefonata>();
            registroSim1.Add(new Telefonata(numeroChiamato1, durata1)
            { });
            Sim schedaSim1 = new Sim(numeroTelefonico, creditoResiduo, registroSim1);

            Console.WriteLine(schedaSim1.creditoResiduo);

            schedaSim1.stampaDatiSim();
        }
    }
}
