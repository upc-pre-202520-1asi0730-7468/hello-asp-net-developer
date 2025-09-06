namespace Acme.Hello.Platform.Generic.Domain.Model.Entities;

public class Developer
{
    public Guid Id { get; } = Guid.NewGuid();
    public string FirstName { get; }
    public string LastName { get; }

    public Developer(string firstName, string lastName)
    {
        FirstName = string.IsNullOrWhiteSpace(firstName) ? "" : firstName.Trim();
        LastName = string.IsNullOrWhiteSpace(lastName) ? "" : lastName.Trim();
    }
}