namespace Kingston.TechnicalTest.Services.Interface
{
    public interface IMathsService
    {
        public List<int> GeneratePrimeNumbers(int x, int y);
        public List<int> GenerateFibonacciNumbers(int x, int y);

    }
}