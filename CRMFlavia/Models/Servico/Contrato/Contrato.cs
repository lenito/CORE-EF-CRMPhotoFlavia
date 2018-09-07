using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRMFlavia.Models.Servico
{
    public class Contrato : BaseModel
    {
        public Contrato(Servico servico, bool rascunho, bool ativo, DateTime ultimaAlteracao)
        {
            Servico = servico;
            Rascunho = rascunho;
            Ativo = ativo;
            UltimaAlteracao = ultimaAlteracao;
        }

        [Required]
        public Servico Servico { get; set; }
        public bool Rascunho { get; set; }
        public bool Ativo { get; set; }
        public DateTime UltimaAlteracao { get; set; }
    }
}
