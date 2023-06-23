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
 * Author: Mary
 * Date: May 1, 2023
 */
namespace TravelExperts
{
    public partial class frmSuppliers : Form
    {
        private const int MODIFY_INDEX = 2;

        private Supplier currentSupplier;
        public frmSuppliers()
        {
            InitializeComponent();
        }

        private void frmSuppliers_Load(object sender, EventArgs e)
        {
            DisplaySuppliers();
        }

        private void DisplaySuppliers()
        {
            dgvSuppliers.Columns.Clear();// reset columns
            List<SupplierDTO> suppliers = SupplierDB.GetSuppliers();
            dgvSuppliers.DataSource = suppliers;
            // add modify button column
            var modifyColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                Text = "Modify",
                HeaderText = ""
            };
            dgvSuppliers.Columns.Add(modifyColumn);

            // do some formatting
            // format the column header
            dgvSuppliers.EnableHeadersVisualStyles = false;
            dgvSuppliers.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dgvSuppliers.ColumnHeadersDefaultCellStyle.BackColor = Color. CadetBlue;
            dgvSuppliers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            // format the odd numbered rows
            dgvSuppliers.AlternatingRowsDefaultCellStyle.BackColor = Color.CadetBlue;

            dgvSuppliers.Columns[0].HeaderText = "Supplier ID";
            dgvSuppliers.Columns[0].Width = 100;
            dgvSuppliers.Columns[1].HeaderText = "Supplier Name";
            dgvSuppliers.Columns[1].Width = 300;
            dgvSuppliers.Columns[2].Width = 120;
            dgvSuppliers.AutoResizeRows();
            dgvSuppliers.AutoResizeColumns();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddModifySupplier secondForm = new frmAddModifySupplier();
            secondForm.isAdd = true;
            secondForm.currentSupplier = null;
            DialogResult result = secondForm.ShowDialog();
            if (result == DialogResult.OK) // proceed with add
            {
                currentSupplier = secondForm.currentSupplier;
                if (currentSupplier != null)
                {
                    try
                    {
                        SupplierDB.AddSupplier(currentSupplier);
                        DisplaySuppliers(); // refresh grid
                    }
                    catch (DbUpdateException ex) // errors coming from SaveChanges
                    {
                        string errorMessage = "Error(s) while adding supplier:\n";
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
                        MessageBox.Show("Database connection lost while adding a supplier. Try again later");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error while adding a supplier: " +
                            ex.Message, ex.GetType().ToString());
                    }
                }
            }
        }

        private void dgvSuppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // e.ColumnIndex is the column where the click happened
            // e.RowIndex is the row where the click happened
            if (e.ColumnIndex == MODIFY_INDEX)
            {
                int supplierId = Convert.ToInt16(dgvSuppliers.
                    Rows[e.RowIndex].Cells[0].Value.ToString().Trim());
                try
                {
                    currentSupplier = SupplierDB.FindSupplier(supplierId);
                    if (currentSupplier != null)
                    {
                        ModifySupplier();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while finding a supplier: " +
                        ex.Message, ex.GetType().ToString());
                }
            }
        }

        private void ModifySupplier()
        {
            frmAddModifySupplier secondForm = new frmAddModifySupplier();
            secondForm.isAdd = false; // it is modify
            secondForm.currentSupplier = currentSupplier;
            DialogResult result = secondForm.ShowDialog();
            if (result == DialogResult.OK) // proceed with modify
            {
                currentSupplier = secondForm.currentSupplier; // new data values
                try
                {
                    SupplierDB.UpdateSupplier(currentSupplier);
                    DisplaySuppliers(); // refresh grid
                }
                catch (DbUpdateException ex) // errors coming from SaveChanges
                {
                    string errorMessage = "Error(s) while modifying supplier:\n";
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
                    MessageBox.Show("Database connection lost while modifying a supplier." +
                        " Try again later");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while modifying a supplier: " +
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
