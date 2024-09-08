using AulasPOO.uteis;

namespace TestTrabalho
{
    [TestClass]
    public class DescontoTest
    {
        [TestMethod]
        public void CalcularDesconto()
        {
            //cenario
            var desc = new Desconto();
            decimal precoNormal = 1299.90M;
            decimal desconto = 26M;
            decimal resultadoEsperado = 961.93M;
            decimal resultado;
            //ação
            resultado = desc.calculaDesconto(precoNormal,desconto);
            //teste
            Assert.AreEqual(resultadoEsperado, Math.Round(resultado, 2), "Calculo do desconto está incorreto");
        }
        [TestMethod]
        public void Calcular0DeDesconto()
        {
            //cenario
            var desc = new Desconto();
            decimal precoNormal = 100M;
            decimal desconto = 0M;
            decimal resultadoEsperado = 100M;
            decimal resultado;
            //ação
            resultado = desc.calculaDesconto(precoNormal, desconto);
            //teste
            Assert.AreEqual(resultadoEsperado, resultado, "Calculo do desconto está incorreto");
        }
        [TestMethod]
        public void CalcularDescontoNegativo()
        {
            //cenario
            var desc = new Desconto();
            decimal precoNormal = 100M;
            decimal desconto = -10M;
            //ação e teste
            Assert.ThrowsException<ArgumentException>(() => desc.calculaDesconto(precoNormal,desconto));
        }
        [TestMethod]
        public void CalcularPrecoProdutoNegativo()
        {
            //cenario
            var desc = new Desconto();
            decimal precoNormal = -100M;
            decimal desconto = 10M;
            //ação e teste
            Assert.ThrowsException<ArgumentException>(() => desc.calculaDesconto(precoNormal, desconto));
        }
    }

    [TestClass]

    public class TrianguloTests
    {
        [TestMethod]
        public void TestaEquilatero()
        {
            //cenario
            decimal lado1 = 5M;
            decimal lado2 = 5M;
            decimal lado3 = 5M;
            string resultado;
            //ação
            resultado = Triangulos.VerTipoDoTriangulo(lado1, lado2, lado3);
            //teste
            Assert.AreEqual("Equilátero", resultado);
        }
        [TestMethod]
        public void TestaIsosceles()
        {
            //cenario
            decimal lado1 = 5M;
            decimal lado2 = 5M;
            decimal lado3 = 8M;
            string resultado;
            //ação
            resultado = Triangulos.VerTipoDoTriangulo(lado1, lado2, lado3);
            //teste
            Assert.AreEqual("Isósceles", resultado);
        }
        [TestMethod]
        public void TestaSeETriangulo()
        {
            //olha agr gripp
        }

    }
}