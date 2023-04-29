namespace LearnDotNet.Store.Abstract;

public interface IDeletableEntity
{
    DateTimeOffset? DeletedAt { get; set; }
}