using TravelExpertsData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Travel Experts App to allow employees to add/modify packages, products, suppliers, and product suppliers.
 * Author: Emmanuel
 * Date: May 1, 2023 * 
 */
namespace TravelExpertsGUI
{
    public partial class frmAddModifyProdSup : Form
    {
        // public because main form needs to set it
        public ProductsSupplier currentProdSup;
        public bool isAdd;
        public frmAddModifyProdSup()
        {
            InitializeComponent();
        }

        private void frmAddModifyProdSup_Load(object sender, EventArgs e)
        {
            // populate combo boxes
            LoadProductIDComboBox();
            cboProductId.SelectedValueChanged += OnProductChanged;

            // differntiate between add and modify
            if (isAdd) // it is Add
            {
                this.Text = "Add Product Supplier";
                cboProductId.SelectedIndex = -1; // no product selected when adding
                cboSupplierId.SelectedIndex = -1; // no supplier selected when adding
            }
            else //it is Modify
            {
                this.Text = "Modify Product Supplier";
                DisplayProdSup();
            }
        }

        private void LoadProductIDComboBox()
        {
            List<ProductDTO> products = ProductDB.GetProducts();
            cboProductId.DataSource = products;
            cboProductId.DisplayMember = "ProdName";
            cboProductId.ValueMember = "ProductId";                
        }

        // Edited by Kevin to filter suppliers according to selected product
        private void OnProductChanged(object? sender, EventArgs e)
        {
            List<SupplierDTO> suppliers = ProductsSupplierDB.GetSuppliersForProd(Convert.ToInt16(cboProductId.SelectedValue));
            cboSupplierId.DataSource = suppliers;
            cboSupplierId.DisplayMember = "SupName";
            cboSupplierId.ValueMember = "SupplierId";
        }

        private void DisplayProdSup()
        {
            if (currentProdSup != null)
            {
                cboProductId.SelectedValue = currentProdSup.ProductId;
                cboSupplierId.SelectedValue = currentProdSup.SupplierId;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool valid = true;
            // for both Add and Modify
            if (valid &&
                Validator.IsSelected(cboProductId) &&
                Validator.IsSelected(cboSupplierId)

              ) // valid data
            {
                if (isAdd) // need to create the object
                {
                    currentProdSup = new ProductsSupplier();
                }
                // put data in
                currentProdSup.ProductId = Convert.ToInt16(cboProductId.SelectedValue);
                currentProdSup.SupplierId = Convert.ToInt16(cboSupplierId.SelectedValue);

                DialogResult = DialogResult.OK;
            }
        }
    }
}
