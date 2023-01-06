using Bogus;
using LearnDotNet.Store.Entities;
using Person = LearnDotNet.Store.Entities.Person;

namespace LearnDotNet.ConsoleApp.Helpers;

internal static class DataGenerator
{
    private static readonly Faker<Person> PersonGenerator = new Faker<Person>()
        .CustomInstantiator(f =>
            new Person(
                Guid.NewGuid(),
                f.Name.FirstName(),
                f.Name.LastName(),
                DateOnly.FromDateTime(f.Person.DateOfBirth)
            )
        );

    private static readonly Faker<DocumentType> DocumentTypeGenerator = new Faker<DocumentType>()
        .CustomInstantiator(f =>
            new DocumentType(
                Guid.NewGuid(),
                f.Commerce.ProductName()
            )
        );

    private static readonly Faker<Document> DocumentGenerator = new Faker<Document>();
    public static Person GeneratePerson() => PersonGenerator.Generate();

    public static DocumentType GenerateDocumentType() => DocumentTypeGenerator.Generate();

    public static Document GenerateDocument(Guid personId, Guid documentTypeId) => DocumentGenerator
        .CustomInstantiator(f =>
            new Document(
                Guid.NewGuid(),
                documentTypeId,
                personId,
                f.Random.Int(1000, 9999).ToString(),
                f.Random.Int(1_000_000, 9_999_999).ToString(),
                f.Date.PastDateOnly(10)
            )
        ).Generate();
}