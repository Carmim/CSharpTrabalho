using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Jogo_da_velha.uteis
{
    public class JogoVelha
    {
        public static void MostrarTabuleiro(char[,] tabuleiro)
        {
            Console.Clear();
            Console.WriteLine($" {tabuleiro[0, 0]} | {tabuleiro[0, 1]} | {tabuleiro[0, 2]}");
            Console.WriteLine($"---+---+---");
            Console.WriteLine($" {tabuleiro[1, 0]} | {tabuleiro[1, 1]} | {tabuleiro[1, 2]}");
            Console.WriteLine($"---+---+---");
            Console.WriteLine($" {tabuleiro[2, 0]} | {tabuleiro[2, 1]} | {tabuleiro[2, 2]}");
        }
        public static bool VerificaPosicao(char[,] tabuleiro, int linha, int coluna, int escolha)
        {
            if (tabuleiro[linha, coluna] != 'X' && tabuleiro[linha, coluna] != 'O' && escolha < 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void TrocaJogador(ref int jogadorAtual)
        {
            if (jogadorAtual == 1)
            {
                jogadorAtual = 2;
            }
            else
                jogadorAtual = 1;

        }
        public static void VerificaVencedor(char[,] tabuleiro, int jogadorAtual, ref bool rodando)
        {
            if ((tabuleiro[0, 0] == tabuleiro[0, 1] && tabuleiro[0, 1] == tabuleiro[0, 2]) ||
            (tabuleiro[1, 0] == tabuleiro[1, 1] && tabuleiro[1, 1] == tabuleiro[1, 2]) ||
            (tabuleiro[2, 0] == tabuleiro[2, 1] && tabuleiro[2, 1] == tabuleiro[2, 2]) ||
            (tabuleiro[0, 0] == tabuleiro[1, 0] && tabuleiro[1, 0] == tabuleiro[2, 0]) ||
            (tabuleiro[0, 1] == tabuleiro[1, 1] && tabuleiro[1, 1] == tabuleiro[2, 1]) ||
            (tabuleiro[0, 2] == tabuleiro[1, 2] && tabuleiro[1, 2] == tabuleiro[2, 2]) ||
            (tabuleiro[0, 0] == tabuleiro[1, 1] && tabuleiro[1, 1] == tabuleiro[2, 2]) ||
            (tabuleiro[0, 2] == tabuleiro[1, 1] && tabuleiro[1, 1] == tabuleiro[2, 0]))
            {
                MostrarTabuleiro(tabuleiro);
                Console.WriteLine($"O jogador número {jogadorAtual} venceu!");
                rodando = false;
            }
        }
        public static void verificaEmpate(char[,] tabuleiro, ref bool rodando)
        {
            int contador = 0;
            foreach (char tab in tabuleiro)
            {
                if (tab == 'X')
                {
                    contador++;
                }
                else if (tab == 'O')
                {
                    contador++;
                }
            }
            if (contador == 9)
            {
                MostrarTabuleiro(tabuleiro);
                Console.WriteLine("O jogo empatou!");
                rodando = false;
            }
        }
    }
}
