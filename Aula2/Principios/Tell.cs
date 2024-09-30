using Aula1.Metodo;

namespace Aula2.Principios
{
    public class Tell
    {
        //Diga aos objetos o que fazer, em vez de perguntar sobre seu estado e tomar decisões.

        public void Comprar()
        {
            // Uso do método
            Pedido pedido = new();
            pedido.Processar();
        }
    }
}
