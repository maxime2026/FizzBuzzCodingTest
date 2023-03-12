# FizzBuzzCodingTest


# Summary
Fizz buzz is a group word game for children to teach them about division. Players take turns to count incrementally, replacing any number divisible by three with the word “fizz”, and any number divisible by five with the word “buzz”

# Installation
Set-up Microsoft .Net Core SDK 6.0 or Runtime Microsoft .Net Core 6.0

# Usage
- Clone the repository FizzBuzzCodingTest
- Open Visual Studio 2022
- Start Debugging the application
	- By default args argument is 20
	- To modify the range, go to Properties/launchSettings.json and update commandLineArgs value

# Details
I have spent 1h50 on the test. 

The main difficulty was to implement a true SOLID application where:
- Each class/method has one purpose
- We dont modify, we extend (like adding more game conditions)
- using correctly dependency injection

I did notice the test was mentioning reflection. I assume the goal was to have all game condtions in one class and use something like myclass.GetType().GetMethods() and Invoke them. It would have made easy to extend by just adding a new method representing a new condition in the class. However, it would make the class too loosy. I am thinking of another developer modifying this class without realizing it has a precise structure/goal and so breaking the game. It is why I went for a solution where we have one game condition per class and we need to add it to our list of game conditions to apply to our game (more strongly couple approach).

# Issues
- When I was having a second look the next day, I realize one major issue. FizzBuzzService depends directly to my GameCondition classes. So, Some of my unit tests in FizzBuzzServiceTest, not only test FizzBuzzService but test my GameConditions implementation at the same time. It should not be the case. We should test FizzBuzzService without to rely on GameCondition (just mock it to control the behavior). We are clearly not respecting Dependency Inversion Principle here.

- Possible solution would have been to use 3 fizzbuzz rule classes as a service class, to easily mock it. Unfortunately, it would have mean to change some tests (bad TDD!) and not respecting the time allow to the test.

# Possible improvement
- Have better naming in some methods/properties
- Add store service with in memory database to store game conditions
- Having more customize game conditions 
	- having one type of class with method bool IsValid(int number, int divideNumber) instead of having one type of class with a static rule in it
- Add integration tests

# Author
Maxime Fleury
