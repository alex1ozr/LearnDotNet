# Exercise 1

### A classic task that tests knowledge of OOP principles and the ability to work with objects.

<details>
    <summary>English version</summary>

- Build a hierarchy of classes that describe objects in the warehouse: pallets, and boxes.
- In addition to the general set of standard properties (Id, width, height, depth, weight), a pallet can contain boxes.
- The box must have either an expiration date or a production date. If a production date is specified, then the expiration date is calculated from the production date plus 100 days.
- Pallet expiration date is calculated as the shortest expiration date of the nested box nested. The weight of the pallet is calculated as the sum of the weight of the nested boxes + 30kg.
- The volume of the box is calculated as the product of width, height, and depth.
- The volume of a pallet is calculated as the sum of the volume of all boxes on it and the product of the pallet’s width, height, and depth.
- Each box should not exceed the dimensions of the pallet (in terms of width and length)
- Organize the writing and reading of the collection to/from the file.
- Group all pallets by expiration date, and sort them in ascending order of expiration date. Sort pallets by weight in each group. Display the result on the screen.
- Display the top 3 pallets that contain the boxes with the longest shelf life, sorted in ascending order of volume.
- Cover your code with unit tests
</details><BR>

<details>
  <summary>Русская версия</summary>

- Построить иерархию классов, описывающих объекты на складе - паллеты и коробки.
- Помимо общего набора стандартных свойств (Id, ширина, высота, глубина, вес), паллета может содержать в себе коробки.
- У коробки должен быть указан срок годности или дата производства. Если указана дата производства, то срок годности вычисляется из даты производства плюс 100 дней.
- Срок годности паллеты вычисляется из наименьшего срока годности коробки, вложенной в паллету. Вес паллеты вычисляется из суммы веса вложенных коробок + 30кг.
- Объем коробки вычисляется как произведение ширины, высоты и глубины.
- Объем паллеты вычисляется как сумма объема всех находящихся на ней коробок и произведения ширины, высоты и глубины паллеты.
- Каждая коробка не должна превышать по размерам паллету (по ширине и длине)
- Организовать запись и чтение коллекции в/из файл.
- Сгруппировать все паллеты по сроку годности, отсортировать по возрастанию срока годности, в каждой группе отсортировать паллеты по весу. Результат вывести на экран.
- Вывести на экран 3 паллеты, которые содержат коробки с наибольшим сроком годности, отсортированные по возрастанию объема.
- Покрыть unit-тестами
</details>
