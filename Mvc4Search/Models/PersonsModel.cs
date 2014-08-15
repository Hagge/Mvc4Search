namespace Mvc4Search.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PersonsModel : DbContext
    {
        public PersonsModel()
            : base("name=PersonsModel")
        {
        }

        public virtual DbSet<Person> Person { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
                .Property(e => e.PersonType)
                .IsFixedLength();
        }
    }
}
