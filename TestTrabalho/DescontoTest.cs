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
            decimal precoNormal = 100M;
            decimal desconto = 0M;
            decimal resultadoEsperado = 100M;
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
            decimal precoNormal = 100M;
            decimal desconto = -10M;
            //a��o e teste
            Assert.ThrowsException<ArgumentException>(() => desc.calculaDesconto(precoNormal,desconto));
        }
        [TestMethod]
        public void CalcularPrecoProdutoNegativo()
        {
            //cenario
            var desc = new Desconto();
            decimal precoNormal = -100M;
            decimal desconto = 10M;
            //a��o e teste
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
            //a��o
            resultado = Triangulos.VerTipoDoTriangulo(lado1, lado2, lado3);
            //teste
            Assert.AreEqual("Equil�tero", resultado);
        }
        [TestMethod]
        public void TestaIsosceles()
        {
            //cenario
            decimal lado1 = 5M;
            decimal lado2 = 5M;
            decimal lado3 = 8M;
            string resultado;
            //a��o
            resultado = Triangulos.VerTipoDoTriangulo(lado1, lado2, lado3);
            //teste
            Assert.AreEqual("Is�sceles", resultado);
        }
        [TestMethod]
        public void TestaSeNaoETriangulo()
        {
            //cenario
            decimal lado1 = 0M;
            decimal lado2 = 2M;
            decimal lado3 = 3M;
            //a��o e teste
            Assert.ThrowsException<ArgumentException>(() => Triangulos.VerTipoDoTriangulo(lado1, lado2, lado3)); 
        }

        [TestMethod]
        public void TestaEscaleno()
        {
            //cenario
            decimal lado1 = 5M;
            decimal lado2 = 6M;
            decimal lado3 = 7M;
            string resultado;
            //a��o
            resultado = Triangulos.VerTipoDoTriangulo(lado1, lado2, lado3);
            //teste
            Assert.AreEqual("Escaleno", resultado);
        }

        //[TestMethod]
        //public void TestaRetangulo()
        //{
        //    //cenario
        //    decimal lado1 = 3M;
        //    decimal lado2 = 4M;
        //    decimal lado3 = 5M;
        //    string resultado;
        //    //a��o
        //    resultado = Triangulos.VerTipoDoTriangulo(lado1, lado2, lado3);
        //    //teste
        //    Assert.AreEqual("Ret�ngulo", resultado);
        //}
        //[TestMethod]
        //public void TestaObtusangulo()
        //{
        //    //cenario
        //    decimal lado1 = 6M;
        //    decimal lado2 = 8M;
        //    decimal lado3 = 10M;
        //    string resultado;
        //    //a��o
        //    resultado = Triangulos.VerTipoDoTriangulo(lado1, lado2, lado3);
        //    //teste
        //    Assert.AreEqual("Obtus�ngulo", resultado);
        //}
        
        //[TestMethod]
        //public void TestaAcutangulo()
        //{
        //    //cenario
        //    decimal lado1 = 5M;
        //    decimal lado2 = 6M;
        //    decimal lado3 = 7M;
        //    string resultado;
        //    //a��o
        //    resultado = Triangulos.VerTipoDoTriangulo(lado1, lado2, lado3);
        //    //teste
        //    Assert.AreEqual("Acut�ngulo", resultado);
            
            
        //}
    }
}