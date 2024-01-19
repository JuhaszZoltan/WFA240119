namespace WFA240119
{
    partial class RentForm
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
            cbxNames = new ComboBox();
            dtpStart = new DateTimePicker();
            nudDays = new NumericUpDown();
            lblUI01 = new Label();
            dgvBikes = new DataGridView();
            btnNewRental = new Button();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            lblUI02 = new Label();
            lblUI03 = new Label();
            lblUI04 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudDays).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBikes).BeginInit();
            SuspendLayout();
            // 
            // cbxNames
            // 
            cbxNames.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxNames.FormattingEnabled = true;
            cbxNames.Location = new Point(12, 27);
            cbxNames.Name = "cbxNames";
            cbxNames.Size = new Size(314, 23);
            cbxNames.TabIndex = 0;
            // 
            // dtpStart
            // 
            dtpStart.Format = DateTimePickerFormat.Short;
            dtpStart.Location = new Point(12, 71);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(314, 23);
            dtpStart.TabIndex = 1;
            // 
            // nudDays
            // 
            nudDays.Location = new Point(12, 115);
            nudDays.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            nudDays.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudDays.Name = "nudDays";
            nudDays.Size = new Size(314, 23);
            nudDays.TabIndex = 2;
            nudDays.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblUI01
            // 
            lblUI01.AutoSize = true;
            lblUI01.Location = new Point(12, 9);
            lblUI01.Name = "lblUI01";
            lblUI01.Size = new Size(151, 15);
            lblUI01.TabIndex = 3;
            lblUI01.Text = "select a customer by name:";
            // 
            // dgvBikes
            // 
            dgvBikes.AllowUserToAddRows = false;
            dgvBikes.AllowUserToDeleteRows = false;
            dgvBikes.AllowUserToResizeColumns = false;
            dgvBikes.AllowUserToResizeRows = false;
            dgvBikes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBikes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvBikes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBikes.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column5 });
            dgvBikes.Location = new Point(12, 159);
            dgvBikes.Name = "dgvBikes";
            dgvBikes.RowHeadersVisible = false;
            dgvBikes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBikes.Size = new Size(314, 192);
            dgvBikes.TabIndex = 4;
            // 
            // btnNewRental
            // 
            btnNewRental.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnNewRental.ForeColor = Color.Black;
            btnNewRental.Location = new Point(12, 359);
            btnNewRental.Name = "btnNewRental";
            btnNewRental.Size = new Size(314, 42);
            btnNewRental.TabIndex = 5;
            btnNewRental.Text = "NEW RENTAL";
            btnNewRental.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            Column1.FillWeight = 1F;
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.FillWeight = 3F;
            Column2.HeaderText = "type";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.FillWeight = 2F;
            Column3.HeaderText = "color";
            Column3.Name = "Column3";
            // 
            // Column5
            // 
            Column5.FillWeight = 1F;
            Column5.HeaderText = "size";
            Column5.Name = "Column5";
            // 
            // lblUI02
            // 
            lblUI02.AutoSize = true;
            lblUI02.Location = new Point(12, 53);
            lblUI02.Name = "lblUI02";
            lblUI02.Size = new Size(117, 15);
            lblUI02.TabIndex = 3;
            lblUI02.Text = "start of rental period:";
            // 
            // lblUI03
            // 
            lblUI03.AutoSize = true;
            lblUI03.Location = new Point(12, 97);
            lblUI03.Name = "lblUI03";
            lblUI03.Size = new Size(93, 15);
            lblUI03.TabIndex = 3;
            lblUI03.Text = "number of days:";
            // 
            // lblUI04
            // 
            lblUI04.AutoSize = true;
            lblUI04.Location = new Point(12, 141);
            lblUI04.Name = "lblUI04";
            lblUI04.Size = new Size(82, 15);
            lblUI04.TabIndex = 3;
            lblUI04.Text = "choose a bike:";
            // 
            // RentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 413);
            Controls.Add(btnNewRental);
            Controls.Add(dgvBikes);
            Controls.Add(lblUI04);
            Controls.Add(lblUI03);
            Controls.Add(lblUI02);
            Controls.Add(lblUI01);
            Controls.Add(nudDays);
            Controls.Add(dtpStart);
            Controls.Add(cbxNames);
            Name = "RentForm";
            Text = "Rental";
            ((System.ComponentModel.ISupportInitialize)nudDays).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBikes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbxNames;
        private DateTimePicker dtpStart;
        private NumericUpDown nudDays;
        private Label lblUI01;
        private DataGridView dgvBikes;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column5;
        private Button btnNewRental;
        private Label lblUI02;
        private Label lblUI03;
        private Label lblUI04;
    }
}