using System.Net.Http;
using System.Threading.Tasks;

namespace DBWorker.DAL.Loaders
{
   public class WebLoader : ILoader
    {
        private readonly string _uri;

        public WebLoader(string uri)
        {
            _uri = uri;
        }

        public async Task<string> LoadAsync()
        {
            var httpClient = new HttpClient();

            return await httpClient.GetStringAsync(_uri);
        }
    }
}
