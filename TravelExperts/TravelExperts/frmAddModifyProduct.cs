using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExpertsData;

/*Travel Experts App to allow employees to add/modify packages, products, suppliers, and product suppliers.
 * Author: Priscila
 * Date: May 1, 2023
 */
namespace TravelExpertsGUI
{
    public partial class frmAddModifyProduct : Form
    {
        // public because main form needs to set it
        public Product currentProduct;
        public bool isAdd;
        public frmAddModifyProduct()
        {
            InitializeComponent();
        }

        private void frmAddModifyProduct_Load(object sender, EventArgs e)
        {
            if (isAdd) // it is Add
            {
                this.Text = "Add Product";
            }
            else //it is Modify
            {
                this.Text = "Modify Product";
                DisplayProduct();
            }
        }

        private void DisplayProduct()
        {
            if (currentProduct != null)
            {
                //txtProductId.Text = currentProduct.ProductId.ToString();
                txtProductName.Text = currentProduct.ProdName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool valid = true;
            // DO NOT REQUIRE DUPLICATE ID CHECK IF PRODUCT ID IS ADDED AUTOMATICALLY
            //if (isAdd) // validate code
            //{
            //    if (Validator.IsPresent(txtProductId))
            //    {
            //        // check if non-negative interger
            //        if (Validator.IsNonNegativeInt(txtProductId))
            //        {
            //            // check if unique
            //            int code = Convert.ToInt16(txtProductId.Text);
            //            List<int> codes = ProductDB.GetProductId();
            //            foreach (int c in codes)
            //            {
            //                if (c == code)
            //                {
            //                    MessageBox.Show($"Duplicate product ID: {code}");
            //                    valid = false; // found duplicate
            //                }
            //            }
            //        }
            //        else
            //        {
            //            valid = false;
            //        }
            //    }
            //    else // empty string
            //    {
            //        valid = false;
            //    }
            //}
            // for both Add and Modify
            if (valid &&
                Validator.IsPresent(txtProductName)
              ) // valid data
            {
                if (isAdd) // need to create the object
                {
                    currentProduct = new Product();
                }
                // put data in
                currentProduct.ProdName = txtProductName.Text;

                DialogResult = DialogResult.OK;
            }
        }
    }
}
