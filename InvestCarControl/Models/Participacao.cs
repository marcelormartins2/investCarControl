using System;
using System.Collections.Generic;

namespace InvestCarControl.Models
{
    public partial class Participacao
    {
        public string ParceiroId { get; set; }
        public string VeiculoId { get; set; }
        public int? PorcentagemCompra { get; set; }
        public int? PorcentagemLucro { get; set; }

        public Parceiro Parceiro { get; set; }
        public Veiculo Veiculo { get; set; }
    }
}
