
namespace Healthcare_ERP.Domain.Exceptions;

public class BadRequestException : CustomException
{
    public BadRequestException(string message)
        : base(message, 400) // 400 Bad Request
    {
    }
}