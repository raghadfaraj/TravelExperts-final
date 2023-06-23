namespace TravelExperts
{
    partial class frmPackages
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
            dgvPackages = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPackages).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(255, 128, 128);
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(677, 381);
            btnExit.Margin = new Padding(2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(150, 43);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.MediumTurquoise;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(282, 381);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 43);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvPackages
            // 
            dgvPackages.BackgroundColor = Color.PaleTurquoise;
            dgvPackages.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPackages.Location = new Point(8, 46);
            dgvPackages.Margin = new Padding(2);
            dgvPackages.Name = "dgvPackages";
            dgvPackages.RowHeadersWidth = 82;
            dgvPackages.RowTemplate.Height = 25;
            dgvPackages.Size = new Size(1115, 318);
            dgvPackages.TabIndex = 6;
            dgvPackages.CellClick += dgvPackage_CellClick;
            // 
            // frmPackages
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            CancelButton = btnExit;
            ClientSize = new Size(1130, 449);
            Controls.Add(btnExit);
            Controls.Add(btnAdd);
            Controls.Add(dgvPackages);
            Margin = new Padding(2);
            Name = "frmPackages";
            Text = "Packages";
            Load += frmPackages_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPackages).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnExit;
        private Button btnAdd;
        private DataGridView dgvPackages;
    }
}