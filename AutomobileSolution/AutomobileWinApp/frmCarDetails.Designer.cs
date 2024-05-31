namespace AutomobileWinApp
{
    partial class frmCarDetails
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
            lbCarName = new Label();
            lbManufacturer = new Label();
            lbPrice = new Label();
            lbReleaseYear = new Label();
            txtCarID = new TextBox();
            txtCarName = new TextBox();
            txtReleaseYear = new MaskedTextBox();
            txtPrice = new MaskedTextBox();
            cboManufacturer = new ComboBox();
            btnSave = new Button();
            btnCancel = new Button();
            lbCarID = new Label();
            SuspendLayout();
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Font = new Font("Segoe UI", 10F);
            lbCarName.Location = new Point(32, 87);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new Size(87, 23);
            lbCarName.TabIndex = 1;
            lbCarName.Text = "Car Name";
            // 
            // lbManufacturer
            // 
            lbManufacturer.AutoSize = true;
            lbManufacturer.Font = new Font("Segoe UI", 10F);
            lbManufacturer.Location = new Point(32, 137);
            lbManufacturer.Name = "lbManufacturer";
            lbManufacturer.Size = new Size(113, 23);
            lbManufacturer.TabIndex = 2;
            lbManufacturer.Text = "Manufacturer";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Font = new Font("Segoe UI", 10F);
            lbPrice.Location = new Point(32, 189);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(47, 23);
            lbPrice.TabIndex = 3;
            lbPrice.Text = "Price";
            // 
            // lbReleaseYear
            // 
            lbReleaseYear.AutoSize = true;
            lbReleaseYear.Font = new Font("Segoe UI", 10F);
            lbReleaseYear.Location = new Point(32, 233);
            lbReleaseYear.Name = "lbReleaseYear";
            lbReleaseYear.Size = new Size(114, 23);
            lbReleaseYear.TabIndex = 4;
            lbReleaseYear.Text = "Released Year";
            // 
            // txtCarID
            // 
            txtCarID.Location = new Point(180, 44);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(318, 27);
            txtCarID.TabIndex = 5;
            // 
            // txtCarName
            // 
            txtCarName.BackColor = Color.White;
            txtCarName.Location = new Point(180, 87);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new Size(318, 27);
            txtCarName.TabIndex = 6;
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new Point(180, 229);
            txtReleaseYear.Mask = "0000";
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(318, 27);
            txtReleaseYear.TabIndex = 7;
            txtReleaseYear.Text = "0";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(180, 185);
            txtPrice.Mask = "000000000";
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(318, 27);
            txtPrice.TabIndex = 8;
            txtPrice.Text = "0";
            // 
            // cboManufacturer
            // 
            cboManufacturer.BackColor = Color.FromArgb(224, 224, 224);
            cboManufacturer.ForeColor = SystemColors.ControlText;
            cboManufacturer.FormattingEnabled = true;
            cboManufacturer.Items.AddRange(new object[] { "Audi", "BMW", "Ford", "Honda", "Hyundai", "Kia", "Suzuki", "Toyota" });
            cboManufacturer.Location = new Point(180, 137);
            cboManufacturer.Name = "cboManufacturer";
            cboManufacturer.Size = new Size(318, 28);
            cboManufacturer.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(224, 224, 224);
            btnSave.DialogResult = DialogResult.OK;
            btnSave.ForeColor = SystemColors.ControlText;
            btnSave.Location = new Point(180, 299);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(116, 40);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(224, 224, 224);
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(378, 299);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 40);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lbCarID
            // 
            lbCarID.AutoSize = true;
            lbCarID.Font = new Font("Segoe UI", 10F);
            lbCarID.ForeColor = SystemColors.ControlText;
            lbCarID.Location = new Point(32, 45);
            lbCarID.Name = "lbCarID";
            lbCarID.Size = new Size(58, 23);
            lbCarID.TabIndex = 12;
            lbCarID.Text = "Car ID";
            // 
            // frmCarDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 362);
            Controls.Add(lbCarID);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cboManufacturer);
            Controls.Add(txtPrice);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtCarName);
            Controls.Add(txtCarID);
            Controls.Add(lbReleaseYear);
            Controls.Add(lbPrice);
            Controls.Add(lbManufacturer);
            Controls.Add(lbCarName);
            Name = "frmCarDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCarDetails";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbCarName;
        private Label lbManufacturer;
        private Label lbPrice;
        private Label lbReleaseYear;
        private TextBox txtCarID;
        private TextBox txtCarName;
        private MaskedTextBox txtReleaseYear;
        private MaskedTextBox txtPrice;
        private ComboBox cboManufacturer;
        private Button btnSave;
        private Button btnCancel;
        private Label lbCarID;
    }
}