using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Teste_Estágio.Models;

namespace Teste_Estágio.Context
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }

        public DbSet<SuppliersModel> Supplier { get; set; }
        public DbSet<MaterialsModel> Material { get; set; }

       
    }

   
}
