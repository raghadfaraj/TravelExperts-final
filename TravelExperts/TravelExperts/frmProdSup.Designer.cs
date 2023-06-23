namespace TravelExperts
{
    partial class frmProdSup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnExit = new Button();
            btnAdd = new Button();
            dgvProdSup = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProdSup).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.LightCoral;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(332, 348);
            btnExit.Margin = new Padding(2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(150, 43);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.MediumTurquoise;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(29, 348);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 43);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvProdSup
            // 
            dgvProdSup.BackgroundColor = Color.LightBlue;
            dgvProdSup.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdSup.Location = new Point(11, 11);
            dgvProdSup.Margin = new Padding(2);
            dgvProdSup.Name = "dgvProdSup";
            dgvProdSup.RowHeadersWidth = 82;
            dgvProdSup.RowTemplate.Height = 25;
            dgvProdSup.Size = new Size(494, 318);
            dgvProdSup.TabIndex = 3;
            dgvProdSup.CellClick += dgvProdSup_CellClick;
            dgvProdSup.CellContentClick += dgvProdSup_CellContentClick;
            // 
            // frmProdSup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            CancelButton = btnExit;
            ClientSize = new Size(521, 409);
            Controls.Add(btnExit);
            Controls.Add(btnAdd);
            Controls.Add(dgvProdSup);
            Margin = new Padding(2);
            Name = "frmProdSup";
            Text = "Products Suppliers";
            Load += frmProdSup_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProdSup).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnExit;
        private Button btnAdd;
        private DataGridView dgvProdSup;
    }
}