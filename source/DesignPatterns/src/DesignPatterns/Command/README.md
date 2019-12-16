# Command

## Problem

## Lösung
Verwendung des Command-Patterns.

## Vor- und Nachteile
+ Makes our code extensible as we can add new commands without changing existing code.
+ Reduces coupling the invoker and receiver of a command.

- Increase in the number of classes for each individual command

## UML
![Image description](https://upload.wikimedia.org/wikipedia/commons/thumb/b/bf/Command_pattern.svg/1400px-Command_pattern.svg.png)

## Testcode
[Link](https://github.com/evoltafreak/patterns/blob/master/tests/DesignPatternsTests/DesignPatternsTests/Command/CommandTest.cs)

## Prod-Code
[Link](https://github.com/evoltafreak/patterns/blob/master/source/DesignPatterns/src/DesignPatterns/Command/Command.cs)
