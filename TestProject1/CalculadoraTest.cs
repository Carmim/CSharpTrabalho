using AulasPOO.uteis;

namespace TestProject1
{
    [TestClass]
    public class CalculadoraTest
    {
        [TestMethod]
        public void SomaTest()
        {
            //cenario
            var calc = new Calculadora();
            int num1 = 20;
            int num2 = 22;
            int resultado;
            //ação
            resultado = calc.Soma(num1, num2);
            //teste
            Assert.AreEqual(42,resultado);
        }
        [TestMethod]
        public void MultiplicaTest()
        {
            //cenario
            int num1 = 5;
            int num2 = 5;
            int resultado;
            // ação
            resultado = Calculadora.Multiplica(num1, num2);
            //teste
            Assert.AreEqual(25,resultado);
        }
        [TestMethod]
        public void ImcTest()
        {
            //cenario
            // imc = peso/(altura * altura)
            float peso = 87.5f;
            float altura = 1.8f;
            float imc;
            //ação
            imc = Calculadora.IMC(peso, altura);
            //teste
            Assert.AreEqual(27.01, imc, Math.Round(imc,2));
        }
    }
}