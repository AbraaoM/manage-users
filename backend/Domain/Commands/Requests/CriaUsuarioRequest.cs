using System;

namespace backend.Domain.Command.Requests {
  public class CriaUsuarioRequest {
    public string Sobrenome {get; set;} 
    public string Nome {get; set;}
    public string Email {get; set;}
    public DateTime DataNascimento {get; set;}
    public Escolaridade Escolaridade {get; set;}
  }
}