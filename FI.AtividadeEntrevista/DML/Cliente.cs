namespace FI.AtividadeEntrevista.DML
{
    /// <summary>
    /// Classe de cliente que representa o registo na tabela Cliente do Banco de Dados
    /// </summary>
    public class Cliente
    {
        /// <summary>
        /// Id
        /// </summary>
        public long Id { get; set; } = long.MinValue;

        /// <summary>
        /// CEP
        /// </summary>
        /// </summary>
        public string Cep { get; set; } = string.Empty;

        public string Cpf { get; set; } = string.Empty;

        /// <summary>
        /// Cidade
        /// </summary>
        public string Cidade { get; set; } = string.Empty;

        /// <summary>
        /// E-mail
        /// </summary>
        public string Email { get; set; } = string.Empty;

        /// <summary>
        /// Estado
        /// </summary>
        public string Estado { get; set; } = string.Empty;

        /// <summary>
        /// Logradouro
        /// </summary>
        public string Logradouro { get; set; } = string.Empty;

        /// <summary>
        /// Nacionalidade
        /// </summary>
        public string Nacionalidade { get; set; } = string.Empty;

        /// <summary>
        /// Nome
        /// </summary>
        public string Nome { get; set; } = string.Empty;

        /// <summary>
        /// Sobrenome
        /// </summary>
        public string Sobrenome { get; set; }

        /// <summary>
        /// Telefone
        /// </summary>
        public string Telefone { get; set; }
    }
}
