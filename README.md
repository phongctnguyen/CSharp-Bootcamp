# CSharp-Bootcamp

## I. Data Types and Variables

### Data Type

- int, double, float
- char, string
- bool
- ...

### Variables

- Store a value, can be unassigned

### Coding Conventions

- [Coding-Conventions](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/coding-conventions)

- Part of Coding Standrad

  + **Reasonable variable name -** While declaring a variable the developer has to give the variable a proper name. The name of the variable should be based on its use

  + **Proper function name -** A function should be given a name based on the functionality it does in the code or program

  + **Comments -** Functions should have comments which state the use and functionality of that function. It helps other developers working on the same project to understand the use of that function
  ```
  Single-Line Comments : //
  Multiline Comments: /* */
  XML Documentaion Comments (create documentation of function or class): ///
  ```

  + **Comments inside functions -** If there is something logical written inside the function which is very complex then the developer should mention what the code does in comments inside the function

  + **Developer Notes -** On the top of the class the developer can mention the use of a class, date of creation and other basic information

### Value and Reference Types

- [Types](https://www.tutorialsteacher.com/csharp/csharp-value-type-and-reference-type)

- Value type

  + Value type as the name suggests is a data type which when declared and assigned a value, holds the *value directly on its own memory*

  + The value type uses a heap to store the value

  + Value types data types are int, float, char, bool ..

- Reference type

  + Reference type is a variable type which instead of storing the value in memory directly, stores the memory location of the actual data

  + The variable here stores the memory reference of the data and not the data correctly

  + Reference type data types are string, class, Array...

  + When we copy this reference type of a data type it wil just copy the memory address of the data so we will then have two variable pointing to the same data


### Naming Conventions

- [Naming Convetions](https://www.dofactory.com/reference/csharp-coding-standards)

### String methods

- Concat()

- SubString(int32)

- ToLower()

- ToUpper()

- Trim()

- IndexOf(string)

- IsNullOrWhiteSpace()

- Format()

### Cheat Sheets Section

[Cheat Sheet 1](https://cheatography.com/laurence/cheat-sheets/c/)

[Cheat Sheet 2](https://www.thecodingguys.net/resources/cs-cheat-sheet.pdf)


## II. Functions and Methods

### Methods

A method is a code block that contains a series of statements. A program causes the statements to be executed by calling the method and specifying any required method arguments. In C#, every executed instruction is performed in the context of a method. The Main method is the entry point for every C# application and it is callled by the common language runtime (CLR) when the program is started.

```
Syntax:

<Access Specifier> <Return Type> <Method Name> (Parameter List)
{
  Method Body
}
```

- Access Specifier: The Access Specifier determines the visibility of a variable or a method from another class.

- Return Type: A method may return a value. The return type is the data type of the value the method returns. If the method is not returning any values, then the return type is void.

- Method name: Method name is a unique identifier and it is case sensitive. It cannot be same as any other identifier declared in the class.

- Parameter list: Enclosed between parantheses, the parameters are used to pass and receive data from a method. The parameter list refers to the type, order, and number of the parameters of a method. Parameters are optional, that is, a method may contain no parameters.

- Method body: This contains the set of instructions needed to complete the required activity


## III. Maing Decisions

### If Statement

```
Syntax:

if (condition) 
{
  // what to do if condition is met 
} 
else if (condition2)
{
  // what to do if condition2 is met
} 
else {
  // what to do if none of the conditions is met
}
```

## IV. Loops

- Advantage of Loops:

  + Save time
  + Quick and easy repetition of code
  + Allows you to work with huge amounts of Data
  + Allows you to loop through arrays

- Loop Types:

  + for loop
  + while loop (check then go)
  + do while loop (do first then check)
  + foreach loop (run through array or list)


### For Loop

```
for (start value; condition; increment) {
  // code body
}
```

### While Loop

```
counterVariable = 0;
while(condition) {
  // execute your code
  counterVariable++;
}

Executes code as long as the condition is met
```

### Do While Loop

```
counterVariable = 0;
do {
  // execute your code
  counterVariable++;
} while(condition)

Executes code as long as the condition is met
```

### Foreach loop
```
runs through an array
only as long as there is content

foreach (type variable in arrayElement) {
  // code body 
}
```

## V. Class 

- A class is a blueprint of an Object
- It has actions/abilities - so called member functions or methods
- It has properties - so called member variables
- Inheritance possible
- Can be used like a Datatype (e.g. String is a Class)

```
Examples:
* Object (Car)
- Properties: HP, Wheels, Lumen, Doors...
- Abilities: Drive, Break, Make Light...
- Inheritance: A5 < Audi < Car
```

[Access Modifier](https://code-maze.com/csharp-basics-access-modifiers/)

## VI. Arrays

``Array``
  + Stores a fixed size sequentia collection of elements
  + ONLY of the same type
  + All kinds of types: int, string, object, etc...
  + Great to store a collection of data - easier to think of a collection of variables of the same type stored at continous memory locations

- Declaring an array

```
  dataType[] arrayName;
  int[] grades;
```

- Initializing an array

```
  dataType[] arrayName = new dataType[amountOfEntries];
  int[] grades = new int[5];
```

- Assigning values to an array

```
  arrayName[index] = value;
```

``Collections: Lists``

  + group of objects/values you work with can grow and shrink dynamically
  + A collection is a class amd it requires an instance of the class before adding elements to that collection
  + Use System.Collections.Generic namespace

- Declaration

```
  var numbers = new List<int>();
  var numbers = new List<int>(1, 5, 35);
```

- Properties

```
  Items
  Count
```

- Method

```
  Add(value)
  Remove(value)
  RemoveAt(index)
  Clear()
  ...
```

- Get Value

```
  Use index: numbers[0]
```

## VII. Inheritance

Inheritance allows us to define a class in terms of another class, which makes it easier to create and maintain an appilcation. This also provides an opportunity to reuse the code functionality and speeds up impelementation time

## VIII. Advanced C#

Marking fields and methods with access modifiers is part of the object oriented programming and increases the safeness of your code are an important part of encapsulation (which is part of OOP)

In object oriented programming languages, encapsulation is used to refer to one of two related but distinct notions, and sometimes to the combination type of 

- A language mechanism for restricting direct access to some of the object's components

- A language construct that facilitates the bundling of data with the methods (or other functions) operating on that data

```
Access Modifier
- private: only accessible inside a class or struct
Ex: 
private int age = 16;
private void Walk() {}

- public: accessible from everywhere in your project
Ex:
public int age = 18;

- protected: accessible from the class and all classes that derive from it
Ex: 
protected int age = 20;

-internal: accessible from its assembly (project)
internal int age = 22;
```

### Garbage Collection
- The .Net Framework provides an automatic memory management
```
  Human denis = new Human(); // allocates Memory
```
- The Framework takes care of reclaiming memory for reuse in the system, once objects are no longer being used
- Don't have to manually call the garbage collector (but can)
- The GC requires processing power
- The GC's goal is to free up memory but not use too much processing power
- Memory isn't necessarily right away
- You can implement the finalizer method to execute code just before an object is released from memory be the GC
- GC run when:
  + When the system has low physical memory
  + When the memory allocated exceeds a pre-set threshold
  + When GC.Collect() is called. Even though this is a tricky method

## IX. Delegates & Events

### Delegates
A delegate is a type that represents references to methods with a particular parameter list and return type. When you instantiate a delegate, you can associate its instance with any method with a compatible signature and return type.. You can invoke (or call) the method through the delegate instance.

- Delegates are similar to C++ function pointers (but fully OOP in C#)
- Delegates allow methods to be passes as params
- Delegates can be used to define callback methods
- Delegates can be changed
  + Important for events - multiple methods can be called on a single event
- Methods do not have to match the delegate type exactly (Covariance and Contravariance)
- Delegates allow use of anonymous functions

```
Declare
delegate returnType Name (param1, param2,... paramN);
deletgate double PerformCalculation (double x, double y);
```

### Concepts of Covariance and Contravariance
- Covariance enables to pass a derived type where a base type is expected (FileStream where Stream is expected)

- Contravariance enables to pass a base type where a derived type is expected (Stream where FileStream is expected)

### Events
`Events`:
- enables communication between objects 
- allows cleaner code
- enables subscriber to listen to sender

```
publlic void OnFileDownloaded(object source, EventArgs e) {}
```

`Delegates`
- The Delegate hereby is a contract between the publisher and the subscriber
- The delegate determines the signature of the event handler method in the subscriber amd can hold multiple method pointers