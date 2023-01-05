namespace LearnDotNet.Store.Exceptions;

/// <summary>
/// Property isn't initialized
/// </summary>
public class UninitializedPropertyException: InvalidOperationException
{
    /// <summary>
    /// .ctor
    /// </summary>
    public UninitializedPropertyException(string propertyName)
        : base($"Property '{propertyName}' isn't initialized")
    {

    }
}
