# Interview questions

### OOP
1. [OOP Principles](https://habr.com/ru/company/otus/blog/525336/)
2. [Class vs Struct](https://c-sharp.pro/классы-или-структуры-в-чем-отличия/)
3. Inheritance
4. Abstract vs Interface
    - What's new in c#8? [Interface default implementations](https://devblogs.microsoft.com/dotnet/default-implementations-in-interfaces/)
5. Difference between protected / internal / protected internal.
6. Generics

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
3. Type safety / [duck typing in .net](https://stackoverflow.com/questions/21278078/what-is-interface-duck-typing) (dynamics, foreach)
4. Default value of type
5. Type members / constructors [initialization order](https://stackoverflow.com/questions/40139099/auto-property-initialization-il-instruction-order)

### LINQ
1. LINQ
2. Delegates - what it is? Event vs Delegate.
3. Anonymous types / methods / Lambdas
4. Extension methods
5. Enumerable / IQueryable / IObservable

### Memory + GC
1. Difference between values and references (stack vs heap)
2. Boxing / Unboxing
3. SOH, LOH, STACK (Small)
4. Memory leaks in .net. Where? When? Why?
5. Garbage Collector
6. How many generations. [Garbage collection](https://learn.microsoft.com/ru-ru/dotnet/standard/garbage-collection/fundamentals).
    - Generations: 0, 1, 2
    - Small objects heap (SOH) vs Large objects heap (LOH)
7. When, how to GC
8. Reference graph
9. Finalizer vs IDisposable
10. Finalization queue / Reachable queue
11. Weak references? What & Why
12. Disposable, using, try, catch, finally. Howto use it? Disposable pattern.

### Threads
1. Threads vs Processes
2. ThreadPool - what it is?
3. Correct way to kill thread
4. Lock Keyword
5. Deadlock, race conditions
6. Mutex / Semaphore / Monitor
7. Volatile? ThreadStatic? ThreadLocal?
8. Interlocked
9. What are the solutions to work with static but to avoid multithreading issues?

### Async/Await
1. What it is? When it is used?
2. Difference from multithreading
3. Why is it prohibited to await in lock/Singleton?

### Data structures and Algorithms
1. Dictionary and HashTable - what for?
    - Why O(1) for adding and finding in c# dictionary? questions about collision
2. Big-O notation
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
5. Static class vs Singleton
6. Producer/Consumer pattern
7. DDD/TDD etc.
8. Idempotence
9. CQRS+Event Sourcing
10. Saga vs 2nd phase commit
11. How do you define good code?
12. What are the most used design patterns and how do they work?
13. How can you add to the application build-in .net core dependency injection to help to implement principle D in SOLID?
14. In a high scalable app which is decomposed to modules, what solution would you suggest to decompose dependency injection logic? How to ensure modularity and scalability? Reflection? 

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
4. Clustered vs non-clustered indexes
5. WHERE vs HAVING
6. How can databases store data efficiently?
7. You’ve been investigating slow api, some select queries take too much time, how to investigate why they are slow?

### ASP.NET Core
1. Middleware
2. Requests pipeline

### System Design
1. Service for shortening urls, how we can create systems like this, what database, architecture, cache, etc. to use?
