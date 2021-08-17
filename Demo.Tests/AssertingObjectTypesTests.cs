using Xunit;

namespace Demo.Tests
{
    public class AssertingObjectTypesTests
    {
        [Fact]
        public void FuncionarioFactory_Criar_DeveRetornarTipoFuncionario()
        {
            // Arrange & Act
            var funcionario = FuncionarioFactory.Criar("Leandro", 10000);

            //Verifica o tipo do Objeto na asserção.

            // Assert
            Assert.IsType<Funcionario>(funcionario);
        }

        [Fact]
        public void FuncionarioFactory_Criar_DeveRetornarTipoDerivadoPessoa()
        {
            // Arrange & Act
            var funcionario = FuncionarioFactory.Criar("Leandro", 10000);

            //Verifica se tipo do Objeto possui a assinatura/herança do tipo passado na asserção.

            // Assert
            Assert.IsAssignableFrom<Pessoa>(funcionario);
        }
    }
}