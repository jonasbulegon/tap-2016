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
            for (i = 1; i < vetor.Length; i++)
            {
                atual = vetor[i];
                j = i;
                while ((j > 0) && (vetor[j - 1] > atual))
                {
                    vetor[j] = vetor[j - 1];
                    j = j - 1;
                }
                vetor[j] = atual;
            }
            return vetor;
        }


        public int[] selectionSort(int[] vetor)
        {
            int min, aux;

            for (int i = 0; i < vetor.Length - 1; i++)
            {
                min = i;

                for (int j = i + 1; j < vetor.Length; j++)
                    if (vetor[j] < vetor[min])
                        min = j;

                if (min != i)
                {
                    aux = vetor[min];
                    vetor[min] = vetor[i];
                    vetor[i] = aux;
                }
            }

            return vetor;
        }



        public int[] quickSort(int[] vetor)
        {
            int inicio = 0;
            int fim = vetor.Length - 1;

            quickSort(vetor, inicio, fim);

            return vetor;
        }

        private static void quickSort(int[] vetor, int inicio, int fim)
        {
            if (inicio < fim)
            {
                int p = vetor[inicio];
                int i = inicio + 1;
                int f = fim;

                while (i <= f)
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
                        int troca = vetor[i];
                        vetor[i] = vetor[f];
                        vetor[f] = troca;
                        i++;
                        f--;
                    }
                }

                vetor[inicio] = vetor[f];
                vetor[f] = p;

                quickSort(vetor, inicio, f - 1);
                quickSort(vetor, f + 1, fim);
            }
        }

    }

}
