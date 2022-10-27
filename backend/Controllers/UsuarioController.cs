using Microsoft.AspNetCore.Mvc;
using backend.Domain.Handlers;
using backend.Domain.Command.Requests;

namespace backend.Controllers {
  [ApiController]
  [Route("Usuarios")]

  public class UsuarioController : ControllerBase { 
    [HttpPost]
    [Route("CriaUsuario")]
    public IActionResult CriaUsuario(
      [FromServices] ICriaUsuarioHandler handler,
      [FromBody] CriaUsuarioRequest command) {
        var response =  handler.Handle(command);
        return Ok(response);
    }

    [HttpGet]
    [Route("ListaUsuarios")]
    public IActionResult ListaUsuarios(
      [FromServices] IListaUsuariosHandler handler
    ){
      var response = handler.Handle();
      return Ok(response);
    }

    [HttpPatch]
    [Route("AtualizaUsuario")]
    public IActionResult AtualizaUsuario(
      [FromServices] IListaUsuariosHandler handler
    ){
      var response = handler.Handle();
      return Ok(response);
    }    
  }
}