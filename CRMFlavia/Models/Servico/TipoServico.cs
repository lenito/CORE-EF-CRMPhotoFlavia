using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRMFlavia.Models.Servico
{
    public class TipoServico : BaseModel
    {
        public TipoServico(Servico servico, string nomeTipoServico, string descricaoServico, bool ativo)
        {
            Servico = servico;
            NomeTipoServico = nomeTipoServico;
            DescricaoServico = descricaoServico;
            Ativo = ativo;
        }

        [Required]
        public Servico Servico { get; set; }
        [Required]
        public string NomeTipoServico { get; set; }
        [Required]
        public string DescricaoServico { get; set; }
        public bool Ativo { get; set; }

    }
}
