using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRMFlavia.Models;
using CRMFlavia.Models.Servico;
using Microsoft.EntityFrameworkCore;

namespace CRMFlavia
{
    public class CRMContext : DbContext
    {
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            //  modelBuilder.Entity<Cliente>().HasKey(t => t.Id);


                
            //modelBuilder.Entity<Produto>().HasKey(t => t.Id);

            //modelBuilder.Entity<Pedido>().HasKey(t => t.Id);
            //modelBuilder.Entity<Pedido>().HasMany(t => t.Itens).WithOne(t => t.Pedido);
            //modelBuilder.Entity<Pedido>().HasOne(t => t.Cadastro).WithOne(t => t.Pedido).IsRequired();

            //modelBuilder.Entity<ItemPedido>().HasKey(t => t.Id);
            //modelBuilder.Entity<ItemPedido>().HasOne(t => t.Pedido);
            //modelBuilder.Entity<ItemPedido>().HasOne(t => t.Produto);

            //modelBuilder.Entity<Cadastro>().HasKey(t => t.Id);
            //modelBuilder.Entity<Cadastro>().HasOne(t => t.Pedido);
        }
       
    }
}
