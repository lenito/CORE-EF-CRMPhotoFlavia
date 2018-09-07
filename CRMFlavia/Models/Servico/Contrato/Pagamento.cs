using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRMFlavia.Models.Servico
{
    public class Pagamento : BaseModel
    {
        public Pagamento(Contrato contrato, double vlTotal, double vlDesconto, double vlEntrada, string moeda, bool liquidado, bool parcelado)
        {
            Contrato = contrato;
            VlTotal = vlTotal;
            VlDesconto = vlDesconto;
            VlEntrada = vlEntrada;
            Moeda = moeda;
            Liquidado = liquidado;
            Parcelado = parcelado;
        }

        [Required]
        public Contrato Contrato { get; set; }
        [Required]
        public double VlTotal { get; set; }
        public double VlDesconto { get; set; }
        public double VlEntrada { get; set; }
        [Required]
        public string Moeda { get; set; }
        public bool Liquidado { get; set; }
        public bool Parcelado { get; set; }

        //responsavelFinanceiro
        //userAlteracao
        //dataAlteracao
    }
}
