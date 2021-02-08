using Juros.Api.Calculo;
using Juros.Shared;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System.Threading.Tasks;

namespace Juros.Test
{
    public class CalculaJurosControllerUnitTests
    {
        private CalculaJurosController _calculaJurosController;

        [SetUp]
        public void Setup()
        {
            var requestHttp = new Mock<IRequestHttp>();
            requestHttp.Setup(p => p.RetornaTaxaJuros()).Returns(Task.Run(() => 0.01M));
            _calculaJurosController = new CalculaJurosController(requestHttp.Object);
        }

        [Test]
        public async Task TestAsync()
        {
            // arrange, act
            var result = await _calculaJurosController.CalculaAsync(100, 5);
            var actual = (double)((OkObjectResult)result.Result).Value;

            // assert
            Assert.IsInstanceOf<OkObjectResult>(result.Result);
            Assert.AreEqual(105.10, actual);
        }
    }
}
