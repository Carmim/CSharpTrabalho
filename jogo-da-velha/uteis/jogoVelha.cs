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
        public static string MostrarTabuleiro(char[,] tabuleiro)
        {
            string tab = $" {tabuleiro[0, 0]} | {tabuleiro[0, 1]} | {tabuleiro[0, 2]}\n" +
                $"---+---+---\n" +
                $" {tabuleiro[1, 0]} | {tabuleiro[1, 1]} | {tabuleiro[1, 2]}\n" +
                $"---+---+---\n" +
                $" {tabuleiro[2, 0]} | {tabuleiro[2, 1]} | {tabuleiro[2, 2]}";
            return tab;
        }
        public static bool VerificaPosicao(char[,] tabuleiro, int linha, int coluna, int escolha)
        {
            if (tabuleiro[linha, coluna] != 'X' && tabuleiro[linha, coluna] != 'O' && escolha < 10 && escolha > 0)
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
        public static bool VerificaVencedor(char[,] tabuleiro, int jogadorAtual)
        {
            bool ganhou = (tabuleiro[0, 0] == tabuleiro[0, 1] && tabuleiro[0, 1] == tabuleiro[0, 2]) ||
                          (tabuleiro[1, 0] == tabuleiro[1, 1] && tabuleiro[1, 1] == tabuleiro[1, 2]) ||
                          (tabuleiro[2, 0] == tabuleiro[2, 1] && tabuleiro[2, 1] == tabuleiro[2, 2]) ||
                          (tabuleiro[0, 0] == tabuleiro[1, 0] && tabuleiro[1, 0] == tabuleiro[2, 0]) ||
                          (tabuleiro[0, 1] == tabuleiro[1, 1] && tabuleiro[1, 1] == tabuleiro[2, 1]) ||
                          (tabuleiro[0, 2] == tabuleiro[1, 2] && tabuleiro[1, 2] == tabuleiro[2, 2]) ||
                          (tabuleiro[0, 0] == tabuleiro[1, 1] && tabuleiro[1, 1] == tabuleiro[2, 2]) ||
                          (tabuleiro[0, 2] == tabuleiro[1, 1] && tabuleiro[1, 1] == tabuleiro[2, 0]);

            return ganhou;
        }
        public static bool verificaEmpate(char[,] tabuleiro)
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
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
