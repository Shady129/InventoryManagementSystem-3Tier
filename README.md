# 📦 Product Management System  
## Console Application using 3-Tier Architecture (C#)
----------------------------------------

📌 Project Overview
----------------------------------------
This project is a **Console-based Product Management System** built using **C#**
and designed according to the **3-Tier Architecture principle**.

The application clearly separates:
- Presentation Layer
- Business Logic Layer
- Data Access Layer

This design ensures clean code, easy maintenance, and scalability.

The system provides full CRUD operations for managing products:
- Add Product
- View All Products
- Update Product
- Delete Product

----------------------------------------
🏗️ 3-Tier Architecture Breakdown
----------------------------------------

🔹 Presentation Layer  
- `Program.cs`  
Responsible for:
- Displaying the menu
- Reading user input
- Showing output to the console  
No business logic is written here.

🔹 Business Logic Layer  
- `ProductService.cs`  
- `IProductService.cs`  
Responsible for:
- Applying validation rules
- Controlling application logic
- Communicating between Presentation and Data layers

🔹 Data Access Layer  
- `ProductRepository.cs`  
Responsible for:
- Storing product data
- Performing CRUD operations
- Implementing repository contract

🔹 Contract Layer  
- `IProductRepository.cs`  
Defines a clear contract for data operations and enables loose coupling.

🔹 Model  
- `Product.cs`  
Represents the Product entity.

----------------------------------------
📂 Project Structure
----------------------------------------

ProductManagementSystem  
│  
├── Program.cs                   // Presentation Layer  
├── ProductService.cs            // Business Layer  
├── IProductService.cs           // Business Contract  
├── ProductRepository.cs         // Data Access Layer  
├── IProductRepository.cs        // Repository Contract  
├── Product.cs                   // Model  

----------------------------------------
⚙️ Technologies Used
----------------------------------------

- Language: C#  
- Application Type: Console Application  
- Architecture: 3-Tier Architecture  
- Design Pattern: Repository Pattern  
- Data Storage: In-Memory List  

----------------------------------------
🧠 Key Concepts Applied
----------------------------------------

✔ 3-Tier Architecture  
✔ Repository Pattern  
✔ Interface-based Programming  
✔ Dependency Injection  
✔ Separation of Concerns  
✔ CRUD Operations  
✔ Input Validation  

----------------------------------------
📋 Application Features
----------------------------------------

▶ Add a new product  
▶ Display all products  
▶ Update product information  
▶ Delete a product by ID  
▶ Validate numeric input using `TryParse`  
▶ Clean and simple console menu  

----------------------------------------
🚀 Application Flow
----------------------------------------

1. User interacts with the Presentation Layer.
2. Requests are sent to the Business Layer.
3. Business rules are applied.
4. Data operations are handled by the Data Layer.
5. Results are returned and displayed to the user.

----------------------------------------
📌 Notes
----------------------------------------

- No database is used (In-Memory data storage).
- The project focuses on **architecture and clean design**.
- Ideal for learning:
  - 3-Tier Architecture
  - Interfaces
  - Repository Pattern

----------------------------------------
🧪 Possible Enhancements
----------------------------------------

🔹 Add database support  
🔹 Implement search and filtering  
🔹 Improve validation rules  
🔹 Convert to Web API or WinForms  

----------------------------------------
👤 Author
----------------------------------------

Shady Mahmoud  
Product Management System  
Console App using 3-Tier Architecture  

========================================
