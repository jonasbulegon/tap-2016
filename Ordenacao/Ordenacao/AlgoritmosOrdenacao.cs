using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menus
{
    public class AlgoritmosOrdenacao
    {

        public int[] InsertionSort(int[] vetor)
        {
            int i, j, atual;
            for (i = 1; i < vetor.Length; i++) // percorre vetor da esquerda para a direita
            {
                atual = vetor[i];
                j = i;
                while ((j > 0) && (vetor[j - 1] > atual)) // alinha os valores da sua esquerda
                {
                    vetor[j] = vetor[j - 1];
                    j = j - 1;
                }
                vetor[j] = atual;
            }
            return vetor; // retorna vetor
        }


        public int[] selectionSort(int[] vetor)
        {
            int min, aux;

            for (int i = 0; i < vetor.Length - 1; i++) // percorre o vetor vasculhando repetidamente os numeros e escolhe o menor valor
            {
                min = i;

                for (int j = i + 1; j < vetor.Length; j++) // comparando o valor minimo com o proximo
                    if (vetor[j] < vetor[min]) // compara se o proximo numero é menor que o primeiro numero
                        min = j; // se for menor ele passa a ser o primeiro

                if (min != i) // menor valor será passado para o início do vetor, e depois o segundo menor valor para a segunda posição e assim sucessivamente
                {
                    aux = vetor[min];
                    vetor[min] = vetor[i];
                    vetor[i] = aux;
                }
            }

            return vetor; // retorna o vetor
        }



        public int[] quickSort(int[] vetor)
        {
            int inicio = 0;
            int fim = vetor.Length - 1;

            quickSort(vetor, inicio, fim); // chamando o quick sort

            return vetor;
        }

        private static void quickSort(int[] vetor, int inicio, int fim)
        {
            if (inicio < fim) // Comparando a primeira posição com a ultima, se a ultima for menor troca com a primeira posição
            {
                int p = vetor[inicio];
                int i = inicio + 1; 
                int f = fim;

                while (i <= f) // Segunda posição com a ultima e faz a comparação
                {
                    if (vetor[i] <= p)
                    {
                        i++;
                    }
                    else if (p < vetor[f])
                    {
                        f--;
                    }
                    else
                    {
                        int troca = vetor[i]; // troca de posição se a ultima for menor que a primeira
                        vetor[i] = vetor[f];
                        vetor[f] = troca;
                        i++;
                        f--;
                    }
                }

                vetor[inicio] = vetor[f]; // volta ao inicio com as posições ja organizadas
                vetor[f] = p;

                quickSort(vetor, inicio, f - 1);
                quickSort(vetor, f + 1, fim);
            }
        }

    }

}
