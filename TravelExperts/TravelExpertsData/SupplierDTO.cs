using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Travel Experts App to allow employees to add/modify packages, products, suppliers, and product suppliers.
 * Author: Mary 
 * Date: May 1, 2023 * 
 */
namespace TravelExpertsData
{
    public class SupplierDTO
    {
        public int SupplierId { get; set; }
        public string? SupName { get; set; }
    }
}
