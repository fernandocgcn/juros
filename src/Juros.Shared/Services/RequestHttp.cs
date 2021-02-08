using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace Juros.Shared
{
    public class RequestHttp : IRequestHttp
    {
        public Task<decimal> RetornaTaxaJuros() =>  Request<decimal>("https://localhost:44375/taxaJuros");

        public string RetornaUrlCodigo() => "https://github.com/fernandocgcn/juros";

        private async Task<T> Request<T>(string url)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var response = await client.GetStringAsync(url);
            return JsonSerializer.Deserialize<T>(response);
        }
    }
}
