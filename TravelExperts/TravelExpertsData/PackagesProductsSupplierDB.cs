using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Travel Experts App to allow employees to add/modify packages, products, suppliers, and product suppliers.
 * Author: Kevin 
 * Date: May 1, 2023 * 
 */
namespace TravelExpertsData
{
    /// <summary>
    /// Method to work with PackagesProductsSupplierDB
    /// </summary>
    public static class PackagesProductsSupplierDB
    {
        /// <summary>
        /// Add new PackagesProductsSupplier
        /// </summary>
        /// <param name="newPkgProdSup"></param>
        public static void AddPkgProdSup(PackagesProductsSupplier newPkgProdSup)
        {
            if (newPkgProdSup != null)
            {
                using (TravelExpertsContext db = new TravelExpertsContext())
                {
                    db.PackagesProductsSuppliers.Add(newPkgProdSup);
                    db.SaveChanges();
                }
            }
        }

    }
}
