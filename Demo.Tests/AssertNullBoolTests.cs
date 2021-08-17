using Xunit;

namespace Demo.Tests
{
    public class AssertNullBoolTests
    {
        [Fact]
        public void Funcionario_Nome_NaoDeveSerNuloOuVazio()
        {
            //Arrange & Act
            var funcionario = new Funcionario("", 1000);

            //Validação de nulidade retornando true or false

            //Assert
            Assert.False(string.IsNullOrEmpty(funcionario.Nome));
        }

        [Fact]
        public void Funcionario_Apelido_NaoDeveTerApelido()
        {
            //Arrange & Act
            var funcionario = new Funcionario("Leandro", 1000);

            //Assert
            Assert.NotNull(funcionario.Nome);

            //Validação de nulidade e validação de tamanho para retornar true or false

            //Assert Bool
            Assert.True(string.IsNullOrEmpty(funcionario.Apelido));
            Assert.False(funcionario.Apelido?.Length > 0);
        }
    }
}