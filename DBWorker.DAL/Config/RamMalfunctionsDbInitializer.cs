using Newtonsoft.Json;
using System.Data.Entity;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBWorker.DAL.Entities;
using DBWorker.DAL.EntityFramework;

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

            const string json = "{\r\n  \"FixIssue\": {\r\n    \"Type\": \"Hardware\",\r\n    \"Price\": \"100\",\r\n    \"TimeSpan\": \"12/17/2019 6:00:00 PM\"\r\n  }\r\n}"


            FixIssue issue = JsonConvert.DeserializeObject<FixIssue>(json);


            MessageBox.Show(issue.Type);
        }
    }
}
