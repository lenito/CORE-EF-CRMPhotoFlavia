using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRMFlavia.Models.Servico
{
    public class Parcela : BaseModel
    {
        public Parcela(Pagamento pagamento, double vlParcela, string moeda, DateTime dataLiquidacao, bool liquidado)
        {
            Pagamento = pagamento;
            VlParcela = vlParcela;
            Moeda = moeda;
            DataLiquidacao = dataLiquidacao;
            Liquidado = liquidado;
        }

        [Required]
        public Pagamento Pagamento { get; set; }
        [Required]
        public double VlParcela { get; set; }
        [Required]
        public string Moeda { get; set; }

        public DateTime DataLiquidacao { get; set; }
        public bool Liquidado { get; set; }

        //userAlteracao
        //dataAlteracao

    }
}
