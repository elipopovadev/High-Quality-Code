# High-Quality-Code
Design Patterns - Creational Patterns; Design Patterns - Structural Patterns; Design Patterns - Behavioral Patterns; Refactoring 
1. Creational Patterns:

    a) Singleton:
      - this pattern ensures that a class has only one instance and provides a global point of access to it;
      - always is sealed class with: private static Singleton instance, private constructor and one getter- public static Singleton GetInstance (see Standard Singleton);
      - class could have methods, fields or properties;
      - Lazy and Eager loading in Singleton;       
      - real world usages: Logging, Managing a connection or a pool of connections to Database, Printer spooling, File, Configuration, Cache, Session based shopping cart;
    
    b) Simple Factory Design Pattern:
      - remember the drawing with the factory, which accept paper (like input) and produces paper boxes; the client doesn't know and doesn't understand factory logic;
      - A factory is an object which is used for creating other objects;
      - static class Factory with method "CreateProduct"- accept the product type and return the whole product;
      - the basic principle behind the factory design pattern is that, at run time, we get an object of similar type based on the parameter we pass; 
     
     c) Factory Method:
      - is used, when we need to create the object (i.e. instance of the Product class) without exposing the object creation logic to the client;
      - we will create an abstract class as the VehicleFactory class which will create and return the instance of the product, but it will let the                                             subclasses(VWFactory, PeugeotFactory) decide which Product class (VWCaddy, VWPassat) to instantiate;
      
      d) Abstract Factory:      
      - remember this example: VW Factory creates doors for cars, windows for cars, tyres, but Honda Factory also creates doors for cars, windows for cars, tyres etc.
      - provides a way to encapsulate a group of individual factories that have a common theme without specifying their concrete classes;
      - every factory creates family of objects (doors, windows, tyres);
      
      e) Builder:
      - remember this example: BugattiChironBuilder (concrete builder for Buggati Chiron) with void SetModel(), void SetTransmission(), void SetBody(), void SetEngine, void SetAccessories();
      - multiply constructor in your class and might expand;
      - avoiding multiply parameters in constructors;
      
      f) Prototype Design Pattern:
      - gives us a way to create new objects from the existing instance of the object;
      - Shallow copy: it will create the new object from the existing object and then copying the value type fields of the current object to the new object. But in the case of               reference type, it will only copy the reference, not the referred object itself;
      - Deep copy: it will create the new object from the existing object and then copying the fields of the current object to the newly created object. If the field is a value type,         then a bit-by-bit copy of the field will be performed. If the field is a reference type, then a new copy of the referred object is created;
