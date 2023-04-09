# Learning course program
This course is based on reading the book **Price M.J. - CSharp 10 and .NET 6** completing tasks at the end of each chapter in a private GitHub repository.
1. Introduction to .NET
    - Chapters 1-2
2. Types, operators & exceptions
    - Chapter 3
    - Video: [History of C#](https://www.youtube.com/watch?app=desktop&v=ysKnBJsnxjE)
3. Unit-tests (xUnit) and LINQ
    - Chapter 4
    - Chapter 11 (except 'Using LINQ with EF Core' part) 
    - [Modified FizzBuzz problem](https://github.com/alex1ozr/LearnDotNet/blob/main/Exercises/FizzBuzz.md)
    - LeetCode practice 
       - [Easy one](https://leetcode.com/problemset/all/?sorting=W3sic29ydE9yZGVyIjoiQVNDRU5ESU5HIiwib3JkZXJCeSI6IkRJRkZJQ1VMVFkifV0%3D)
         - Develop using xUnit (Fact & Theory) + FluentAssertions
         - See [Unit-tests reference project](https://github.com/alex1ozr/LearnDotNet/tree/main/CodeSamples/UnitTests)
    - Video: [Unit-tests principles](https://www.youtube.com/watch?v=LkrqqpkKIXE)
    - [101 LINQ samples](https://github.com/dotnet/try-samples/blob/main/101-linq-samples/index.md)
4. OOP
    - Chapter 5
    - LeetCode practice
5. OOP, Interfaces & Inheritance
    - Chapter 6
6. Nuget packages & SOLID
    - Chapter 7
    - [Metanit](https://metanit.com/sharp/patterns/5.1.php)
7. Common .NET types
    - Chapter 8
    - [Dictionary/HashTable](https://blog.markvincze.com/back-to-basics-dictionary-part-1/)
8. Files, Streams & Serialization
   - Chapter 9
9. [Design patterns](https://github.com/alex1ozr/LearnDotNet/tree/main/Patterns)
   - [Metanit](https://metanit.com/sharp/patterns/1.1.php)
10. [Excercise #1](https://github.com/alex1ozr/LearnDotNet/blob/main/Exercises/Exercise_1.md)
11. ORM (EF Core)
    - Chapter 10
    - [Metanit](https://metanit.com/sharp/efcore/)
    - [MSDN](https://learn.microsoft.com/en-us/ef/core/get-started/overview/first-app?tabs=netcore-cli)
    - [EF Core & Nullable Reference Types](https://learn.microsoft.com/en-us/ef/core/miscellaneous/nullable-reference-types)
    - [EF Core sample](https://github.com/alex1ozr/LearnDotNet/tree/main/CodeSamples/EF)
12. LINQ
    - Chapter 11
    - [MSDN](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/introduction-to-linq-queries)
    - [LINQ pipeline](https://www.red-gate.com/simple-talk/development/dotnet-development/linq-secrets-revealed-chaining-and-debugging/#fourth)
13. [Excercise #2](https://github.com/alex1ozr/LearnDotNet/blob/main/Exercises/Exercise_2.md)
    - [Automapper](https://www.youtube.com/watch?v=3Rx85qlgjS4)
    - [SQLite tutorial](https://metanit.com/sql/sqlite/)
14. Multitasking
    - [Metanit](https://metanit.com/sharp/tutorial/13.3.php)
    - [Task.Run vs Task.Factory.StartNew](https://devblogs.microsoft.com/pfxteam/task-run-vs-task-factory-startnew/)
15. ASP.NET
    - Chapter 13
    - [Metanit](https://metanit.com/sharp/aspnet6/)
16. ASP.NET + DI
    - Dependency Injection (ServiceCollection)
      - [MSDN](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-7.0)
      - [Exercise #3](https://github.com/alex1ozr/LearnDotNet/blob/main/Exercises/Exercise_3.md)
17. ASP.NET + Autofac
    - Dependency Injection (Autofac)
      - [GitHub](https://github.com/autofac/Autofac)
      - [Documentation](https://autofac.readthedocs.io/en/latest/getting-started/index.html)
18. ASP.NET + Docker
    - Docker
        - Habr: [1](https://habr.com/ru/company/ruvds/blog/438796/), [2](https://habr.com/ru/post/439978/), [3](https://habr.com/ru/company/ruvds/blog/439980/), [4](https://habr.com/ru/company/ruvds/blog/440658/), [5](https://habr.com/ru/company/ruvds/blog/440660/), [6](https://habr.com/ru/post/441574/)
        - [What's Docker - Video](https://www.youtube.com/watch?v=TJg7QpqCH70)
19. ASP.NET web api & HttpClient + Configuration
    - Chapter 16
    - Configuration
        - [MSDN](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/configuration/?view=aspnetcore-7.0)
    - Routing
        - [MSDN: Web API routing without MVC](https://learn.microsoft.com/en-us/aspnet/web-api/overview/web-api-routing-and-actions/routing-in-aspnet-web-api)
        - [MSDN: Routing and Action Selection](https://learn.microsoft.com/en-us/aspnet/web-api/overview/web-api-routing-and-actions/routing-and-action-selection)
        - [MSDN: Attribute Routing](https://learn.microsoft.com/en-us/aspnet/web-api/overview/web-api-routing-and-actions/attribute-routing-in-web-api-2)
    - Parameter binding in ASP.NET
        - [MSDN: Model Binding](https://learn.microsoft.com/en-us/aspnet/core/mvc/models/model-binding?view=aspnetcore-3.1)
    - [Excercise #4](https://github.com/alex1ozr/LearnDotNet/blob/main/Exercises/Exercise_4.md)
20. ASP.NET + E2E tests
    - HttpClient generation (NSwag)
      - [GitHub](https://github.com/RicoSuter/NSwag/wiki/CommandLine)
      - [CLI sample](https://github.com/alex1ozr/NumbersIntoWords/blob/main/src/Api.Client/Generator/GenerateClient.ps1)
    - End2End tests (TestContainers)
      - [GitHub](https://github.com/testcontainers/testcontainers-dotnet)
      - [Video](https://www.youtube.com/watch?v=E4TeWBFzcCw)
      - [Sample](https://github.com/alex1ozr/DockerTests)
    - Documentation (Markdown)
      - [Article](https://highload.today/markdown/)
21. ASP.NET MVC (Optional)
    - Chapters 14-15
22. Job interview simulation - Code Review / System design
