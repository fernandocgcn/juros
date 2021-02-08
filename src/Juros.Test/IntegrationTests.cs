using NUnit.Framework;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace Juros.Test
{
    public class IntegrationTests
    {
        private async Task<T> Request<T>(string url)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var response = await client.GetStringAsync(url);
            return JsonSerializer.Deserialize<T>(response);
        }

        [Test]
        public async Task TestAsync()
        {
            // arrange, act
            var actual = await Request<double>("https://localhost:44370/calculajuros?valorInicial=100&meses=5");

            // assert
            Assert.AreEqual(105.10, actual);
        }
    }
}
