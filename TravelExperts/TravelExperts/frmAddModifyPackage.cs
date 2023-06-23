using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExpertsData;

/* Travel Experts App to allow employees to add/modify packages, products, suppliers, and product suppliers.
 * Author: Kevin 
 * Date: May 1, 2023
 */
namespace TravelExpertsGUI
{
    public partial class frmAddModifyPackage : Form
    {
        // public because main form needs to set it
        public Package currentPackage;
        public PackagesProductsSupplier currentPkgProdSup;
        public bool isAdd;
        public frmAddModifyPackage()
        {
            InitializeComponent();
        }

        private void frmAddModifyPackage_Load(object sender, EventArgs e)
        {
            // differntiate between add and modify
            if (isAdd) // it is Add
            {
                this.Text = "Add Package";
                //LoadProdSupComboBox();
                //cboProdSup.Enabled = true;      // require ProductSupplier information for Add
                //cboProdSup.SelectedIndex = -1;  // no product supplier selected

                // populate product and supplier combo boxes when ProdSup is selected
                LoadProductIDComboBox();
                cboProduct.Enabled = true;
                cboSupplier.Enabled = true;
                cboProduct.SelectedIndex = -1;
                cboProduct.SelectedValueChanged += OnIndexChanged;
            }
            else //it is Modify
            {
                this.Text = "Modify Package";
                //cboProdSup.Enabled = false;     // don't require ProdSup info for Modify
                cboProduct.Enabled = false;
                cboSupplier.Enabled = false;
                DisplayPackage();
            }
        }

        // on Product Supplier combo box change, populate Product and Supplier fields
        private void OnIndexChanged(object sender, EventArgs e)
        {
            List<SupplierDTO> suppliers = ProductsSupplierDB.GetSuppliersForProd(Convert.ToInt16(cboProduct.SelectedValue));
            cboSupplier.DataSource = suppliers;
            cboSupplier.DisplayMember = "SupName";
            cboSupplier.ValueMember = "SupplierId";
        }

        //private void LoadProdSupComboBox()
        //{
        //    List<ProductsSupplierDTO> prodSup = ProductsSupplierDB.GetProductsSuppliers();

        //    cboProdSup.DataSource = prodSup;
        //    cboProdSup.DisplayMember = "ProductSupplierId";
        //    cboProdSup.ValueMember = "ProductSupplierId";
        //}
        private void LoadProductIDComboBox()
        {
            List<ProductDTO> products = ProductDB.GetProducts();
            cboProduct.DataSource = products;
            cboProduct.DisplayMember = "ProdName";
            cboProduct.ValueMember = "ProductId";
        }

        private void DisplayPackage()
        {
            // fill in all fields
            if (currentPackage != null)
            {
                txtPkgName.Text = currentPackage.PkgName;
                dtpStart.Value = Convert.ToDateTime(currentPackage.PkgStartDate);
                dtpEnd.Value = Convert.ToDateTime(currentPackage.PkgEndDate);
                txtDesc.Text = currentPackage.PkgDesc;
                txtPrice.Text = currentPackage.PkgBasePrice.ToString("N2");
                txtCommission.Text = Convert.ToDecimal(currentPackage.PkgAgencyCommission).ToString("N2");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool valid = true;
            if (isAdd) // validate code
            {
                // new package must have associated product supplier to add to PackagesProductsSupplier
                if (!Validator.IsSelected(cboProduct) || !Validator.IsSelected(cboProduct))
                {
                    valid = false;
                }
            }
            // for both Add and Modify
            if (valid &&
                Validator.IsPresent(txtPkgName) &&
                Validator.IsPresent(txtDesc) &&
                Validator.IsPresent(txtPrice) &&
                Validator.IsNonNegativeDecimal(txtPrice) &&
                Validator.IsPresent(txtCommission) &&
                Validator.IsNonNegativeDecimal(txtCommission) &&
                Validator.IsGreaterThan(txtPrice, txtCommission) &&
                Validator.IsLaterThan(dtpStart, dtpEnd)
              ) // valid data
            {
                if (isAdd) // need to create the object
                {
                    currentPackage = new Package();
                    currentPkgProdSup = new PackagesProductsSupplier();

                    //currentPkgProdSup.ProductSupplierId = Convert.ToInt16(cboProdSup.Text);
                    // have to find ProductSupplierId using Product id and supplier id
                    currentPkgProdSup.ProductSupplierId = ProductsSupplierDB.FindProdSup((int)cboProduct.SelectedValue, (int)cboSupplier.SelectedValue);
                }
                // put data in
                currentPackage.PkgName = txtPkgName.Text;
                currentPackage.PkgDesc = txtDesc.Text;
                currentPackage.PkgStartDate = dtpStart.Value;
                currentPackage.PkgEndDate = dtpEnd.Value;
                currentPackage.PkgBasePrice = Convert.ToDecimal(txtPrice.Text);
                currentPackage.PkgAgencyCommission = Convert.ToDecimal(txtCommission.Text);

                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
