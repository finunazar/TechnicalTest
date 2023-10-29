using Kingston.TechnicalTest.Services.Interface;

namespace Kingston.TechnicalTest.Services
{
    public class MathsService : IMathsService
    {
        public MathsService() { }

        public List<int> GenerateFibonacciNumbers(int x, int y)
        {
            if (ValidateRequest(x, y))
                throw new InvalidDataException("Invalid Values for either X or Y or both");

            int a = 0, b = 1, c;
            List<int> result = new List<int>();
            while (result.Count < x)
            {
                c = a + b;
                if (c > y)
                {
                    result.Add(c);
                }
                a = b;
                b = c;
            }
            return result;
        }

        public List<int> GeneratePrimeNumbers(int x, int y)
        {
            if (ValidateRequest(x, y))
                throw new InvalidDataException("Invalid values for either X or Y or both");

            int c = 2, num = y + 1;
            bool isPrime = true;
            List<int> result = new List<int>();
            while (result.Count < x)
            {
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        c++;
                        if (c > 2)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                }
                if (isPrime)
                {
                    result.Add(num);
                }
                c = 2;
                num = num + 1;
                isPrime = true;
            }
            return result;
        }

        private static bool ValidateRequest(int x, int y)
        {
            if (x <= 0 || y <= 0)
            {
                return true;
            }
            return false;
        }
    }
}