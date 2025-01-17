﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FI.AtividadeEntrevista.DML
{
    public class Beneficiario
    {
        public long Id { get; set; } = long.MinValue;
        public long IdCliente { get; set; } = long.MinValue;
        public string Cpf { get; set; } = string.Empty;
        public string Nome { get; set; } = string.Empty;

        public Beneficiario() { }
    }

    public class BeneficiarioFilter
    {
        public long Id { get; set; } = 0;
        public long IdCliente { get; set; } = 0;        
        public string CpfCliente { get; set; } = string.Empty;

        public BeneficiarioFilter() { }
    }
}
