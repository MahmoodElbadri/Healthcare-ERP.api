namespace Healthcare_ERP.Domain.Exceptions;

public class NotFoundException : Exception
{
    public NotFoundException(string message) : base(message)
    {
    }

    public NotFoundException(string message, string entityId) : base($"{message} with Id {entityId} not found")
    {
    }

    
}
