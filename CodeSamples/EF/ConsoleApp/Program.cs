// See https://aka.ms/new-console-template for more information

using LearnDotNet.ConsoleApp.Helpers;
using LearnDotNet.Store;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");

var context = new PeopleContext();
await context.Database.MigrateAsync();

context.People.Add(DataGenerator.GeneratePerson());
await context.SaveChangesAsync();

var people = await context.People.ToArrayAsync();

foreach (var person in people)
{
    Console.WriteLine($"{person.LastName} {person.FirstName}, {person.DateOfBirth}");
}