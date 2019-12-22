using System.Collections.Generic;
using System.Data.Entity;
using DBWorker.DAL.Config;
using DBWorker.DAL.Entities;

namespace DBWorker.DAL.EntityFramework
{
    public class RamMalfunctionsContext : DbContext
    {
        public RamMalfunctionsContext()
            : base("name=RamMalfunctionsContext")
        {

        }

        static RamMalfunctionsContext()
        {
            Database.SetInitializer(new RamMalfunctionsDbInitializer());
        }

        public virtual DbSet<Ram> RAMs { get; set; }
        public virtual DbSet<Manufacturer> Manufacturers { get; set; }
        public virtual DbSet<RamMediaType> RAMMediaTypes { get; set; }
        public virtual DbSet<UserServiceLink> UserServiceLinks { get; set; }
        public virtual DbSet<RamMedia> RAMMedias { get; set; }
        public virtual DbSet<Malfunction> Malfunctions { get; set; }
        public virtual DbSet<FixIssue> FixIssues { get; set; }
    }
}
