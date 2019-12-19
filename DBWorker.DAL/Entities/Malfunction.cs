using System;
using System.Collections.Generic;

namespace DBWorker.DAL.Entities
{
    public class Malfunction
    {
        public Malfunction()
        {
            Rams = new HashSet<Ram>();
            UserServiceLinks = new HashSet<UserServiceLink>();
            FixIssues = new HashSet<FixIssue>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime AppearsDate { get; set; }

        public virtual ICollection<UserServiceLink> UserServiceLinks { get; set; }

        public virtual ICollection<FixIssue> FixIssues { get; set; }

        public virtual ICollection<Ram> Rams { get; set; }
    }
}
