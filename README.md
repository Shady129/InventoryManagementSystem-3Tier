# 🧱 InventoryManagementSystem-3Tier

🧠 OVERVIEW
A clean C# console application built using the 3-Tier Architecture pattern.
The project focuses on separating responsibilities between layers while
enforcing proper business rules and clean design principles.

✔ Separation of Concerns
✔ Repository Pattern
✔ Dependency Injection
✔ Interface-Based Design
✔ Business Rules Enforcement
✔ Ready for Database or Web API

🧩 ARCHITECTURE FLOW
🖥️ UI Layer (Program.cs)
│  ▸ Read user input
│  ▸ Display menus & results
│  ▸ Handle exceptions
│
▼
🧠 Business Layer (Service)
│  ▸ Apply business rules
│  ▸ Validate data
│  ▸ Prevent invalid operations
│  ▸ Decide whether actions are allowed
│
▼
🗄️ Data Access Layer (Repository)
│  ▸ Store data
│  ▸ Retrieve data
│  ▸ Execute commands only
│  ▸ No business logic

🗂️ PROJECT STRUCTURE
InventoryManagementSystem
├── 🖥️ Program.cs
├── 🧠 Inventory.Business
│   ├── IProductService        // UI ↔ Business contract
│   └── ProductService         // Business rules & logic
└── 🗄️ Inventory.DataAccess
    ├── IProductRepository     // Business ↔ Data contract
    └── ProductRepository      // Data storage (List as fake DB)

🔌 INTERFACES RESPONSIBILITY
IProductService
▸ Defines what the user can do
▸ Exposes business operations only
▸ Used by the UI layer

IProductRepository
▸ Defines how data is accessed
▸ Exposes data-related operations
▸ Used internally by the Business layer

🧠 BUSINESS RULES ENFORCED
✔ Prevent adding duplicate products
✔ Prevent updating non-existing products
✔ Prevent deleting non-existing products
✔ Validate price and quantity
✔ Centralized decision-making in Business layer

🚀 FUTURE EXTENSIONS
▸ Replace List with Database
▸ Convert Console App to Web API
▸ Add Logging
▸ Add Unit Testing
▸ Custom Exceptions

📎 SUMMARY
This project demonstrates how a real-world application can be structured using
the 3-Tier Architecture, keeping the code clean, scalable, and maintainable.
