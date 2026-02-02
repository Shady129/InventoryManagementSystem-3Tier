======================================================================
[::] PRODUCT MANAGEMENT SYSTEM - 3 TIER ARCHITECTURE (.NET)
======================================================================

[>>] DESCRIPTION
----------------------------------------------------------------------
Console based Product Management System built to practice clean
3-Tier Architecture with clear separation of concerns.

Layers are separated into:
- Presentation Layer
- Business Logic Layer
- Data Access Layer

This structure helps building scalable and maintainable applications.

[>>] ARCHITECTURE
----------------------------------------------------------------------
[UI ] Presentation Layer : Program.cs
[BL ] Business Layer     : ProductService.cs / IProductService.cs
[DAL] Data Layer         : ProductRepository.cs / IProductRepository.cs
[MOD] Model              : Product.cs

[>>] PROJECT GOALS
----------------------------------------------------------------------
[OK] Apply 3-Tier Architecture correctly
[OK] Use Interfaces for abstraction
[OK] Separate business rules from data access
[OK] Prepare project for future API / UI expansion

[>>] TECHNOLOGIES
----------------------------------------------------------------------
[LANG] C#
[PLAT] .NET Console Application
[PATT] Repository Pattern
[ARCH] 3-Tier Architecture

[>>] FEATURES
----------------------------------------------------------------------
[+] Add Product
[*] View All Products
[~] Update Product
[-] Delete Product
[#] In-Memory Storage using List

[>>] PROJECT FILES
----------------------------------------------------------------------
ProductManagementSystem
|
|-- Product.cs
|-- Program.cs
|
|-- IProductRepository.cs
|-- ProductRepository.cs
|
|-- IProductService.cs
`-- ProductService.cs

[>>] NOTES
----------------------------------------------------------------------
- UI layer never talks directly to Data layer
- Business layer contains validation and rules
- Data layer handles storage only

[>>] AUTHOR
----------------------------------------------------------------------
Shady Mahmoud

[>>] STATUS
----------------------------------------------------------------------
Learning Project
Architecture Practice
Ready for Extension

======================================================================
