using LearnDotNet.Store.Abstract;

namespace LearnDotNet.Store.Entities;

public sealed class Person: IDbEntity, IDeletableEntity
{
    public Person(
        Guid id,
        string firstName,
        string lastName,
        DateOnly dateOfBirth)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dateOfBirth;
    }

    public Guid Id { get; set; }
    
    public string FirstName { get; set; }
    
    public string LastName { get; set; }
    
    public DateOnly DateOfBirth { get; set; }
    
    public DateOnly? DateOfDeath { get; set; }
    
    public DateTimeOffset? DeletedAt { get; set; }
    
    public ICollection<Document> Documents { get; set; } = new List<Document>();
}