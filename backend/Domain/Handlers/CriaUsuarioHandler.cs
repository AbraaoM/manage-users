using System;
using backend.Domain;
using backend.Domain.Command.Responses;
using backend.Domain.Command.Requests;
using backend.Domain.Entities;
using backend.Domain.Repositories;

namespace backend.Domain.Handlers {
  public class CriaUsuarioHandler {
    IUsuarioRepository _repository;

    public CriaUsuarioHandler (IUsuarioRepository repository) {
      repository = _repository;
    }

    public CriaUsuarioResponse Handle(CriaUsuarioRequest command) {
      var usuario = new Usuario(command.Nome, command.Sobrenome, command.Email, command.DataNascimento, command.Escolaridade);

      _repository.Add(usuario);

      _repository.SaveChanges();

      return new CriaUsuarioResponse {
        Id = usuario.Id,
        Nome = usuario.Nome,
        Sobrenome = usuario.Sobrenome,
        Email = usuario.Email,
        DataNascimento = usuario.DataNascimento,
        Escolaridade = usuario.Escolaridade
      };
    }

  }
}