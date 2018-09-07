using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRMFlavia.Models.Servico
{
    public class Servico : BaseModel
    {
        public Servico(Cliente cliente, DateTime dataPrimeiroContato, string detalhesContato, bool clienteDesistiu)
        {
            Cliente = cliente;
            DataPrimeiroContato = dataPrimeiroContato;
            DetalhesContato = detalhesContato;
            ClienteDesistiu = clienteDesistiu;
        }

        [Required]
        public Cliente Cliente { get; set; }
        [Required]
        public DateTime DataPrimeiroContato { get; set; }
        [Required]
        public string DetalhesContato { get; set; }
        public bool ClienteDesistiu { get; set; }
    }
}
