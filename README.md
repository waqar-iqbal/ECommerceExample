# ECommerceExample

A simple .Net API endpoint that receives an object representing a typical e-commerce order and saves it into database.

I've tried to use DDD and push as much logic as I could into the domains, as well forcing the use of constructors when creating new instances of the domain models.

I look up the price of the products form the database as we can't trust the front end client to send us that information.

I've added some basic validation and I throw an exception with some details as to the problem.

By Waqar Iqbal
