using LearnDotNet.ConsoleApp.Helpers;
using LearnDotNet.Store;
using Microsoft.EntityFrameworkCore;

var context = new PeopleContext();
await context.Database.MigrateAsync();

var newPerson = context.People.Add(DataGenerator.GeneratePerson());

var newDocumentType = context.DocumentTypes.Add(DataGenerator.GenerateDocumentType());
context.Documents.Add(
    DataGenerator.GenerateDocument(newPerson.Entity.Id, newDocumentType.Entity.Id));

await context.SaveChangesAsync();

var people = await context.People
    .Include(x => x.Documents)
    .ThenInclude(x => x.Type)
    .ToArrayAsync();

foreach (var person in people)
{
    Console.WriteLine($"{person.LastName} {person.FirstName}, {person.DateOfBirth}");
    Console.WriteLine($"\tDocuments:");
    if (person.Documents.Any())
    {
        foreach (var personDocument in person.Documents)
        {
            Console.WriteLine($"\t\t{personDocument.Type.Name}, {personDocument.Series} {personDocument.Number}, {personDocument.DateOfIssue}");
        }
    }
    else
    {
        Console.WriteLine("\t\tNo documents");
    }
}