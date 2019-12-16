# Chain of Responsibilty

## Problem
- When you want to decouple a request’s sender and receiver
- Multiple objects, determined at runtime, are candidates to handle a request
- When you don’t want to specify handlers explicitly in your code
- When you want to issue a request to one of several objects without specifying the receiver explicitly.

## Lösung
Realisierung von einer Chain of Responsibility.

## Vor- und Nachteile
+ To reduce the coupling degree. Decoupling it will request the sender and receiver.
+ Simplified object. The object does not need to know the chain structure.
+ Enhance flexibility of object assigned duties. By changing the members within the chain or change their order, allow dynamic adding or deleting responsibility.
+ Increase the request processing new class of very convenient.

- The request must be received not guarantee.
- The performance of the system will be affected, but also in the code debugging is not easy may cause cycle call.
- It may not be easy to observe the characteristics of operation, due to debug.

## UML
![UML](https://upload.wikimedia.org/wikipedia/commons/thumb/4/40/Zustaendigkeitskette.svg/944px-Zustaendigkeitskette.svg.png)

## Testcode
[Link](https://github.com/evoltafreak/patterns/blob/master/tests/DesignPatternsTests/DesignPatternsTests/Chain_Of_Responsibilty/ChainOfResponsibiltyTest.cs)

## Prod-Code
[Link](https://github.com/evoltafreak/patterns/blob/master/source/DesignPatterns/src/DesignPatterns/Chain_Of_Responsibilty/ChainOfResponsibilty.cs)
