using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aulaGamaProduto.fucoes
{
    internal class Calc
    {


        public double calcLucro(double valorCompra, double percLucro)
        {

            return valorCompra * percLucro;
        }

        public double calcVenda(double valorCompra, double percVenda)
        {
            return valorCompra + (valorCompra * percVenda / 100);
        }

    }
}
