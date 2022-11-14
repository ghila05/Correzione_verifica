using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correzione_verifica
{
    class Carta
    {
        string _id;
        string _pin;
        Conto c = new Conto("1235", "Ghila", "Intesa San Paolo");

        public Carta(string id, string pin)
        {
            _id = id;
            _pin = pin;
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
 
        public float Saldo(string pin)
        {
            if (pin == _pin)
            {
                return c.saldo;
            }
            else
            {
                throw new Exception("pin errato");
            }
        }
        
        public void Deposita(float somma, string pin)
        {
            if (pin == _pin)
            {
                c.Deposita(somma);
            }
            else
            {
                throw new Exception("pin errato");
            }
        }
        public void Preleva(float somma, string pin)
        {
            if (pin == _pin)
            {
                c.Preleva(somma);
            }
            else
            {
                throw new Exception("pin errato");
            }
        }

    }
}
