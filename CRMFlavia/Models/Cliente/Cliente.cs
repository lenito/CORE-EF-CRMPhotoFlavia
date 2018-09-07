using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRMFlavia.Models
{
    public class Cliente : BaseModel
    {
        public Cliente(string nomeCliente, string cpfCliente, DateTime dataNascimento, DateTime dataCadastro, Endereco endereco)
        {
            NomeCliente = nomeCliente;
            CpfCliente = cpfCliente;
            DataNascimento = dataNascimento;
            DataCadastro = dataCadastro;
            Endereco = endereco;
        }

        [Required]
        public string NomeCliente { get; private set; }
        [Required]
        public string CpfCliente { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public Endereco Endereco { get; private set; }


    }
}
