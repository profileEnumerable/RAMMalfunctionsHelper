using System.Data.Entity;
using DBWorker.DAL.Config;
using DBWorker.DAL.Entities;

namespace DBWorker.DAL.EntityFramework
{
    public class RamMalfunctionsModelContainer : DbContext
    {
        public RamMalfunctionsModelContainer()
            : base("name=RamMalfunctionsModelContainer")
        {

        }

        static RamMalfunctionsModelContainer()
        {
            Database.SetInitializer(new RamMalfunctionsDbInitializer());
        }

        public virtual DbSet<UserServiceLink> UserServiceLinks { get; set; }
        public virtual DbSet<RamMedia> RAMMedias { get; set; }
        public virtual DbSet<Malfunction> Malfunctions { get; set; }
        public virtual DbSet<FixIssue> FixIssues { get; set; }
    }
}
