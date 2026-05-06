using Inventory.Business;
using Inventory.DataAccess;
using InventorySystem.Models;


namespace InventoryManagementSystem
{
    internal class Program
    {

        static IProductService productService;


        static void Main(string[] args)
        {

            Initialize();
            RunApplication();
        }


        static void Initialize()
        {
            IProductRepository productRepository = new ProductRepository();
            productService = new ProductService(productRepository);
        }


        static void ShowMenu()
        {
            Console.WriteLine("\n1 - Add Product");
            Console.WriteLine("2 - Show All Products");
            Console.WriteLine("3 - Update Product");
            Console.WriteLine("4 - Delete Product");
            Console.WriteLine("5 - Exit");
            Console.Write("Choose: ");
        }


        static int ReadNumber()
        {
            int number;

            while (!int.TryParse(Console.ReadLine(), out number))
            {

                Console.Write("Invalid number, try again: ");
            }

            return number;

        }


        static void RunApplication()
        {
            while (true)
            {
                ShowMenu();
                int choice = ReadNumber();
                HandleUserChoice(choice);
            }

        }


        
static bool HandleUserChoice(int choice)
{
    switch (choice)
    {
        case 1:
            AddProduct();
            return true;

        case 2:
            ShowAllProducts();
            return true;

        case 3:
            UpdateProduct();
            return true;

        case 4:
            DeleteProduct();
            return true;

        case 5:
            return false;

        default:
            Console.WriteLine("Invalid choice.");
            return true;
    }
}

     


            static void AddProduct()
            {
                Product product = new Product();


                Console.Write("Id: ");
                product.Id = ReadNumber();

                Console.Write("Name: ");
                product.Name = Console.ReadLine();

                Console.Write("Price: ");
                product.Price = decimal.Parse(Console.ReadLine());

                Console.Write("Quantity: ");
                product.Quantity = ReadNumber();

                productService.Add(product);
            }



            static void ShowAllProducts()
            {
                List<Product> products = productService.GetAll();

                foreach (Product product in products)
                {
                Console.WriteLine(
                    $"Id:{product.Id} Name:{product.Name} Price:{product.Price} Qty:{product.Quantity}\n");
                
                }
            }



            static void UpdateProduct()
            {
                Product product = new Product();

                Console.Write("Id to update: ");
                product.Id = ReadNumber();

                Console.Write("New Name: ");
                product.Name = Console.ReadLine();

                Console.Write("New Price: ");
                product.Price = decimal.Parse(Console.ReadLine());

                Console.Write("New Quantity: ");
                product.Quantity = ReadNumber();

                productService.Update(product);
            }


            static void DeleteProduct()
            {
                Console.Write("Id to delete: ");
                int id = ReadNumber();

                productService.Delete(id);
            }
    }

}










    
