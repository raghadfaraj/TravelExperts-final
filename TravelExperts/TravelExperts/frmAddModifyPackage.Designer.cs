namespace TravelExpertsGUI
{
    partial class frmAddModifyPackage
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
            label3 = new Label();
            label2 = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtPkgName = new TextBox();
            label8 = new Label();
            label9 = new Label();
            txtDesc = new TextBox();
            txtPrice = new TextBox();
            txtCommission = new TextBox();
            dtpStart = new DateTimePicker();
            dtpEnd = new DateTimePicker();
            cboProduct = new ComboBox();
            cboSupplier = new ComboBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(176, 321);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(180, 45);
            label3.TabIndex = 21;
            label3.Text = "Start Date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(106, 238);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(249, 45);
            label2.TabIndex = 20;
            label2.Text = "Package Name:";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(255, 128, 128);
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(773, 753);
            btnCancel.Margin = new Padding(6);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(176, 78);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.MediumTurquoise;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(170, 759);
            btnSave.Margin = new Padding(6);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(187, 72);
            btnSave.TabIndex = 17;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(192, 406);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(164, 45);
            label4.TabIndex = 24;
            label4.Text = "End Date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(155, 487);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(201, 45);
            label5.TabIndex = 25;
            label5.Text = "Description:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(175, 572);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(181, 45);
            label6.TabIndex = 26;
            label6.Text = "Base Price:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(144, 655);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(212, 45);
            label7.TabIndex = 27;
            label7.Text = "Commission:";
            // 
            // txtPkgName
            // 
            txtPkgName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPkgName.Location = new Point(444, 234);
            txtPkgName.Margin = new Padding(6);
            txtPkgName.Name = "txtPkgName";
            txtPkgName.Size = new Size(600, 50);
            txtPkgName.TabIndex = 28;
            txtPkgName.Tag = "Package Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(209, 50);
            label8.Margin = new Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new Size(148, 45);
            label8.TabIndex = 33;
            label8.Text = "Product:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(201, 146);
            label9.Name = "label9";
            label9.Size = new Size(155, 45);
            label9.TabIndex = 34;
            label9.Text = "Supplier:";
            // 
            // txtDesc
            // 
            txtDesc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDesc.Location = new Point(444, 484);
            txtDesc.Margin = new Padding(6);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(600, 50);
            txtDesc.TabIndex = 35;
            txtDesc.Tag = "Package Description";
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrice.Location = new Point(444, 569);
            txtPrice.Margin = new Padding(6);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(305, 50);
            txtPrice.TabIndex = 36;
            txtPrice.Tag = "Package Base Price";
            // 
            // txtCommission
            // 
            txtCommission.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCommission.Location = new Point(444, 652);
            txtCommission.Margin = new Padding(6);
            txtCommission.Name = "txtCommission";
            txtCommission.Size = new Size(305, 50);
            txtCommission.TabIndex = 37;
            txtCommission.Tag = "Package Agency Commission";
            // 
            // dtpStart
            // 
            dtpStart.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpStart.Location = new Point(444, 316);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(600, 50);
            dtpStart.TabIndex = 38;
            dtpStart.Tag = "Package Start Date";
            // 
            // dtpEnd
            // 
            dtpEnd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpEnd.Location = new Point(444, 401);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(600, 50);
            dtpEnd.TabIndex = 39;
            dtpEnd.Tag = "Package End Date";
            // 
            // cboProduct
            // 
            cboProduct.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboProduct.FormattingEnabled = true;
            cboProduct.Location = new Point(444, 50);
            cboProduct.Name = "cboProduct";
            cboProduct.Size = new Size(600, 53);
            cboProduct.TabIndex = 40;
            // 
            // cboSupplier
            // 
            cboSupplier.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboSupplier.FormattingEnabled = true;
            cboSupplier.Location = new Point(444, 138);
            cboSupplier.Name = "cboSupplier";
            cboSupplier.Size = new Size(600, 53);
            cboSupplier.TabIndex = 41;
            // 
            // frmAddModifyPackage
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            CancelButton = btnCancel;
            ClientSize = new Size(1102, 888);
            Controls.Add(cboSupplier);
            Controls.Add(cboProduct);
            Controls.Add(dtpEnd);
            Controls.Add(dtpStart);
            Controls.Add(txtCommission);
            Controls.Add(txtPrice);
            Controls.Add(txtDesc);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtPkgName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Name = "frmAddModifyPackage";
            Text = "frmAddModifyPackage";
            Load += frmAddModifyPackage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboSupplierId;
        private ComboBox cboProductId;
        private Label label3;
        private Label label2;
        private Button btnCancel;
        private Button btnSave;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtPkgName;
        private Label label8;
        private Label label9;
        private TextBox txtDesc;
        private TextBox txtPrice;
        private TextBox txtCommission;
        private DateTimePicker dtpStart;
        private DateTimePicker dtpEnd;
        private ComboBox cboProduct;
        private ComboBox cboSupplier;
    }
}