using Xunit;

namespace Demo.Tests
{
    public class AssertStringsTests
    {
        [Fact]
        public void StringsTools_UnirNomes_RetornarNomeCompleto()
        {
            //Arrange
            var sut = new StringTools();

            //Act
            var nomeCompleto = sut.Unir("Leandro", "Alves");

            // Verifica se a string retornada do método é igual a passada na asserção considera camelCase.

            //Assert
            Assert.Equal("Leandro Alves", nomeCompleto);
        }

        [Fact]
        public void StringTools_UnirNomes_DeveIgnorarCase()
        {
            //Arrange
            var sut = new StringTools();

            //Act
            var nomeCompleto = sut.Unir("Leandro", "Alves");

            // Verifica se a string retornada do método é igual a passada na asserção ignorando camelCase.

            //Assert
            Assert.Equal("LEANDRO ALVES", nomeCompleto, true);
        }

        [Fact]
        public void StringTools_UnirNomes_DeveConterTrecho()
        {
            //Arrange
            var sut = new StringTools();

            //Act
            var nomeCompleto = sut.Unir("Leandro", "Alves");

            //Verifica na string se contém a condição passada.

            //Assert
            Assert.Contains("andro", nomeCompleto);
        }

        [Fact]
        public void StringTools_UnirNomes_DeveComecarCom()
        {
            //Arrange
            var sut = new StringTools();

            //Act
            var nomeCompleto = sut.Unir("Leandro", "Alves");

            //Verifica na string se começa com a condição passada.

            //Assert
            Assert.StartsWith("Lea", nomeCompleto);
        }

        [Fact]
        public void StringTools_UnirNomes_DeveAcabarCom()
        {
            //Arrange
            var sut = new StringTools();

            //Act
            var nomeCompleto = sut.Unir("Leandro", "Alves");

            //Verifica na string se termina com a condição passada.

            //Assert
            Assert.EndsWith("ves", nomeCompleto);
        }

        [Fact]
        public void StringTools_UnirNomes_ValidarExpressaoRegular()
        {
            //Arrange
            var sut = new StringTools();

            //Act
            var nomeCompleto = sut.Unir("Leandro", "Alves");

            //Verifica se a string bate com o regex passado.

            //Assert
            Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", nomeCompleto);
        }
    }
}