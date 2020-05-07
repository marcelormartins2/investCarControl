using System;
using System.Collections.Generic;

namespace InvestCarControl.Models
{
    public partial class Responsavel
    {
        public int DespesaId { get; set; }
        public string ParceiroId { get; set; }
        public int? Porcentagem { get; set; }

        public Despesa Despesa { get; set; }
        public Parceiro Parceiro { get; set; }
    }
}
