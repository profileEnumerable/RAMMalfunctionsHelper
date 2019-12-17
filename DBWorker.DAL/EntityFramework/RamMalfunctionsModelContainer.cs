using System.Data.Entity;
using DBWorker.DAL.Config;

namespace DBWorker.DAL.EDM
{
    public partial class RamMalfunctionsModelContainer : DbContext
    {
        static RamMalfunctionsModelContainer()
        {
            Database.SetInitializer(new RamMalfunctionsDbInitializer());
        }
    }
}
