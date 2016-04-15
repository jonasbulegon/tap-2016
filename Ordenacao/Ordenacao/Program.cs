using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace menus // criando o menu
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[100]; // declarando o vetor de 100 posicões

            Random rnd = new Random(); // criando aleatoriamente as 100 posição por Random
            for (int i = 0; i < 100; i++) // for do Random
            {
                vetor[i] = rnd.Next(0, 100);
            }

            AlgoritmosOrdenacao ordenar = new AlgoritmosOrdenacao(); // Importando da classe AlgoritmosOrdenação.cs
            int opcao = 0;
            do
            {
                Console.WriteLine("Escolha o algoritmo"); // Implementação do Menu
                Console.WriteLine("1. Insertion Sort"); // Implementação do Menu
                Console.WriteLine("2. Quick Sort"); // Implementação do Menu
                Console.WriteLine("3. Selection Sort"); // Implementação do Menu
                Console.WriteLine("Qualquer outra opção: Sair"); // Implementação do Menu
                int.TryParse(Console.ReadLine(), out opcao); // Implementação do Menu

                if (opcao == 0) // Opção de saida
                {
                    Console.WriteLine("Saindo..."); // Implementação do Menu
                }
                else // Opção de outra escolha
                {
                    if (opcao == 1) // Primeira Opção de escolha
                    {
                        // FUNCTION INSERTION SORT
                        var resultado = ordenar.InsertionSort(vetor);
                        for (int i = 0; i < resultado.Length; i++)
                        {
                            Console.Write(resultado[i] + ",");
                        }
                        Console.WriteLine("");
                    }
                    else if (opcao == 2) // Opção de outra escolha ou Segunda Opção
                    {


                        // FUNCTION QUICK SORT
                        var resultado2 = ordenar.quickSort(vetor);
                        for (int i = 0; i < resultado2.Length; i++)
                        {
                            Console.Write(resultado2[i] + ",");
                        }
                        Console.WriteLine("");
                    }

                    else if (opcao == 3) // Opção de outra escolha ou Terceira Opção
                    {
                        // FUNCTION SELECTION SORT 
                        var resultado3 = ordenar.selectionSort(vetor);
                        for (int i = 0; i < resultado3.Length; i++)
                        {
                            Console.Write(resultado3[i] + ",");
                        }
                        Console.WriteLine("");
                    }
                }

            } 
            while (opcao != 0);
        }
    }
}