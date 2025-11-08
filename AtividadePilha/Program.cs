using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadePilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pilha p = new Pilha(100);

            Console.WriteLine("(+) para somar       | \n" +
                "(-) para diminuir    | \n" +
                "(/) para dividir     | \n" +
                "(*) para Multiplicar | ");

            for (int i = 0; i < 100; i++)
            {
                if (p.Cheia() == true)
                {
                    Console.WriteLine("Pilha Cheia!! Faça uma operação!");
                }

                Console.Write("\nDigite um n° ou valor: ");
                string valor = Console.ReadLine();
                if (valor == "+") {

                    if (p.Vazia() == true)
                    {
                        Console.WriteLine("Pilha Vazia!!");
                    }

                    else
                    {
                        int n1 = p.Desempilhar();
                        int n2 = p.Desempilhar();
                        int n3;
                        n3 = n2 + n1;
                        p.Empilhar(n3);
                        Console.WriteLine(n3);
                    }
                }
                else if (valor == "-") {
                    if (p.Vazia() == true)
                    {
                        Console.WriteLine("Pilha Vazia!!");
                    }

                    else
                    {
                        int n1 = p.Desempilhar();
                        int n2 = p.Desempilhar();
                        int n3;
                        n3 = n2 - n1;
                        p.Empilhar(n3);
                        Console.WriteLine(n3);
                    }
                }
                else if (valor == "*") {
                    if (p.Vazia() == true)
                    {
                        Console.WriteLine("Pilha Vazia!!");
                    }

                        int n1 = p.Desempilhar();
                        int n2 = p.Desempilhar();
                        int n3;
                        n3 = n2 * n1;
                        p.Empilhar(n3);
                    Console.WriteLine(n3);
                }
                else if (valor == "/") {
                    if (p.Vazia() == true)
                    {
                        Console.WriteLine("Pilha Vazia!!");
                    }

                        int n1 = p.Desempilhar();
                        int n2 = p.Desempilhar();
                        int n3;
                        n3 = n2 / n1;
                        p.Empilhar(n3);
                        Console.WriteLine(n3);
                } 
                else
                {
                    p.Empilhar(int.Parse(valor));
                }
            }
        }
    }
}
