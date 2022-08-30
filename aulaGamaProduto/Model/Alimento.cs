using aulaGamaProduto.fucoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aulaGamaProduto.Model
{
    internal class Alimento : Grupo
    {

        public Boolean? perecivel { get; set; }

        public string validade { get; set; }

        public void lerDadosEspecial()
        {
            Console.WriteLine("Digite a validade do Produto");
            validade = Console.ReadLine();

            do
            {
                Console.WriteLine("Digite o Status do Produto D para disponivel e N para não disponivel");
                var s = Console.ReadLine();
                switch (s.ToLower())
                {
                    case "n":
                        {
                            perecivel = false;
                            break;
                        };
                    case "d":
                        {
                            perecivel = true;
                            break;
                        }
                    default:
                        perecivel = null;
                        Console.WriteLine("Opção invalido");

                        break;
                }
            } while (Status == null);
        }
    }
}
