using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRMFlavia.Models.Servico
{
    public class Evento : BaseModel
    {
        public Evento(Cliente cliente, DateTime dataEvento, TipoServico tipoEvento, string descEvento)
        {
            Cliente = cliente;
            DataEvento = dataEvento;
            TipoEvento = tipoEvento;
            DescEvento = descEvento;
        }

        [Required]
        public Cliente Cliente { get; set; }
        [Required]
        public DateTime DataEvento { get; set; }
        [Required]
        public TipoServico TipoEvento { get; set; }
        public string DescEvento { get; set; }
    }
}
