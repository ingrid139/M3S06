using Aula3._2_S;
using Aula3.Exercicios;

namespace Aula3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FullStack Educacional - Aula 3, módulo 3 semana 6!");
            OpenCloseExemple();
            ExerciseOCP();
            Console.ReadKey();
        }

        public static void OpenCloseExemple()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine();
            Console.WriteLine("Exemplo de correção do principio Aberto/Fechado!!");
            var contratoClt = new ContratoClt();
            var folha = new FolhaDePagamento();

            folha.calcular(contratoClt);
            Console.WriteLine();
        }

        public static void ExerciseOCP()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine();
            Console.WriteLine("Exercicio OCP!!");

            var original = new CalculadoraDesconto();
            var valorOriginal = original.CalcularDesconto("VIP", 1500);
            Console.WriteLine($"Valor original: {valorOriginal}");


            Console.WriteLine("************************************");
            Console.WriteLine();
            Console.WriteLine("Correção do exercicio OCP!!");
            var corrigido = new CalculadoraDesconto_();
            var vip = new DescontoVIP();
            var valorCorrigido = corrigido.CalcularDesconto(vip, 1500);
            Console.WriteLine($"Valor corrigido: {valorOriginal}");
        }
    }
}
