<h1 align="center"> MicroMarket APIGateway </h1>
<div align="center"><h3> Description </h3></div>

API gateway provides a single entry point for all users of your application into MicroMarket system. 
As a end user, you don't care if you have some fancy microservices architecture, you just want to access the backend in the simplest & most understandable way possible - API gateway gives you an abstraction layer between your services and the user.
Instead of clients sending requests directly to services one by one, they can send them to a central interface.
Then, the API gateway will pass the requests on to the appropriate services.
<div align="center"><h3> Possible benefits </h3></div>

 - Increased simplicity for your users
 - Possibility to gather metrics
 - Better security (you can have only one auth system in the API Gateway service)
 - Input validation
 - Input/response translation to different data formats
 - Routing
 
<div align="center"><h3> Other resources </h3></div>
Zuul by Netflix (take a read, you won't regret it): <br>
https://github.com/Netflix/zuul/wiki <br>
Ocelot: <br>
https://github.com/ThreeMammals/Ocelot <br>
Ntrada: <br>
https://github.com/snatch-dev/Ntrada <br>
