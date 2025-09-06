namespace Acme.Hello.Platform.Generic.Interfaces.REST.Resources;

/// <summary>
/// Represents a request to greet a developer. 
/// </summary>
/// <param name="FirstName">The first name of the developer, which can be null.</param>
/// <param name="LastName">The last name of the developer, which can be null.</param>
public record GreetDeveloperRequest(string? FirstName, string? LastName);