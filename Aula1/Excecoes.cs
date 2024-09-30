using Microsoft.Extensions.Logging;

namespace Aula1
{
    public class Excecoes
    {
        private readonly ILogger _logger;

        public Excecoes()
        {
            _logger = new Logger();
        }
        public void ProcessData(int value)
        {
            if (value < 0)
            {
                throw new CustomException("O valor não pode ser negativo.");
            }
        }

        public void ProcessDataLog(int value)
        {
            try
            {
                if (value < 0)
                {
                    _logger.LogError("O valor não pode ser negativo.");
                    throw new CustomException("O valor não pode ser negativo.");
                }
            }
            catch (CustomException ex)
            {
                // Tratamento específico para CustomException
                _logger.LogError("Erro específico: ", ex);
                Console.WriteLine($"Erro específico: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Tratamento genérico para outras exceções
                _logger.LogError("Erro inesperado: ", ex);
                Console.WriteLine($"Erro inesperado: {ex.Message}");
            }
            finally
            {
                // Código que sempre será executado, independentemente de uma exceção ter sido lançada ou não
                _logger.LogInformation("Processamento concluído.");
                Console.WriteLine("Processamento concluído.");
            }
        }
    }

    public class CustomException : Exception
    {
        public CustomException(string message) : base(message) { }
    }
}
