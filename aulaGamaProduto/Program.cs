using aulaGamaProduto.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastro_class
{

    internal class Program
    {
        static void Main(string[] args)
        {

            List<Grupo> list = new List<Grupo>();


            Console.WriteLine("Ola gostaria de adicionar Produtos");
            var s = "n";
            bool? inicio = false;
            do
            {
                Console.WriteLine("Digite s para sim e n para não");
                s = Console.ReadLine();
                switch (s.ToLower())
                {
                    case "n":
                        {
                            inicio = false;
                            break;
                        };
                    case "s":
                        {
                            inicio = true;
                            break;
                        }
                    default:
                        {
                            inicio = false;
                            Console.WriteLine("Opção invalido");
                        }
                        break;
                };
            } while (inicio == null);
            if (inicio.Value)
                do
                {
                    inicio = null;
                    Grupo lGrupo = new Grupo();
                    lGrupo = new Alimento();
                    Alimento lAlimento = new Alimento();
                    Eletrodomestico lEletrodomestico = new Eletrodomestico();

                    Console.WriteLine("Digite 1 para Alimento e 2 para Eletromestico");
                    s = Console.ReadLine();
                    switch (s.ToLower())
                    {
                        case "1":
                            {
                                lAlimento = new Alimento();
                                lAlimento.lerDados();
                                lAlimento.lerDadosEspecial();
                                list.Add(lAlimento);

                                break;
                            };
                        case "2":
                            {
                                lEletrodomestico = new Eletrodomestico();
                                lEletrodomestico.lerDados();
                                lEletrodomestico.lerDadosEspecial();
                                list.Add(lAlimento);

                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Valor invalido");
                            }
                            break;
                    };
                    lGrupo = new Eletrodomestico();

                    Console.WriteLine("Ola gostaria de adicionar mais Produtos");
                    Console.WriteLine("Digite s para sim e n para não");
                    s = Console.ReadLine();
                    switch (s.ToLower())
                    {
                        case "n":
                            {
                                inicio = false;
                                break;
                            };
                        case "s":
                            {
                                inicio = true;
                                break;
                            }
                        default:
                            {
                                inicio = false;
                                Console.WriteLine("Valor invalido");
                            }
                            break;
                    };

                } while (inicio == null);
            if (list.Count > 0)
                do
                {
                    Console.WriteLine("Ola gostaria de mostra os  Produtos");
                    Console.WriteLine("Digite s para sim e n para não");

                    s = Console.ReadLine();

                    switch (s.ToLower())
                    {
                        case "n":
                            {
                                inicio = false;
                                break;
                            };
                        case "s":
                            {
                                inicio = true;
                                list.ForEach(obj => obj.escreverDado());
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Valor invalido");

                            }
                            break;
                    };
                } while (inicio == null);
            if (list.Count > 0)
                do
                {
                    Console.WriteLine("Ola gostaria de Troca os Status");
                    Console.WriteLine("Digite s para sim e n para não");

                    s = Console.ReadLine();

                    switch (s.ToLower())
                    {
                        case "n":
                            {
                                inicio = false;
                                break;
                            };
                        case "s":
                            {
                                inicio = false;
                                Console.WriteLine("Digite o nome do produto no qual queira alterar");
                                var produto = Console.ReadLine();

                                list.ForEach(obj =>
                                {
                                    if (produto == obj.Name)
                                    {
                                        obj.trocaStatus();
                                    }

                                });
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Valor invalido");

                            }
                            break;
                    };
                } while (inicio == null);
        }
    }
}