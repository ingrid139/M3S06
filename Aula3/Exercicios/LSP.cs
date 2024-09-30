
namespace Aula3.Exercicios
{
    public class LSP
    {
        //o código da classe abaixo está violando o principio de Liskov. Reescreva aplicando a correção
    }
    public class Retangulo
    {
        public virtual int Largura { get; set; }
        public virtual int Altura { get; set; }

        public int CalcularArea()
        {
            return Largura * Altura;
        }
    }

    public class Quadrado : Retangulo
    {
        public override int Largura
        {
            set { base.Largura = base.Altura = value; }
        }

        public override int Altura
        {
            set { base.Largura = base.Altura = value; }
        }
    }
}
