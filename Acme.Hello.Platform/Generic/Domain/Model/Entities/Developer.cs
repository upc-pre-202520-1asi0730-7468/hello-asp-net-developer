namespace Acme.Hello.Platform.Generic.Domain.Model.Entities;

/// <summary>
/// Represents a Developer entity in the Generic bounded context. 
/// </summary>
/// <remarks>
/// This entity is used to represent a developer in the Generic bounded context.
/// When instantiated, the FirstName and LastName properties are trimmed of whitespace,
/// and the ID property is generated.
/// </remarks>
public class Developer
{
    public Guid Id { get; } = Guid.NewGuid();
    public string FirstName { get; }
    public string LastName { get; }

    /// <summary>
    /// Creates a new Developer entity. 
    /// </summary>
    /// <param name="firstName">The first name of the developer.</param>
    /// <param name="lastName">The last name of the developer.</param>
    public Developer(string firstName, string lastName)
    {
        FirstName = string.IsNullOrWhiteSpace(firstName) ? "" : firstName.Trim();
        LastName = string.IsNullOrWhiteSpace(lastName) ? "" : lastName.Trim();
    }
    
    /// <summary>
    /// Gets the full name of the developer. 
    /// </summary>
    /// <returns>The full name of the developer with the format: FirstName LastName.</returns>
    public string GetFullName() => $"{FirstName} {LastName}".Trim();
    
    /// <summary>
    /// Checks if the developer has any name empty. 
    /// </summary>
    /// <returns>True if either the first name or last name is empty; otherwise, false.</returns>
    public bool HasAnyNameEmpty() => string.IsNullOrWhiteSpace(FirstName) || string.IsNullOrWhiteSpace(LastName);
}