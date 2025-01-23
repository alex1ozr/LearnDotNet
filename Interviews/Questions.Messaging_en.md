# Interview questions (Messaging)

## General questions
1. What is Kafka?
    - How does it work? What are topics and partitions?
    - Why is Kafka not a queue? How is Kafka different from a queue (RMQ)?
    - What are the configurations of Kafka?
    - What are the message delivery guarantees in Kafka?
    - Suppose the fact of sending a message to Kafka was not committed and we try to send it again? Will there be two messages in Kafka? Why is it bad? How to fix it? (idempotence)
        - What are the options/examples of implementing idempotent message processing?
    - Suppose a consumer read a message from Kafka, the message processing somehow failed, and the consumer did not commit the offset. What will happen? How to fix it? (if the error is repetitive, then the partition is blocked, it needs to be moved to the Dead Letter Queue)
    - What are the guarantees of message order preservation when delivering through Kafka? (within a partition)
    - What is the measure of parallelism in Kafka? (number of partitions in a topic)
    - How to specify to consumers that they should listen to one partition? (put them in one Consumer Group)
    - If there is 1 partition in a topic, and the topic is listened to by a consumer group of 2 consumers, how many consumers will work, how many will be idle?
        - If, on the contrary, there are 2 partitions and 1 consumer group? What will happen?
        - If there are 4 partitions and 5 consumers? What will happen?
2. What is Rabbit MQ?
    - How does it work? What are exchange, queue, and binding?