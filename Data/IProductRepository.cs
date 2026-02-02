using InventorySystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.DataAccess
{
    public interface IProductRepository
    {


        void Add(Product product);
        void Update(Product product);
        void Delete(int Id);
        Product GetById(int id);
        List<Product>GetAll();

        bool IsProductExists(int id);

    }
    
    
}
