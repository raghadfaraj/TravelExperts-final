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
    // Product class without navigation property
    public class ProductDTO
    {
        public int ProductId { get; set; }
        public string ProdName { get; set; }
    }
}
