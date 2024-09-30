using Aula2.Refatoracao.Modelo;

namespace Aula2.Refatoracao
{
    public class Condicionais
    {
        public void ProcessarPagamentos(List<Pagamento> pagamentos)
        {
            foreach (var pagamento in pagamentos)
            {
                if (pagamento.Tipo == "CartaoCredito")
                {
                    // Processar pagamento com cartão de crédito
                    Console.WriteLine("Processando pagamento com cartão de crédito...");
                    // Código para processar pagamento com cartão de crédito
                }
                else if (pagamento.Tipo == "Boleto")
                {
                    // Processar pagamento com boleto
                    Console.WriteLine("Processando pagamento com boleto...");
                    // Código para processar pagamento com boleto
                }
                else if (pagamento.Tipo == "Pix")
                {
                    // Processar pagamento com Pix
                    Console.WriteLine("Processando pagamento com Pix...");
                    // Código para processar pagamento com Pix
                }
            }
        }
    }

    public class CondicionaisRefatorado
    {
        public void ProcessarPagamentos(List<Pagamento> pagamentos)
        {
            foreach (var pagamento in pagamentos)
            {
                ProcessarPagamento(pagamento);
            }
        }

        private void ProcessarPagamento(Pagamento pagamento)
        {
            switch (pagamento.Tipo)
            {
                case "CartaoCredito":
                    ProcessarCartaoCredito(pagamento);
                    break;
                case "Boleto":
                    ProcessarBoleto(pagamento);
                    break;
                case "Pix":
                    ProcessarPix(pagamento);
                    break;
                default:
                    throw new ArgumentException("Tipo de pagamento desconhecido");
            }
        }

        private void ProcessarCartaoCredito(Pagamento pagamento)
        {
            Console.WriteLine("Processando pagamento com cartão de crédito...");
            // Código para processar pagamento com cartão de crédito
        }

        private void ProcessarBoleto(Pagamento pagamento)
        {
            Console.WriteLine("Processando pagamento com boleto...");
            // Código para processar pagamento com boleto
        }

        private void ProcessarPix(Pagamento pagamento)
        {
            Console.WriteLine("Processando pagamento com Pix...");
            // Código para processar pagamento com Pix
        }
    }
}
