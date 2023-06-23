using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
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
 * Author: Priscila
 * Date: May 1, 2023
 */
namespace TravelExpertsGUI
{
    public partial class frmProducts : Form
    {
        private const int MODIFY_INDEX = 2;

        private Product currentProduct;
        public frmProducts()
        {
            InitializeComponent();
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            DisplayProducts();
        }

        private void DisplayProducts()
        {
            dgvProducts.Columns.Clear();// reset columns
            List<ProductDTO> products = ProductDB.GetProducts();
            dgvProducts.DataSource = products;
            // add modify button column
            var modifyColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                Text = "Modify",
                HeaderText = ""
            };
            dgvProducts.Columns.Add(modifyColumn);

            // do some formatting
            // format the column header
            dgvProducts.EnableHeadersVisualStyles = false;
            dgvProducts.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dgvProducts.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
            dgvProducts.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            // format the odd numbered rows
            dgvProducts.AlternatingRowsDefaultCellStyle.BackColor = Color.CadetBlue;

            dgvProducts.Columns[0].HeaderText = "Product ID";
            dgvProducts.Columns[0].Width = 100;
            dgvProducts.Columns[1].HeaderText = "Product Name";
            dgvProducts.Columns[1].Width = 300;
            dgvProducts.Columns[2].Width = 120;
            dgvProducts.AutoResizeRows();
            dgvProducts.AutoResizeColumns();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddModifyProduct secondForm = new frmAddModifyProduct();
            secondForm.isAdd = true;
            secondForm.currentProduct = null;
            DialogResult result = secondForm.ShowDialog();
            if (result == DialogResult.OK) // proceed with add
            {
                currentProduct = secondForm.currentProduct;
                if (currentProduct != null)
                {
                    try
                    {
                        ProductDB.AddProduct(currentProduct);
                        DisplayProducts(); // refresh grid
                    }
                    catch (DbUpdateException ex) // errors coming from SaveChanges
                    {
                        string errorMessage = "Error(s) while adding product:\n";
                        var sqlException = (SqlException)ex.InnerException;
                        foreach (SqlError error in sqlException.Errors)
                        {
                            errorMessage += "ERROR CODE:  " + error.Number +
                                            " " + error.Message + "\n";
                        }
                        MessageBox.Show(errorMessage);
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Database connection lost while adding a product. Try again later");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error while adding a product: " +
                            ex.Message, ex.GetType().ToString());
                    }
                }
            }
        }

        private void dgvProducts_CellClick(object sender,
            DataGridViewCellEventArgs e)
        {
            // e.ColumnIndex is the column where the click happened
            // e.RowIndex is the row where the click happened
            if (e.ColumnIndex == MODIFY_INDEX)
            {
                int productId = Convert.ToInt16(dgvProducts.
                    Rows[e.RowIndex].Cells[0].Value.ToString().Trim());
                try
                {
                    currentProduct = ProductDB.FindProduct(productId);
                    if (currentProduct != null)
                    {
                        ModifyProduct();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while finding a product: " +
                        ex.Message, ex.GetType().ToString());
                }
            }
        }

        // modify current product
        private void ModifyProduct()
        {
            frmAddModifyProduct secondForm = new frmAddModifyProduct();
            secondForm.isAdd = false; // it is modify
            secondForm.currentProduct = currentProduct;
            DialogResult result = secondForm.ShowDialog();
            if (result == DialogResult.OK) // proceed with modify
            {
                currentProduct = secondForm.currentProduct; // new data values
                try
                {
                    ProductDB.UpdateProduct(currentProduct);
                    DisplayProducts(); // refresh grid
                }
                catch (DbUpdateException ex) // errors coming from SaveChanges
                {
                    string errorMessage = "Error(s) while modifying product:\n";
                    var sqlException = (SqlException)ex.InnerException;
                    foreach (SqlError error in sqlException.Errors)
                    {
                        errorMessage += "ERROR CODE:  " + error.Number +
                                        " " + error.Message + "\n";
                    }
                    MessageBox.Show(errorMessage);
                }
                catch (SqlException)
                {
                    MessageBox.Show("Database connection lost while modifying a product." +
                        " Try again later");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while modifying a product: " +
                        ex.Message, ex.GetType().ToString());
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
