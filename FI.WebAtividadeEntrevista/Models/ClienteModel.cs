﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
namespace WebAtividadeEntrevista.Models
{
    /// <summary>
    /// Classe de Modelo de Cliente
    /// </summary>
    public class ClienteModelDTO
    {
        public long Id { get; set; } = long.MinValue;

        /// <summary>
        /// CEP
        /// </summary>
        [Required]
        public string CEP { get; set; } = string.Empty;

        /// <summary>
        /// CEP
        /// </summary>
        [Required]
        public string Cpf { get; set; } = string.Empty;

        /// <summary>
        /// Cidade
        /// </summary>
        [Required]
        public string Cidade { get; set; } = string.Empty;

        /// <summary>
        /// E-mail
        /// </summary>
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Digite um e-mail válido")]
        public string Email { get; set; } = string.Empty;

        /// <summary>
        /// Estado
        /// </summary>
        [Required]
        [MaxLength(2)]
        public string Estado { get; set; } = string.Empty;

        /// <summary>
        /// Logradouro
        /// </summary>
        [Required]
        public string Logradouro { get; set; } = string.Empty;

        /// <summary>
        /// Nacionalidade
        /// </summary>
        [Required]
        public string Nacionalidade { get; set; } = string.Empty;

        /// <summary>
        /// Nome
        /// </summary>
        [Required]
        public string Nome { get; set; } = string.Empty;

        /// <summary>
        /// Sobrenome
        /// </summary>
        [Required]
        public string Sobrenome { get; set; } = string.Empty;

        /// <summary>
        /// Telefone
        /// </summary>
        public string Telefone { get; set; } = string.Empty;

    }    


    public class ClienteModel
    {
        public long Id { get; set; } = long.MinValue;

        /// <summary>
        /// CEP
        /// </summary>
        [Required]
        public string CEP { get; set; } = string.Empty;

        /// <summary>
        /// CEP
        /// </summary>
        [Required]
        public string Cpf { get; set; } = string.Empty;

        /// <summary>
        /// Cidade
        /// </summary>
        [Required]
        public string Cidade { get; set; } = string.Empty;

        /// <summary>
        /// E-mail
        /// </summary>
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Digite um e-mail válido")]
        public string Email { get; set; } = string.Empty;

        /// <summary>
        /// Estado
        /// </summary>
        [Required]
        [MaxLength(2)]
        public string Estado { get; set; } = string.Empty;

        /// <summary>
        /// Logradouro
        /// </summary>
        [Required]
        public string Logradouro { get; set; } = string.Empty;

        /// <summary>
        /// Nacionalidade
        /// </summary>
        [Required]
        public string Nacionalidade { get; set; } = string.Empty;

        /// <summary>
        /// Nome
        /// </summary>
        [Required]
        public string Nome { get; set; } = string.Empty;

        /// <summary>
        /// Sobrenome
        /// </summary>
        [Required]
        public string Sobrenome { get; set; } = string.Empty;

        /// <summary>
        /// Telefone
        /// </summary>
        public string Telefone { get; set; } = string.Empty;

        public ClienteModel() { }
        public ClienteModel(ClienteModelDTO dto)
        {
            this.Id = dto.Id;
            this.CEP = dto.CEP;
            this.Cpf = dto.Cpf.Replace(".", "").Replace("-", "");
            this.Nome = dto.Nome;
            this.Sobrenome = dto.Sobrenome;
            this.Nacionalidade = dto.Nacionalidade;
            this.CEP = dto.CEP.Replace("-", "");
            this.Estado = dto.Estado;
            this.Cidade = dto.Cidade;
            this.Logradouro = dto.Logradouro;
            this.Telefone = dto.Telefone;
            this.Email = dto.Email;

        }
    }
}