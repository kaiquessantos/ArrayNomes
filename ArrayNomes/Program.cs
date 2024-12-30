using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayNomes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] nomes = new string[5];
            int contador = 0;

            bool inout = false;

            while (inout == false)
            {
                Console.WriteLine("Gerenciador de nomes!");
                Console.WriteLine("Digite 1 - Para adicionar os nomes.\n(Digite 5 nomes no total 1 por vez. 'u')");
                Console.WriteLine("Digite 2 - Para listar os nomes."); 
                Console.WriteLine("Digite 0 - Para sair.");
                int escolha = int.Parse(Console.ReadLine());

                switch(escolha)
                {
                    case 1:
                        if (contador < nomes.Length)
                        {
                            Console.WriteLine("Qual nome deseja adicionar?");
                            string nomeDesejado = Console.ReadLine();
                            nomes[contador] = nomeDesejado;
                            contador++;
                            Console.WriteLine("Nome adicionado com sucesso, tecle Enter para prosseguir.");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Sinto muito, o gerenciador está lotado.");
                            Console.ReadLine();
                        }
                        break;

                    case 2:
                        Console.WriteLine("Aqui estão os nomes listados até o momento: ");

                        Array.Sort(nomes);

                        foreach (string nome in nomes)
                        {
                            Console.WriteLine(nome);
                        }

                        Console.WriteLine("Deseja saber a posição de algum nome especifico?\n1 - Sim\n2 - Não");
                        int position = int.Parse(Console.ReadLine());

                        if (position == 1)
                        {
                            Console.WriteLine("Digite o nome que deseja saber a posição: ");
                            string namePos = Console.ReadLine();
                            int posicaoArray = Array.BinarySearch(nomes, namePos);
                            Console.WriteLine($"{namePos} está nesta posição: {posicaoArray}.");
                            Console.WriteLine("Tecle Enter para prosseguir.");
                            Console.ReadLine();
                        }

                        if (position == 2)
                        {
                            Console.Clear();
                        }

                        break;

                    case 0:
                        inout = true;
                        break;

                    default:
                        Console.WriteLine("Erro.\nTecle Enter para voltar.");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                        
                }

                Console.Clear();
            }


        }

    }
}
