using FI.AtividadeEntrevista.DML;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAtividadeEntrevista.Models
{
    /// <summary>
    /// Classe de Modelo de Cliente
    /// </summary>
    public class BeneficiarioModelDto
    {
        public long Id { get; set; } = long.MinValue;
        public long IdCliente { get; set; } = long.MinValue;

        /// <summary>
        /// CEP
        /// </summary>
        [Required]
        public string CpfBeneficiario { get; set; } = string.Empty;

        /// <summary>
        /// CEP
        /// </summary>
        [Required]
        public string Nome { get; set; } = string.Empty;

       

    }   

    public class BeneficiarioModel
    {
        public long Id { get; set; } = long.MinValue;
        public long IdCliente { get; set; } = long.MinValue;
        public string Cpf { get; set; } = string.Empty;        
        public string Nome { get; set; } = string.Empty;

        public BeneficiarioModel(BeneficiarioModelDto dto)
        {
            this.Cpf = dto.CpfBeneficiario.Replace(".", "").Replace("-", "");
            this.IdCliente = dto.IdCliente;
            this.Nome = dto.Nome;
            this.Id = dto.Id;
        }
    }
    
    public class BeneficiarioFiltro
    {
        public long Id { get; set; }= long.MinValue;    
        public long IdCliente { get; set; }= long.MinValue; 
        public string Cpf { get; set; }  = string.Empty;
       

       

    }


}