
using csharp_tutorial.Helpers.Hsl;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace csharp_tutorial
{
    public class Glenn
    {
        public void ExtractEntry(IEnumerator<ZipArchiveEntry> entriesEnumerator, string destinationDirectory)
        {
            var entry = entriesEnumerator.Current;
            var destinationPath = Path.Combine(destinationDirectory, entry.FullName);
            entry.ExtractToFile(destinationPath); // Noncompliant
        }
    }
}