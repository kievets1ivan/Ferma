using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FermaContext : DbContext
    {

        public FermaContext() 
            : base("Connection") { }

        public DbSet<FermaEntity> FermaEntities { get; set; }

        public override int SaveChanges()
        {

            foreach (var x in ChangeTracker
                .Entries<IDeletable>()
                .Where(e => e.State == EntityState.Deleted))
            {
                x.Entity.IsDelete = true;
                x.State = EntityState.Modified;

            }

            return base.SaveChanges();
        }
    }
}
