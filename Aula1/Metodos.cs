using Aula1.Metodo;
using System.Linq;

namespace Aula1
{
    public class Metodos
    {
        public Context _context = new();

        // Método que calcula a média de uma lista de números
        public double CalcularMedia(List<int> numeros)
        {
            return numeros.Average();
        }

        // Método que salva um registro no banco de dados
        public void SalvarRegistro(Registro registro)
        {
            _context.Registros.Add(registro);
            _context.SaveChanges();
        }

        // Método que envia um email de confirmação
        public void EnviarEmailConfirmacao(string email)
        {
            // Lógica para enviar email
        }

        // Método que obtém todos os usuários ativos
        public List<Usuario> ObterUsuariosAtivos()
        {
            return _context.Usuarios.Where(u => u.Ativo).ToList();
        }

        // Método que atualiza o status de um pedido
        public void AtualizarStatusPedido(int pedidoId, string novoStatus)
        {
            var pedido = _context.Pedidos.Find(x => x.PedidoId == pedidoId);
            if (pedido != null)
            {
                pedido.Status = novoStatus;
                _context.SaveChanges();
            }
        }

        // Método que deleta um usuário pelo ID
        public void DeletarUsuario(int usuarioId)
        {
            var usuario = _context.Usuarios.Find(x => x.UsuarioId == usuarioId);
            if (usuario != null)
            {
                _context.Usuarios.Remove(usuario);
                _context.SaveChanges();
            }
        }
    }
}
