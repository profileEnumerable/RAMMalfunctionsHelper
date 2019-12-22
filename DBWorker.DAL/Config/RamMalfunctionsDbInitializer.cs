using DBWorker.DAL.Entities;
using DBWorker.DAL.EntityFramework;
using DBWorker.DAL.Loaders;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;

namespace DBWorker.DAL.Config
{
    internal class RamMalfunctionsDbInitializer : DropCreateDatabaseAlways<RamMalfunctionsContext>
    {
        private readonly string[] _configFileNames;
        private readonly string _resourcePath;

        public RamMalfunctionsDbInitializer()
        {
            _resourcePath = ConfigurationManager.ConnectionStrings["AbsoluteLocalPath"].ConnectionString;

            _configFileNames = new[]
            {
                "Ram","FixIssue", "Malfunction", "UserServiceLink"
            };
        }

        public static T GetDeserializedCollection<T>(string json) where T : class
        {
            T items = JsonConvert.DeserializeObject<T>(json);

            return items;
        }

        protected override void Seed(RamMalfunctionsContext context)
        {
            foreach (var fileName in _configFileNames)
            {
                var filePath = $@"{_resourcePath}\{fileName}.json";

                var json = new FileLoader(filePath).Load();

                switch (fileName)
                {
                    case "FixIssue":
                        {
                            context.FixIssues.AddRange(GetDeserializedCollection<List<FixIssue>>(json));
                            break;
                        }

                    case "UserServiceLink":
                        {
                            context.UserServiceLinks.AddRange(GetDeserializedCollection<List<UserServiceLink>>(json));
                            break;
                        }
                    case "Malfunction":
                        {
                            context.Malfunctions.AddRange(GetDeserializedCollection<List<Malfunction>>(json));
                            break;
                        }

                    case "Ram":
                        {
                            context.RAMs.AddRange(GetDeserializedCollection<List<Ram>>(json));
                            break;
                        }
                }
            }

            context.SaveChanges();
        }
    }
}