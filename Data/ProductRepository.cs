using InventorySystem.Models;


namespace Inventory.DataAccess
{
    public class ProductRepository:IProductRepository
    {

        private static List<Product> products = new List<Product>();


        public void Add(Product product)
        {
            products.Add(product);

        }

        public Product GetById(int id)
        {
            return products.FirstOrDefault(p => p.Id == id);
        }

        public List<Product> GetAll()
        {
            return products.ToList();
        }

        public void Update(Product product)
        {
            Product existingProduct = GetById(product.Id);


            if(product != null)
            {
                existingProduct.Name = product.Name;
                existingProduct.Price = product.Price;
                existingProduct.Quantity = product.Quantity;
            }
        }



        public void Delete(int id)
        {

            Product product = GetById(id);

            if( product != null )
            {

                products.Remove(product);

            }
        }


        public bool IsProductExists(int id)
        {
            
            return products.Find(p => p.Id == id) != null;
        }













    }
}
