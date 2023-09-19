using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caConteiner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pilha pilha1 = new Pilha();
            Pilha pilha2 = new Pilha();
            Pilha pilha3 = new Pilha();
            Pilha pilha4 = new Pilha();
            int codigo;

            Console.WriteLine("[1] Inserir contenier");
            Console.WriteLine("[2] Remover contanier");
            Console.WriteLine("[3] SAIR");

            string controle;
            string lugaradd, lugarRemove;
            controle=Console.ReadLine();
            while(controle != "3")
            {
                switch (controle)
                {
                    case "1":
                        Console.WriteLine("Adicionar na pilha 1,2,3 ou 4?");
                        lugaradd =Console.ReadLine();
                        switch (lugaradd)
                        {
                            case "1":
                                Console.WriteLine("Digite o codigo:");
                                codigo = Convert.ToInt32(Console.ReadLine());
                                pilha1.addFim(codigo);
                                Console.WriteLine("Pilha:");
                                pilha1.Imprimirlista();

                                break;



                            case "2":
                                Console.WriteLine("Digite o codigo:");
                                codigo = Convert.ToInt32(Console.ReadLine());
                                pilha2.addFim(codigo);
                                Console.WriteLine("Pilha:");
                                pilha3.Imprimirlista();
                                break;


                            case "3":
                                Console.WriteLine("Digite o codigo:");
                                codigo = Convert.ToInt32(Console.ReadLine());
                                pilha3.addFim(codigo);
                                Console.WriteLine("Pilha:");
                                pilha3.Imprimirlista();
                                break;



                            case "4":
                                Console.WriteLine("Digite o codigo:");
                                codigo = Convert.ToInt32(Console.ReadLine());
                                pilha4.addFim(codigo);
                                Console.WriteLine("Pilha:");
                                pilha4.Imprimirlista();
                                break;



                            default:
                                Console.WriteLine("Opção inválida. Tente novamente.");
                                break;




                        }
                        break;




                    case "2":
                        Console.WriteLine("remover na pilha 1,2,3 ou 4?");
                        lugarRemove = Console.ReadLine();
                        switch (lugarRemove)
                        {
                            case "1":
                                Console.WriteLine("Digite o Codigo:");
                                codigo = Convert.ToInt32(Console.ReadLine());
                                pilha1.RemoveFim(codigo);
                                Console.WriteLine("Pilha:");
                                pilha1.Imprimirlista();
                                break;



                            case "2":
                                Console.WriteLine("Digite o Codigo:");
                                codigo = Convert.ToInt32(Console.ReadLine());
                                pilha2.RemoveFim(codigo);
                                Console.WriteLine("Pilha:");
                                pilha2.Imprimirlista();
                                break;


                            case "3":
                                Console.WriteLine("Digite o Codigo:");
                                codigo = Convert.ToInt32(Console.ReadLine());
                                pilha3.RemoveFim(codigo);
                                Console.WriteLine("Pilha:");
                                pilha3.Imprimirlista();
                                break;



                            case "4":
                                Console.WriteLine("Digite o Codigo:");
                                codigo = Convert.ToInt32(Console.ReadLine());
                                pilha4.RemoveFim(codigo);
                                Console.WriteLine("Pilha:");
                                pilha4.Imprimirlista();
                                break;



                            default:
                                Console.WriteLine("Opção inválida. Tente novamente.");
                                break;




                        }
                        break;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;


                }
                Console.WriteLine("[1] Inserir contenier");
                Console.WriteLine("[2] Remover contanier");
                Console.WriteLine("[3] SAIR");

                controle = Console.ReadLine();
            }


        }
    }
}
