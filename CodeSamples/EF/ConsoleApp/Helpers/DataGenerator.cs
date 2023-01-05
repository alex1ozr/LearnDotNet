using Bogus;
using Person = LearnDotNet.Store.Entities.Person;

namespace LearnDotNet.ConsoleApp.Helpers;

internal static class DataGenerator
{
    private static readonly Faker<Person> _personGenerator = new Faker<Person>()
        .CustomInstantiator(f =>
            new Person(
                Guid.NewGuid(),
                f.Name.FirstName(),
                f.Name.LastName(),
                DateOnly.FromDateTime(f.Person.DateOfBirth)
            )
        );

    public static Person GeneratePerson() => _personGenerator.Generate();
}