using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2.Principios
{
    public class KISS
    {
        //Mantenha o design simples e evite complexidade desnecessária.
        //Imagine que você precisa calcular a área de um círculo. Em vez de criar uma classe complexa, você pode manter o código simples e direto:

        // Código simples para calcular a área de um círculo
        public double CalcularAreaCirculo(double raio)
        {
            return Math.PI * Math.Pow(raio, 2);
        }

        // Código simples para calcular a soma de dois números
        public int Somar(int a, int b)
        {
            return a + b;
        }
    }
}
