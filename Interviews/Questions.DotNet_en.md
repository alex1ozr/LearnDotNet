# Interview questions (.NET)

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
    - What is string interning?
2. GetHashCode. What it is, what it for, Which requirements
3. What's immutable? what's for?
4. Immutable collections and thread-safe collections, what's the difference?

### .NET
1. [out/ ref/ in](https://www.pluralsight.com/guides/csharp-in-out-ref-parameters)
   - Can ref and out be used with both value types and reference types?
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
9. What is faster: concatenation or interpolation?

### LINQ
1. LINQ
2. Delegates - what is it? Event vs Delegate.
3. Anonymous types / methods / Lambdas
4. Extension methods
5. Enumerable / IQueryable / IObservable
6. Can you change the expression tree in IQueryable?

### Entity Framework / ORM
1. Lazy/Eager loading, what are they for?
   - what are the pros and cons?
   - Why use the virtual keyword for navigation properties?
2. What is Dapper and how does it differ from EF Core?
3. What does Context.SaveChanges() unfold into?

### Memory + GC
1. [Memory allocation in the heap](https://learn.microsoft.com/en-us/dotnet/standard/automatic-memory-management)
   - Explicit and implicit memory allocation in the heap
2. Difference between Reference types and Value types (stack vs heap)
3. [Boxing / Unboxing and type casting](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/boxing-and-unboxing)
4. SOH, LOH, STACK (Small)
5. Memory leaks in .net. Where? When? Why?
6. Garbage Collector
7. How many generations. [Garbage collection](https://learn.microsoft.com/ru-ru/dotnet/standard/garbage-collection/fundamentals).
    - Generations: 0, 1, 2
    - Small objects heap (SOH) vs Large objects heap (LOH)
    - Is it possible to change the criterion (85 KB) by which objects are determined to be large objects heap?
8. How many heaps and stacks are there in a .net application?
9. When, how to GC
10. Reference graph
11. Finalizer vs IDisposable
12. [Finalization queue / Freachable queue](https://nabacg.wordpress.com/2012/03/11/what-do-you-know-about-freachable-queue/)
13. [Weak references](https://learn.microsoft.com/en-us/dotnet/standard/garbage-collection/weak-references)? What & Why
14. Disposable, using, try, catch, finally. Howto use it? [Disposable pattern](https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/dispose-pattern).

### Threads
1. Threads vs Processes
2. ThreadPool - what it is?
   - [Habr](https://habr.com/ru/articles/654101/)
3. What configurations can be applied to ThreadPool?
4. Correct [way to kill thread](https://dotnettutorials.net/lesson/how-to-terminate-a-thread-in-csharp/#:~:text=How%20to%20Terminate%20a%20Thread%20in%20C%23%3F,exception%2C%20the%20thread%20is%20terminated.)
5. [Lock Keyword](https://www.c-sharpcorner.com/UploadFile/de41d6/monitor-and-lock-in-C-Sharp/)
6. Deadlock, race conditions
7. Mutex / Semaphore / Monitor
   - [MSDN](https://learn.microsoft.com/en-us/dotnet/standard/threading/overview-of-synchronization-primitives)
   - [Habr](https://habr.com/ru/articles/459514/)
8. Access control to objects
   - What does lock unfold into?
   - What is BlockingСollection, ConcurrentBag?
   - How does Semaphore differ from SemaphoreSlim?
9. Volatile? ThreadStatic? ThreadLocal?
10. Interlocked
11. What are the solutions to work with static but to avoid multithreading issues?

### Async/Await
1. What it is? When it is used?
   - Do you need async/await for a heavy mathematical calculation function? (No, it will still take all the processor time)
2. Difference from multithreading
3. What is a synchronization context? Where is it used?
4. Why is it prohibited to await in lock/Singleton?
5. What is the difference between Task and Thread?
6. async await best practices
   - [David Fowler](https://github.com/davidfowl/AspNetCoreDiagnosticScenarios/blob/master/AsyncGuidance.md)
7. Why is ConfigureAwait() needed and is there a need to use it in ASP.NET Core?
8. What is the difference between ConfigureAwait(true) and ConfigureAwait(false)? In the context of finite state machines, where does the execution return?
9. What is Task? What does it unfold into?

### Data structures and Algorithms
1. Dictionary and HashTable - what for?
   - Why O(1) for adding and finding in c# dictionary?
   - Characteristics of the hash function
   - Types of hashing (chain/open addressing)
   - Ways to resolve collisions
2. [Big-O notation](https://www.freecodecamp.org/news/big-o-notation-why-it-matters-and-why-it-doesnt-1674cfa8a23c/)
3. DateTime vs DateTimeOffset vs TimeSpan
4. List vs LinkedList vs Array

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

### ASP.NET Core
1. [Middleware](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/middleware/?view=aspnetcore-6.0)
2. Requests pipeline
3. What middleware must be in ASP.NET Core?
4. What is an HTTP client factory and why would we use it?
5. What is a retry policy?
6. Difference between HTTP 1.0 and HTTP 2.0
   - What are the HTTP methods
   - HTTP request caching methods
7. Identification, authentication, authorization.
8. What are Cookies, JWT, OIDC?
9. What is HostedService?
10. What health checks are included in the middleware by default, how to connect your own?
11. [What is CORS](https://andrewlock.net/series/understanding-cross-origin-security-headers/)?

### File handling
1. Concurrent access to files
   - What effects can occur when reading/writing concurrently?