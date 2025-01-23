# Вопросы для интервью (.NET)

### Общие вопросы по сборкам
1. Что такое сборка?
2. Что такое EXE и DLL?
3. Что такое JIT?

### ООП
1. [Принципы ООП](https://habr.com/ru/company/otus/blog/525336/)
2. [Класс vs Структура](https://c-sharp.pro/классы-или-структуры-в-чем-отличия/)
3. [Record class vs record struct](https://falberthen.github.io/posts/cs10-records/)
4. Наследование
5. Абстрактный класс vs Интерфейс
   - Что нового в c#8? [Реализации по умолчанию в интерфейсах](https://devblogs.microsoft.com/dotnet/default-implementations-in-interfaces/)
6. Разница между protected / internal / protected internal.
7. Обобщения (Generics)

### Неизменяемость
1. String / StringBuilder - что и почему?
   - Типы строк, почему это особые типы в c#, являются ли они значимыми или ссылочными типами?
   - Что такое интернирование строк?
2. GetHashCode. Что это, для чего, какие требования
3. Что такое неизменяемость? Для чего она нужна?

### .NET
1. [out/ ref/ in](https://www.pluralsight.com/guides/csharp-in-out-ref-parameters)
   - Можно ли ref и out использовать как со значимыми, так и со ссылочными?
2. Статические / readonly / Константные поля - разница?
   - Каковы критерии значения, которое можно установить в константное поле?
   - Что такое статическое, какие риски связаны со статическими полями, зачем их использовать?
3. Что такое методы расширения? Какие риски связаны с ними?
4. Безопасность типов / [утиная типизация в .net](https://stackoverflow.com/questions/21278078/what-is-interface-duck-typing) (динамика, foreach)
5. Значение по умолчанию для типа
6. Члены типа / конструкторы [порядок инициализации](https://stackoverflow.com/questions/40139099/auto-property-initialization-il-instruction-order)
7. Ковариантность vs Контрвариантность
   - [MSDN](https://learn.microsoft.com/en-us/dotnet/standard/generics/covariance-and-contravariance)
   - [Metanit](https://metanit.com/sharp/tutorial/3.27.php)
8. Что такое Рефлексия?

### LINQ
1. LINQ
2. Делегаты - что это? Событие vs Делегат.
3. Анонимные типы / методы / Лямбды
4. Методы расширения
5. Enumerable / IQueryable / IObservable

### Память + GC
1. Разница между ссылочными и значимыми типами (стек vs куча)
2. [Упаковка / Распаковка и приведение типов](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/boxing-and-unboxing)
3. SOH, LOH, STACK (Маленький)
4. Утечки памяти в .net. Где? Когда? Почему?
5. Сборщик мусора
6. Сколько поколений. [Сборка мусора](https://learn.microsoft.com/ru-ru/dotnet/standard/garbage-collection/fundamentals).
   - Поколения: 0, 1, 2
   - Куча малых объектов (SOH) vs Куча больших объектов (LOH)
   - Можно ли изменить критерий (85 КБ), по которому объекты определяются как большие объекты?
7. Сколько бывает куч и стэков в рамках .net приложения?
8. Когда и как использовать GC
9. Граф ссылок
10. Финализатор vs IDisposable
11. [Очередь финализации / Очередь Freachable](https://nabacg.wordpress.com/2012/03/11/what-do-you-know-about-freachable-queue/)
12. [Слабые ссылки](https://learn.microsoft.com/en-us/dotnet/standard/garbage-collection/weak-references)? Что и зачем
13. Disposable, using, try, catch, finally. Как использовать? [Шаблон Disposable](https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/dispose-pattern).

### Потоки
1. Потоки vs Процессы
2. Пул потоков - что это?
   - [Habr](https://habr.com/ru/articles/654101/)
3. Правильный [способ завершения потока](https://dotnettutorials.net/lesson/how-to-terminate-a-thread-in-csharp/#:~:text=How%20to%20Terminate%20a%20Thread%20in%20C%23%3F,exception%2C%20the%20thread%20is%20terminated.)
4. [Ключевое слово Lock](https://www.c-sharpcorner.com/UploadFile/de41d6/monitor-and-lock-in-C-Sharp/)
5. Взаимоблокировка, состояния гонки
6. Mutex / Semaphore / Monitor
   - [MSDN](https://learn.microsoft.com/en-us/dotnet/standard/threading/overview-of-synchronization-primitives)
   - [Habr](https://habr.com/ru/articles/459514/)
7. Управление доступом к объектам
   - Во что разворачивается lock?
   - Что такое BlockingСollection, ConcurrentBag?
   - Чем отличается semaphore от semaphoreSlim?
8. Volatile? ThreadStatic? ThreadLocal?
9. Interlocked
10. Какие решения для работы со статическими данными, чтобы избежать проблем многопоточности?

### Async/Await
1. Что это? Когда используется?
   - Нужны ли async/await для тяжелой математической функции?
     - Нет она всё равно займёт всё процессорное время
2. Разница с многопоточностью
3. Что такое контекст синхронизации? Где используется?
4. Почему запрещено использовать await в lock/Singleton?
5. Лучшие практики async await
   - [David Fowler](https://github.com/davidfowl/AspNetCoreDiagnosticScenarios/blob/master/AsyncGuidance.md)

### Структуры данных и Алгоритмы
1. Dictionary и HashTable - для чего?
   - Почему O(1) для добавления и поиска в c# dictionary? вопросы о коллизиях
2. [Нотация Big-O](https://www.freecodecamp.org/news/big-o-notation-why-it-matters-and-why-it-doesnt-1674cfa8a23c/)
3. DateTime vs DateTimeOffset vs TimeSpan
4. List vs LinkedList vs Array

### Тестирование
1. Тесты - как? Unit \ Интеграционные тесты? В чем разница?
2. Fake vs Mock vs Stub

### Сеть
1. Модель OSI
2. TCP vs UDP
3. TLS vs SSL
4. HTTP методы
5. JWT токены
6. [Разница между 301 (постоянный) и 302 типами редиректа?](https://www.domain.com/blog/what-is-a-redirect/)

### ASP.NET Core
1. [Middleware](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/middleware/?view=aspnetcore-6.0)
2. Жизненный цикл запроса в ASP.NET
3. Что такое фабрика HTTP клиентов и зачем она нужна?
4. Что такое политика повторных попыток?
5. Разница между HTTP 1.0 и HTTP 2.0
   ○ Какие бывают HTTP методы
   ○ Методы Кэширования HTTP запросов