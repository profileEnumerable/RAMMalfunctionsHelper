using System.Threading.Tasks;

namespace DBWorker.DAL.Loaders
{
   public interface ILoader
    {
        Task<string> LoadAsync();
    }
}
