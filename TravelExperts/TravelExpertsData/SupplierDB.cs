using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Travel Experts App to allow employees to add/modify packages, products, suppliers, and product suppliers.
 * Author: Mary 
 * Date: May 1, 2023 * 
 */
namespace TravelExpertsData
{
    /// <summary>
    /// repository of methods to work  with Suppliers table
    /// </summary>
    public static class SupplierDB
    {
        /// <summary>
        /// retrieves suppliers data
        /// </summary>
        /// <returns>list of lightweight supplier objects</returns>
        public static List<SupplierDTO> GetSuppliers()
        {
            List<SupplierDTO> suppliers = null;// empty list
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                suppliers = db.Suppliers.
                    OrderBy(p => p.SupplierId).
                    Select(p => new SupplierDTO()
                    {
                        SupplierId = p.SupplierId,
                        SupName = p.SupName
                    }).ToList();
            }
            return suppliers;
        }

        /// <summary>
        /// find supplier by primary key value
        /// </summary>
        /// <param name="supplierId">id of the supplier to find</param>
        /// <returns>found supplier or null</returns>
        public static Supplier FindSupplier(int supplierId)
        {
            Supplier supplier = null;
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                supplier = db.Suppliers.Find(supplierId);
            }
            return supplier;
        }

        /// <summary>
        /// get list of supplier codes
        /// </summary>
        /// <returns> list of supplier IDs</returns>
        public static List<int> GetSupplierId()
        {
            List<int> codes = new List<int>();
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                codes = db.Suppliers.Select(p => p.SupplierId).ToList();
            }
            return codes;
        }

        /// <summary>
        /// adds new supplier
        /// </summary>
        /// <param name="newSup">supplier to add</param>
        public static void AddSupplier(Supplier newSup)
        {
            if (newSup != null)
            {
                using (TravelExpertsContext db = new TravelExpertsContext())
                {
                    db.Suppliers.Add(newSup);
                    db.SaveChanges();
                }
            }
        }

        /// <summary>
        ///  update existing supplier with new data 
        /// </summary>
        /// <param name="newSupData">new supplier data</param>
        public static void UpdateSupplier(Supplier newSupData)
        {
            if (newSupData != null)
            {
                using (TravelExpertsContext db = new TravelExpertsContext())
                {
                    // find the supplier to update in this context
                    Supplier prod = db.Suppliers.Find(newSupData.SupplierId);
                    if (prod != null) // it still exists
                    {
                        // code does not  change
                        prod.SupName = newSupData.SupName;
                        db.SaveChanges();
                    }
                }
            }
        }
    }
}
