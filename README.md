# KATA.Supermarket

Subject statement:

The problem domain is something seemingly simple: pricing goods at supermarkets.
 
Some things in supermarkets have simple prices: this can of beans costs $0.65. Other things have more complex prices. For example:
- three for a dollar (so what’s the price if I buy 4, or 5?)
- $1.99/pound (so what does 4 ounces cost?)
- buy two, get one free (so does the third item have a price?)

Here you will find my implementation of a code in .NET Core, using TDD and S.O.L.I.D principles

Using Visual Studio 2019. The solution KATA.Supermarket includes two projects:
- KATA.Supermarket.Test: MSTest (.Net Core) test project
- KATA.Supermarket: Class Library (.NET Core) 

The approach is to write simple test case first then using the refactor menu item "Generate new method..." to generate the item class into the library project

Use cases:
1) Items should have a name associated to it
2) Items should have a unique item number
3) Items should have a price

I'm using Factory pattern to build an item which it has a name,  a price and a unique id
Then now I'm using Factory Pattern to build cans of something in my Grocery and then refactor library and test projects
Ex: Cans of beans 0.65€, Cans of corns 0.85€

Also I'm using Composite pattern because a cart is composed with multiple items
Ex: 1 Can of beans 0.65€ + 1 Can of corns 0.85€ then my cart is 1.5€
