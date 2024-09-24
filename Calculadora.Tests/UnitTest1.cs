using Xunit;
using Calculadora;

namespace Calculadora.Tests
{
    public class CalculadoraTests
    {
        [Fact]
        public void TestAdicionar()
        {
            // Arrange
            double num1 = 5;
            double num2 = 3;

            // Act
            double resultado = Program.Adicionar(num1, num2);

            // Assert
            Assert.Equal(8, resultado);
        }

        [Fact]
        public void TestSubtrair()
        {
            // Arrange
            double num1 = 10;
            double num2 = 4;

            // Act
            double resultado = Program.Subtrair(num1, num2);

            // Assert
            Assert.Equal(6, resultado);
        }

        [Fact]
        public void TestMultiplicar()
        {
            // Arrange
            double num1 = 7;
            double num2 = 6;

            // Act
            double resultado = Program.Multiplicar(num1, num2);

            // Assert
            Assert.Equal(42, resultado);
        }

        [Fact]
        public void TestDividir()
        {
            // Arrange
            double num1 = 8;
            double num2 = 2;

            // Act
            double resultado = Program.Dividir(num1, num2);

            // Assert
            Assert.Equal(4, resultado);
        }

        [Fact]
        public void TestDividirPorZero()
        {
            // Arrange
            double num1 = 10;
            double num2 = 0;

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => Program.Dividir(num1, num2));
        }
    }
}
