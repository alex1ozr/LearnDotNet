# Notification system

## Requirements and Goals of the System
The Notification system should have the following features:

- An authenticated API endpoint to trigger notifications from any backend or microservice.
- Support for various channels like Email, SMS, and Push by integrating with their respective APIs.
- Users should be able to choose their preferences for each notification type and channel.
- Respect service limits of downstream services to prevent throttling or suspension.
- The system should be horizontally scalable to handle potentially unlimited scaling.

## Solution

![Example](https://uploads-ssl.webflow.com/62848c86f245f1727f6ea541/6298e496b63f6d1957fba24f_6261788f597b292e2732eb02_Technical%2520Designs(3).png)

[Full solution](https://www.notificationapi.com/blog/notification-service-design-with-architectural-diagrams)