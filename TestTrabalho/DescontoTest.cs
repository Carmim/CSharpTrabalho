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
            decimal desconto = 26;
            decimal resultadoEsperado = 961.93M;
            decimal resultado;
            //a��o
            resultado = desc.calculaDesconto(precoNormal,desconto);
            //teste
            Assert.AreEqual(resultadoEsperado, Math.Round(resultado, 2), "Calculo do desconto est� incorreto");
        }
        [TestMethod]
        public void Calcular0DeDesconto()
        {
            //cenario
            var desc = new Desconto();
            decimal precoNormal = 100;
            decimal desconto = 0;
            decimal resultadoEsperado = 100;
            decimal resultado;
            //a��o
            resultado = desc.calculaDesconto(precoNormal, desconto);
            //teste
            Assert.AreEqual(resultadoEsperado, resultado, "Calculo do desconto est� incorreto");
        }
        [TestMethod]
        public void CalcularDescontoNegativo()
        {
            //cenario
            var desc = new Desconto();
            decimal precoNormal = 100;
            decimal desconto = -10;
            //a��o e teste
            Assert.ThrowsException<ArgumentException>(() => desc.calculaDesconto(precoNormal,desconto));
        }
    }
}