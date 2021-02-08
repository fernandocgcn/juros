using Juros.Api.Taxa;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;

namespace Juros.Test
{
    public class TaxaJurosControllerUnitTests
    {
        private TaxaJurosController _taxaJurosController;

        [SetUp]
        public void Setup()
        {
            _taxaJurosController = new TaxaJurosController();
        }

        [Test]
        public void Test()
        {
            // arrange, act
            var result = _taxaJurosController.Get();
            var actual = (decimal)((OkObjectResult)result.Result).Value;

            // assert
            Assert.IsInstanceOf<OkObjectResult>(result.Result);
            Assert.AreEqual(0.01M, actual);
        }
    }
}
