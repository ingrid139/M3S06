using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2.Principios
{
    public class YAGNI
    {
        // Código que implementa apenas a funcionalidade necessária
        public class Cliente
        {
            public string Nome { get; set; }
            public string Email { get; set; }

            // Método necessário para validar o email
            public bool ValidarEmail()
            {
                return Email.Contains("@");
            }
        }

        //ANTES
        public class Calculadora
        {
            public double Somar(double a, double b)
            {
                return a + b;
            }

            public double Subtrair(double a, double b)
            {
                return a - b;
            }

            public double Multiplicar(double a, double b)
            {
                return a * b;
            }

            public double Dividir(double a, double b)
            {
                return a / b;
            }

            // Método adicional que não é necessário no momento
            public double CalcularRaizQuadrada(double a)
            {
                return Math.Sqrt(a);
            }
        }

        //DEPOIS
        /*No exemplo “Antes”, o método CalcularRaizQuadrada foi adicionado, mas não é necessário no momento. Seguindo o princípio YAGNI, removemos esse método no exemplo “Depois”, mantendo apenas as funcionalidades que são realmente necessárias*/
        public class Calculadora_
        {
            public double Somar(double a, double b)
            {
                return a + b;
            }

            public double Subtrair(double a, double b)
            {
                return a - b;
            }

            public double Multiplicar(double a, double b)
            {
                return a * b;
            }

            public double Dividir(double a, double b)
            {
                return a / b;
            }
        }
    }
}
