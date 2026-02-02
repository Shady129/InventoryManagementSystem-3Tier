using Inventory.DataAccess;
using InventorySystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Business
{
    public class ProductService:IProductService
    {

        private readonly IProductRepository repository;


        public ProductService(IProductRepository repository)
        {

            this.repository = repository;

        }
        
        public void Add(Product product)
        {

            if (product == null)

                throw new ArgumentNullException("Product is null");



            if (product.Price < 0)
                throw new ArgumentException("Price cannot be negative");



            if (product.Quantity < 0)
                throw new ArgumentException("Quantity cannot be negative");



            if (repository.IsProductExists(product.Id))

                throw new InvalidOperationException("Product already exists");

            repository.Add(product);
  
        }


        public List<Product>GetAll()
        {

            return repository.GetAll();
        }


        public Product GetById(int Id)
        {
            return repository.GetById(Id);

        }


       public void Update(Product product)
        {

            if(product == null)
                return;

            if (product.Price < 0)

                return;

            if (product.Quantity < 0)
                return;


            if (!repository.IsProductExists(product.Id))

                return;

    

            repository.Update(product);
        }


        public void Delete(int Id)
        {


            if (!repository.IsProductExists(Id))
                return;

            repository.Delete(Id);
        }


            
    }



}

