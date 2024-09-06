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
            if (desconto < 0 || desconto > 100)
            {
                throw new ArgumentException("Entre com um desconto que esteja entre 0% e 100%");
            }
            else if (precoNormal < 0)
            {
                throw new ArgumentException("O produto não pode ter preço negativo");
            }

            //Valor do Desconto = Preço Original x (Porcentagem de Desconto / 100)
            return precoNormal - (precoNormal * (desconto / 100) );
        }

    }
}
