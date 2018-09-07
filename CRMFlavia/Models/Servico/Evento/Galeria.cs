using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRMFlavia.Models.Servico
{
    public class Galeria : BaseModel
    {
        public Galeria(Evento evento, string descricaoGaleria, DateTime dataCriacao, bool ativa)
        {
            Evento = evento;
            DescricaoGaleria = descricaoGaleria;
            DataCriacao = dataCriacao;
            Ativa = ativa;
        }

        [Required]
        public Evento Evento { get; set; }
        [Required]
        public string DescricaoGaleria { get; set; }
        public DateTime DataCriacao { get; set; }
        public bool Ativa { get; set; }
    }
}
