using System.Collections.Generic;

namespace DBWorker.DAL.Entities
{
    public class RamMediaType
    {
        public RamMediaType()
        {
            RamMedias = new HashSet<RamMedia>();
        }

        public int Id { get; set; }
        public string Type { get; set; }

        public virtual ICollection<RamMedia> RamMedias { get; set; }
    }
}
