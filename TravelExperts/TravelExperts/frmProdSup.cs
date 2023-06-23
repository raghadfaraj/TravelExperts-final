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
using TravelExpertsGUI;


/*Travel Experts App to allow employees to add/modify packages, products, suppliers, and product suppliers.
 * Author: Emmanuel
 * Date: May 1, 2023 * 
 */
namespace TravelExperts
{
    public partial class frmProdSup : Form
    {
        private const int MODIFY_INDEX = 3;

        private ProductsSupplier currentProdSup;
        public frmProdSup()
        {
            InitializeComponent();
        }

        private void frmProdSup_Load(object sender, EventArgs e)
        {
            DisplayProdSups();
        }

        private void DisplayProdSups()
        {
            dgvProdSup.Columns.Clear();// reset columns
            List<ProductsSupplierDTO> prodSups = ProductsSupplierDB.GetProductsSuppliers();
            dgvProdSup.DataSource = prodSups;
            // add modify button column
            var modifyColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                Text = "Modify",
                HeaderText = ""
            };
            dgvProdSup.Columns.Add(modifyColumn);

            // do some formatting
            // format the column header
            dgvProdSup.EnableHeadersVisualStyles = false;
            dgvProdSup.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dgvProdSup.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
            dgvProdSup.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            // format the odd numbered rows
            dgvProdSup.AlternatingRowsDefaultCellStyle.BackColor = Color.CadetBlue;

            dgvProdSup.Columns[0].HeaderText = "Product Supplier";
            dgvProdSup.Columns[0].Width = 100;
            dgvProdSup.Columns[1].HeaderText = "Product ID";
            dgvProdSup.Columns[1].Width = 100;
            dgvProdSup.Columns[2].HeaderText = "Supplier ID";
            dgvProdSup.Columns[2].Width = 100;
            dgvProdSup.Columns[3].Width = 120;
            dgvProdSup.AutoResizeRows();
            dgvProdSup.AutoResizeColumns();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddModifyProdSup secondForm = new frmAddModifyProdSup();
            secondForm.isAdd = true;
            secondForm.currentProdSup = null;
            DialogResult result = secondForm.ShowDialog();
            if (result == DialogResult.OK) // proceed with add
            {
                currentProdSup = secondForm.currentProdSup;
                if (currentProdSup != null)
                {
                    try
                    {
                        ProductsSupplierDB.AddProductsSupplier(currentProdSup);
                        DisplayProdSups(); // refresh grid
                    }
                    catch (DbUpdateException ex) // errors coming from SaveChanges
                    {
                        string errorMessage = "Error(s) while adding product supplier:\n";
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
                        MessageBox.Show("Database connection lost while adding a product supplier. Try again later");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error while adding a product supplier: " +
                            ex.Message, ex.GetType().ToString());
                    }
                }
            }
        }

        private void dgvProdSup_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // e.ColumnIndex is the column where the click happened
            // e.RowIndex is the row where the click happened
            if (e.ColumnIndex == MODIFY_INDEX)
            {
                int prodSupId = Convert.ToInt16(dgvProdSup.Rows[e.RowIndex].Cells[0].Value.ToString().Trim());
                try
                {
                    currentProdSup = ProductsSupplierDB.FindProductsSupplier(prodSupId);
                    if (currentProdSup != null)
                    {
                        ModifyProdSup();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while finding a product supplier: " +
                        ex.Message, ex.GetType().ToString());
                }
            }
        }

        private void ModifyProdSup()
        {
            frmAddModifyProdSup secondForm = new frmAddModifyProdSup();
            secondForm.isAdd = false; // it is modify
            secondForm.currentProdSup = currentProdSup;
            DialogResult result = secondForm.ShowDialog();
            if (result == DialogResult.OK) // proceed with modify
            {
                currentProdSup = secondForm.currentProdSup; // new data values
                try
                {
                    ProductsSupplierDB.UpdateProductsSupplier(currentProdSup);
                    DisplayProdSups(); // refresh grid
                }
                catch (DbUpdateException ex) // errors coming from SaveChanges
                {
                    string errorMessage = "Error(s) while modifying product supplier:\n";
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
                    MessageBox.Show("Database connection lost while modifying a product supplier." +
                        " Try again later");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while modifying a product supplier: " +
                        ex.Message, ex.GetType().ToString());
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvProdSup_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
