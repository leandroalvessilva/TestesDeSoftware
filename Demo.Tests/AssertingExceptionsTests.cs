using System;
using Xunit;

namespace Demo.Tests
{
    public class AssertingExceptionsTests
    {
        [Fact]
        public void Calculadora_Dividir_DeveRetornarErroDivisaoPorZero()

        {
            // Arrange
            var calculadora = new Calculadora();

            // Verificar se uma exception específica é retornado do método.

            //Act & Assert
            Assert.Throws<DivideByZeroException>(() => calculadora.Dividir(10, 0));
        }

        [Fact]
        public void Funcionario_Salario_DeveRetornarErroSalarioInferiorPermitido()

        {
            // Arrange & Act & Assert

            // Verificar se uma exception genérica é retornado do método.

            var exception = Assert.Throws<Exception>(() => FuncionarioFactory.Criar("Leandro", 250));

            Assert.Equal("Salario inferior ao permitido.", exception.Message);
        }
    }
}