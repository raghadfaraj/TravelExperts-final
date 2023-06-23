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
    /// repository of methods to work with Packages table
    /// </summary>
    public static class PackageDB
    {
        /// <summary>
        /// retrieves Package data
        /// </summary>
        /// <returns>list of lightweight package objects</returns>
        public static List<PackageDTO> GetPackages()
        {
            List<PackageDTO> packages = new List<PackageDTO>();// empty list
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                packages = db.Packages.
                    OrderBy(p => p.PackageId).
                    Select(p => new PackageDTO()
                    {
                        PackageId = p.PackageId,
                        PkgName = p.PkgName,
                        PkgStartDate = p.PkgStartDate,
                        PkgEndDate = p.PkgEndDate,
                        PkgDesc = p.PkgDesc,
                        PkgBasePrice = p.PkgBasePrice,
                        PkgAgencyCommission = p.PkgAgencyCommission
                    }).ToList();
            }
            return packages;
        }

        /// <summary>
        /// find package by primary key value
        /// </summary>
        /// <param name="packageId">id of the package to find</param>
        /// <returns>found package or null</returns>
        public static Package FindPackage(int packageId)
        {
            Package package = null;
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                package = db.Packages.Find(packageId);
            }
            return package;
        }

        /// <summary>
        /// get list of package codes
        /// </summary>
        /// <returns> list of package IDs</returns>
        //public static List<int> GetPackagesId()
        //{
        //    List<int> codes = new List<int>();
        //    using (TravelExpertsContext db = new TravelExpertsContext())
        //    {
        //        codes = db.Packages.Select(p => p.PackagesId).ToList();
        //    }
        //    return codes;
        //}

        /// <summary>
        /// adds new package
        /// </summary>
        /// <param name="newPackage">package to add</param>
        public static void AddPackage(Package newPackage)
        {
            if (newPackage != null)
            {
                using (TravelExpertsContext db = new TravelExpertsContext())
                {
                    db.Packages.Add(newPackage);
                    db.SaveChanges();
                }
            }
        }

        /// <summary>
        ///  update existing package with new data 
        /// </summary>
        /// <param name="newPackageData">new package data</param>
        public static void UpdatePackage(Package newPackageData)
        {
            if (newPackageData != null)
            {
                using (TravelExpertsContext db = new TravelExpertsContext())
                {
                    // find the package to update in this context
                    Package package = db.Packages.Find(newPackageData.PackageId);
                    if (package != null) // it still exists
                    {
                        // code does not  change
                        package.PackageId = newPackageData.PackageId;
                        package.PkgName = newPackageData.PkgName;
                        package.PkgStartDate = newPackageData.PkgStartDate;
                        package.PkgEndDate = newPackageData.PkgEndDate;
                        package.PkgDesc = newPackageData.PkgDesc;
                        package.PkgBasePrice = newPackageData.PkgBasePrice;
                        package.PkgAgencyCommission = newPackageData.PkgAgencyCommission;
                        db.SaveChanges();
                    }
                }
            }
        }
    }
}
