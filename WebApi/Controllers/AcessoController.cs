using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.DTO;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AcessoController : ControllerBase
    {
        [HttpPost("Logon")]
        public Usuario Logon(UsuarioDto usuarioDto)
        {
            UsuarioRepository  repository = new UsuarioRepository();
            Usuario model = repository.Logon(usuarioDto.Email, usuarioDto.Senha);
            return model;
        }
    }
}
