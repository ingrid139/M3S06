
namespace Aula1
{
    public class MetodosEfeitosColaterais
    {
    }

    //Antes
    public class Circulo
    {
        public double Raio { get; set; }
        public double Area { get; set; }

        public void CalcularArea()
        {
            Area = Math.PI * Math.Pow(Raio, 2);
        }
    }

    //Depois
    public class CirculoDepois
    {
        public double Raio { get; set; }

        public double CalcularArea()
        {
            return Math.PI * Math.Pow(Raio, 2);
        }
    }
}
