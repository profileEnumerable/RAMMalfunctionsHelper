using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBWorker.DAL.Loaders
{
    public class FileLoader : ILoader
    {
        public async Task<string> LoadAsync(string path)
        {
            try
            {
                using (var streamReader = new StreamReader(path))
                {
                    return await streamReader.ReadToEndAsync();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("File not loaded" + e.Message);
                return null;
            }
        }
    }
}