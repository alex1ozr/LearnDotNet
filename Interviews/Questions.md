# Вопросы на собеседованиях

### OOP
1. [OOP Principles](https://habr.com/ru/company/otus/blog/525336/)
2. [Class vs Struct](https://c-sharp.pro/классы-или-структуры-в-чем-отличия/)
3. Inheritance
4. Abstract vs Interface
    - What's new in c#8? [Inteface default implementations](https://devblogs.microsoft.com/dotnet/default-implementations-in-interfaces/)
5. Difference between protected / internal / protected internal.
6. Generics

### Immutable
1. String / StringBuilder - what and why?
2. GetHashCode. What it is, what it for, Which requirements
3. Whats immutable? whats for?

### .NET
1. Ref and out parameters?
2. Readonly / Const - difference?
3. Type safety / [duck typing in .net](https://stackoverflow.com/questions/21278078/what-is-interface-duck-typing) (dynamics, foreach)
4. default value of type

### LINQ
1. LINQ
2. Delegates - what it is? Event vs Delegate.
3. Anonymous types / methods / Lambdas
4. Extension methods
5. Enumerable / IQueryable / IObservable

### Memory + GC
1. Difference between values and references (stack vs heap)
2. Boxing / Unboxig
3. SOH, LOH, STACK (Small)
5. Memory leaks in .net. Where? When? Why?
6. Garbage Collector
7. How many generations. [Сборка мусора](https://learn.microsoft.com/ru-ru/dotnet/standard/garbage-collection/fundamentals).
    - Generations: 0, 1, 2
    - Куча малых объектов (SOH) и Куча больших объектов (LOH)
8. When, how to GC
9. Reference graph
10. Finalizer vs IDisposable
11. Finalization queue / Reachable queue
12. Weak references? What & Why
13. Disposable, using, try, catch, finally. Howto use it? Disposable patterm.

### Threads
1. Threads vs Processes
2. ThreadPool - what it is?
3. Correct way to kill thread
4. Lock Kevword
5. Deadlock, race conditions
6. Mutex / Semafor / Monitor
7. Volatile? ThreadStatic?

### Async/Await
1. What it is? When it use?
2. Difference from multithreading
3. Why is it prohibited to await in lock/Singleton?

### Data structures and Algorythms
1. Dictionary and HashTable - what for?
2. Big-O notation
3. DateTime vs DateTimeOffset vs TimeSpan
4. List vs LinkedList

### Principles / Patterns
1. Design pattern / antipattern (which design patterns you know?)
2. SOLID
    - [Single Responsibility Principle](https://metanit.com/sharp/patterns/5.1.php) (Принцип единственной обязанности)
    - [Open/Closed Principle](https://metanit.com/sharp/patterns/5.2.php) (Принцип открытости/закрытости)
    - [Liskov Substitution Principle](https://metanit.com/sharp/patterns/5.3.php) (Принцип подстановки Лисков)
    - [Interface Segregation Principle](https://metanit.com/sharp/patterns/5.4.php) (Принцип разделения интерфейсов)
    - [Dependency Inversion Principle](https://metanit.com/sharp/patterns/5.5.php) (Принцип инверсии зависимостей)
4. Inversion of control
5. [GRASP](https://habr.com/ru/post/92570/)
6. Static class vs Singleton
7. Producer/Consumer pattern
8. DDD/TDD etc.

### Testing
1. Tests - howto? Unit \ Integration tests? What's difference?
2. Fake vs Mock vs Stub

# Network
1. Модель OSI
2. TCP vs UDP
3. TLS vs SSL
4. HTTP методы
5. JWT tokens
6. [Difference between 301 (permanent) and 302 types of redirection?](https://www.domain.com/blog/what-is-a-redirect/)


17. Destructor & IDisposable
18. Что такое идемпотентность и как применяется?
19. [out/ ref/ in](https://www.pluralsight.com/guides/csharp-in-out-ref-parameters)
20. Устройство коллекций в .NET
21. отличие массива и списка
22. 
26. 
27. 
28. ASP.NET Core как устроена работа с запросами? 
29. ASP.NET Core что такое Middleware и как используется?

35. 

37. Примитивы синхронизации (Mutex, Monitor, Semaphore, Interlocked)
38. PLINQ AsParallel когда надо применять?
39. 
40. 
42. Уровни изоляции тразакций
43. [ACID](https://habr.com/ru/post/555920/)
    - Atomicity — Атомарность
    - Consistency — Согласованность
    - Isolation — Изолированность
    - Durability — Надёжность
44. Индексы в БД. Что такое? Какие бывают?
45. Кластерные и не кластерные индексы
46. Временные таблицы. Что такое? Какие бывают?
47. CQRS+Event Sourcing
50. Saga vs 2nd phase commit
51. WHERE vs HAVING 
52. How do you define good code?
53. How would you ensure scalability of code? What are the principles of good code (SOLID)?
54. What are the most used design patterns and how do they work?
55. How can you add to the application build-in .net core dependency injection to help to implement principle D in SOLID? 
56. In a high scalable app which is decomposed to modules, what solution would you suggest to decompose dependency injection logic? How to ensure modularity and scalability? Reflection? 
57. Differences between Constants and Readonly fields?
58. What is the criteria of value that could be set to a constant field?
59. What is static, what are the risks behind static fields, why to use them?
60. What are the solutions to work with static but to avoid multithreading issues?
61. Thread static attribute?
62. You’ve been investigating slow api, some select queries take too much time, how to investigate why they are slow?
63. How can databases store data efficiently ?
64. What is the purpose of index in db? 
65. Why O(1) for adding and finding in c# dictionary? questions about collision
66. What's your definition of a clean code? What things to avoid?
67. Solid, example of single responsibility?
68. Design patterns, did you have a case when you used it?
69. What is dependency injection, how does it help the project?
70. Value types and reference types differences?
71. How do you delete reference type from a memory? questions about garbage collector, finalizing method
72. String types, why are special types in c#, is it value types or reference types?
73. Questions about string builder
74. Service for shortening urls bitly, how we can create systems like this, what database, architecture, cache, etc to use?
75. 
