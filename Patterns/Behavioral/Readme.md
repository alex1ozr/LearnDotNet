# Паттерны поведения
### Стратегия (Strategy)
[Паттерн Strategy](https://metanit.com/sharp/patterns/3.1.php) позволяет менять выбранный алгоритм независимо от объектов-клиентов, которые его используют.

### Шаблонный метод (Template method)
[Поведенческий шаблон проектирования](https://metanit.com/sharp/patterns/3.4.php), определяющий основу алгоритма и позволяющий наследникам переопределять некоторые шаги алгоритма, не изменяя его структуру в целом.

### Посредник (Mediator)
[Поведенческий шаблон проектирования](https://metanit.com/sharp/patterns/3.9.php), обеспечивающий взаимодействие множества объектов, формируя при этом слабое зацепление и избавляя объекты от необходимости явно ссылаться друг на друга.
Заменяет взаимодействие "все со всеми" взаимодействием "один со всеми".

### Итератор (Iterator)
[Шаблон проектирования](https://metanit.com/sharp/patterns/3.5.php), предоставляющий объект, позволяющий получить последовательный доступ к элементам объекта-агрегата без использования описаний каждого из агрегированных объектов.

### Наблюдатель (Observer)
[Реализует у класса механизм](https://metanit.com/sharp/patterns/3.2.php), который позволяет объекту этого класса получать оповещения об изменении состояния других объектов и тем самым наблюдать за ними.

### Посетитель (Visitor)
[Поведенческий шаблон проектирования](https://metanit.com/sharp/patterns/3.11.php), описывающий операцию, которая выполняется над объектами других классов. При изменении посетителя нет необходимости изменять обслуживаемые классы.

### Команда (Command)
[Поведенческий шаблон проектирования](https://metanit.com/sharp/patterns/3.3.php), представляющий действие. Объект команды заключает в себе само действие и его параметры.

### Состояние (State)
[Поведенческий шаблон проектирования](https://metanit.com/sharp/patterns/3.6.php), позволяющий объекту изменять свое поведение в зависимости от текущего внутреннего состояния состояния.

### Цепочка обязанностей (Chain of responsibility)
[Поведенческий шаблон проектирования](https://metanit.com/sharp/patterns/3.7.php), позволяющий избежать привязки отправителя запроса к его получателю, разрешая обработать запрос нескольким объектам. 
Связывает объекты-получатели в цепочку и передает запрос следующему по цепочке обработчику.
