using InventoryManagementSystem.Business;
using InventoryManagementSystem.DataAccess;
using InventoryManagementSystem.Models;


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


   


        static void RunApplication()
        {
            while (true)
            {
                ShowMenu();

                int choice = InputHelper.ReadInt("Enter the choic: ", 1);

                bool keepRunning = HandleUserChoice(choice);

                if (!keepRunning)
                    break;
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

                
                product.Id = InputHelper.ReadInt("Id: ", 1);

               
                product.Name = InputHelper.ReadString("Name: ");

                
                product.Price = InputHelper.ReadDec("Price: ", 0);

                
                product.Quantity = InputHelper.ReadInt("Quantity: ", 0);

                try
                {
                    productService.Add(product);
                    Console.WriteLine("\nProduct Added successfully.");
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
        }



            static void ShowAllProducts()
            {
                List<Product> products = productService.GetAll();

                foreach (Product product in products)
                {
                Console.WriteLine(
                    $"\nId:{product.Id} - Name:{product.Name} -  Price:{product.Price} - Qty:{product.Quantity}\n");
                
                }
            }



            static void UpdateProduct()
            {
                Product product = new Product();

                
                product.Id = InputHelper.ReadInt("Id to update: ", 1);

            
                product.Name = InputHelper.ReadString("New Name: ");

               
                product.Price = InputHelper.ReadDec("New Price: ", 0);

              
               product.Quantity = InputHelper.ReadInt("New Quantity: ", 0);


                try
                {
                    productService.Update(product);
                    Console.WriteLine("\nProduct Updated successfully.");
            }
                catch(Exception ex)
                {
                     Console.WriteLine(ex.Message);

                }

               

            }


            static void DeleteProduct()
            {
                
;               int Id = InputHelper.ReadInt("Id to delete: ",1);




                try
                {
                    productService.Delete(Id);
                    Console.WriteLine("\nProduct deleted successfully.");

            }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }


             
            }



    }

}










    
