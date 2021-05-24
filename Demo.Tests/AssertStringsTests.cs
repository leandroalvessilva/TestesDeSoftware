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

            //Assert
            Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", nomeCompleto);
        }
    }
}