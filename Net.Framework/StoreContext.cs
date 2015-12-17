using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Net.Framework.Models;

namespace Net.Framework
{
    public class StoreContext : DbContext
    {
        public DbSet<MemberT> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<IncludeMetadataConvention>();
        }
    }
}