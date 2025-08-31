# C# Design Patterns Implementation

This project contains implementations of various design patterns in C#.

## Project Structure

```
DesignPatterns/
├── Adapter/                    # Adapter Pattern
│   ├── IPaymentGateway.cs
│   ├── PaypalApp.cs
│   ├── PaypalAdapter.cs
│   ├── StripeApp.cs
│   ├── StripeAdapter.cs
│   └── Client.cs
├── Bridge/                     # Bridge Pattern
│   ├── IDevice.cs
│   ├── Tv.cs
│   ├── Radio.cs
│   ├── RemoteControl.cs
│   ├── AdvancedRemoteControl.cs
│   └── Client.cs
├── Builder/                    # Builder Pattern
│   ├── Student.cs
│   └── Client.cs
├── Decorator/                  # Decorator Pattern
│   ├── ICoffee.cs
│   ├── SimpleCoffee.cs
│   ├── AbstractDecorator.cs
│   ├── MilkDecorator.cs
│   ├── SugarDecorator.cs
│   └── Client.cs
├── Factory/                    # Factory Patterns
│   ├── AbstractFactory/        # Abstract Factory Pattern
│   │   ├── Components/
│   │   │   ├── Buttons/
│   │   │   │   ├── IButton.cs
│   │   │   │   ├── AndroidButton.cs
│   │   │   │   └── IosButton.cs
│   │   │   └── Dropdowns/
│   │   │       ├── IDropdown.cs
│   │   │       ├── AndroidDropdown.cs
│   │   │       └── IosDropdown.cs
│   │   ├── SupportedPlatform.cs
│   │   ├── IUiFactory.cs
│   │   ├── AndroidUiFactory.cs
│   │   ├── IosUiFactory.cs
│   │   ├── UiPlatformFactory.cs
│   │   └── Client.cs
│   └── PracticalFactory/       # Practical Factory Pattern
│       ├── IVehicle.cs
│       ├── Car.cs
│       ├── Motorcycle.cs
│       ├── VehicleFactory.cs
│       ├── CarVehicleFactory.cs
│       ├── MotorcycleVehicleFactory.cs
│       └── Client.cs
├── Flyweight/                  # Flyweight Pattern
│   ├── TreeType.cs
│   ├── TreeFactory.cs
│   ├── Tree.cs
│   ├── Forest.cs
│   └── Client.cs
├── Prototype/                  # Prototype Pattern
│   ├── IPrototype.cs
│   ├── Student.cs
│   ├── IntelligentStudent.cs
│   ├── StudentRegistry.cs
│   └── Client.cs
├── Singleton/                  # Singleton Pattern
│   ├── Database.cs
│   └── Client.cs
├── Observer/                   # Observer Pattern
│   ├── IObserver.cs
│   ├── ISubject.cs
│   ├── NewsAgency.cs
│   ├── NewsChannel.cs
│   └── Client.cs
├── Strategy/                   # Strategy Pattern
│   ├── IPaymentStrategy.cs
│   ├── CreditCardPayment.cs
│   ├── PayPalPayment.cs
│   ├── BitcoinPayment.cs
│   ├── ShoppingCart.cs
│   └── Client.cs
├── ChainOfResponsibility/      # Chain of Responsibility Pattern
│   ├── IHandler.cs
│   ├── AbstractHandler.cs
│   ├── Level1Support.cs
│   ├── Level2Support.cs
│   ├── Level3Support.cs
│   └── Client.cs
├── Program.cs                  # Main demo application
├── DesignPatterns.csproj       # Project file
└── README.md                   # This file
```

## Design Patterns Implemented

### 1. Adapter Pattern
- **Purpose**: Allows incompatible interfaces to work together
- **Implementation**: Payment gateway adapters for PayPal and Stripe
- **Key Classes**: `IPaymentGateway`, `PaypalAdapter`, `StripeAdapter`

### 2. Bridge Pattern
- **Purpose**: Decouples abstraction from implementation so both can vary independently
- **Implementation**: Remote controls working with different devices (TV, Radio)
- **Key Classes**: `IDevice`, `RemoteControl`, `Tv`, `Radio`, `AdvancedRemoteControl`

### 3. Builder Pattern
- **Purpose**: Constructs complex objects step by step
- **Implementation**: Student object builder with validation
- **Key Classes**: `Student`, `StudentBuilder`

### 4. Singleton Pattern
- **Purpose**: Ensures a class has only one instance
- **Implementation**: Thread-safe database connection
- **Key Classes**: `Database`

### 5. Decorator Pattern
- **Purpose**: Adds new functionality to objects dynamically
- **Implementation**: Coffee with various add-ons (milk, sugar)
- **Key Classes**: `ICoffee`, `AbstractDecorator`, `MilkDecorator`, `SugarDecorator`

