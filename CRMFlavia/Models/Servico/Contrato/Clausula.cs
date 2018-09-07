
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRMFlavia.Models.Servico
{
    public class Clausula : BaseModel
    {
        public Clausula(Contrato contrato, string clausulaContratual, bool ativa, DateTime dataAdicao, DateTime dataSuspensao)
        {
            Contrato = contrato;
            ClausulaContratual = clausulaContratual;
            Ativa = ativa;
            DataAdicao = dataAdicao;
            DataSuspensao = dataSuspensao;
        }

        [Required]
        public Contrato Contrato { get; set; }
        [Required]
        public String ClausulaContratual { get; set; }
        public Boolean Ativa { get; set; }
        public DateTime DataAdicao { get; set; }
        public DateTime DataSuspensao { get; set; }
        //classe usuario que suspendeu
    }
}
