using System;

namespace backend.Domain.Queries.Responses {
  public class ListaUsuariosResponse {
    public Guid Id {get; set;} 
    public string Sobrenome {get; set;} 
    public string Nome {get; set;}
    public string Email {get; set;}
    public DateTime DataNascimento {get; set;}
    public Escolaridade Escolaridade {get; set;}
  }
}