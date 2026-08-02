using System.Net;
using System.Text.Json;
using Healthcare_ERP.Domain.Wrappers;

namespace Healthcare_ERP.api.Middlewares;

public class ExceptionHandlingMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<ExceptionHandlingMiddleware> _logger;

    public ExceptionHandlingMiddleware(RequestDelegate next, ILogger<ExceptionHandlingMiddleware> logger)
    {
        _next = next;
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            // Let the request proceed normally
            await _next(context);
        }
        catch (Exception ex)
        {
            // If it crashes anywhere, catch it here
            _logger.LogError(ex, "An unhandled exception occurred.");
            await HandleExceptionAsync(context, ex);
        }
    }

    private static Task HandleExceptionAsync(HttpContext context, Exception exception)
    {
        context.Response.ContentType = "application/json";
        context.Response.StatusCode = (int)HttpStatusCode.InternalServerError; // 500

        // Wrap the error in your standard response pattern
        var response = ApiResponse<object>.Failure(
            error: exception.Message,
            message: "An unexpected error occurred on the server."
        );

        // Serialize to JSON with camelCase to match frontend expectations
        var json = JsonSerializer.Serialize(response, new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        });

        return context.Response.WriteAsync(json);
    }
}