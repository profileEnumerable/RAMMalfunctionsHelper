using System;

namespace DBWorker.DAL.Entities
{
    public class FixIssue
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
        public DateTime TimeSpan { get; set; }

        public virtual Malfunction Malfunction { get; set; }
    }
}
