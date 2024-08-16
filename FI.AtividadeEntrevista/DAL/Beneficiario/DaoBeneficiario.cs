using FI.AtividadeEntrevista.DML;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace FI.AtividadeEntrevista.DAL
{
    /// <summary>
    /// Classe de acesso a dados de Cliente
    /// </summary>
    internal class DaoBeneficiario : AcessoDados
    {
        /// <summary>
        /// Inclui um novo cliente
        /// </summary>
        /// <param name="cliente">Objeto de cliente</param>
        public long Incluir(DML.Beneficiario beneficiario)
        {
           
            List<System.Data.SqlClient.SqlParameter> parametros = new List<System.Data.SqlClient.SqlParameter>()
            {
                new System.Data.SqlClient.SqlParameter("Nome", beneficiario.Nome),               
                new System.Data.SqlClient.SqlParameter("Cpf", beneficiario.Cpf),               
                new System.Data.SqlClient.SqlParameter("idCliente", beneficiario.IdCliente),
                
            };

            DataSet ds = base.Consultar("FI_SP_IncBeneficiario", parametros);
            long ret = 0;
            if (ds.Tables[0].Rows.Count > 0)
                long.TryParse(ds.Tables[0].Rows[0][0].ToString(), out ret);
            return ret;
        }

        public List<Beneficiario> Listar(DML.BeneficiarioFilter filter)
        {

            List<System.Data.SqlClient.SqlParameter> parametros = new List<System.Data.SqlClient.SqlParameter>()
            {
                new System.Data.SqlClient.SqlParameter("id", filter.Id),              
                new System.Data.SqlClient.SqlParameter("idCliente", filter.IdCliente),

            };

            DataSet ds = base.Consultar("FI_SP_ConsBeneficiario", parametros);

            
            List<DML.Beneficiario> grid = new List<DML.Beneficiario>();

            
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    
                    DML.Beneficiario beneficiario = new DML.Beneficiario
                    {
                        Id = Convert.ToInt64(row["Id"]),
                        IdCliente = Convert.ToInt64(row["IDCLIENTE"]),
                        Nome = row["NOME"].ToString(),
                        Cpf = row["CPF"].ToString(),                       
                    };
                    grid.Add(beneficiario);
                }
            }
            return grid;
        }

    }
}
