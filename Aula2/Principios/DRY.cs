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

        //DEPOIS
        //Com essa abordagem, você pode calcular a área de diferentes formas chamando a mesma função:
        double areaCirculo = CalcularArea(TipoForma.Circulo, 5);
        double areaRetangulo = CalcularArea(TipoForma.Retangulo, 4, 6);
        double areaTriangulo = CalcularArea(TipoForma.Triangulo, 3, 7);

        public static double CalcularArea(TipoForma tipo, params double[] parametros)
        {
            switch (tipo)
            {
                case TipoForma.Circulo:
                    return Math.PI * Math.Pow(parametros[0], 2);
                case TipoForma.Retangulo:
                    return parametros[0] * parametros[1];
                case TipoForma.Triangulo:
                    return parametros[0] * parametros[1] / 2;
                default:
                    throw new ArgumentException("Tipo de forma desconhecido");
            }
        }
    }

    public enum TipoForma
    {
        Circulo,
        Retangulo,
        Triangulo
    }
}
