using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aulaGamaProduto.Model
{
    internal class Eletrodomestico : Grupo
    {

        public string potencia { get; set; }


        public void lerDadosEspecial()
        {
            Console.WriteLine("Digite a Potencia do Eletrodomestico");
            potencia = Console.ReadLine();

        }

    }
}
