namespace TravelExperts
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            btnPackages = new Button();
            btnProducts = new Button();
            btnSuppliers = new Button();
            btnProdSupp = new Button();
            btnExit = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnPackages
            // 
            btnPackages.BackColor = Color.Salmon;
            btnPackages.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnPackages.ForeColor = SystemColors.ButtonHighlight;
            btnPackages.Location = new Point(316, 301);
            btnPackages.Margin = new Padding(4, 4, 4, 4);
            btnPackages.Name = "btnPackages";
            btnPackages.Size = new Size(190, 64);
            btnPackages.TabIndex = 0;
            btnPackages.Text = "Packages";
            btnPackages.UseVisualStyleBackColor = false;
            btnPackages.Click += btnPackages_Click;
            // 
            // btnProducts
            // 
            btnProducts.BackColor = Color.FromArgb(0, 192, 192);
            btnProducts.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnProducts.ForeColor = SystemColors.ButtonHighlight;
            btnProducts.Location = new Point(316, 392);
            btnProducts.Margin = new Padding(4, 4, 4, 4);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(190, 67);
            btnProducts.TabIndex = 1;
            btnProducts.Text = "Products";
            btnProducts.UseVisualStyleBackColor = false;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnSuppliers
            // 
            btnSuppliers.BackColor = Color.FromArgb(255, 128, 128);
            btnSuppliers.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSuppliers.ForeColor = Color.White;
            btnSuppliers.Location = new Point(772, 301);
            btnSuppliers.Margin = new Padding(4, 4, 4, 4);
            btnSuppliers.Name = "btnSuppliers";
            btnSuppliers.Size = new Size(192, 62);
            btnSuppliers.TabIndex = 2;
            btnSuppliers.Text = "Suppliers";
            btnSuppliers.UseVisualStyleBackColor = false;
            btnSuppliers.Click += btnSuppliers_Click;
            // 
            // btnProdSupp
            // 
            btnProdSupp.BackColor = Color.FromArgb(0, 192, 192);
            btnProdSupp.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnProdSupp.ForeColor = SystemColors.ButtonHighlight;
            btnProdSupp.Location = new Point(772, 392);
            btnProdSupp.Margin = new Padding(4, 4, 4, 4);
            btnProdSupp.Name = "btnProdSupp";
            btnProdSupp.Size = new Size(192, 67);
            btnProdSupp.TabIndex = 3;
            btnProdSupp.Text = "Products Suppliers";
            btnProdSupp.UseVisualStyleBackColor = false;
            btnProdSupp.Click += btnProdSupp_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.White;
            btnExit.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.FromArgb(255, 128, 128);
            btnExit.Location = new Point(546, 347);
            btnExit.Margin = new Padding(4, 4, 4, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(183, 66);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(332, 8);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(633, 281);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(12, 69);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(288, 99);
            label1.TabIndex = 6;
            label1.Text = "Travel";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(4, 169);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(324, 99);
            label2.TabIndex = 7;
            label2.Text = "Experts";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            CancelButton = btnExit;
            ClientSize = new Size(1004, 464);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnExit);
            Controls.Add(btnProdSupp);
            Controls.Add(btnSuppliers);
            Controls.Add(btnProducts);
            Controls.Add(btnPackages);
            Margin = new Padding(4, 4, 4, 4);
            Name = "frmMain";
            Text = "Main Page";
            Load += frmMain_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPackages;
        private Button btnProducts;
        private Button btnSuppliers;
        private Button btnProdSupp;
        private Button btnExit;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
    }
}