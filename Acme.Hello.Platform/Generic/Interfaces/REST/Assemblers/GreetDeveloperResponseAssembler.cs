using Acme.Hello.Platform.Generic.Domain.Model.Entities;
using Acme.Hello.Platform.Generic.Interfaces.REST.Resources;

namespace Acme.Hello.Platform.Generic.Interfaces.REST.Assemblers;

/// <summary>
/// Assembles a <see cref="GreetDeveloperResponse"/> from a Developer entity. 
/// </summary>
public static class GreetDeveloperResponseAssembler
{
    /// <summary>
    /// Assembles a <see cref="GreetDeveloperResponse"/> from a Developer entity. 
    /// </summary>
    /// <remarks>
    /// If the entity is null or has any name empty, a default response is returned.
    /// </remarks>
    /// <param name="entity">The <see cref="Developer"/> entity to assemble from.</param>   
    /// <returns>A <see cref="GreetDeveloperResponse"/> with the greeting message.</returns>   
    public static GreetDeveloperResponse ToResponseFromEntity(Developer? entity)
    {
        if (entity is null || entity.HasAnyNameEmpty())
            return new GreetDeveloperResponse("Welcome Anonymous ASP.NET Developer");
        return new GreetDeveloperResponse(entity.Id, entity.GetFullName(),
            $"Congrats {entity.GetFullName()}! You are an ASP.NET Developer.");
}
}