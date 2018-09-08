using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe_matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] Matriz;
            int L, C,NumMatriz, LINHA, COLUNA;

            Console.WriteLine("Informe o numero de linhas da matriz: ");
            L = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o numero de colunas da matriz: ");
            C = Convert.ToInt32(Console.ReadLine());

            LINHA = L;
            COLUNA = C;

            Matriz = new int[L, C];

            for(int linha = 0; linha < L; linha++)
            {
                for(int coluna = 0; coluna < C; coluna++)
                {
                    Console.WriteLine("Informe o valor da posição(Linha/Coluna): [" + linha.ToString() + "," + coluna.ToString() + "]");
                    Matriz[linha,coluna] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Informe um número pertencente à raiz: ");
            NumMatriz = Convert.ToInt32(Console.ReadLine());

            for (int linha = 0; linha < L; linha++)
            {
                for (int coluna = 0; coluna < C; coluna++)
                {
                    if(Matriz[linha, coluna] == NumMatriz)
                    {
                        L = linha;
                        C = coluna;
                        break;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            for (int linha = 0; linha < LINHA; linha++)
            {
                for (int coluna = 0; coluna < COLUNA; coluna++)
                {
                    Console.Write(" "+Matriz[linha, coluna].ToString()+" ");
                }
                Console.WriteLine();
            }

            if ((L-1) >= 0)
            {
                Console.WriteLine("Número acima: " + Matriz[L - 1, C]);
            }

            if((L + 1) < LINHA)
            {
                Console.WriteLine("Número Abaixo: " + Matriz[L + 1, C]);
            }

            if ((C-1) >= 0)
            {
                Console.WriteLine("Número a esquerda: " + Matriz[L, C - 1]);
            }

            if ((C + 1) < COLUNA)
            {
                Console.WriteLine("Número a direita: " + Matriz[L, C + 1]);
            }

            Console.ReadLine();    
        }

        
    }
}