### 6. Abstract Factory Pattern
- **Purpose**: Creates families of related objects
- **Implementation**: UI components for different platforms (Android, iOS)
- **Key Classes**: `IUiFactory`, `AndroidUiFactory`, `IosUiFactory`

### 7. Factory Method Pattern (Practical Factory)
- **Purpose**: Creates objects without specifying exact classes
- **Implementation**: Vehicle factory for different vehicle types
- **Key Classes**: `VehicleFactory`, `CarVehicleFactory`, `MotorcycleVehicleFactory`

### 8. Flyweight Pattern
- **Purpose**: Reduces memory usage by sharing common parts
- **Implementation**: Tree types sharing in a forest
- **Key Classes**: `TreeType`, `TreeFactory`, `Forest`

### 9. Prototype Pattern
- **Purpose**: Creates new objects by cloning existing ones
- **Implementation**: Student cloning with inheritance
- **Key Classes**: `IPrototype<T>`, `Student`, `IntelligentStudent`

### 10. Observer Pattern
- **Purpose**: Defines a one-to-many dependency between objects
- **Implementation**: News agency publishing to multiple news channels
- **Key Classes**: `IObserver`, `ISubject`, `NewsAgency`, `NewsChannel`

### 11. Strategy Pattern
- **Purpose**: Encapsulates algorithms and makes them interchangeable
- **Implementation**: Different payment methods (Credit Card, PayPal, Bitcoin)
- **Key Classes**: `IPaymentStrategy`, `CreditCardPayment`, `PayPalPayment`, `BitcoinPayment`, `ShoppingCart`

### 12. Chain of Responsibility Pattern
- **Purpose**: Passes requests along a chain of handlers
- **Implementation**: Support ticket escalation (Level 1 → Level 2 → Level 3)
- **Key Classes**: `IHandler`, `AbstractHandler`, `Level1Support`, `Level2Support`, `Level3Support`

## Pattern Summary

| # | Pattern | Category | Purpose | Demo Shows |
|---|---------|----------|---------|------------|
| 1 | **Adapter** | Structural | Interface compatibility | PayPal/Stripe payment processing |
| 2 | **Bridge** | Structural | Abstraction/Implementation decoupling | Remote controls with TV/Radio |
| 3 | **Builder** | Creational | Complex object construction | Student object with validation |
| 4 | **Singleton** | Creational | Single instance guarantee | Database connection management |
| 5 | **Decorator** | Structural | Dynamic functionality addition | Coffee with milk/sugar add-ons |
| 6 | **Abstract Factory** | Creational | Related object families | Platform-specific UI components |
| 7 | **Factory Method** | Creational | Object creation delegation | Vehicle manufacturing |
| 8 | **Flyweight** | Structural | Memory optimization | Tree types sharing in forest |
| 9 | **Prototype** | Creational | Object cloning | Student inheritance cloning |
| 10 | **Observer** | Behavioral | Event notification system | News agency publishing |
| 11 | **Strategy** | Behavioral | Algorithm selection | Multiple payment methods |
| 12 | **Chain of Responsibility** | Behavioral | Request handling chain | Support ticket escalation |

### Pattern Categories
- **Creational Patterns**: Deal with object creation mechanisms
- **Structural Patterns**: Deal with object composition and relationships
- **Behavioral Patterns**: Deal with communication between objects

## How to Run

1. **Prerequisites**: .NET 6.0 or later
2. **Build**: `dotnet build`
3. **Run**: `dotnet run`

## Key C# Features Used

- **Interfaces**: For defining contracts
- **Abstract Classes**: For base implementations
- **Generics**: For type-safe implementations
- **Properties**: For clean getter/setter syntax
- **LINQ**: For collection operations
- **Pattern Matching**: For switch expressions
- **Nullable Reference Types**: For better null safety
- **Readonly Fields**: For immutability

## Differences from Java Implementation

1. **Naming Conventions**: C# uses PascalCase for public members
2. **Properties**: C# properties instead of getter/setter methods
3. **Interfaces**: C# interfaces with 'I' prefix
4. **Collections**: C# generic collections instead of Java collections
5. **String Interpolation**: C# string interpolation with `$`
6. **Null Safety**: C# nullable reference types
7. **Thread Safety**: C# `lock` statement instead of `synchronized`

## Benefits of C# Implementation

- **Type Safety**: Strong typing with compile-time checks
- **Performance**: Better performance than Java in many scenarios
- **Modern Features**: Latest C# language features
- **IDE Support**: Excellent Visual Studio and VS Code support
- **Cross-Platform**: Runs on Windows, macOS, and Linux
- **Memory Management**: Automatic garbage collection with better control

## Learning Outcomes

This implementation demonstrates:
- Object-oriented design principles
- SOLID principles
- Design pattern best practices
- C# language features
- Clean code practices
- Separation of concerns
- Code reusability and maintainability
