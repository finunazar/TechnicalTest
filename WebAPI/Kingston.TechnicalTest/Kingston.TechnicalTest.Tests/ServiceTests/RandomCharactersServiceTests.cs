using Kingston.TechnicalTest.Services;
using Kingston.TechnicalTest.Services.Interface;

namespace Kingston.TechnicalTest.Tests.ServiceTesst
{
    public class RandomCharactersServiceTests
    {
        private static IRandomCharactersService _randomCharactersService;
        [SetUp]
        public void Setup()
        {
            _randomCharactersService = new RandomCharactersService();
        }

        [Test]
        [TestCase(10, 5)]
        public void GetRandomCharacters_ValidData_ReturnSuccess(int x, int y)
        {
            var result = _randomCharactersService.GetRandomCharacters(x, y);
            Assert.IsNotNull(result);
            Assert.That(result.Count, Is.EqualTo(x));
        }

        [Test]
        [TestCase(10, -2)]
        public void GetRandomCharacters_InValidData_ThrowsError(int x, int y)
        {
            var result = Assert.Throws<InvalidDataException>(() => _randomCharactersService.GetRandomCharacters(x, y));
        }
    }
}