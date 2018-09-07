using CRMFlavia.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRMFlavia.Repositories
{
    public abstract class BaseRepository<T> where T : BaseModel
    {
        protected readonly CRMContext contexto;
        protected readonly DbSet<T> dbSet;

        public BaseRepository(CRMContext contexto)
        {
            this.contexto = contexto;
            dbSet = contexto.Set<T>();
        }


    }
}
