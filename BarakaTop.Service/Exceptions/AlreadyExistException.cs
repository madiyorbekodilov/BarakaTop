namespace BarakaTop.Service.Exceptions;

public class AlreadyExistException : Exception
{
    public int StatusCode { get; set; }
    public AlreadyExistException(string message) : base(message)
    { }

    public AlreadyExistException(string message, Exception innerException) : base(message, innerException)
    { }
}
