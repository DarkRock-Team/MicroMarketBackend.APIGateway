## MicroMarket APIGateway
 **Description**<br>
API gateway provides a single entry point for all users of your application into MicroMarket system. 
As a end user, you don't care if you have some fancy microservices architecture, you just want to access the backend in the simplest & most understandable way possible - API gateway gives you an abstraction layer between your services and the user.
Instead of clients sending requests directly to services one by one, they can send them to a central interface.
Then, the API gateway will pass the requests on to the appropriate services.

## Possible benefits

 - Increased simplicity for your users
 - Possibility to gather metrics
 - Better security (you can have only one auth system in the API Gateway service)
 - Input validation
 - Input/response translation to different data formats
 - Routing
 
## Other resources
Zuul by Netflix (take a read, you won't regret it):
https://github.com/Netflix/zuul/wiki
Ocelot:
https://github.com/ThreeMammals/Ocelot
Ntrada:
https://github.com/snatch-dev/Ntrada
