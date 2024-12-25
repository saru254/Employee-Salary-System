# Employee Salary System

## Overview

The Employee Salary System is a simple C# program that demonstrates the concept of **Abstraction** and **Polymorphism** using an abstract class and its derived subclasses. The system models employees with different roles (Manager and Developer) and calculates their bonuses based on their salary.

This system is designed to:
- Define an abstract `Employee` class with fields for employee name and salary.
- Implement an abstract method `CalculateBonus()` to be overridden by specific employee roles.
- Create subclasses for different employee roles, each implementing its own logic for bonus calculation.

## Features
- **Abstract Class**: `Employee` with fields for `Name` and `Salary`.
- **Abstract Method**: `CalculateBonus()`, which is implemented differently by each subclass.
- **Subclasses**:
  - `Manager`: Bonus is calculated as 10% of the salary.
  - `Developer`: Bonus is calculated as 5% of the salary.
- Simple and extensible design for adding more employee roles in the future.

## Requirements
- .NET SDK 6.0 or higher
- C# programming language

## Installation

1. Clone the repository or download the project folder.
2. Open the project folder in Visual Studio or your preferred C# development environment.
3. Build and run the project.

## How It Works

1. **Employee Class**:
   - The `Employee` class is abstract, meaning it cannot be instantiated directly. It contains two fields, `Name` and `Salary`, and an abstract method `CalculateBonus()`.

2. **Manager Class**:
   - The `Manager` class inherits from `Employee` and overrides the `CalculateBonus()` method to return a bonus of 10% of the salary.

3. **Developer Class**:
   - The `Developer` class also inherits from `Employee` and overrides the `CalculateBonus()` method to return a bonus of 5% of the salary.

4. The `Main` method demonstrates how objects of `Manager` and `Developer` are created and their respective bonuses are calculated and displayed.

## Example Output

```
Alice's Bonus: $8,000.00
Bob's Bonus: $3,000.00
```

## Contributing

If you wish to contribute to the project, please feel free to fork the repository and submit pull requests with any improvements or additional features.

## License

This project is open-source and available under the MIT License.

---

Feel free to adapt this README according to any specific details you may want to add about your project.
