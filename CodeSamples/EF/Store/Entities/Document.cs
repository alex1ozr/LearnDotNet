using LearnDotNet.Store.Abstract;
using LearnDotNet.Store.Exceptions;

namespace LearnDotNet.Store.Entities;

public sealed class Document: IDbEntity, IDeletableEntity
{
    private DocumentType? _type;
    private Person? _person;
    
    public Document(
        Guid id, 
        Guid typeId,
        Guid personId,
        string series, 
        string number, 
        DateOnly dateOfIssue)
    {
        Id = id;
        TypeId = typeId;
        PersonId = personId;
        Series = series;
        Number = number;
        DateOfIssue = dateOfIssue;
    }
    
    public Guid Id { get; set; }
    
    public DateOnly DateOfIssue { get; set; }
    
    public string? Series { get; set; }
    
    public string Number { get; set; }
    
    public DateOnly? DateOfExpiration { get; set; }
    
    public Guid TypeId { get; set; }
    
    public Guid PersonId { get; set; }
    
    public Person Person
    {
        get => _person ?? throw new UninitializedPropertyException(nameof(Person));
        set => _person = value;
    }

    public DocumentType Type
    {
        get => _type ?? throw new UninitializedPropertyException(nameof(Type));
        set => _type = value;
    }

    public DateTimeOffset? DeletedAt { get; set; }
}