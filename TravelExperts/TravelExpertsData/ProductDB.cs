using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Travel Experts App to allow employees to add/modify packages, products, suppliers, and product suppliers.
 * Author: Priscila 
 * Date: May 1, 2023 * 
 */
namespace TravelExpertsData
{
    /// <summary>
    /// repository of methods to work  with Products table
    /// </summary>
    public static class ProductDB
    {
        /// <summary>
        /// retrieves products data
        /// </summary>
        /// <returns>list of lightweight product objects</returns>
        public static List<ProductDTO> GetProducts()
        {
            List<ProductDTO> products = null;// empty list
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                products = db.Products.
                    OrderBy(p => p.ProductId).
                    Select(p => new ProductDTO()
                    {
                        ProductId = p.ProductId,
                        ProdName = p.ProdName
                    }).ToList();
            }
            return products;
        }

        /// <summary>
        /// find product by primary key value
        /// </summary>
        /// <param name="productId">id of the product to find</param>
        /// <returns>found product or null</returns>
        public static Product FindProduct(int productId)
        {
            Product product = null;
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                product = db.Products.Find(productId);
            }
            return product;
        }

        /// <summary>
        /// get list of product codes
        /// </summary>
        /// <returns> list of product IDs</returns>
        public static List<int> GetProductId()
        {
            List<int> codes = new List<int>();
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                codes = db.Products.Select(p => p.ProductId).ToList();
            }
            return codes;
        }

        /// <summary>
        /// adds new product
        /// </summary>
        /// <param name="newProd">product to add</param>
        public static void AddProduct(Product newProd)
        {
            if (newProd != null)
            {
                using (TravelExpertsContext db = new TravelExpertsContext())
                {
                    db.Products.Add(newProd);
                    db.SaveChanges();
                }
            }
        }

        /// <summary>
        ///  update existing product with new data 
        /// </summary>
        /// <param name="newProdData">new product data</param>
        public static void UpdateProduct(Product newProdData)
        {
            if (newProdData != null)
            {
                using (TravelExpertsContext db = new TravelExpertsContext())
                {
                    // find the product to update in this context
                    Product prod = db.Products.Find(newProdData.ProductId);
                    if (prod != null) // it still exists
                    {
                        // code does not  change
                        prod.ProdName = newProdData.ProdName;
                        db.SaveChanges();
                    }
                }
            }
        }
    }
}
