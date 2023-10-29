using Kingston.TechnicalTest.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Kingston.TechnicalTest.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MathAndRandomController : ControllerBase
    {
        private readonly IMathsService _mathsService;
        private readonly IRandomCharactersService _randomCharactersService;
        public MathAndRandomController(IMathsService mathsService, IRandomCharactersService randomCharactersService)
        {
            _mathsService = mathsService;
            _randomCharactersService = randomCharactersService;
        }

        [HttpGet]
        [Route("PrimeNumbers")]
        public IActionResult GeneratePrimeNumbers(int x, int y)
        {
            try
            {
                return Ok(_mathsService.GeneratePrimeNumbers(x, y));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("FibonacciNumbers")]
        public IActionResult GenerateFibonacciNumbers(int x, int y)
        {
            try
            {
                return Ok(_mathsService.GenerateFibonacciNumbers(x, y));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("RandomCharacters")]
        public IActionResult GetRandomCharacters(int x, int y)
        {
            try
            {
                return Ok(_randomCharactersService.GetRandomCharacters(x, y));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}