# Interview questions

### General assembly questions
1. What is an assembly? 
2. What is an EXE and DLL? 
3. What is JIT?

### OOP
1. [OOP Principles](https://habr.com/ru/company/otus/blog/525336/)
2. [Class vs Struct](https://c-sharp.pro/классы-или-структуры-в-чем-отличия/)
3. [Record class vs record struct](https://falberthen.github.io/posts/cs10-records/)
4. Inheritance
5. Abstract vs Interface
    - What's new in c#8? [Interface default implementations](https://devblogs.microsoft.com/dotnet/default-implementations-in-interfaces/)
6. Difference between protected / internal / protected internal.
7. Generics

### Immutable
1. String / StringBuilder - what and why?
    - String types, why are special types in c#, is it value types or reference types?
2. GetHashCode. What it is, what it for, Which requirements
3. What's immutable? what's for?

### .NET
1. [out/ ref/ in](https://www.pluralsight.com/guides/csharp-in-out-ref-parameters)
2. Static / readonly / Const fields - difference?
    - What is the criteria of value that could be set to a constant field?
    - What is static, what are the risks behind static fields, why to use them?
3. What are extension methods? What are the risks behind them?
4. Type safety / [duck typing in .net](https://stackoverflow.com/questions/21278078/what-is-interface-duck-typing) (dynamics, foreach)
5. Default value of type
6. Type members / constructors [initialization order](https://stackoverflow.com/questions/40139099/auto-property-initialization-il-instruction-order)
7. Covariance vs Contrvariance
   - [MSDN](https://learn.microsoft.com/en-us/dotnet/standard/generics/covariance-and-contravariance)
   - [Metanit](https://metanit.com/sharp/tutorial/3.27.php)
8. What is Reflection?

### LINQ
1. LINQ
2. Delegates - what is it? Event vs Delegate.
3. Anonymous types / methods / Lambdas
4. Extension methods
5. Enumerable / IQueryable / IObservable

### Memory + GC
1. Difference between Reference types and Value types (stack vs heap)
2. [Boxing / Unboxing and type casting](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/boxing-and-unboxing)
3. SOH, LOH, STACK (Small)
4. Memory leaks in .net. Where? When? Why?
5. Garbage Collector
6. How many generations. [Garbage collection](https://learn.microsoft.com/ru-ru/dotnet/standard/garbage-collection/fundamentals).
    - Generations: 0, 1, 2
    - Small objects heap (SOH) vs Large objects heap (LOH)
7. When, how to GC
8. Reference graph
9. Finalizer vs IDisposable
10. [Finalization queue / Freachable queue](https://nabacg.wordpress.com/2012/03/11/what-do-you-know-about-freachable-queue/)
11. [Weak references](https://learn.microsoft.com/en-us/dotnet/standard/garbage-collection/weak-references)? What & Why
12. Disposable, using, try, catch, finally. Howto use it? [Disposable pattern](https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/dispose-pattern).

### Threads
1. Threads vs Processes
2. ThreadPool - what it is?
   - [Habr](https://habr.com/ru/articles/654101/)
3. Correct [way to kill thread](https://dotnettutorials.net/lesson/how-to-terminate-a-thread-in-csharp/#:~:text=How%20to%20Terminate%20a%20Thread%20in%20C%23%3F,exception%2C%20the%20thread%20is%20terminated.)
4. [Lock Keyword](https://www.c-sharpcorner.com/UploadFile/de41d6/monitor-and-lock-in-C-Sharp/)
5. Deadlock, race conditions
6. Mutex / Semaphore / Monitor
   - [MSDN](https://learn.microsoft.com/en-us/dotnet/standard/threading/overview-of-synchronization-primitives)
   - [Habr](https://habr.com/ru/articles/459514/)
7. Volatile? ThreadStatic? ThreadLocal?
8. Interlocked
9. What are the solutions to work with static but to avoid multithreading issues?

### Async/Await
1. What it is? When it is used?
2. Difference from multithreading
3. Why is it prohibited to await in lock/Singleton?
4. async await best practices
   - [David Fowler](https://github.com/davidfowl/AspNetCoreDiagnosticScenarios/blob/master/AsyncGuidance.md)

### Data structures and Algorithms
1. Dictionary and HashTable - what for?
    - Why O(1) for adding and finding in c# dictionary? questions about collision
2. [Big-O notation](https://www.freecodecamp.org/news/big-o-notation-why-it-matters-and-why-it-doesnt-1674cfa8a23c/)
3. DateTime vs DateTimeOffset vs TimeSpan
4. List vs LinkedList vs Array

### Principles / Patterns
1. Design pattern / antipattern (which design patterns you know?)
2. SOLID
    - [Single Responsibility Principle](https://metanit.com/sharp/patterns/5.1.php) (Принцип единственной обязанности)
    - [Open/Closed Principle](https://metanit.com/sharp/patterns/5.2.php) (Принцип открытости/закрытости)
    - [Liskov Substitution Principle](https://metanit.com/sharp/patterns/5.3.php) (Принцип подстановки Лисков)
    - [Interface Segregation Principle](https://metanit.com/sharp/patterns/5.4.php) (Принцип разделения интерфейсов)
    - [Dependency Inversion Principle](https://metanit.com/sharp/patterns/5.5.php) (Принцип инверсии зависимостей)
3. Inversion of control
4. [GRASP](https://habr.com/ru/post/92570/)
5. [Low coupling & high cohesion](https://medium.com/german-gorelkin/low-coupling-high-cohesion-d36369fb1be9)
6. Static class vs Singleton
7. Producer/Consumer pattern
8. DDD/TDD etc.
9. Idempotence
10. CQRS+Event Sourcing
11. Saga vs 2nd phase commit
12. How do you define good code?
13. What are the most used design patterns and how do they work?
14. How can you add to the application build-in .net core dependency injection to help to implement principle D in SOLID?
15. In a high scalable app which is decomposed to modules, what solution would you suggest to decompose dependency injection logic? How to ensure modularity and scalability? Reflection? 

### Testing
1. Tests - howto? Unit \ Integration tests? What's difference?
2. Fake vs Mock vs Stub

### Network
1. Модель OSI
2. TCP vs UDP
3. TLS vs SSL
4. HTTP методы
5. JWT tokens
6. [Difference between 301 (permanent) and 302 types of redirection?](https://www.domain.com/blog/what-is-a-redirect/)

### Database / ORM (EF)
1. Transaction isolation levels
2. [ACID](https://habr.com/ru/post/555920/)
    - Atomicity — Атомарность
    - Consistency — Согласованность
    - Isolation — Изолированность
    - Durability — Надёжность
3. Temporary tables
4. [Clustered vs non-clustered indexes](https://ru.wikipedia.org/wiki/Индекс_(базы_данных))
5. WHERE vs HAVING
6. [CAP theorem](https://habr.com/ru/articles/328792/)
7. How can databases store data efficiently?
8. You’ve been investigating slow api, some select queries take too much time, how to investigate why they are slow?

### ASP.NET Core
1. [Middleware](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/middleware/?view=aspnetcore-6.0)
2. Requests pipeline
3. What is an HTTP client factory and why would we use it?
4. What is a retry policy?

### System Design
1. Service for shortening urls, how we can create systems like this, what database, architecture, cache, etc. to use?
