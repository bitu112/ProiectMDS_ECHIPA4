using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProiectMDS.Model_Fitness;


namespace ProiectMDS.Contexts_Fitness
{
    public class Context:DbContext
    {
        private bool isMigration = true;

        public DbSet<Abonament> Abonamente { get; set; }
        public DbSet<Angajat> Angajati { get; set; }
        public DbSet<Client> Clienti { get; set; }
        public DbSet<ClientAbonament> ClientAbonamente { get; set; }
        public DbSet<ClientSupliment> ClientSuplimente { get; set; }
        public DbSet<Supliment> Suplimente { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (isMigration)
                optionsBuilder.UseSqlServer(@"Server=.\;Database=DBProiectMDS;Trusted_Connection=true;");
        }
        public Context() { }
        public Context(DbContextOptions<Context> options) : base(options) { }
    }
}
