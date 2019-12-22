using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBWorker.DAL.Loaders
{
    public class FileLoader : ILoader
    {
        private readonly string _filePath;

        public FileLoader(string filePath)
        {
            _filePath = filePath;
        }

        public string Load()
        {
            try
            {
                using (var streamReader = new StreamReader(_filePath))
                {
                    return  streamReader.ReadToEnd();
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
