using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correzione_verifica
{
    class Sportello
    {
        string _id;
        string _indirizzo;
        string _banca;

        public Sportello(string id, string indirizzo, string banca)
        {
            _id = id;
            _indirizzo = indirizzo;
            _banca = banca;
        }

        public string id
        {
            get
            {
                return _id;
            }
            private set
            {
                _id = value;
            }

        }

        public string banca
        {
            get
            {
                return _banca;
            }
            private set
            {
                _banca = value;
            }
        }

        public string indirizzo
        {
            get
            {
                return _indirizzo;
            }
            private set
            {
                _indirizzo = value;
            }
        }

        public Carta Inserisci(Carta carta)
        {
            return carta;
        }

        public Carta Rimuovi(Carta carta)
        {
            return carta;
        }

        public Carta getCarta(Carta carta)
        {
            return carta;
        }

    }
    
    
}
