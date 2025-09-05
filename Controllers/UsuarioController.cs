using Microsoft.AspNetCore.Mvc;
using GerenciamentoAtividadesApi.Models;
using GerenciamentoAtividadesApi.Repositorios.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GerenciamentoAtividadesApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public UsuarioController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<Usuario>>> GetUsuarios()
        {
            var usuarios = await _usuarioRepositorio.BuscarTodosUsuarios();
            return Ok(usuarios);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Usuario>> GetUsuario(int id)
        {
            var usuario = await _usuarioRepositorio.BuscarPorId(id);
            if (usuario == null) return NotFound();
            return Ok(usuario);
        }

        [HttpPost]
        public async Task<ActionResult<Usuario>> AddUsuario([FromBody] Usuario usuario)
        {
            var novoUsuario = await _usuarioRepositorio.Adicionar(usuario);
            return Ok(novoUsuario);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Usuario>> AtualizarUsuario(int id, [FromBody] Usuario usuario)
        {
            var usuarioAtualizado = await _usuarioRepositorio.Atualizar(usuario, id);
            return Ok(usuarioAtualizado);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> ApagarUsuario(int id)
        {
            await _usuarioRepositorio.Apagar(id);
            return Ok(new { mensagem = "Usuário apagado com sucesso" });
        }
    }
}
