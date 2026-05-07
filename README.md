# 📦 Product Management System  
## Console Application using Layered Architecture (C#)

----------------------------------------

📌 Project Overview
----------------------------------------

This project is a **Console-based Product Management System** built using **C#**
and designed using a **Simple Layered Architecture** approach.

The application separates responsibilities into:
- Presentation Layer
- Business Logic Layer
- Data Access Layer
- Models

This structure improves:
- Code organization
- Maintainability
- Readability
- Separation of concerns

The system provides full CRUD operations for managing products:
- Add Product
- View All Products
- Update Product
- Delete Product

----------------------------------------
🏗️ Architecture Breakdown
----------------------------------------

🔹 Presentation Layer  
- `Program.cs`  
- `InputHelper.cs`

Responsible for:
- Displaying menus
- Reading and validating user input
- Showing messages and results to the console
- Handling user interaction flow

No business logic is implemented here.

🔹 Business Logic Layer  
- `ProductService.cs`
- `IProductService.cs`

Responsible for:
- Applying validation rules
- Handling application logic
- Throwing business exceptions
- Communicating with the data layer

🔹 Data Access Layer  
- `ProductRepository.cs`
- `IProductRepository.cs`

Responsible for:
- Managing product storage
- Performing CRUD operations
- Handling in-memory data access

🔹 Models  
- `Product.cs`

Represents the Product entity.

----------------------------------------
📂 Project Structure
----------------------------------------

ProductManagementSystem  
│  
├── Program.cs  
├── InputHelper.cs  
│  
├── Business  
│   ├── ProductService.cs  
│   └── IProductService.cs  
│  
├── DataAccess  
│   ├── ProductRepository.cs  
│   └── IProductRepository.cs  
│  
├── Models  
│   └── Product.cs  

----------------------------------------
⚙️ Technologies Used
----------------------------------------

- Language: C#
- Application Type: Console Application
- Architecture: Simple Layered Architecture
- Design Pattern: Repository Pattern
- Data Storage: In-Memory List

----------------------------------------
🧠 Key Concepts Applied
----------------------------------------

✔ Layered Architecture  
✔ Repository Pattern  
✔ Interface-based Programming  
✔ Dependency Injection  
✔ Separation of Concerns  
✔ CRUD Operations  
✔ Input Validation  
✔ Exception Handling  

----------------------------------------
📋 Application Features
----------------------------------------

▶ Add a new product  
▶ Display all products  
▶ Update product information  
▶ Delete a product by ID  
▶ Input validation using `TryParse`  
▶ Exception handling  
▶ Reusable `InputHelper` class  
▶ Clean and simple console menu  

----------------------------------------
🚀 Application Flow
----------------------------------------

1. User interacts with the Presentation Layer.
2. Input is validated using `InputHelper`.
3. Requests are sent to the Business Layer.
4. Business rules and validations are applied.
5. Data operations are handled by the Data Access Layer.
6. Results are displayed back to the user.

----------------------------------------
📌 Notes
----------------------------------------

- The project uses **in-memory storage** through a static `List<Product>`.
- No real database is used.
- The project focuses on:
  - Clean architecture
  - Layer separation
  - Validation
  - Repository abstraction

⚠️ Note:
This project is better described as a:

`Console App using Simple Layered Architecture`

rather than a full **3-Tier Architecture** application.

----------------------------------------
🧪 Possible Enhancements
----------------------------------------

🔹 Add SQL Server support  
🔹 Add Entity Framework Core  
🔹 Implement search and filtering  
🔹 Improve validation rules  
🔹 Add logging  
🔹 Add unit testing  
🔹 Convert to Web API or WinForms  

----------------------------------------
👤 Author
----------------------------------------

Shady Mahmoud

Product Management System  
Console App using Simple Layered Architecture

========================================
