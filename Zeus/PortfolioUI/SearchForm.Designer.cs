namespace PortfolioUI
{
    partial class SearchForm
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
            label1 = new Label();
            txtDescription = new TextBox();
            btnSearch = new Button();
            DGVSearch = new DataGridView();
            panel6 = new Panel();
            label2 = new Label();
            label3 = new Label();
            cmbBD = new ComboBox();
            btnClear = new Button();
            lblProductClass = new Label();
            cmbProductClass = new ComboBox();
            lblOnSaleDate = new Label();
            dtpOnSaleDateFrom = new DateTimePicker();
            label4 = new Label();
            dtpOnSaleDateTo = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)DGVSearch).BeginInit();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 189);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "Description:";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(145, 186);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(322, 23);
            txtDescription.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1329, 219);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // DGVSearch
            // 
            DGVSearch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVSearch.Location = new Point(69, 293);
            DGVSearch.Name = "DGVSearch";
            DGVSearch.Size = new Size(1448, 621);
            DGVSearch.TabIndex = 3;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(0, 32, 96);
            panel6.Controls.Add(label2);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1626, 144);
            panel6.TabIndex = 149;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(35, 47);
            label2.Name = "label2";
            label2.Size = new Size(391, 65);
            label2.TabIndex = 0;
            label2.Text = "Portfolio Search";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(114, 219);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 150;
            label3.Text = "BD:";
            // 
            // cmbBD
            // 
            cmbBD.FormattingEnabled = true;
            cmbBD.Location = new Point(145, 216);
            cmbBD.Name = "cmbBD";
            cmbBD.Size = new Size(181, 23);
            cmbBD.TabIndex = 151;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(1446, 219);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 152;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lblProductClass
            // 
            lblProductClass.AutoSize = true;
            lblProductClass.Location = new Point(57, 248);
            lblProductClass.Name = "lblProductClass";
            lblProductClass.Size = new Size(82, 15);
            lblProductClass.TabIndex = 153;
            lblProductClass.Text = "Product Class:";
            // 
            // cmbProductClass
            // 
            cmbProductClass.BackColor = SystemColors.Control;
            cmbProductClass.FormattingEnabled = true;
            cmbProductClass.Items.AddRange(new object[] { "Specials", "Seasonal - Easter", "Seasonal - Christmas" });
            cmbProductClass.Location = new Point(145, 245);
            cmbProductClass.Name = "cmbProductClass";
            cmbProductClass.Size = new Size(205, 23);
            cmbProductClass.TabIndex = 122;
            // 
            // lblOnSaleDate
            // 
            lblOnSaleDate.Location = new Point(492, 181);
            lblOnSaleDate.Name = "lblOnSaleDate";
            lblOnSaleDate.Size = new Size(110, 23);
            lblOnSaleDate.TabIndex = 155;
            lblOnSaleDate.Text = "On Sale Date From:";
            lblOnSaleDate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dtpOnSaleDateFrom
            // 
            dtpOnSaleDateFrom.CustomFormat = " ";
            dtpOnSaleDateFrom.Format = DateTimePickerFormat.Short;
            dtpOnSaleDateFrom.Location = new Point(608, 181);
            dtpOnSaleDateFrom.Name = "dtpOnSaleDateFrom";
            dtpOnSaleDateFrom.Size = new Size(96, 23);
            dtpOnSaleDateFrom.TabIndex = 154;
            // 
            // label4
            // 
            label4.Location = new Point(710, 181);
            label4.Name = "label4";
            label4.Size = new Size(110, 23);
            label4.TabIndex = 157;
            label4.Text = "On Sale Date To:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dtpOnSaleDateTo
            // 
            dtpOnSaleDateTo.CustomFormat = " ";
            dtpOnSaleDateTo.Format = DateTimePickerFormat.Short;
            dtpOnSaleDateTo.Location = new Point(826, 181);
            dtpOnSaleDateTo.Name = "dtpOnSaleDateTo";
            dtpOnSaleDateTo.Size = new Size(96, 23);
            dtpOnSaleDateTo.TabIndex = 156;
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1626, 953);
            Controls.Add(label4);
            Controls.Add(dtpOnSaleDateTo);
            Controls.Add(lblOnSaleDate);
            Controls.Add(dtpOnSaleDateFrom);
            Controls.Add(cmbProductClass);
            Controls.Add(lblProductClass);
            Controls.Add(btnClear);
            Controls.Add(cmbBD);
            Controls.Add(label3);
            Controls.Add(panel6);
            Controls.Add(DGVSearch);
            Controls.Add(btnSearch);
            Controls.Add(txtDescription);
            Controls.Add(label1);
            Name = "SearchForm";
            Text = "SearchForm";
            ((System.ComponentModel.ISupportInitialize)DGVSearch).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView DGVSearch;
        private Panel panel6;
        private Label label2;
        private Label label3;
        private ComboBox cmbBD;
        private Button btnClear;
        private Label lblProductClass;
        private ComboBox cmbProductClass;
        private Label lblOnSaleDate;
        private DateTimePicker dtpOnSaleDateFrom;
        private Label label4;
        private DateTimePicker dtpOnSaleDateTo;
    }
}
