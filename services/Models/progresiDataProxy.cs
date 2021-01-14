namespace services.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class progresiDataProxy : DbContext
    {
        public progresiDataProxy()
            : base("name=progresidb")
        {
        }

        public virtual DbSet<progresi_bunches> progresi_bunches { get; set; }
        public virtual DbSet<progresi_categories> progresi_categories { get; set; }
        public virtual DbSet<progresi_stages> progresi_stages { get; set; }
        public virtual DbSet<progresi_tasks> progresi_tasks { get; set; }
        public virtual DbSet<progresi_teams> progresi_teams { get; set; }
        public virtual DbSet<progresi_users> progresi_users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

    }
}