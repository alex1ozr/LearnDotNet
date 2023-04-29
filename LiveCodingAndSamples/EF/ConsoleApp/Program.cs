using LearnDotNet.ConsoleApp.Helpers;
using LearnDotNet.Store;
using Microsoft.EntityFrameworkCore;

const int peopleCount = 10;
//File.Delete("../people.db");

var rnd = new Random();
await using var context = new PeopleContext();
await context.Database.MigrateAsync();

for (int i = 0; i < peopleCount; i++)
{
    var newPerson = context.People.Add(DataGenerator.GeneratePerson());
    for (int j = 0; j < rnd.Next(0, 5); j++)
    {
        var newDocumentType = context.DocumentTypes.Add(DataGenerator.GenerateDocumentType());
        context.Documents.Add(
            DataGenerator.GenerateDocument(newPerson.Entity.Id, newDocumentType.Entity.Id));
    }
}
await context.SaveChangesAsync();

var dt = new DateOnly(2000, 01, 01);
var people = await context.People
    .Where(x=> x.DateOfBirth >= dt)
    .Include(x => x.Documents)
    .ThenInclude(x => x.Type)
    .ToArrayAsync();

foreach (var person in people)
{
    Console.WriteLine($"{person.LastName} {person.FirstName}, {person.DateOfBirth}");
    Console.WriteLine("\tDocuments:");
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