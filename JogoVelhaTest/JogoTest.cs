namespace Jogo_da_velha.uteis.Tests
{
    [TestClass]
    public class JogoVelhaTests
    {
        [TestMethod]
        public void VerificaPosicao_PosicaoVaziaEEscolhaMenorQue10()
        {
            int linha = 1;
            int coluna = 1;
            int escolha = 5;
            char[,] tabuleiro = {
                { ' ', ' ', ' ' },
                { ' ', ' ', ' ' },
                { ' ', ' ', ' ' }
            };
            bool resultado = JogoVelha.VerificaPosicao(tabuleiro, linha, coluna, escolha);

            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void VerificaPosicao_PosicaoOcupada()
        {
            int linha = 0;
            int coluna = 0;
            int escolha = 1;
            char[,] tabuleiro = {
                { 'X', ' ', ' ' },
                { ' ', ' ', ' ' },
                { ' ', ' ', ' ' }
            };

            bool resultado = JogoVelha.VerificaPosicao(tabuleiro, linha, coluna, escolha);

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void VerificaPosicao_EscolhaMaiorOuIgualA10()
        {
            int linha = 0;
            int coluna = 0;
            int escolha = 10;
            char[,] tabuleiro = {
                { ' ', ' ', ' ' },
                { ' ', ' ', ' ' },
                { ' ', ' ', ' ' }
            };

            bool resultado = JogoVelha.VerificaPosicao(tabuleiro, linha, coluna, escolha);

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void TrocaJogador_AlternaJogadorCorretamente()
        {
            int jogadorAtual = 1;

            JogoVelha.TrocaJogador(ref jogadorAtual);

            Assert.AreEqual(2, jogadorAtual);

            JogoVelha.TrocaJogador(ref jogadorAtual);

            Assert.AreEqual(1, jogadorAtual);
        }

        [TestMethod]
        public void VerificaVencedor_JogoComVencedor()
        {
            char[,] tabuleiro = {
                { 'X', 'X', 'X' },
                { ' ', 'O', ' ' },
                { ' ', ' ', 'O' }
            };
            int jogadorAtual = 1;

            Assert.IsTrue(JogoVelha.VerificaVencedor(tabuleiro, jogadorAtual));
        }

        [TestMethod]
        public void VerificaEmpate_JogoEmpatado()
        {
            char[,] tabuleiro = {
                { 'X', 'O', 'X' },
                { 'X', 'X', 'O' },
                { 'O', 'X', 'O' }
            };
            bool rodando = true;
            JogoVelha.verificaEmpate(tabuleiro);
            Assert.IsTrue(rodando);
        }

        [TestMethod]
        public void InicializaTabuleiro()
        {
            char[,] tabuleiro = {
            {'1', '2', '3'},
            {'4', '5', '6'},
            {'7', '8', '9'}
        };
            string esperado = " 1 | 2 | 3\n" +
            "---+---+---\n" +
            " 4 | 5 | 6\n" +
            "---+---+---\n" +
            " 7 | 8 | 9";

            Assert.AreEqual(esperado, JogoVelha.MostrarTabuleiro(tabuleiro));
        }
    }
}