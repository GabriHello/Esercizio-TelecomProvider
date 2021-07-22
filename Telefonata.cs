using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelecommmmmProvider
{
    class Telefonata
    {


        /*string numeroDestinatario;
       int durataChiamata;*/

        public string numeroDestinatario { get; }
        public int durataChiamata { get; }
        public Telefonata(/*string numeroDestinatario, int durataChiamata*/string numeroDestinatario, int durataChiamata)
        {
            //Se io inserisco numero e durata nel costruttore, sono costretto a usarli entrambi (una chiamata ha destinatario E durata)
            /* this.numeroDestinatario = numeroDestinatario;
             this.durataChiamata = durataChiamata;*/
            this.numeroDestinatario = numeroDestinatario;
            this.durataChiamata = durataChiamata;

        }


        //Possiamo scriverli come proprietà con get set 
        /*public int MinutiChiamata()
        {
            *//*durataChiamata = 10203;*//*
            return durataChiamata;
        }
        public string NumeroChiamato()
        {
            return numeroDestinatario;
        }*/
        /*public string numeroDestinatario { get; set; }
        public int durataChiamata { get; set; }*/



    }
}
