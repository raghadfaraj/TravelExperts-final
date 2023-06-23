using TravelExpertsGUI;

namespace TravelExperts
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            var productForm = new frmProducts();
            productForm.ShowDialog();
        }

        private void btnPackages_Click(object sender, EventArgs e)
        {
            var packagesForm = new frmPackages();
            packagesForm.ShowDialog();
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            var suppliersForm = new frmSuppliers();
            suppliersForm.ShowDialog();
        }

        private void btnProdSupp_Click(object sender, EventArgs e)
        {
            var prodSuppForm = new frmProdSup();
            prodSuppForm.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}