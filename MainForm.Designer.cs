namespace WFA240119
{
    partial class MainForm
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
            btnNewRent = new Button();
            cbxTypes = new ComboBox();
            lblUI01 = new Label();
            dgvRents = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvRents).BeginInit();
            SuspendLayout();
            // 
            // btnNewRent
            // 
            btnNewRent.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnNewRent.ForeColor = Color.LimeGreen;
            btnNewRent.Location = new Point(12, 12);
            btnNewRent.Name = "btnNewRent";
            btnNewRent.Size = new Size(326, 52);
            btnNewRent.TabIndex = 0;
            btnNewRent.Text = "RECORD NEW RENT";
            btnNewRent.UseVisualStyleBackColor = true;
            // 
            // cbxTypes
            // 
            cbxTypes.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTypes.FormattingEnabled = true;
            cbxTypes.Location = new Point(380, 41);
            cbxTypes.Name = "cbxTypes";
            cbxTypes.Size = new Size(246, 23);
            cbxTypes.TabIndex = 1;
            // 
            // lblUI01
            // 
            lblUI01.AutoSize = true;
            lblUI01.Location = new Point(380, 12);
            lblUI01.Name = "lblUI01";
            lblUI01.Size = new Size(126, 15);
            lblUI01.TabIndex = 2;
            lblUI01.Text = "filter for this type only:";
            // 
            // dgvRents
            // 
            dgvRents.AllowUserToAddRows = false;
            dgvRents.AllowUserToDeleteRows = false;
            dgvRents.AllowUserToResizeColumns = false;
            dgvRents.AllowUserToResizeRows = false;
            dgvRents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRents.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvRents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRents.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dgvRents.Location = new Point(12, 82);
            dgvRents.Name = "dgvRents";
            dgvRents.RowHeadersVisible = false;
            dgvRents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRents.Size = new Size(614, 308);
            dgvRents.TabIndex = 3;
            // 
            // Column1
            // 
            Column1.FillWeight = 1F;
            Column1.HeaderText = "Customer";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.FillWeight = 3F;
            Column2.HeaderText = "Bike";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.FillWeight = 2F;
            Column3.HeaderText = "Start";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.FillWeight = 2F;
            Column4.HeaderText = "End";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.FillWeight = 1F;
            Column5.HeaderText = "Price";
            Column5.Name = "Column5";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 402);
            Controls.Add(dgvRents);
            Controls.Add(lblUI01);
            Controls.Add(cbxTypes);
            Controls.Add(btnNewRent);
            Name = "MainForm";
            Text = "Kobold Bikers 2023";
            ((System.ComponentModel.ISupportInitialize)dgvRents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNewRent;
        private ComboBox cbxTypes;
        private Label lblUI01;
        private DataGridView dgvRents;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}
