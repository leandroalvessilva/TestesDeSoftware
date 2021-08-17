using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Demo.Tests
{
    public class CalculadoraTests
    {
        [Fact]
        public void Calculadora_Somar_RetornarValorSoma()
        {
            // Arrange 
            var calculadora = new Calculadora();

            //Act 
            var resultado = calculadora.Somar(2, 2);

            //Verifica se o retorno do método é igual ao passado na asserção.

            //Assert 
            Assert.Equal(4, resultado);
        }

        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(4, 2, 6)]
        [InlineData(3, 2, 5)]
        [InlineData(1, 2, 3)]
        public void Calculadora_Somar_RetornarValoresSomaCorretos(double v1, double v2, double total)
        {
            // Arrange 
            var calculadora = new Calculadora();

            //Act
            var resultado = calculadora.Somar(v1, v2);

            //Verifica se o retorno do método é igual ao passado na asserção.

            //Assert
            Assert.Equal(total, resultado);
        }
    }
}
