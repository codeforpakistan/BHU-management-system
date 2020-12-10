namespace MaternityCareSystem.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class HmsContext : DbContext
    {
        public HmsContext()
            : base("name=HmModel")
        {
        }

        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

       
    }
}
