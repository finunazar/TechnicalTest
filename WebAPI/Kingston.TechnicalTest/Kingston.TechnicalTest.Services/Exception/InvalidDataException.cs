namespace Kingston.TechnicalTest.Services.Exceptions
{
    public class InvalidDataException : Exception
    {
        public InvalidDataException() { }
        public InvalidDataException(string message) : base(message) { }

    }
}
