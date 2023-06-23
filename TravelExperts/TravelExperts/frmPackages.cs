using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExpertsData;
using TravelExpertsGUI;

/* Travel Experts App to allow employees to add/modify packages, products, suppliers, and product suppliers.
 * Author: Kevin
 * Date: May 1, 2023
 */
namespace TravelExperts
{
    public partial class frmPackages : Form
    {
        private const int MODIFY_INDEX = 7; // Modify button on Column 7 or 8th column

        private Package currentPackage;
        private PackagesProductsSupplier currentPkgProdSup;
        public frmPackages()
        {
            InitializeComponent();
        }

        private void frmPackages_Load(object sender, EventArgs e)
        {
            DisplayPackages();
        }

        private void DisplayPackages()
        {
            dgvPackages.Columns.Clear();// reset columns
            List<PackageDTO> packages = PackageDB.GetPackages();
            dgvPackages.DataSource = packages;

            // add modify button column
            var modifyColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                Text = "Modify",
                HeaderText = ""
            };
            dgvPackages.Columns.Add(modifyColumn);

            // do some formatting
            // format the column header
            dgvPackages.EnableHeadersVisualStyles = false;
            dgvPackages.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dgvPackages.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
            dgvPackages.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            // format the odd numbered rows
            dgvPackages.AlternatingRowsDefaultCellStyle.BackColor = Color.CadetBlue;

            // change to en-us locale
            CultureInfo.CurrentCulture = new CultureInfo("en-US", false); // change to en-US

            dgvPackages.Columns[0].HeaderText = "Package ID";
            dgvPackages.Columns[1].HeaderText = "Package Name";
            dgvPackages.Columns[2].HeaderText = "Start Date";
            dgvPackages.Columns[2].DefaultCellStyle.Format = "d"; // date
            dgvPackages.Columns[3].HeaderText = "End Date";
            dgvPackages.Columns[3].DefaultCellStyle.Format = "d";
            dgvPackages.Columns[4].HeaderText = "Description";
            dgvPackages.Columns[5].HeaderText = "Base Price";
            dgvPackages.Columns[5].DefaultCellStyle.Format = "c"; // currency
            dgvPackages.Columns[6].HeaderText = "Commission";
            dgvPackages.Columns[6].DefaultCellStyle.Format = "c";
            dgvPackages.AutoResizeRows();
            dgvPackages.AutoResizeColumns();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddModifyPackage secondForm = new frmAddModifyPackage();
            secondForm.isAdd = true;
            secondForm.currentPackage = null;
            secondForm.currentPkgProdSup = null;
            DialogResult result = secondForm.ShowDialog();
            if (result == DialogResult.OK) // proceed with add
            {
                currentPackage = secondForm.currentPackage;
                currentPkgProdSup = secondForm.currentPkgProdSup;

                if (currentPackage != null && currentPkgProdSup != null)
                {
                    try
                    {
                        PackageDB.AddPackage(currentPackage);
                        currentPkgProdSup.PackageId = currentPackage.PackageId;
                        PackagesProductsSupplierDB.AddPkgProdSup(currentPkgProdSup);
                        DisplayPackages(); // refresh grid
                    }
                    catch (DbUpdateException ex) // errors coming from SaveChanges
                    {
                        string errorMessage = "Error(s) while adding package:\n";
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
                        MessageBox.Show("Database connection lost while adding a package. Try again later");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error while adding a package: " +
                            ex.Message, ex.GetType().ToString());
                    }
                }
            }
        }

        private void dgvPackage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // e.ColumnIndex is the column where the click happened
            // e.RowIndex is the row where the click happened
            if (e.ColumnIndex == MODIFY_INDEX)
            {
                int packageId = Convert.ToInt16(dgvPackages.Rows[e.RowIndex].Cells[0].Value.ToString().Trim());
                try
                {
                    currentPackage = PackageDB.FindPackage(packageId);
                    if (currentPackage != null)
                    {
                        ModifyPackage();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while finding a package: " +
                        ex.Message, ex.GetType().ToString());
                }
            }
        }

        private void ModifyPackage()
        {
            frmAddModifyPackage secondForm = new frmAddModifyPackage();
            secondForm.isAdd = false; // it is modify
            secondForm.currentPackage = currentPackage;
            DialogResult result = secondForm.ShowDialog();
            if (result == DialogResult.OK) // proceed with modify
            {
                currentPackage = secondForm.currentPackage; // new data values
                try
                {
                    PackageDB.UpdatePackage(currentPackage);
                    DisplayPackages(); // refresh grid
                }
                catch (DbUpdateException ex) // errors coming from SaveChanges
                {
                    string errorMessage = "Error(s) while modifying package:\n";
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
                    MessageBox.Show("Database connection lost while modifying a package." +
                        " Try again later");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while modifying a package: " +
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
