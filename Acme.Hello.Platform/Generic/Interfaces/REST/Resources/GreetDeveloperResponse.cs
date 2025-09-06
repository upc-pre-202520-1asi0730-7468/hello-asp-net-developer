namespace Acme.Hello.Platform.Generic.Interfaces.REST.Resources;

/// <summary>
/// Represents a response to a greeting request. 
/// </summary>
/// <param name="Id">The ID of the developer, which can be null.</param>
/// <param name="FirstName">The first name of the developer, which can be null.</param>
/// <param name="LastName">The last name of the developer, which can be null.</param>
/// <param name="Message">The greeting message to be returned to the caller.</param>
public record GreetDeveloperResponse(Guid? Id, string? FullName, string Message)
{
    /// <summary>
    /// Creates a new GreetDeveloperResponse with a message. 
    /// </summary>
    /// <param name="message">The greeting message to be returned to the caller.</param>
    public GreetDeveloperResponse(string message) : this(null, null, message) { }
}