using FixtureProject.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixtureProject.Contexts
{
    public class FixtureContext : DbContext
    {
        public FixtureContext() : base("AccessContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
        public DbSet<Fixture> Fixtures { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //主键
            modelBuilder.Entity<Fixture>().HasKey(m => new {m.Id,m.SerialNo});
            //默认值
            base.OnModelCreating(modelBuilder);
        }
    }
}
