# 🧱 Inventory Management System — 3-Tier Architecture


 INVENTORY MANAGEMENT SYSTEM
 CONSOLE APPLICATION — 3 TIER ARCHITECTURE (C#)


📌 OVERVIEW
--------------------------------------------------------
This project is a clean implementation of the 3-Tier
Architecture pattern using C#.

The main goal is to clearly separate responsibilities
between layers and enforce proper business rules.

✔ Separation of Concerns
✔ Repository Pattern
✔ Dependency Injection
✔ Interface-Based Design
✔ Business Rules Enforcement
✔ Ready for Database or Web API

--------------------------------------------------------

🧩 ARCHITECTURE FLOW
--------------------------------------------------------
🖥️ UI LAYER (Program.cs)
│
│  ▸ Reads user input
│  ▸ Displays menus & results
│  ▸ Handles exceptions
│
▼
🧠 BUSINESS LAYER (Service)
│
│  ▸ Applies business rules
│  ▸ Validates data
│  ▸ Prevents invalid operations
│  ▸ Decides whether actions are allowed
│
▼
🗄️ DATA ACCESS LAYER (Repository)
│
│  ▸ Stores data
│  ▸ Retrieves data
│  ▸ Executes commands only
│  ▸ No business logic
│
--------------------------------------------------------

🗂️ PROJECT STRUCTURE
--------------------------------------------------------
InventoryManagementSystem
│
├── 🖥️ Program.cs
│
├── 🧠 Inventory.Business
│   ├── IProductService        // UI ↔ Business contract
│   └── ProductService         // Business rules & logic
│
└── 🗄️ Inventory.DataAccess
    ├── IProductRepository     // Business ↔ Data contract
    └── ProductRepository      // Data storage (List as fake DB)

--------------------------------------------------------

🔌 INTERFACES RESPONSIBILITY
--------------------------------------------------------
IProductService
▸ Defines what the user can do
▸ Exposes business operations only
▸ Used by the UI layer

IProductRepository
▸ Defines how data is accessed
▸ Exposes data-related operations
▸ Used internally by the Business layer

--------------------------------------------------------

🧠 BUSINESS RULES ENFORCED
--------------------------------------------------------
✔ Prevent adding duplicate products
✔ Prevent updating non-existing products
✔ Prevent deleting non-existing products
✔ Validate price and quantity
✔ Centralized decision making in Business layer

--------------------------------------------------------

🚀 FUTURE EXTENSIONS
--------------------------------------------------------
▸ Replace List with Database
▸ Convert Console App to Web API
▸ Add Logging
▸ Add Unit Testing
▸ Custom Exceptions

--------------------------------------------------------

📎 SUMMARY
--------------------------------------------------------
This project demonstrates how a real-world application
should be structured using the 3-Tier Architecture,
keeping the code clean, scalable, and maintainable.

--------------------------------------------------------
