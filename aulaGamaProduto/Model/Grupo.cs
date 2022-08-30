using aulaGamaProduto.fucoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aulaGamaProduto.Model
{
    internal class Grupo
    {
        public string Name { get; set; }
        public string Unid { get; set; }
        public Boolean? Status { get; set; }
        public int Quantidade { get; set; }
        public double PrecoCompra { get; set; }
        public double PrecoLucro { get; set; }
        public double PrecoVenda { get; set; }
        public string Armazenagem { get; set; }

        public void lerDados()
        {
            Calc fCalc = new Calc();
            Console.WriteLine("Digite o nome do Produto");
            Name = Console.ReadLine();
            Console.WriteLine("Digite o unidade do Produto");
            Unid = Console.ReadLine();

            do
            {
                Console.WriteLine("Digite o Status do Produto D para disponivel e N para não disponivel");
                var s = Console.ReadLine();
                switch (s.ToLower())
                {
                    case "n":
                        {
                            Status = false;
                            break;
                        };
                    case "d":
                        {
                            Status = true;
                            break;
                        }
                    default:
                        Status = null;
                        Console.WriteLine("Opção invalido");

                        break;
                }
            } while (Status == null);
            Console.WriteLine("Digite a  Quantidade do Produto");
            Quantidade = (int)Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Digite o Preco de compra do Produto");
            PrecoCompra = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a porcentagem de lucro do produto ");
            PrecoLucro = Convert.ToDouble(Console.ReadLine());
            PrecoVenda = fCalc.calcLucro(PrecoCompra, PrecoLucro);
            Console.WriteLine("Digite o armazenamento do produto ");
            Armazenagem = Console.ReadLine();
        }
        public void escreverDado()
        {

            Console.WriteLine("O nome do Produto e:\n " + Name);
            Console.WriteLine("A Unidade do Produto e:\n " + Unid);
            if (Status.Value)
                Console.WriteLine("O Status do Produto e:\nVerdadeiro");
            else
                Console.WriteLine("O Status do Produto e:\nFalse");
            Console.WriteLine("A Quantidade do Produto e:\n" + Name);
            Console.WriteLine("O preco de compra e:\n" + PrecoCompra);
            Console.WriteLine("A porcentagem de :\n" + PrecoLucro);
            Console.WriteLine("O Preco com o venda e:\n " + PrecoVenda);
            Console.WriteLine("O lucal de armazenamento e:\n " + Armazenagem);
        }
        public void trocaStatus()
        {
            do
            {
                Console.WriteLine("Digite o Status do Produto D para disponivel e N para não disponivel");
                var s = Console.ReadLine();
                switch (s.ToLower())
                {
                    case "n":
                        {
                            Status = false;
                            break;
                        };
                    case "s":
                        {
                            Status = true;
                            break;
                        }
                    default:
                        Status = null;
                        Console.WriteLine("Opção invalido");

                        break;
                }
            } while (Status == null);

        }
    };


}

