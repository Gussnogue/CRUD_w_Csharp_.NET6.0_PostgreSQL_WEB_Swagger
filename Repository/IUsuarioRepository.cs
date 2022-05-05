using usuario.Model;

namespace usuario.Repository
{
    public interface IUsuarioRepository
    {
         Task<IEnumerable<Usuario>> BuscaUsuarios();
         Task<Usuario> BuscaUsuario(int id);
         void AdicionaUsuario(Usuario usuario);
         void AtualizaUsuario(Usuario usuario);
         void DeletaUsuario(Usuario usuario);

         Task<bool> SaveChangesAsync();
    }
}