namespace DBWorker.DAL.Entities
{
    public class UserServiceLink
    {
        public int Id { get; set; }
        public string Link { get; set; }

        public virtual Malfunction Malfunction { get; set; }
    }
}
