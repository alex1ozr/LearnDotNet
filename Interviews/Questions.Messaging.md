# Interview questions (Messaging)

## General questions
1. Что такое Kafka?
   - Как работает? что такое топики, партиции?
   - Почему Kafka это не очередь? чем Kafka отличается от очереди?
   - Какие бывают конфигурации Kafka?
   - Какие гарантии доставки сообщений в Kafka?
   - Допустим, не закоммитился факт отправки сообщения в кафку и мы перепопробуем отправить ещё раз? в кафке будет два сообщения? чем плохо? как полечить? (идемпотентность)
     - Какие бывают варианты/примеры осуществления идемпотентности обработки сообщений?
   - Допустим, консьюмер считал сообщение из кафки, обработка сообщения как-то упала и консьюмер не закоммитил оффсет. чо будет? как полечить? (если ошибка повторяющаяся, то блокировка партишена, надо перекладывать в Dead Letter Queue)
   - Какие гарантии сохранения порядка сообщений при доставке через кафку? (в пределах партиции).
   - Что является мерой параллельности в кафке? (число партишенов в топике)
   - Как указать косньюмерам чтобы они слушали одну партицию? (положить их в один Consumer Group)
   - Если в топике 1 партиция, топик слушает консьюмер груп из 2 консьюмеров, сколько консьюмеров будет работать, сколько простаивать? 
     - Если наоборот, 2 партиции и 1 консьюмер групп? Что будет? 
     - Если 4 партиции и 5 консьюмеров? Что будет?
2. Что такое Rabbit MQ
   - Как работает? что такое exchange, queue, binding?