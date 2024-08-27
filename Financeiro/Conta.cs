using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financeiro
{
    public class Conta
    {
        //atributo
        private int _numero;

        //propriedade
        public int Numero 
        {
            get
            {
                return _numero;
            }
            private set
            {
                _numero = value;
            }
        }
        public Conta(int numero)
        {
            _numero = numero;
        }
        public Conta()
        {
        }
    }
}
