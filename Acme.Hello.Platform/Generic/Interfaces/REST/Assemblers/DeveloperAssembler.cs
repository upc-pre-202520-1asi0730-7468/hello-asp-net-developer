using Acme.Hello.Platform.Generic.Domain.Model.Entities;
using Acme.Hello.Platform.Generic.Interfaces.REST.Resources;

namespace Acme.Hello.Platform.Generic.Interfaces.REST.Assemblers;

/// <summary>
/// Assembles a Developer entity from a request. 
/// </summary>
public static class DeveloperAssembler
{
    /// <summary>
    /// Assembles a Developer entity from a request. 
    /// </summary>
    /// <param name="request">The <see cref="GreetDeveloperRequest"/> to assemble from.</param>
    /// <returns>The assembled <see cref="Developer"/> or null if the request is invalid.</returns>
    public static Developer? ToEntityFromRequest(GreetDeveloperRequest? request)
    {
        if (request is null 
            || string.IsNullOrWhiteSpace(request.FirstName) 
            || string.IsNullOrWhiteSpace(request.LastName))
            return null;
        return new Developer(request.FirstName, request.LastName);
    }
}