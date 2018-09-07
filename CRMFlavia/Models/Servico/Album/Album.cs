using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRMFlavia.Models.Servico
{
    public class Album : BaseModel
    {
        public Album(Cliente cliente, Evento evento, bool finalizado, DateTime dataFinalizado)
        {
            Cliente = cliente;
            Evento = evento;
            Finalizado = finalizado;
            DataFinalizado = dataFinalizado;
        }

        [Required]
        public Cliente Cliente { get; set; }
        [Required]
        public Evento Evento { get; set; }
        public bool Finalizado { get; set; }
        public DateTime DataFinalizado { get; set; }


        //responsavelProjeto
        //userAlteracao
        //dataAlteracao

    }
}
