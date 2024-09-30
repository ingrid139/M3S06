
using Aula1;

namespace Aula2.Refatoracao
{
    public class Extracao
    {
        //Situação: Um trecho de código que apresenta uma funcionalidade específica.
        //Solução: Transformar esse fragmento num método com nome explicativo.
        
        private string _name = "Nome do Cliente"; 
        
        //antes
        public void PrintOwing()
        {
            PrintBanner();
            //print details
            Console.WriteLine("name: " + _name);
            Console.WriteLine("amount: " + GetOutstanding());
        }

        //depois
        public void PrintOwingRefact()
        {
            PrintBanner();
            PrintDetails();
        }

        public void PrintDetails()
        {
            //print details
            Console.WriteLine("name: " + _name);
            Console.WriteLine("amount: " + GetOutstanding());
        }

        public void PrintBanner()
        {
            Console.WriteLine("*************************");
            Console.WriteLine("***** Customer Owes *****");
            Console.WriteLine("*************************");
        }

        public double GetOutstanding()
        {
            return 123.45; // Valor de exemplo
        }
    }
}
