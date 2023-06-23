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

/*Travel Experts App to allow employees to add/modify packages, products, suppliers, and product suppliers.
 * Author: Mary
 * Date: May 1, 2023
 */
namespace TravelExpertsGUI
{
    public partial class frmAddModifySupplier : Form
    {
        // public because main form needs to set it
        public Supplier currentSupplier;
        public bool isAdd;
        public frmAddModifySupplier()
        {
            InitializeComponent();
        }

        private void frmAddModifySupplier_Load(object sender, EventArgs e)
        {
            if (isAdd) // it is Add
            {
                this.Text = "Add Supplier";
                txtSupplierId.Enabled = true;
            }
            else //it is Modify
            {
                this.Text = "Modify Supplier";
                DisplaySupplier();
                txtSupplierId.Enabled = false;
            }
        }

        private void DisplaySupplier()
        {
            if (currentSupplier != null)
            {
                txtSupplierId.Text = currentSupplier.SupplierId.ToString();
                txtSupplierName.Text = currentSupplier.SupName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool valid = true;
            if (isAdd) // validate code
            {
                if (Validator.IsPresent(txtSupplierId))
                {
                    // check if non-negative integer
                    if (Validator.IsNonNegativeInt(txtSupplierId))
                    {
                        // check if unique
                        int code = Convert.ToInt16(txtSupplierId.Text);
                        List<int> codes = SupplierDB.GetSupplierId();
                        foreach (int c in codes)
                        {
                            if (c == code)
                            {
                                MessageBox.Show($"Duplicate supplier ID: {code}");
                                valid = false; // found duplicate
                            }
                        }
                    }
                    else
                    {
                        valid = false;
                    }
                }
                else // empty string
                {
                    valid = false;
                }
            }
            // for both Add and Modify
            if (valid &&
                Validator.IsPresent(txtSupplierName)
              ) // valid data
            {
                if (isAdd) // need to create the object
                {
                    currentSupplier = new Supplier();
                }
                // put data in
                currentSupplier.SupplierId = Convert.ToInt16(txtSupplierId.Text);
                currentSupplier.SupName = txtSupplierName.Text;

                DialogResult = DialogResult.OK;
            }
        }
    }
}
