# Interview questions (Architecture)

## General questions
1. What is a monolith?
    - What are its advantages?
    - What are its disadvantages?
    - What problems does it solve?
    - What problems does it introduce?
2. What is a microservice?
    - What are its advantages?
    - What are its disadvantages?
    - What problems does it solve?
    - What problems does it introduce?
    - What are the options for interaction between two microservices? (network, queues, databases, files)
3. What network interactions do you know? (synchronous, asynchronous)
    - Which ones are used and why? What are the advantages? Disadvantages?
    - What to do if a request fails? (retries)
        - How to organize retries? (exponential backoff + jitter)
        - How to choose a retry limit? What will you do if all retries fail?
        - How long can a request be executed, will it wait for all these retries? (timeouts)
            - What timeouts should be set for which operations? How?
4. Suppose a service can handle 10 rps, but we start receiving 1000 rps, how to fix it? (rate limiter)
    - What rate limiter algorithms exist?
5. Suppose microservice A calls microservice B synchronously, the call takes 100 ms. We have 100 rps on A. And suddenly B starts responding not in 100ms but in 3000ms.
   - What will happen? Why is it bad? What are the options for fixing it?
6. There is the following architecture: reading from a queue, writing to a database, sending to another queue. How to make the system fault-tolerant (read from the first queue, but did not have time to send to the next one).
   - The use of the Transactional Outbox pattern is expected.
7. Difference between SOA and microservices architecture.

## System design
1. URL shortening service, how can we create such a system, what database, architecture, cache, etc. to use?