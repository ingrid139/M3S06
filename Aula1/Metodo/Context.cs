

namespace Aula1.Metodo
{
    public class Context
    {
        public List<Registro> Registros;
        public List<Usuario> Usuarios { get; internal set; }
        public List<Pedido> Pedidos { get; internal set; }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}