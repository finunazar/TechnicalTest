using Kingston.TechnicalTest.Services.Interface;

namespace Kingston.TechnicalTest.Services
{
    public class RandomCharactersService : IRandomCharactersService
    {
        public RandomCharactersService() { }

        public List<char> GetRandomCharacters(int x, int y)
        {
            if (ValidateRequest(x, y))
                throw new InvalidDataException("Invalid values for either X or Y or both");

            Random random = new Random(y);
            string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            List<char> result = new List<char>();
            while (result.Count < x)
            {
                int i = random.Next(0, characters.Length);
                result.Add(characters[i]);
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