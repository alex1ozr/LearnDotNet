using System.ComponentModel.DataAnnotations;

namespace LearnDotNet.WebAppSample.Console.Options;

public class OptionsSample
{
    public const string OptionKey = "OptionsSample";
    
    [Required]
    public required string Value { get; init; }
}