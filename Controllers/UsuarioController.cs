using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using usuario.Model;
using usuario.Repository;

namespace usuario.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        
        private readonly IUsuarioRepository _repository;

        public UsuarioController(IUsuarioRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var usuarios = await _repository.BuscaUsuarios();
            return usuarios.Any()
                     ? Ok(usuarios)
                     : NoContent();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetbyId(int id)
        {
            var usuario = await _repository.BuscaUsuario(id);
            return usuario != null
                     ? Ok(usuario)
                     : NotFound("Usuário não encontrado");
        }

        [HttpPost]
        public async Task<IActionResult> Post(Usuario usuario)
        {
            _repository.AdicionaUsuario(usuario);
            return await _repository.SaveChangesAsync()
                    ? Ok("Usuário Adicionado com sucesso")
                    : BadRequest("Erro ao salvar o usuário");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Usuario usuario)
        {
            var usuarioBanco = await _repository.BuscaUsuario(id);
            if (usuarioBanco == null) return NotFound("Usuário não encontrado");

            usuarioBanco.Nome = usuario.Nome ?? usuarioBanco.Nome;
            usuarioBanco.DataNascimento = usuario.DataNascimento != new DateTime()
            ? usuario.DataNascimento : usuarioBanco.DataNascimento;

            _repository.AtualizaUsuario(usuarioBanco);

            return await _repository.SaveChangesAsync()
                    ? Ok("Usuário Atualizado com sucesso")
                    : BadRequest("Erro ao salvar o usuário");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var usuarioBanco = await _repository.BuscaUsuario(id);
            if (usuarioBanco == null) return NotFound("Usuário não encontrado");

            _repository.DeletaUsuario(usuarioBanco);

            return await _repository.SaveChangesAsync()
                    ? Ok("Usuário Deletado com sucesso")
                    : BadRequest("Erro ao deletar o usuário");


        }


    }
}