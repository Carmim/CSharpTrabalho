using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulasPOO.uteis
{
    public class Desconto
    {
        public decimal calculaDesconto(decimal precoNormal, decimal desconto)
        {
            if (desconto < 0)
            {
                throw new ArgumentException("Não existe desconto negativo");
            }
            
            //Valor do Desconto = Preço Original x (Porcentagem de Desconto / 100)
            return precoNormal - (precoNormal * (desconto / 100) );
        }

    }
}
