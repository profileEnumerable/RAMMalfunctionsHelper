namespace DBWorker.DAL.Entities
{
    public class RamMedia
    {
        public int Id { get; set; }
        public string Data { get; set; }
        public virtual Ram RAM { get; set; }
        public virtual RamMediaType RAMMediaType { get; set; }
    }
}
