# High-Quality-Code
Design Patterns - Creational Patterns; Design Patterns - Structural Patterns; Design Patterns - Behavioral Patterns; Refactoring 
1. Creational Patterns:

    a) Singleton:
      - always is sealed class with: private static Singleton instance, private constructor and one getter- public static Singleton GetInstance (see Standard Singleton);
      - always is with only one instance;
      - Lazy and Eager loading in Singleton;
       Real World Usages:
      - Logging, Managing a connection or a pool of connections to Database, Printer spooling, File, Configuration, Cache, Session based shopping cart;
    
    b) Simple Factory:
      - remember the drawing with the factory, which accept paper (like input) and produces paper boxes; the client doesn't know and doesn't understand factory logic;
      - creates objects without exposing the instantion logic to the client;
      - folder with enumeration;
      - static class Factory with method "CreateProduct"- accept the product type(enum) and return the whole product;
     
     c) Factory Method:
      - we create the object without exposing the creation logic. In this pattern, an interface is used for creating an object, but let subclass decide which class to instantiate. The           creation of object is done when it is required. The Factory method allows a class later instantiation to subclasses.
