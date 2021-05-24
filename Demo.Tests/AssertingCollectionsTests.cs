using Xunit;

namespace Demo.Tests
{
    public class AssertingCollectionsTests
    {
        [Fact]
        public void Funcionario_Habilidades_NaoDevePossuirHabilidadesVazias()
        {
            // Arranger & Act
            var funcionario = FuncionarioFactory.Criar("Leandro", 10000);

            // Assert
            Assert.All(funcionario.Habilidades, habilidade => Assert.False(string.IsNullOrEmpty(habilidade)));
        }

        [Fact]
        public void Funcionario_Habilidades_JuniorDevePossuiHabilidadeBasica()
        {
            // Arranger & Act
            var funcionario = FuncionarioFactory.Criar("Leandro", 1000);

            // Assert
            Assert.Contains("OOP", funcionario.Habilidades);
        }

        [Fact]
        public void Funcionario_Habilidades_JuniorNaoDevePossuiHabilidadeAvancada()
        {
            // Arranger & Act
            var funcionario = FuncionarioFactory.Criar("Leandro", 1000);

            // Assert
            Assert.DoesNotContain("Microservices", funcionario.Habilidades);
        }

        [Fact]
        public void Funcionario_Habilidades_SeniorDevePossuirTodasHabilidades()
        {
            // Arranger & Act
            var funcionario = FuncionarioFactory.Criar("Leandro", 15000);

            var habilidadesBasicas = new[]
            {
                "Lógica de Programação",
                "OOP",
                "Testes",
                "Microservices"
            };

            // Assert
            Assert.Equal(habilidadesBasicas, funcionario.Habilidades);
        }
    }
}