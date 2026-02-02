============================================================
🧱 PRODUCT MANAGEMENT SYSTEM – 3 TIER ARCHITECTURE (.NET)
============================================================

DESCRIPTION
-----------
Console-based Product Management System built using 3-Tier Architecture.
The project focuses on clean separation between Presentation Layer,
Business Logic Layer, and Data Access Layer to practice scalable and
maintainable software design principles.

ARCHITECTURE
------------
- Presentation Layer : Program.cs (User Interaction & Menu)
- Business Layer     : ProductService.cs / IProductService.cs
- Data Layer         : ProductRepository.cs / IProductRepository.cs
- Model              : Product.cs

PROJECT GOALS
-------------
- Practice 3-Tier Architecture
- Understand separation of concerns
- Apply interfaces and dependency abstraction
- Prepare foundation for future expansion (API / UI / Database)

TECHNOLOGIES
------------
- Language   : C#
- Platform   : .NET Console Application
- Pattern    : Repository Pattern
- Architecture: 3-Tier Architecture

FEATURES
--------
- Add Product
- View All Products
- Update Product
- Delete Product
- In-Memory Data Storage (List)

PROJECT STRUCTURE
-----------------
ProductManagementSystem
│
├── Product.cs
├── Program.cs
│
├── IProductRepository.cs
├── ProductRepository.cs
│
├── IProductService.cs
└── ProductService.cs

NOTES
-----
- Business Layer handles validation and rules
- Data Layer handles storage and retrieval
- Presentation Layer only interacts with Business Layer
- No direct dependency between UI and Data Layer

AUTHOR
------
Shady Mahmoud

STATUS
------
Learning Project – Architecture Practice – Ready for Extension

============================================================
