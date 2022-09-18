# Вопросы на собеседованиях

1. [Принципы ООП](https://habr.com/ru/company/otus/blog/525336/)
3. SOLID
    - [Single Responsibility Principle](https://metanit.com/sharp/patterns/5.1.php) (Принцип единственной обязанности)
    - [Open/Closed Principle](https://metanit.com/sharp/patterns/5.2.php) (Принцип открытости/закрытости)
    - [Liskov Substitution Principle](https://metanit.com/sharp/patterns/5.3.php) (Принцип подстановки Лисков)
    - [Interface Segregation Principle](https://metanit.com/sharp/patterns/5.4.php) (Принцип разделения интерфейсов)
    - [Dependency Inversion Principle](https://metanit.com/sharp/patterns/5.5.php) (Принцип инверсии зависимостей)
5. Что такое [GRASP](https://habr.com/ru/post/92570/)?
6. Что такое иерархия типов?
7. Расскажи про устройство памяти
8. Сколько поколений есть в GC. [Сборка мусора](https://learn.microsoft.com/ru-ru/dotnet/standard/garbage-collection/fundamentals).
    - Поколения: 0, 1, 2
    - Куча малых объектов (SOH) и Куча больших объектов (LOH)
10. [Class vs Struct](https://c-sharp.pro/классы-или-структуры-в-чем-отличия/)
11. Abstract class vs Interface
12. Static class vs Singleton
13. Event vs delegate
14. Lambda vs delegate
15. Reference and value types
16. Stack & heap
17. Destructor & IDisposable
18. Что такое идемпотентность и как применяется?
19. [out/ ref/ in](https://www.pluralsight.com/guides/csharp-in-out-ref-parameters)
20. Устройство коллекций в .NET
21. отличие массива и списка
22. default значение
23. Generic класс - что такое?
24. IEnumerable vs IQuerieble
25. StringBuilder vs String.Concat()
26. DateTime vs DateTimeOffset vs TimeSpan
27. List vs LinkedList
28. ASP.NET Core как устроена работа с запросами? 
29. ASP.NET Core что такое Middleware и как используется?
30. Модель OSI
31. TCP vs UDP
32. TLS vs SSL
33. HTTP методы
34. JWT токены что такое и как работает
35. Deadlock, race conditions
36. Task & Thread
37. Примитивы синхронизации (Mutex, Monitor, Semaphore, Interlocked)
38. PLINQ AsParallel когда надо применять?
39. Producer/Consumer pattern
40. Почему нельзя await  в lock/Singleton
41. async await Threads
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
48. Immutability
49. DDD/TDD etc.
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
75. Difference between 301 (permanent) and 302 types of redirection?
