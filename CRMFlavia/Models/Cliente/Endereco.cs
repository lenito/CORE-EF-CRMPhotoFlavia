using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRMFlavia.Models
{
    public class Endereco : BaseModel
    {
        public Endereco(Cliente cliente, string tipoEndereco, string logradouro, int numero, string complemento, string bairro, string cidade, string estado, string cep)
        {
            Cliente = cliente;
            TipoEndereco = tipoEndereco;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Cep = cep;
        }

        public Cliente Cliente { get; private set; }
        public string TipoEndereco { get; private set; }
        public string Logradouro { get; private set; }
        public int Numero { get; private set; }
        public string Complemento { get; private set; }
        public string Bairro { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
        public string Cep { get; private set; }

    }
}
