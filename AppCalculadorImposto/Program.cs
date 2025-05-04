using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCalculadorImposto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Exibe o cabeçalho da aplicação
                Console.WriteLine("=================== Calculadora de impostos ===================");

                // Solicita ao usuário o valor do produto
                Console.Write("Digite o valor do produto: ");
                decimal valorProduto = decimal.Parse(Console.ReadLine()); // Lê e converte o valor do produto para decimal

                // Solicita ao usuário o tipo de imposto
                Console.Write("Digite o tipo de imposto (1 - ICMS, 2 - IPI, 3 - PIS/COFINS): ");
                string tipo = Console.ReadLine(); // Lê o tipo de imposto como string

                // Seleciona o tipo de imposto com base na entrada do usuário
                TipoImposto tipoImposto = Helper.selecionarImposto(tipo);

                // Cria uma instância da calculadora de imposto com o tipo de imposto e o valor do produto
                CalculadoraDeImposto calculadoraDeImposto = new CalculadoraDeImposto(tipoImposto, valorProduto);

                // Calcula o valor do imposto devido
                decimal valorImposto = calculadoraDeImposto.calcular();

                // Exibe o valor do imposto devido
                Console.WriteLine("Imposto devido: " + valorImposto);
            }
            catch (FormatException)
            {
                // Trata erros de formato, como entrada inválida para números
                Console.WriteLine("Erro: O valor digitado não está em um formato válido. Por favor, tente novamente.");
            }
            catch (ArgumentException ex)
            {
                // Trata erros de tipo de imposto inválido
                Console.WriteLine("Erro: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Trata quaisquer outros erros não previstos
                Console.WriteLine("Ocorreu um erro inesperado: " + ex.Message);
            }
            finally
            {
                // Aguarda o usuário pressionar uma tecla antes de encerrar o programa
                Console.WriteLine("Pressione qualquer tecla para sair.");
                Console.ReadKey();
            }
        }
    }
}
