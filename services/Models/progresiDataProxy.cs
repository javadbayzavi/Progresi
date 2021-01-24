namespace services.Models
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Linq;
    using MongoDB.Driver;
    using MongoDB.EntityFramework.Core;
`    public class MongoSettings
    {
        public MongoSettings(string connectionString, string databaseName)
        {
            ConnectionString = connectionString;
            DatabaseName = databaseName;
        }

        public string ConnectionString { get; set; }

        public string DatabaseName { get; set; }
    }

    public class progresiDataProxy : MongoDB.EntityFramework.Core.DbContext
    {
        public progresiDataProxy(IMongoClient client, MongoSettings settings)
            : base(client, settings.DatabaseName)
        {
            //TODO: lazy

        }

        public virtual DbSet<progresi_bunches> progresi_bunches { get; set; }
        public virtual DbSet<progresi_categories> progresi_categories { get; set; }
        public virtual DbSet<progresi_stages> progresi_stages { get; set; }
        public virtual DbSet<progresi_tasks> progresi_tasks { get; set; }
        public virtual DbSet<progresi_teams> progresi_teams { get; set; }
        public virtual DbSet<progresi_users> progresi_users { get; set; }

        public virtual DbSet<progresi_stage_tasks> progresi_stage_tasks { get; set; }
        public virtual DbSet<progresi_bunch_categories> progresi_bunch_categories { get; set; }
        public virtual DbSet<progresi_task_assigns> progresi_task_assigns { get; set; }
        public virtual DbSet<progresi_task_categories> progresi_task_categories { get; set; }
        public virtual DbSet<progresi_user_teams> progresi_user_teams { get; set; }

    }
}
