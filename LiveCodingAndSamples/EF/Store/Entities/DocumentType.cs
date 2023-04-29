using LearnDotNet.Store.Abstract;

namespace LearnDotNet.Store.Entities;

public sealed class DocumentType: IDbEntity, IDeletableEntity
{
    public DocumentType(Guid id, string name)
    {
        Id = id;
        Name = name;
    }
    
    public Guid Id { get; set; }
    
    public string Name { get; set; }
    
    public DateTimeOffset? DeletedAt { get; set; }
}