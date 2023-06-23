namespace TravelExpertsGUI
{
    partial class frmAddModifySupplier
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
            label2 = new Label();
            label1 = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            txtSupplierName = new TextBox();
            txtSupplierId = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(14, 179);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(251, 45);
            label2.TabIndex = 11;
            label2.Text = "Supplier Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(68, 67);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(197, 45);
            label1.TabIndex = 10;
            label1.Text = "Supplier ID:";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(255, 128, 128);
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(447, 287);
            btnCancel.Margin = new Padding(6);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(244, 69);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.MediumTurquoise;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(106, 287);
            btnSave.Margin = new Padding(6);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(244, 69);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtSupplierName
            // 
            txtSupplierName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSupplierName.Location = new Point(290, 176);
            txtSupplierName.Margin = new Padding(6);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(456, 50);
            txtSupplierName.TabIndex = 7;
            txtSupplierName.Tag = "Supplier Name";
            // 
            // txtSupplierId
            // 
            txtSupplierId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSupplierId.Location = new Point(290, 64);
            txtSupplierId.Margin = new Padding(6);
            txtSupplierId.Name = "txtSupplierId";
            txtSupplierId.Size = new Size(256, 50);
            txtSupplierId.TabIndex = 6;
            txtSupplierId.Tag = "Supplier ID";
            // 
            // frmAddModifySupplier
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            CancelButton = btnCancel;
            ClientSize = new Size(794, 405);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtSupplierName);
            Controls.Add(txtSupplierId);
            Name = "frmAddModifySupplier";
            Text = "Add/Modify Supplier";
            Load += frmAddModifySupplier_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button btnCancel;
        private Button btnSave;
        private TextBox txtSupplierName;
        private TextBox txtSupplierId;
    }
}