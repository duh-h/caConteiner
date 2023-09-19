using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caConteiner
{
    internal class Pilha
    {
        public Noh Head { get; set; }
        public int Contador;


        public Pilha()
        {
            this.Head = new Noh();
            this.Head.anterior = null;
            this.Head.proximo = null;
            this.Contador = 0;
        }

        public void addFim(int info)
        {
            if (Contador < 3)
            {
                Noh atual = Head.proximo;

                while (atual != null)
                {
                    if (atual.info == info)
                    {
                        Console.WriteLine("O Codigo já existe na Pilha.");
                        return;
                    }
                    atual = atual.proximo;
                }

                Noh novoNoh = new Noh(info);

                if (this.Head.anterior == null)
                {
                    this.Head.anterior = novoNoh;
                    this.Head.proximo = novoNoh;
                }
                else
                {
                    novoNoh.anterior = this.Head.proximo;
                    this.Head.proximo.proximo = novoNoh;
                    this.Head.proximo = novoNoh;
                }

                this.Contador++;
            }
            else
            {
                Console.WriteLine("Nao e possivel adicionar mais containers na pilha");
            }
        }


        public void Imprimirlista()
        {
            Noh atual = Head.anterior;

            while (atual != null)
            {
                Console.WriteLine(atual.info);
                atual = atual.proximo;
            }

            Console.WriteLine();
        }
        public int RemoveFim(int info)
        {
            if (Head.proximo == null)
            {
                Console.WriteLine("A Pilha está vazia.");
                return -1;
            }
            else
            {
                if (info == Head.proximo.info)
                {

                    int removido = Head.proximo.info;

                    if (Head.anterior == Head.proximo)
                    {
                        Head.anterior = null; ; Head.proximo = null;
                    }
                    else
                    {
                        Head.proximo = Head.proximo.anterior;
                        Head.proximo.proximo = null;
                    }
                    this.Contador--;

                    return removido;
                }
                Console.WriteLine("Codigo Invalido");
                return -1;
            }
        }
    }
}
