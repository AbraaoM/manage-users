using System;

namespace backend.Domain.Command.Responses {
  public class CriaUsuarioResponse {
    public Guid Id {get; set;} 
    public string Sobrenome {get; set;} 
    public string Nome {get; set;}
    public string Email {get; set;}
    public DateTime DataNascimento {get; set;}
    public Escolaridade Escolaridade {get; set;}
  }
}