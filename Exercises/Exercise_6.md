# Exercise 6

### This task extends [the previous one](https://github.com/alex1ozr/LearnDotNet/blob/main/Exercises/Exercise_5.md)

<details>
    <summary>English version</summary>

- Add PostgreSQL as an option to store data for the previously implemented web application
  - Application should be able to work with both databases (SQLite and PostgreSQL)
    - Add a configuration option to choose the database (use IOptions pattern)
  - Use [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/) and [Npgsql.EntityFrameworkCore.PostgreSQL](https://www.nuget.org/packages/Npgsql.EntityFrameworkCore.PostgreSQL/)
  - Use [TestContainers](https://github.com/testcontainers/testcontainers-dotnet) and [Docker](https://www.docker.com/) to run PostgreSQL for Integration Tests
    - Integration tests should use PostgreSQL Database only
  - Refactor the application to comply Clean Architecture principles
  - Write Readme.md with 
    - description of the application (including all API controllers)
    - instructions how to
      - run the application
      - run the tests
      - add/update the database schema using migrations
</details><br/>

<details>
    <summary>Русская версия</summary>

- Добавить PostgreSQL как опцию для хранения данных для ранее реализованного web приложения
  - Приложение должно уметь работать с обоими базами данных (SQLite и PostgreSQL)
    - Добавить опцию конфигурации для выбора базы данных (использовать паттерн IOptions)
  - Использовать [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/) и [Npgsql.EntityFrameworkCore.PostgreSQL](https://www.nuget.org/packages/Npgsql.EntityFrameworkCore.PostgreSQL/)
  - Использовать [TestContainers](https://github.com/testcontainers/testcontainers-dotnet) и [Docker](https://www.docker.com/) для запуска PostgreSQL для интеграционных тестов
    - Интеграционные тесты должны использовать только PostgreSQL
  - Отрефакторить приложение в соответствии с принципами Clean Architecture
  - Написать Readme.md с
    - описанием приложения (включая все API контроллеры)
    - инструкциями по
      - запуску приложения
      - запуску тестов
      - добавлению/обновлению схемы базы данных с помощью миграций
</details>