using CRMFlavia.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRMFlavia.Repositories
{
    public class ClienteRepository : BaseRepository<Cliente>, IClienteRepository
    {
        public ClienteRepository(CRMContext contexto) : base(contexto)
        {

        }
        public async Task<IList<Cliente>> GetCliente()
        {
            return await dbSet.ToListAsync();
        }

        public async Task SaveCliente(Cliente cliente)
        {
            await dbSet.AddAsync(new Cliente(cliente.NomeCliente, cliente.CpfCliente,cliente.DataNascimento,cliente.DataCadastro, cliente.Endereco));
            await contexto.SaveChangesAsync();
        }
    }
}
