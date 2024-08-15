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
    public class BeneficiarioModel
    {
        public long Id { get; set; } = long.MinValue;
        public long IdCliente { get; set; } = long.MinValue;

        /// <summary>
        /// CEP
        /// </summary>
        [Required]
        public string Cpf { get; set; } = string.Empty;

        /// <summary>
        /// CEP
        /// </summary>
        [Required]
        public string Nome { get; set; } = string.Empty;

       

    }    
}