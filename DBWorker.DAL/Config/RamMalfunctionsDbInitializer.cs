using DBWorker.DAL.EDM;
using Newtonsoft.Json;
using System.Data.Entity;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBWorker.DAL.Config
{
    internal class RamMalfunctionsDbInitializer : DropCreateDatabaseAlways<RamMalfunctionsModelContainer>
    {
        private static async Task<string> LoadJsonStringAsync(string uri)
        {
            var httpClient = new HttpClient();

            return await httpClient.GetStringAsync(uri);
        }

        protected override void Seed(RamMalfunctionsModelContainer context)
        {
            const string githubPages =
                "https://raw.githubusercontent.com/profileEnumerable/profileEnumerable.github.io/master/cardData.json";


            FixIssue issue = JsonConvert.DeserializeObject<FixIssue>(LoadJsonStringAsync(githubPages).Result);


            MessageBox.Show(issue.ToString());
        }
    }
}
