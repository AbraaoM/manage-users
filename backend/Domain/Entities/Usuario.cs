using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

public enum Escolaridade {
  Infantil,
  Fundamental,
  Médio,
  Superior
}

namespace backend.Domain.Entities {
  public class ValidaDataMenorHoje : ValidationAttribute {
      protected override ValidationResult IsValid(object value, ValidationContext validationContext) {
          DateTime dt = (DateTime)value;
          if (dt >= DateTime.UtcNow) {
              return ValidationResult.Success;
          }
          return new ValidationResult(ErrorMessage ?? "Data de nascimento inválida! Data deve ser menor ou igual a hoje.");
      }
  }

  public class Usuario {
    public Usuario (string nome, string sobrenome, string email, DateTime dataNascimento, Escolaridade escolaridade) {
      Id = Guid.NewGuid();
      Nome = nome;
      Sobrenome = sobrenome;
      Email = email;
      DataNascimento = dataNascimento;
      Escolaridade = escolaridade;
    }

    [Key]
    public Guid Id {get; set;}
    public string Sobrenome {get; set;} 
    public string Nome {get; set;}
    [EmailAddress]
    public string Email {get; set;}

    [ValidaDataMenorHoje]
    public DateTime DataNascimento {get; set;}
    public Escolaridade Escolaridade {get; set;}
  }
}
