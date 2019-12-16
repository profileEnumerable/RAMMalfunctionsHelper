using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBWorker.DAL.EDM;

namespace DBWorker.DAL.Config
{
    class RamMalfunctionsDbInitializer : DropCreateDatabaseIfModelChanges<RamMalfunctionsModelContainer>
    {
        protected override void Seed(RamMalfunctionsModelContainer context)
        {
            
        }
    }
}
