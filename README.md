## Command Query Responsibility Segregation, or CQRS, is a software development architecture pattern that summarizes separating reading and writing into two models: query and command, one for reading and one for writing data, respectively.
## - Query model: responsible for reading the data from the DB and updating the graphical interface.
## - Command model: responsible for writing data in the DB and validating the data. Its interaction with the graphical interface is only to receive the data to be written.
## In this example we will show how to implement it in a simple way using mediator.
