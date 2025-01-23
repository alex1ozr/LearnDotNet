# Interview questions (Databases)

1. What types of databases are there?
2. What are the advantages/disadvantages of relational/non-relational databases?
    - What criteria should be used to choose a database?
3. What is [ACID](https://habr.com/ru/post/555920/)?
    - Atomicity
    - Consistency
    - Isolation
    - Durability
4. What is BASE?
5. What is the [CAP theorem](https://habr.com/ru/articles/328792/), why is it true, examples?
6. What is a transaction?
    - How is a transaction ensured?
    - How does a transaction work under the hood?
    - If a transaction is committed, is the change immediately written to the database or stored somewhere else?
    - What are the transaction propagation types, what do they mean, why are they needed? Which ones does PostgreSQL support? Which one is the default? Why?
    - What are the transaction isolation levels? What effect do they have, what effects do they prevent, how are they ensured, how do they work under the hood, why are they used?
7. What is ORM?
    - What are the pros and cons?
8. What is the N+1 problem?
    - How to solve it?
9. What are indexes in a database?
    - What types of indexes are there, what are they used for?
        - [Clustered vs non-clustered indexes](https://ru.wikipedia.org/wiki/Индекс_(базы_данных))
    - In a situation of selection by equality of value, which index is preferable? And for selection by range of indexes, which one?
    - If there is a hash index, and the selection condition is a range, will the index be applied?
    - How to determine which column to index in the database?
    - How to determine that a composite index is needed?
    - Does the order of columns in a composite index matter?
        - If yes, how to determine the order of columns in the index?
    - If there is a composite index, and the selection is made only by the first field, will the index be applied? And if only by the third field? Will it be applied?
10. How does the query planner work?
    - How does the query planner determine whether to use an index or not?
    - In what situations will the index not be used?
    - How can the query execution plan be viewed?
    - How to view the query execution time on current data?
    - Is the query execution plan always the same for the same query?
    - How does the planner decide which query execution plan to create?
11. How does the query optimizer work in a DBMS?
12. What caches are there in a DBMS? (e.g., in PostgreSQL) How do they work? What are they for?
13. Ways to scale a database?
    - What is replication?
    - What is sharding?
    - What is partitioning?
14. What are non-relational databases?
    - What types are there?
    - What are the advantages/disadvantages?
15. What are in-memory databases?
    - What are the advantages/disadvantages?
    - Why can't everything just be stored in Redis?
16. What are temporary tables?
17. How does MS SQL differ from PostgreSQL?
18. Pros and cons of Entity Framework.