using System.Collections.Generic;

namespace DBWorker.DAL.Entities
{
    public class Manufacturer
    {
        public Manufacturer()
        {
            this.RAMs = new HashSet<Ram>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public bool IsCertified { get; set; }

        public virtual ICollection<Ram> RAMs { get; set; }
    }
}
