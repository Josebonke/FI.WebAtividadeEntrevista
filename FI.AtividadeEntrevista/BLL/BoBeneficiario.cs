using FI.AtividadeEntrevista.DML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FI.AtividadeEntrevista.BLL
{
    public class BoBeneficiario
    {
        DAL.DaoBeneficiario beneDal = new DAL.DaoBeneficiario();
        /// <summary>
        /// Inclui um novo cliente
        /// </summary>
        /// <param name="beneficiario">Objeto de cliente</param>
        public long Incluir(DML.Beneficiario beneficiario)
        {           
            return this.beneDal.Incluir(beneficiario);
        }

        public List<DML.Beneficiario> Listar(DML.BeneficiarioFilter beneficiario)
        {
            return this.beneDal.Listar(beneficiario);
        }

    }
        
}
