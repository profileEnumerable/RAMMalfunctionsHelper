using System;
using System.Collections.Generic;

namespace DBWorker.DAL.Entities
{
    public class Ram
    {
        public Ram()
        {
            Malfunctions = new HashSet<Malfunction>();
            RAMMedias = new HashSet<RamMedia>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Size { get; set; }
        public DateTime PruductionDate { get; set; }
        public int? MemoryFrequency { get; set; }
        public string UsePropose { get; set; }
        public bool IsBuffered { get; set; }
        public DateTime Warranty { get; set; }

        public virtual Manufacturer Manufacturer { get; set; }
        public virtual ICollection<RamMedia> RAMMedias { get; set; }

        public virtual ICollection<Malfunction> Malfunctions { get; set; }
    }
}
