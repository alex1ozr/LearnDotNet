# Exercise 3

### This task extends [the previous one](https://github.com/alex1ozr/LearnDotNet/blob/main/Exercises/Exercise_2.md)

<details>
    <summary>English version</summary>

- Develop ASP .NET Web API application (.NET 6) with specified functionality:
  - Create / change / delete pallets
  - Add/Change/Remove boxes from a specific pallet
  - Getting a pallet by ID
  - Getting a list of pallets with pagination (how many pallets to get & how many to skip)
- Implement the following technologies:
  - Automapper
  - FluentValidation
  - EF Core 6 over SQLite
  - Swagger
  - DI (ServiceCollection / Autofac / any container of your choice)
- Divide the solution into projects corresponding to layers:
  - Storage (EF context)
  - Business logic
  - web API
  - Tests
- Consider the following points:
  - EF entities != DTOs
</details><br/>

<details>
    <summary>Русская версия</summary>

Является развитием [предыдущего задания](https://github.com/alex1ozr/LearnDotNet/blob/main/Exercises/Exercise_2.md).
- Разработать ASP .NET Web Api приложение (.NET 6) с функционалом:
  - Создание / изменение / удаление паллет
  - Добавление / Изменение / удаление коробок с конкретной паллеты
  - Получение паллеты по ИД
  - Получение списка паллет с пагинацией (сколько паллет получить + сколько пропустить)
- Внедрить следующие технологии:
  - Automapper
  - [FluentValidation](https://github.com/FluentValidation/FluentValidation)
  - EF Core 6 с хранением данных в SQLite
  - Swagger
  - DI (ServiceCollection / Autofac / любой контейнер на ваш выбор)
- Разбить решение на проекты, соответствующие слоям:
  - Хранилище (EF-контекст)
  - Бизнес-логика
  - Web api
  - Тесты
- Учесть следующие моменты:
  - Сущности EF != DTO
</details>
