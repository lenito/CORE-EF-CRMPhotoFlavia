using CRMFlavia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRMFlavia.Repositories
{
    public interface IClienteRepository
    {
        Task SaveCliente(Cliente cliente);
        Task<IList<Cliente>> GetCliente();
    }
}
