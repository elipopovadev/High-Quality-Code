# High-Quality-Code
Creational Design Patterns; Structural Design Patterns; Behavioral Design Patterns; Dependency Injection Design Pattern; Repository Design Pattern 
1. Creational Design Patterns:

    a) Singleton:
      - this pattern ensures that a class has only one instance and provides a global point of access to it;
      - always is sealed class with: private static Singleton instance, private constructor and one getter- public static Singleton GetInstance (see Standard Singleton);
      - class could have methods, fields or properties;
      - Lazy loading is to load the object on-demand or you can say object when needed. The most important point that you need to keep in mind is that, you need to use the Lazy               loading when the cost of the object creation is very high as well as the use of that object is very rare. 
      - remember that the Lazy<T> objects are by default thread-safe. In a multi-threaded environment, when multiple threads are trying to access the same Get Instance property at           the same time, then the lazy object will take care of thread safety.   
      - Eager loading: initialize the singleton object at the time of application start-up rather than on-demand and keep it ready in memory to be used in the future. The advantage           of using Eager Loading in the Singleton design pattern is that the CLR (Common Language Runtime) will take care of object initialization and thread-safety. That means we will         not require to write any code explicitly for handling the thread-safety for a multithreaded environment.
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
      - the Abstract Factory is a super factory that creates other factories;
      - every factory creates family of objects (doors, windows, tyres);
      
      e) Builder:
      - remember this example: BugattiChironBuilder (concrete builder for Buggati Chiron) with void SetModel(), void SetTransmission(), void SetBody(), void SetEngine, void                   SetAccessories();
      - avoiding multiply parameters in constructors;
      - we need to use Builder Design Pattern when there is multiply constructor in the class or might be expand in the future;
      
    
      f) Fluent Interface Design Pattern:
      - the Fluent Interfaces and Method chaining are related to each other. Or we can say that one is a concept and the other one is its implementation;
      - the main objective of the Fluent Interface Design Pattern is that we can apply multiple properties (or methods) to an object by connecting them with dots (.) without having           to re-specify the object name each time;
      - we have created methods for each property in our Fluent class. Also, notice the return of the method is set to the FluentEmployee. Now the above fluent interface is going to         be consumed by the client;
      
      g) Prototype Design Pattern:
      - gives us a way to create new objects from the existing instance of the object;
      - Shallow copy: it will create the new object from the existing object and then copying the value type fields of the current object to the new object. But in the case of               reference type, it will only copy the reference, not the referred object itself;
      - Deep copy: it will create the new object from the existing object and then copying the fields of the current object to the newly created object. If the field is a value type,         then a bit-by-bit copy of the field will be performed. If the field is a reference type, then a new copy of the referred object is created;
    
   
    
    
    
2. Structural Design Patterns:
    
      a) Facade:
      - defines a higher-level interface that makes the subsystem easier to use;
      - hides the complexities of the system;
    
     b) Proxy:
      - remember the example with ATM (proxy), client and bank;
      - the Proxy is the object which is being called by the client to access the real object behind the scene;
      - the client will call the method of the Proxy object and the proxy will be responsible to call the method of the Real Object;
      - could interface to anything such as a network connection, a large object in memory, a file, or some other resources that are expensive or impossible to duplicate;
      - The Proxy servers can drastically improve the performance of the application. This is because it saves the results of a request for a certain period of time;
      - Virtual Proxy, Remote Proxy, Protection Proxy;
    
    c) Adapter:
     - adapter is responsible for communication between two independent or incompatible interfaces;
     - works as a bridge between two incompatible interfaces;
     - example is: HR System (Client) will send the employee information in the form of a String Array to the Adapter and it will read the employee information from the string array        and put each employee object into the List<Employee> and then the Adapter will send the List<Employee> to the ProcessSalary method of Third Party Billing System. Then the            ProcessSalary method calculates the Salary of each employee and deposits the salary into the Employee’s bank account;
    
    d) Bridge:
      - there are two parts: the first part is the abstraction and the second part is the implementation;
      - providing a bridge betwen abstract class and implementation class - bridge interface;
      - allows the abstraction and implementation to be developed independently;
      - if you want to add a new implementation or if you want to remove any implementation, then it will not affect the Abstraction layer;
      - the client will only use the abstraction to save or delete the object;
    
    e) Decorator:
     - dynamically changes the functionality of an object at runtime without impacting the existing functionality of the objects;
     - adds additional functionalities to the object by wrapping it;
     - remember how to create car with diesel engine and car with petrol engine, or pizza decorator;
    
    f) Composite:
     - compose objects into tree structures to represent part-whole hierarchies;
     - composite let clients treat individual objects and compositions of objects uniformly;
     - this pattern creates a tree structure of a group of objects;
     - the Composite Pattern is used where we need to treat a group of objects in a similar way as a single unit object;
     - will be having a tree structure having composite objects and leaf objects;
     - composite component may also contain other composite objects;
     - the object which does not contain any other objects is simply treated as a leaf object;
     - if you perform some operation on the leaf object then the same operation should be performed on the composite objects (for example to get price);
    
    g) Flyweight:
     - is used when there is a need to create a large number of objects of almost similar nature;
     - is basically used to reduce the number of objects created, decrease the memory footprint, and increase the overall performance of the application;
     - this design pattern tries to reduce the already existing similar kind of objects by storing them and create a new object when no matching object is found (FlyweightFactory);
     - example: we have to create 3000 red circles, 4000 blue circles, 5000 black circles; 
     - we can improve the performance by creating the circle object only one time and reuse that circle object many times to create a different type of color;


    
    
    
3. Behavioral Design Patterns:
    
    a) Chain of Responsibility:
     - the chain of responsibility design pattern creates a chain of receiver objects for a given request;
     - normally each receiver contains a reference to another receiver;
     - if one receiver cannot handle the request then it passes the same request to the next receiver and so on;
     - one receiver handles the request in the chain or one or more receivers handle the request;
     - remember the example with Developer, Team Leader, Project Leader and HR: only one receiver in the chain will handle the request and approve leave of the employee;
    
    b) Iterator:
     - the iterator pattern is a design pattern in which an iterator is used to traverse a container ( ist, Array List, Array, etc.) and access the elements of the container;
     - allows sequential access of elements without exposing the inside logic;
     - we can access the elements of a collection object in a sequential manner without any need to know its internal representations;
    
    
    
    
