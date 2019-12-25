using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBWorker.DAL.Loaders
{
    public class WebLoader : ILoader
    {
        public async Task<string> LoadAsync(string path)
        {
            var httpClient = new HttpClient();

            Task<string> httpResult = null;

            try
            {
                httpResult = httpClient.GetStringAsync(path);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error occured when loading the json");
            }

            return httpResult.Result;
        }
    }
}