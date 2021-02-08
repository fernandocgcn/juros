using System.Threading.Tasks;

namespace Juros.Shared
{
    public interface IRequestHttp
    {
        Task<decimal> RetornaTaxaJuros();
        string RetornaUrlCodigo();
    }
}
