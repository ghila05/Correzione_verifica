using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correzione_verifica
{
    class Conto
    {
        string _id;
        string _cliente;
        string _banca;
        float _saldo;


        public Conto(string id, string cliente, string banca)
        {
            _id = id;
            _cliente = cliente;
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

        public string cliente
        {
            get
            {
                return _cliente;
            }
            private set
            {
                _cliente = value;
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

        public float saldo
        {
            get
            {
                return _saldo;
            }
            private set
            {
                _saldo = value;
            }
        }

        public void Deposita(float somma)
        {

            _saldo = _saldo + somma;

        }
        public void Preleva(float somma)
        {
            if (_saldo - somma > 0)
            {
                _saldo = _saldo - somma;
            }
            else
            {
                throw new Exception("saldo insuff");
            }

        }
        public void Bonifico(float somma)
        {
            Preleva(somma);
            // invia(float somma, string contodestinatario)

        }

    }
}
