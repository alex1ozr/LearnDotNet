using System.ComponentModel.DataAnnotations;

namespace LearnDotNet.ExperimentsConsoleApp.Options;

internal sealed class SomeOptions
{
    public const string SectionName = "SomeOptions";

    [Required]
    public string? Value { get; set; }
}