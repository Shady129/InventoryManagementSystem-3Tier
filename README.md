# 📦 Inventory Management System – C# Console Application (3-Tier Architecture)

A C# console-based Inventory Management System that simulates real-world inventory
operations with a strong focus on clean architecture, separation of concerns, and
business rule enforcement. The project demonstrates how a structured inventory
workflow can be implemented using the 3-Tier Architecture pattern without external
libraries or databases.

## 🚀 Features
- ➕ Add new products with validation
- ✏️ Update existing products safely
- 🗑️ Delete products with existence checks
- 📋 View all products
- 🔍 Get product by ID
- 🚫 Prevent duplicate product IDs
- 🧠 Centralized business logic
- ⚠️ Exception handling for invalid operations

## 🛠️ Technologies Used
- C#
- .NET Console Application
- Collections (List)
- Interfaces
- Dependency Injection
- Repository Pattern
- 3-Tier Architecture

## 📂 Project Structure
InventoryManagementSystem-3Tier/
├── Program.cs
├── Inventory.Business/
│   ├── IProductService.cs
│   └── ProductService.cs
├── Inventory.DataAccess/
│   ├── IProductRepository.cs
│   └── ProductRepository.cs
├── InventorySystem.Models/
│   └── Product.cs
├── README.md
└── .gitignore

## 🧠 Project Design Overview
The system follows the 3-Tier Architecture pattern.
- UI Layer handles user interaction and menu navigation only.
- Business Layer contains all validation rules and decision-making logic.
- Data Access Layer handles data storage using an in-memory list as a fake database.
Layers communicate through interfaces to ensure loose coupling and maintainability.

## 🧹 Code Quality
This project applies clean code principles by separating responsibilities between
layers, avoiding duplicated logic, centralizing business rules in the service layer,
using clear naming conventions, and keeping the UI layer free from business logic.


## 🎯 Learning Outcomes
- Understanding the 3-Tier Architecture in practice
- Applying the Repository Pattern correctly
- Using interfaces to decouple application layers
- Implementing business rules in the correct layer
- Handling exceptions in a structured way
- Building scalable and maintainable console applications

## 🚀 Future Improvements
- Replace in-memory list with a database
- Convert the project to a Web API
- Add logging
- Add unit testing
- Implement custom exceptions

## 📝 Learning Notes
This project focuses on architectural correctness rather than only functionality.
It highlights how separating UI, business logic, and data access layers leads to
cleaner, more maintainable, and scalable codebases.
