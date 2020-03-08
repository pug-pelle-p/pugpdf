using System.IO;
using System.Threading.Tasks;

namespace PugPdf.Core
{
    public class PdfDocument
    {
        public byte[] BinaryData { get; }

        public PdfDocument(byte[] data)
        {
            BinaryData = data;
        }

        public void SaveAs(string path)
        {
            File.WriteAllBytes(path, BinaryData);
        }

        public string SaveInTempFolder()
        {
            var filePath = GetTempFilePath();
            
            SaveAs(filePath);

            return filePath;
        }

        private static string GetTempFilePath()
        {
            var path = Path.GetTempFileName().Replace(".tmp", "");
            return path + ".pdf";
        }

#if NETSTANDARD2_1

        public Task SaveAsAsync(string path)
        {
            return File.WriteAllBytesAsync(path, BinaryData);
        }

        public async Task<string> SaveInTempFolderAsync()
        {
            var filePath = GetTempFilePath();
            
            await SaveAsAsync(filePath);

            return filePath;
        }

#endif
    }
}