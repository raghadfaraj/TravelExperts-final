namespace TravelExpertsGUI
{
    partial class frmAddModifyProduct
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
            txtProductName = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtProductName
            // 
            txtProductName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtProductName.Location = new Point(78, 115);
            txtProductName.Margin = new Padding(6);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(451, 50);
            txtProductName.TabIndex = 1;
            txtProductName.Tag = "Product Name";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.MediumTurquoise;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(78, 198);
            btnSave.Margin = new Padding(6);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(200, 69);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(255, 128, 128);
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(329, 198);
            btnCancel.Margin = new Padding(6);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(200, 69);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(78, 54);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(245, 45);
            label2.TabIndex = 5;
            label2.Text = "Product Name:";
            // 
            // frmAddModifyProduct
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            CancelButton = btnCancel;
            ClientSize = new Size(612, 313);
            Controls.Add(label2);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtProductName);
            Margin = new Padding(6);
            Name = "frmAddModifyProduct";
            Text = "Add/Modify Product";
            Load += frmAddModifyProduct_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtProductName;
        private Button btnSave;
        private Button btnCancel;
        private Label label2;
    }
}