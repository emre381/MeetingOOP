
---

# Program1 - Simulating Human Interaction

This project is a simple C# console application that demonstrates basic object-oriented programming principles like encapsulation, methods, and using `private` members within a class.

## Description

The program defines a class called `Insan` (Human in Turkish), which models basic human-like behavior with methods to greet, ask for information, and respond with details about the person. Two instances of the `Insan` class are created, and these instances interact with each other in the form of greetings and responses.

## Class: `Insan`

### Properties:
- `isim` (private): Stores the name of the person.
- `yas` (private): Stores the age of the person.

### Methods:
1. **selamver()**: This method prints a greeting, "Merhaba" (Hello), to the console.
2. **bilgileriSor()**: This method asks for the name and age of the person.
3. **cevapVer()**: This method prints out the person's name and age as a response.
4. **isimVeYasDuzenleme(string isim, int yas)**: This method sets the name (`isim`) and age (`yas`) of the person.

## Main Method:
The `Main` method creates two objects (`i1` and `i2`) of the `Insan` class. These objects interact with each other using the methods defined in the `Insan` class:
- Both `i1` and `i2` greet the user.
- `i1` asks for the name and age, and `i2` responds.
- Similarly, `i2` asks for the name and age, and `i1` responds.

### Code Example:

```csharp
Insan i1 = new Insan();
Insan i2 = new Insan();

i1.isimVeYasDuzenleme("Emre", 24);
i2.isimVeYasDuzenleme("Ahmet", 33);

i1.selamver();
i2.selamver();
i1.bilgileriSor();
i2.cevapVer();
i2.bilgileriSor();
i1.cevapVer();
```

### Output Example:

```
Merhaba
Merhaba
Adın ne ve kaç yaşındasın ? 
Benim adımAhmetve yaşım33
Adın ne ve kaç yaşındasın ? 
Benim adımEmreve yaşım24
```

## How to Run:
1. Clone or download the project to your local machine.
2. Open the project in a C# IDE (like Visual Studio).
3. Run the program by pressing `F5` or clicking "Start" in your IDE.

## Purpose:
This project serves as an educational example to show how to:
- Define and use classes and objects in C#.
- Use encapsulation by making properties private and accessing them via public methods.
- Create multiple instances of a class and simulate basic interactions between them.

---

