namespace Aula2.Principios
{
    public class DRY
    {
        //Evite duplicação de código, abstraindo partes comuns em um único local.
        //Suponha que você precise calcular a área de diferentes formas geométricas. Em vez de duplicar o código para cada forma, você pode criar métodos reutilizáveis:
        public static double CalcularAreaCirculo(double raio)
        {
            return Math.PI * Math.Pow(raio, 2);
        }

        public static double CalcularAreaRetangulo(double largura, double altura)
        {
            return largura * altura;
        }

        public static double CalcularAreaTriangulo(double baseTriangulo, double altura)
        {
            return baseTriangulo * altura / 2;
        }
    }
}
