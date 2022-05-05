using usuario.Model;
using usuario.Data;
using Microsoft.EntityFrameworkCore;

namespace usuario.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly UsuarioContext _context;

        public UsuarioRepository(UsuarioContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Usuario>> BuscaUsuarios()
        {
            return await _context.Usuarios.ToListAsync();
        }
        public async Task<Usuario> BuscaUsuario(int id)
        {
            return await _context.Usuarios.
                        Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public void AdicionaUsuario(Usuario usuario)
        {
            _context.Add(usuario);
        }

        public void AtualizaUsuario(Usuario usuario)
        {
            _context.Update(usuario);
        }



        public void DeletaUsuario(Usuario usuario)
        {
            _context.Remove(usuario);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}