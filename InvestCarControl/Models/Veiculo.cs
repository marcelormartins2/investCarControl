using System;
using System.Collections.Generic;

namespace InvestCarControl.Models
{
    public partial class Veiculo
    {
        public Veiculo()
        {
            Participacao = new HashSet<Participacao>();
        }

        public string Id { get; set; }
        public string Placa { get; set; }
        public string Chassis { get; set; }
        public string Cor { get; set; }
        public string Dut { get; set; }
        public int? AnoModelo { get; set; }
        public int DespesaId { get; set; }
        public int ModeloCarId { get; set; }

        public Despesa Despesa { get; set; }
        public Modelocar ModeloCar { get; set; }
        public ICollection<Participacao> Participacao { get; set; }
    }
}
