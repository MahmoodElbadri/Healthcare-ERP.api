
namespace Healthcare_ERP.Domain.Exceptions;

public abstract class CustomException : Exception
{
    public int StatusCode { get; }

    protected CustomException(string message, int statusCode) : base(message)
    {
        StatusCode = statusCode;
    }
}
