using Microsoft.EntityFrameworkCore;
using Rehber.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rehber.API.Data.Concrate
{
    public class Context : DbContext
    {
        public Context()
        {

        }
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=AnilDb;trusted_connection=true");

        }
        
        public DbSet<Kullanici> KULLANICILAR { get; set; }

    }
}
