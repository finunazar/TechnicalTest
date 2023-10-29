using Kingston.TechnicalTest.Services;
using Kingston.TechnicalTest.Services.Interface;

namespace Kingston.TechnicalTest.Tests.ServiceTesst
{
    public class MathsServiceTests
    {
        private static IMathsService _mathsService;
        [SetUp]
        public void Setup()
        {
            _mathsService = new MathsService();
        }

        [Test]
        [TestCase(10, 5)]
        public void GenerateFibonacciNumbers_ValidData_ReturnSuccess(int x, int y)
        {
            var result = _mathsService.GenerateFibonacciNumbers(x, y);
            Assert.IsNotNull(result);
            Assert.That(result.Count, Is.EqualTo(x));
        }

        [Test]
        [TestCase(10, -2)]
        public void GenerateFibonacciNumbers_InValidData_ThrowsError(int x, int y)
        {
            var result = Assert.Throws<InvalidDataException>(() => _mathsService.GenerateFibonacciNumbers(x, y));
        }

        [Test]
        [TestCase(10, 5)]
        public void GeneratePrimeNumbers_ValidData_ReturnSuccess(int x, int y)
        {
            var result = _mathsService.GeneratePrimeNumbers(x, y);
            Assert.IsNotNull(result);
            Assert.That(result.Count, Is.EqualTo(x));
        }

        [Test]
        [TestCase(10, 5)]
        public void GeneratePrimeNumbers_InValidData_ThrowsError(int x, int y)
        {
            var result = _mathsService.GeneratePrimeNumbers(x, y);
            Assert.IsNotNull(result);
            Assert.That(result.Count, Is.EqualTo(x));
        }
    }
}