using System.Windows.Forms;

namespace PortfolioUI
{
    partial class PortfolioEntry
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

        private void InitializeComponent()
        {
            txtDescription = new TextBox();
            dtpOnSaleDate = new DateTimePicker();
            txtTheme = new TextBox();
            txtOnSaleWeek = new TextBox();
            txtDayOfWeek = new TextBox();
            txtOnSaleYear = new TextBox();
            lblOnSaleYear = new Label();
            lblDayOfWeek = new Label();
            lblProductClass = new Label();
            lblTheme = new Label();
            lblDescription = new Label();
            lblOnSaleDate = new Label();
            lblOnSaleWeek = new Label();
            btnCreatePortfolio = new Button();
            lblAGCCategory = new Label();
            cmbCategory = new ComboBox();
            lblACGCG = new Label();
            cmbCG = new ComboBox();
            cmbSCG = new ComboBox();
            lblACGSCG = new Label();
            cmbBrandOrALDIPL = new ComboBox();
            lblBrandOrALDIPL = new Label();
            lblRegions = new Label();
            flpRegions = new FlowLayoutPanel();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox8 = new CheckBox();
            checkBox7 = new CheckBox();
            BtnSelectAll = new Button();
            txtPlannedQuantity = new TextBox();
            txtCost = new TextBox();
            txtFreightCost = new TextBox();
            txtRetail = new TextBox();
            txtSales = new TextBox();
            chkGST = new CheckBox();
            lblPlannedQuantity = new Label();
            lblCost = new Label();
            lblFreightCost = new Label();
            lblRetail = new Label();
            lblSales = new Label();
            txtContractedQuantity = new TextBox();
            txtDuty = new TextBox();
            txtEstDeliveredCost = new TextBox();
            txtMarginPercent = new TextBox();
            txtMargin = new TextBox();
            lblContractedQuantity = new Label();
            lblCurrency = new Label();
            lblIncoterms = new Label();
            lblDuty = new Label();
            lblEstDeliveredCost = new Label();
            lblMarginPercent = new Label();
            lblMargin = new Label();
            cmbIncoTerms = new ComboBox();
            cmbCurrency = new ComboBox();
            cmbProductClass = new ComboBox();
            chkHarmonised = new CheckBox();
            cmbNewRepeatEPD = new ComboBox();
            lblSourcingEntity = new Label();
            lblNewRepeatEPD = new Label();
            cmbSourcingEntity = new ComboBox();
            txtPromotionID = new TextBox();
            lblPromotionID = new Label();
            txtDisplayID = new TextBox();
            txtSingleGenericID = new TextBox();
            txtPacksize = new TextBox();
            label1 = new Label();
            lblSingleGenericID = new Label();
            lblCaseSize = new Label();
            panel1 = new Panel();
            label15 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            lblGrpLbl1 = new Label();
            panel2 = new Panel();
            label23 = new Label();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            lblGrpLbl2 = new Label();
            panel3 = new Panel();
            label14 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            cmbBD = new ComboBox();
            lblBD = new Label();
            cmbEM = new ComboBox();
            lblEM = new Label();
            cmbBA = new ComboBox();
            lblBA = new Label();
            lblGrpLbl3 = new Label();
            lblGrpLbl4 = new Label();
            lblGrpLbl5 = new Label();
            panel4 = new Panel();
            label13 = new Label();
            panel5 = new Panel();
            label3 = new Label();
            lblCaseDimensions = new Label();
            lblUnitLength = new Label();
            txtUnitLength = new TextBox();
            lblUnitWidth = new Label();
            txtUnitWidth = new TextBox();
            lblUnitHeight = new Label();
            txtUnitHeight = new TextBox();
            lblCaseLength = new Label();
            txtCaseLength = new TextBox();
            lblCaseWidth = new Label();
            txtCaseWidth = new TextBox();
            lblCaseHeight = new Label();
            txtCaseHeight = new TextBox();
            panel6 = new Panel();
            label2 = new Label();
            btnValidate = new Button();
            cmbDBU = new ComboBox();
            lblDBU = new Label();
            cmbGD = new ComboBox();
            lblGD = new Label();
            panel7 = new Panel();
            flpRegions.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.Bisque;
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.Location = new Point(117, 12);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(513, 23);
            txtDescription.TabIndex = 0;
            // 
            // dtpOnSaleDate
            // 
            dtpOnSaleDate.CustomFormat = " ";
            dtpOnSaleDate.Format = DateTimePickerFormat.Short;
            dtpOnSaleDate.Location = new Point(118, 47);
            dtpOnSaleDate.Name = "dtpOnSaleDate";
            dtpOnSaleDate.Size = new Size(207, 23);
            dtpOnSaleDate.TabIndex = 1;
            dtpOnSaleDate.ValueChanged += dtpOnSaleDate_ValueChanged;
            // 
            // txtTheme
            // 
            txtTheme.BackColor = Color.Bisque;
            txtTheme.BorderStyle = BorderStyle.FixedSingle;
            txtTheme.Location = new Point(117, 79);
            txtTheme.Name = "txtTheme";
            txtTheme.Size = new Size(208, 23);
            txtTheme.TabIndex = 2;
            // 
            // txtOnSaleWeek
            // 
            txtOnSaleWeek.BackColor = Color.LightSkyBlue;
            txtOnSaleWeek.BorderStyle = BorderStyle.FixedSingle;
            txtOnSaleWeek.ForeColor = SystemColors.WindowText;
            txtOnSaleWeek.Location = new Point(530, 47);
            txtOnSaleWeek.Name = "txtOnSaleWeek";
            txtOnSaleWeek.Size = new Size(100, 23);
            txtOnSaleWeek.TabIndex = 4;
            // 
            // txtDayOfWeek
            // 
            txtDayOfWeek.BackColor = Color.LightSkyBlue;
            txtDayOfWeek.BorderStyle = BorderStyle.FixedSingle;
            txtDayOfWeek.Location = new Point(530, 76);
            txtDayOfWeek.Name = "txtDayOfWeek";
            txtDayOfWeek.Size = new Size(100, 23);
            txtDayOfWeek.TabIndex = 5;
            // 
            // txtOnSaleYear
            // 
            txtOnSaleYear.BackColor = Color.LightSkyBlue;
            txtOnSaleYear.BorderStyle = BorderStyle.FixedSingle;
            txtOnSaleYear.Location = new Point(530, 105);
            txtOnSaleYear.Name = "txtOnSaleYear";
            txtOnSaleYear.Size = new Size(100, 23);
            txtOnSaleYear.TabIndex = 6;
            // 
            // lblOnSaleYear
            // 
            lblOnSaleYear.Location = new Point(424, 105);
            lblOnSaleYear.Name = "lblOnSaleYear";
            lblOnSaleYear.Size = new Size(100, 23);
            lblOnSaleYear.TabIndex = 58;
            lblOnSaleYear.Text = "On Sale Year:";
            lblOnSaleYear.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDayOfWeek
            // 
            lblDayOfWeek.Location = new Point(424, 76);
            lblDayOfWeek.Name = "lblDayOfWeek";
            lblDayOfWeek.Size = new Size(100, 23);
            lblDayOfWeek.TabIndex = 49;
            lblDayOfWeek.Text = "Day Of Week:";
            lblDayOfWeek.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblProductClass
            // 
            lblProductClass.Location = new Point(12, 108);
            lblProductClass.Name = "lblProductClass";
            lblProductClass.Size = new Size(100, 23);
            lblProductClass.TabIndex = 57;
            lblProductClass.Text = "Product Class:";
            lblProductClass.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTheme
            // 
            lblTheme.Location = new Point(12, 78);
            lblTheme.Name = "lblTheme";
            lblTheme.Size = new Size(100, 23);
            lblTheme.TabIndex = 53;
            lblTheme.Text = "Theme:";
            lblTheme.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDescription
            // 
            lblDescription.Location = new Point(12, 12);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(100, 23);
            lblDescription.TabIndex = 46;
            lblDescription.Text = "Description:";
            lblDescription.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblOnSaleDate
            // 
            lblOnSaleDate.Location = new Point(12, 47);
            lblOnSaleDate.Name = "lblOnSaleDate";
            lblOnSaleDate.Size = new Size(100, 23);
            lblOnSaleDate.TabIndex = 48;
            lblOnSaleDate.Text = "On Sale Date:";
            lblOnSaleDate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblOnSaleWeek
            // 
            lblOnSaleWeek.Location = new Point(424, 47);
            lblOnSaleWeek.Name = "lblOnSaleWeek";
            lblOnSaleWeek.Size = new Size(100, 23);
            lblOnSaleWeek.TabIndex = 49;
            lblOnSaleWeek.Text = "On Sale Week:";
            lblOnSaleWeek.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnCreatePortfolio
            // 
            btnCreatePortfolio.Location = new Point(759, 610);
            btnCreatePortfolio.Name = "btnCreatePortfolio";
            btnCreatePortfolio.Size = new Size(243, 54);
            btnCreatePortfolio.TabIndex = 59;
            btnCreatePortfolio.Text = "Submit";
            btnCreatePortfolio.UseVisualStyleBackColor = true;
            btnCreatePortfolio.Click += btnCreatePortfolio_Click;
            // 
            // lblAGCCategory
            // 
            lblAGCCategory.Location = new Point(3, 13);
            lblAGCCategory.Name = "lblAGCCategory";
            lblAGCCategory.Size = new Size(100, 23);
            lblAGCCategory.TabIndex = 50;
            lblAGCCategory.Text = "ACG - Category:";
            lblAGCCategory.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cmbCategory
            // 
            cmbCategory.BackColor = Color.Bisque;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(109, 14);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(278, 23);
            cmbCategory.TabIndex = 60;
            // 
            // lblACGCG
            // 
            lblACGCG.Location = new Point(3, 54);
            lblACGCG.Name = "lblACGCG";
            lblACGCG.Size = new Size(100, 23);
            lblACGCG.TabIndex = 61;
            lblACGCG.Text = "ACG - CG:";
            lblACGCG.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cmbCG
            // 
            cmbCG.BackColor = Color.Bisque;
            cmbCG.FormattingEnabled = true;
            cmbCG.Location = new Point(109, 57);
            cmbCG.Name = "cmbCG";
            cmbCG.Size = new Size(278, 23);
            cmbCG.TabIndex = 62;
            // 
            // cmbSCG
            // 
            cmbSCG.BackColor = Color.Bisque;
            cmbSCG.FormattingEnabled = true;
            cmbSCG.Location = new Point(109, 98);
            cmbSCG.Name = "cmbSCG";
            cmbSCG.Size = new Size(278, 23);
            cmbSCG.TabIndex = 63;
            // 
            // lblACGSCG
            // 
            lblACGSCG.Location = new Point(21, 97);
            lblACGSCG.Name = "lblACGSCG";
            lblACGSCG.Size = new Size(82, 23);
            lblACGSCG.TabIndex = 64;
            lblACGSCG.Text = "ACG - SCG:";
            lblACGSCG.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cmbBrandOrALDIPL
            // 
            cmbBrandOrALDIPL.BackColor = Color.Bisque;
            cmbBrandOrALDIPL.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBrandOrALDIPL.Items.AddRange(new object[] { "Branded", "PL" });
            cmbBrandOrALDIPL.Location = new Point(118, 138);
            cmbBrandOrALDIPL.Name = "cmbBrandOrALDIPL";
            cmbBrandOrALDIPL.Size = new Size(205, 23);
            cmbBrandOrALDIPL.TabIndex = 65;
            // 
            // lblBrandOrALDIPL
            // 
            lblBrandOrALDIPL.Location = new Point(6, 138);
            lblBrandOrALDIPL.Name = "lblBrandOrALDIPL";
            lblBrandOrALDIPL.Size = new Size(106, 23);
            lblBrandOrALDIPL.TabIndex = 66;
            lblBrandOrALDIPL.Text = "Brand or ALDI P/L:";
            lblBrandOrALDIPL.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblRegions
            // 
            lblRegions.Location = new Point(59, 164);
            lblRegions.Name = "lblRegions";
            lblRegions.Size = new Size(53, 23);
            lblRegions.TabIndex = 93;
            lblRegions.Text = "Regions:";
            lblRegions.TextAlign = ContentAlignment.MiddleRight;
            // 
            // flpRegions
            // 
            flpRegions.Controls.Add(checkBox1);
            flpRegions.Controls.Add(checkBox2);
            flpRegions.Controls.Add(checkBox3);
            flpRegions.Controls.Add(checkBox4);
            flpRegions.Controls.Add(checkBox5);
            flpRegions.Controls.Add(checkBox6);
            flpRegions.Controls.Add(checkBox8);
            flpRegions.Controls.Add(checkBox7);
            flpRegions.Location = new Point(117, 167);
            flpRegions.Name = "flpRegions";
            flpRegions.Size = new Size(436, 28);
            flpRegions.TabIndex = 91;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(3, 3);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(49, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "MIN";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(58, 3);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(47, 19);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "DER";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(111, 3);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(45, 19);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "STP";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(162, 3);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(46, 19);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "PRE";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(214, 3);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(51, 19);
            checkBox5.TabIndex = 4;
            checkBox5.Text = "DAN";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(271, 3);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(46, 19);
            checkBox6.TabIndex = 5;
            checkBox6.Text = "BRE";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.Location = new Point(323, 3);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(48, 19);
            checkBox8.TabIndex = 7;
            checkBox8.Text = "RGY";
            checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Location = new Point(377, 3);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(43, 19);
            checkBox7.TabIndex = 6;
            checkBox7.Text = "JKT";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // BtnSelectAll
            // 
            BtnSelectAll.Location = new Point(559, 167);
            BtnSelectAll.Name = "BtnSelectAll";
            BtnSelectAll.Size = new Size(75, 23);
            BtnSelectAll.TabIndex = 92;
            BtnSelectAll.Text = "Select All";
            BtnSelectAll.Click += BtnSelectAll_Click;
            // 
            // txtPlannedQuantity
            // 
            txtPlannedQuantity.BackColor = Color.Bisque;
            txtPlannedQuantity.BorderStyle = BorderStyle.FixedSingle;
            txtPlannedQuantity.Location = new Point(118, 23);
            txtPlannedQuantity.Name = "txtPlannedQuantity";
            txtPlannedQuantity.Size = new Size(208, 23);
            txtPlannedQuantity.TabIndex = 94;
            txtPlannedQuantity.TextChanged += txtPlannedQuantity_TextChanged;
            // 
            // txtCost
            // 
            txtCost.BackColor = Color.Bisque;
            txtCost.BorderStyle = BorderStyle.FixedSingle;
            txtCost.Location = new Point(119, 62);
            txtCost.Name = "txtCost";
            txtCost.Size = new Size(100, 23);
            txtCost.TabIndex = 95;
            txtCost.TextChanged += txtCost_TextChanged;
            // 
            // txtFreightCost
            // 
            txtFreightCost.BackColor = Color.Bisque;
            txtFreightCost.BorderStyle = BorderStyle.FixedSingle;
            txtFreightCost.Location = new Point(118, 99);
            txtFreightCost.Name = "txtFreightCost";
            txtFreightCost.Size = new Size(100, 23);
            txtFreightCost.TabIndex = 96;
            txtFreightCost.TextChanged += txtFreightCost_TextChanged;
            // 
            // txtRetail
            // 
            txtRetail.BackColor = Color.Bisque;
            txtRetail.BorderStyle = BorderStyle.FixedSingle;
            txtRetail.Location = new Point(118, 142);
            txtRetail.Name = "txtRetail";
            txtRetail.Size = new Size(100, 23);
            txtRetail.TabIndex = 97;
            txtRetail.TextChanged += txtRetail_TextChanged;
            // 
            // txtSales
            // 
            txtSales.BackColor = Color.LightSkyBlue;
            txtSales.BorderStyle = BorderStyle.FixedSingle;
            txtSales.Location = new Point(118, 187);
            txtSales.Name = "txtSales";
            txtSales.Size = new Size(206, 23);
            txtSales.TabIndex = 98;
            // 
            // chkGST
            // 
            chkGST.Location = new Point(270, 122);
            chkGST.Name = "chkGST";
            chkGST.RightToLeft = RightToLeft.Yes;
            chkGST.Size = new Size(54, 24);
            chkGST.TabIndex = 99;
            chkGST.Text = ":GST";
            chkGST.TextAlign = ContentAlignment.MiddleRight;
            chkGST.CheckedChanged += chkGST_CheckedChanged;
            // 
            // lblPlannedQuantity
            // 
            lblPlannedQuantity.Location = new Point(3, 22);
            lblPlannedQuantity.Name = "lblPlannedQuantity";
            lblPlannedQuantity.Size = new Size(110, 23);
            lblPlannedQuantity.TabIndex = 100;
            lblPlannedQuantity.Text = "Planned Quantity:";
            lblPlannedQuantity.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCost
            // 
            lblCost.Location = new Point(13, 60);
            lblCost.Name = "lblCost";
            lblCost.Size = new Size(100, 23);
            lblCost.TabIndex = 101;
            lblCost.Text = "Cost:";
            lblCost.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblFreightCost
            // 
            lblFreightCost.Location = new Point(13, 99);
            lblFreightCost.Name = "lblFreightCost";
            lblFreightCost.Size = new Size(100, 23);
            lblFreightCost.TabIndex = 102;
            lblFreightCost.Text = "Freight Cost:";
            lblFreightCost.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblRetail
            // 
            lblRetail.Location = new Point(13, 142);
            lblRetail.Name = "lblRetail";
            lblRetail.Size = new Size(100, 23);
            lblRetail.TabIndex = 103;
            lblRetail.Text = "Retail:";
            lblRetail.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSales
            // 
            lblSales.Location = new Point(8, 185);
            lblSales.Name = "lblSales";
            lblSales.Size = new Size(105, 23);
            lblSales.TabIndex = 104;
            lblSales.Text = "Sales:";
            lblSales.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtContractedQuantity
            // 
            txtContractedQuantity.Location = new Point(471, 23);
            txtContractedQuantity.Name = "txtContractedQuantity";
            txtContractedQuantity.Size = new Size(160, 23);
            txtContractedQuantity.TabIndex = 105;
            txtContractedQuantity.TextChanged += txtContractedQuantity_TextChanged;
            // 
            // txtDuty
            // 
            txtDuty.BackColor = Color.Bisque;
            txtDuty.BorderStyle = BorderStyle.FixedSingle;
            txtDuty.Location = new Point(305, 93);
            txtDuty.Name = "txtDuty";
            txtDuty.Size = new Size(100, 23);
            txtDuty.TabIndex = 108;
            txtDuty.TextChanged += txtDuty_TextChanged;
            // 
            // txtEstDeliveredCost
            // 
            txtEstDeliveredCost.BackColor = Color.LightSkyBlue;
            txtEstDeliveredCost.BorderStyle = BorderStyle.FixedSingle;
            txtEstDeliveredCost.Location = new Point(531, 101);
            txtEstDeliveredCost.Name = "txtEstDeliveredCost";
            txtEstDeliveredCost.Size = new Size(100, 23);
            txtEstDeliveredCost.TabIndex = 109;
            // 
            // txtMarginPercent
            // 
            txtMarginPercent.BackColor = Color.LightSkyBlue;
            txtMarginPercent.BorderStyle = BorderStyle.FixedSingle;
            txtMarginPercent.Location = new Point(531, 142);
            txtMarginPercent.Name = "txtMarginPercent";
            txtMarginPercent.Size = new Size(100, 23);
            txtMarginPercent.TabIndex = 110;
            // 
            // txtMargin
            // 
            txtMargin.BackColor = Color.LightSkyBlue;
            txtMargin.BorderStyle = BorderStyle.FixedSingle;
            txtMargin.Location = new Point(447, 185);
            txtMargin.Name = "txtMargin";
            txtMargin.Size = new Size(184, 23);
            txtMargin.TabIndex = 111;
            // 
            // lblContractedQuantity
            // 
            lblContractedQuantity.Location = new Point(351, 22);
            lblContractedQuantity.Name = "lblContractedQuantity";
            lblContractedQuantity.Size = new Size(119, 23);
            lblContractedQuantity.TabIndex = 112;
            lblContractedQuantity.Text = "Contracted Quantity:";
            lblContractedQuantity.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCurrency
            // 
            lblCurrency.Location = new Point(229, 63);
            lblCurrency.Name = "lblCurrency";
            lblCurrency.Size = new Size(70, 23);
            lblCurrency.TabIndex = 113;
            lblCurrency.Text = "Currency:";
            lblCurrency.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblIncoterms
            // 
            lblIncoterms.Location = new Point(447, 59);
            lblIncoterms.Name = "lblIncoterms";
            lblIncoterms.Size = new Size(78, 23);
            lblIncoterms.TabIndex = 114;
            lblIncoterms.Text = "Incoterms:";
            lblIncoterms.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDuty
            // 
            lblDuty.Location = new Point(251, 91);
            lblDuty.Name = "lblDuty";
            lblDuty.Size = new Size(48, 23);
            lblDuty.TabIndex = 115;
            lblDuty.Text = "Duty:";
            lblDuty.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblEstDeliveredCost
            // 
            lblEstDeliveredCost.Location = new Point(418, 101);
            lblEstDeliveredCost.Name = "lblEstDeliveredCost";
            lblEstDeliveredCost.Size = new Size(107, 23);
            lblEstDeliveredCost.TabIndex = 116;
            lblEstDeliveredCost.Text = "Est Delivered Cost:";
            lblEstDeliveredCost.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblMarginPercent
            // 
            lblMarginPercent.Location = new Point(451, 140);
            lblMarginPercent.Name = "lblMarginPercent";
            lblMarginPercent.Size = new Size(74, 23);
            lblMarginPercent.TabIndex = 117;
            lblMarginPercent.Text = "Margin %:";
            lblMarginPercent.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblMargin
            // 
            lblMargin.Location = new Point(374, 183);
            lblMargin.Name = "lblMargin";
            lblMargin.Size = new Size(67, 23);
            lblMargin.TabIndex = 118;
            lblMargin.Text = "Margin $:";
            lblMargin.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cmbIncoTerms
            // 
            cmbIncoTerms.BackColor = Color.Bisque;
            cmbIncoTerms.FormattingEnabled = true;
            cmbIncoTerms.Items.AddRange(new object[] { "FOB", "ZEX", "DDP", "EXW" });
            cmbIncoTerms.Location = new Point(531, 60);
            cmbIncoTerms.Name = "cmbIncoTerms";
            cmbIncoTerms.Size = new Size(100, 23);
            cmbIncoTerms.TabIndex = 120;
            // 
            // cmbCurrency
            // 
            cmbCurrency.BackColor = Color.Bisque;
            cmbCurrency.FormattingEnabled = true;
            cmbCurrency.Items.AddRange(new object[] { "AUD", "USD", "GBP", "EUR", "CNY" });
            cmbCurrency.Location = new Point(305, 64);
            cmbCurrency.Name = "cmbCurrency";
            cmbCurrency.Size = new Size(100, 23);
            cmbCurrency.TabIndex = 121;
            // 
            // cmbProductClass
            // 
            cmbProductClass.BackColor = Color.Bisque;
            cmbProductClass.FormattingEnabled = true;
            cmbProductClass.Items.AddRange(new object[] { "Specials", "Seasonal - Easter", "Seasonal - Christmas" });
            cmbProductClass.Location = new Point(118, 109);
            cmbProductClass.Name = "cmbProductClass";
            cmbProductClass.Size = new Size(205, 23);
            cmbProductClass.TabIndex = 122;
            // 
            // chkHarmonised
            // 
            chkHarmonised.Location = new Point(236, 12);
            chkHarmonised.Name = "chkHarmonised";
            chkHarmonised.RightToLeft = RightToLeft.Yes;
            chkHarmonised.Size = new Size(126, 24);
            chkHarmonised.TabIndex = 127;
            chkHarmonised.Text = ":Harmonised Item";
            chkHarmonised.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cmbNewRepeatEPD
            // 
            cmbNewRepeatEPD.BackColor = Color.OliveDrab;
            cmbNewRepeatEPD.Items.AddRange(new object[] { "New" });
            cmbNewRepeatEPD.Location = new Point(484, 13);
            cmbNewRepeatEPD.Name = "cmbNewRepeatEPD";
            cmbNewRepeatEPD.Size = new Size(121, 23);
            cmbNewRepeatEPD.TabIndex = 124;
            // 
            // lblSourcingEntity
            // 
            lblSourcingEntity.Location = new Point(8, 13);
            lblSourcingEntity.Name = "lblSourcingEntity";
            lblSourcingEntity.Size = new Size(100, 23);
            lblSourcingEntity.TabIndex = 125;
            lblSourcingEntity.Text = "Sourcing Entity:";
            lblSourcingEntity.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblNewRepeatEPD
            // 
            lblNewRepeatEPD.Location = new Point(378, 12);
            lblNewRepeatEPD.Name = "lblNewRepeatEPD";
            lblNewRepeatEPD.Size = new Size(100, 23);
            lblNewRepeatEPD.TabIndex = 126;
            lblNewRepeatEPD.Text = "New Repeat/EPD:";
            lblNewRepeatEPD.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cmbSourcingEntity
            // 
            cmbSourcingEntity.BackColor = Color.Bisque;
            cmbSourcingEntity.FormattingEnabled = true;
            cmbSourcingEntity.Items.AddRange(new object[] { "National", "IB", "IBA", "AO", "DB", "GS" });
            cmbSourcingEntity.Location = new Point(109, 14);
            cmbSourcingEntity.Name = "cmbSourcingEntity";
            cmbSourcingEntity.Size = new Size(121, 23);
            cmbSourcingEntity.TabIndex = 128;
            // 
            // txtPromotionID
            // 
            txtPromotionID.BackColor = Color.LightSkyBlue;
            txtPromotionID.BorderStyle = BorderStyle.FixedSingle;
            txtPromotionID.Location = new Point(117, 201);
            txtPromotionID.Name = "txtPromotionID";
            txtPromotionID.Size = new Size(206, 23);
            txtPromotionID.TabIndex = 129;
            // 
            // lblPromotionID
            // 
            lblPromotionID.Location = new Point(12, 198);
            lblPromotionID.Name = "lblPromotionID";
            lblPromotionID.Size = new Size(100, 23);
            lblPromotionID.TabIndex = 130;
            lblPromotionID.Text = "Promotion ID:";
            lblPromotionID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtDisplayID
            // 
            txtDisplayID.Location = new Point(109, 21);
            txtDisplayID.Name = "txtDisplayID";
            txtDisplayID.Size = new Size(121, 23);
            txtDisplayID.TabIndex = 132;
            // 
            // txtSingleGenericID
            // 
            txtSingleGenericID.Location = new Point(349, 20);
            txtSingleGenericID.Name = "txtSingleGenericID";
            txtSingleGenericID.Size = new Size(121, 23);
            txtSingleGenericID.TabIndex = 133;
            // 
            // txtPacksize
            // 
            txtPacksize.Location = new Point(554, 20);
            txtPacksize.Name = "txtPacksize";
            txtPacksize.Size = new Size(51, 23);
            txtPacksize.TabIndex = 134;
            // 
            // label1
            // 
            label1.Location = new Point(25, 21);
            label1.Name = "label1";
            label1.Size = new Size(78, 23);
            label1.TabIndex = 135;
            label1.Text = "Display ID:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSingleGenericID
            // 
            lblSingleGenericID.Location = new Point(236, 20);
            lblSingleGenericID.Name = "lblSingleGenericID";
            lblSingleGenericID.Size = new Size(107, 23);
            lblSingleGenericID.TabIndex = 136;
            lblSingleGenericID.Text = "Single/Generic ID:";
            lblSingleGenericID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCaseSize
            // 
            lblCaseSize.Location = new Point(484, 20);
            lblCaseSize.Name = "lblCaseSize";
            lblCaseSize.Size = new Size(66, 23);
            lblCaseSize.TabIndex = 137;
            lblCaseSize.Text = "Case Size:";
            lblCaseSize.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label15);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtDescription);
            panel1.Controls.Add(lblDescription);
            panel1.Controls.Add(lblDayOfWeek);
            panel1.Controls.Add(lblProductClass);
            panel1.Controls.Add(lblTheme);
            panel1.Controls.Add(lblOnSaleYear);
            panel1.Controls.Add(lblOnSaleWeek);
            panel1.Controls.Add(lblOnSaleDate);
            panel1.Controls.Add(txtOnSaleYear);
            panel1.Controls.Add(txtPromotionID);
            panel1.Controls.Add(txtDayOfWeek);
            panel1.Controls.Add(lblPromotionID);
            panel1.Controls.Add(txtOnSaleWeek);
            panel1.Controls.Add(txtTheme);
            panel1.Controls.Add(dtpOnSaleDate);
            panel1.Controls.Add(cmbBrandOrALDIPL);
            panel1.Controls.Add(lblBrandOrALDIPL);
            panel1.Controls.Add(BtnSelectAll);
            panel1.Controls.Add(cmbProductClass);
            panel1.Controls.Add(flpRegions);
            panel1.Controls.Add(lblRegions);
            panel1.Location = new Point(39, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(668, 241);
            panel1.TabIndex = 138;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Red;
            label15.Location = new Point(331, 137);
            label15.Name = "label15";
            label15.Size = new Size(17, 21);
            label15.TabIndex = 161;
            label15.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(331, 109);
            label7.Name = "label7";
            label7.Size = new Size(17, 21);
            label7.TabIndex = 159;
            label7.Text = "*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(331, 78);
            label6.Name = "label6";
            label6.Size = new Size(17, 21);
            label6.TabIndex = 160;
            label6.Text = "*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(331, 47);
            label5.Name = "label5";
            label5.Size = new Size(17, 21);
            label5.TabIndex = 159;
            label5.Text = "*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(631, 9);
            label4.Name = "label4";
            label4.Size = new Size(17, 21);
            label4.TabIndex = 158;
            label4.Text = "*";
            // 
            // lblGrpLbl1
            // 
            lblGrpLbl1.Location = new Point(25, 22);
            lblGrpLbl1.Name = "lblGrpLbl1";
            lblGrpLbl1.Size = new Size(87, 23);
            lblGrpLbl1.TabIndex = 139;
            lblGrpLbl1.Text = "On Sale Date";
            lblGrpLbl1.TextAlign = ContentAlignment.BottomRight;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lblEstDeliveredCost);
            panel2.Controls.Add(label23);
            panel2.Controls.Add(label22);
            panel2.Controls.Add(label21);
            panel2.Controls.Add(label20);
            panel2.Controls.Add(label19);
            panel2.Controls.Add(label18);
            panel2.Controls.Add(label17);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(txtContractedQuantity);
            panel2.Controls.Add(txtPlannedQuantity);
            panel2.Controls.Add(lblPlannedQuantity);
            panel2.Controls.Add(txtCost);
            panel2.Controls.Add(lblCost);
            panel2.Controls.Add(lblFreightCost);
            panel2.Controls.Add(txtFreightCost);
            panel2.Controls.Add(txtRetail);
            panel2.Controls.Add(lblRetail);
            panel2.Controls.Add(lblSales);
            panel2.Controls.Add(txtSales);
            panel2.Controls.Add(lblContractedQuantity);
            panel2.Controls.Add(lblCurrency);
            panel2.Controls.Add(cmbIncoTerms);
            panel2.Controls.Add(chkGST);
            panel2.Controls.Add(lblDuty);
            panel2.Controls.Add(txtDuty);
            panel2.Controls.Add(cmbCurrency);
            panel2.Controls.Add(lblIncoterms);
            panel2.Controls.Add(txtEstDeliveredCost);
            panel2.Controls.Add(txtMargin);
            panel2.Controls.Add(lblMargin);
            panel2.Controls.Add(txtMarginPercent);
            panel2.Controls.Add(lblMarginPercent);
            panel2.Location = new Point(39, 353);
            panel2.Name = "panel2";
            panel2.Size = new Size(668, 234);
            panel2.TabIndex = 140;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label23.ForeColor = Color.Red;
            label23.Location = new Point(637, 61);
            label23.Name = "label23";
            label23.Size = new Size(17, 21);
            label23.TabIndex = 169;
            label23.Text = "*";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.ForeColor = Color.Red;
            label22.Location = new Point(408, 93);
            label22.Name = "label22";
            label22.Size = new Size(17, 21);
            label22.TabIndex = 168;
            label22.Text = "*";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.ForeColor = Color.Red;
            label21.Location = new Point(407, 63);
            label21.Name = "label21";
            label21.Size = new Size(17, 21);
            label21.TabIndex = 167;
            label21.Text = "*";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.Red;
            label20.Location = new Point(328, 125);
            label20.Name = "label20";
            label20.Size = new Size(17, 21);
            label20.TabIndex = 166;
            label20.Text = "*";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.Red;
            label19.Location = new Point(228, 138);
            label19.Name = "label19";
            label19.Size = new Size(17, 21);
            label19.TabIndex = 165;
            label19.Text = "*";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.Red;
            label18.Location = new Point(225, 97);
            label18.Name = "label18";
            label18.Size = new Size(17, 21);
            label18.TabIndex = 164;
            label18.Text = "*";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.Red;
            label17.Location = new Point(225, 61);
            label17.Name = "label17";
            label17.Size = new Size(17, 21);
            label17.TabIndex = 163;
            label17.Text = "*";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.Red;
            label16.Location = new Point(328, 18);
            label16.Name = "label16";
            label16.Size = new Size(17, 21);
            label16.TabIndex = 162;
            label16.Text = "*";
            // 
            // lblGrpLbl2
            // 
            lblGrpLbl2.Location = new Point(25, 327);
            lblGrpLbl2.Name = "lblGrpLbl2";
            lblGrpLbl2.Size = new Size(87, 23);
            lblGrpLbl2.TabIndex = 141;
            lblGrpLbl2.Text = "Commercial";
            lblGrpLbl2.TextAlign = ContentAlignment.BottomRight;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label14);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(cmbBD);
            panel3.Controls.Add(lblBD);
            panel3.Controls.Add(cmbEM);
            panel3.Controls.Add(lblEM);
            panel3.Controls.Add(cmbBA);
            panel3.Controls.Add(lblBA);
            panel3.Controls.Add(cmbCategory);
            panel3.Controls.Add(lblAGCCategory);
            panel3.Controls.Add(lblACGCG);
            panel3.Controls.Add(cmbCG);
            panel3.Controls.Add(lblACGSCG);
            panel3.Controls.Add(cmbSCG);
            panel3.Location = new Point(759, 48);
            panel3.Name = "panel3";
            panel3.Size = new Size(634, 133);
            panel3.TabIndex = 142;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Red;
            label14.Location = new Point(611, 97);
            label14.Name = "label14";
            label14.Size = new Size(17, 21);
            label14.TabIndex = 162;
            label14.Text = "*";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(611, 57);
            label12.Name = "label12";
            label12.Size = new Size(17, 21);
            label12.TabIndex = 159;
            label12.Text = "*";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(611, 11);
            label11.Name = "label11";
            label11.Size = new Size(17, 21);
            label11.TabIndex = 159;
            label11.Text = "*";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(393, 97);
            label10.Name = "label10";
            label10.Size = new Size(17, 21);
            label10.TabIndex = 161;
            label10.Text = "*";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(393, 57);
            label9.Name = "label9";
            label9.Size = new Size(17, 21);
            label9.TabIndex = 160;
            label9.Text = "*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(393, 13);
            label8.Name = "label8";
            label8.Size = new Size(17, 21);
            label8.TabIndex = 159;
            label8.Text = "*";
            // 
            // cmbBD
            // 
            cmbBD.BackColor = Color.LightSkyBlue;
            cmbBD.FormattingEnabled = true;
            cmbBD.Location = new Point(454, 97);
            cmbBD.Name = "cmbBD";
            cmbBD.Size = new Size(151, 23);
            cmbBD.TabIndex = 153;
            cmbBD.SelectedIndexChanged += cmbBD_SelectedIndexChanged;
            // 
            // lblBD
            // 
            lblBD.Location = new Point(402, 97);
            lblBD.Name = "lblBD";
            lblBD.Size = new Size(46, 23);
            lblBD.TabIndex = 152;
            lblBD.Text = "BD:";
            lblBD.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cmbEM
            // 
            cmbEM.BackColor = Color.Bisque;
            cmbEM.FormattingEnabled = true;
            cmbEM.Location = new Point(454, 57);
            cmbEM.Name = "cmbEM";
            cmbEM.Size = new Size(151, 23);
            cmbEM.TabIndex = 151;
            cmbEM.SelectedIndexChanged += cmbEM_SelectedIndexChanged;
            // 
            // lblEM
            // 
            lblEM.Location = new Point(402, 57);
            lblEM.Name = "lblEM";
            lblEM.Size = new Size(46, 23);
            lblEM.TabIndex = 150;
            lblEM.Text = "EM:";
            lblEM.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cmbBA
            // 
            cmbBA.BackColor = Color.Bisque;
            cmbBA.FormattingEnabled = true;
            cmbBA.Location = new Point(454, 12);
            cmbBA.Name = "cmbBA";
            cmbBA.Size = new Size(151, 23);
            cmbBA.TabIndex = 66;
            cmbBA.SelectedIndexChanged += cmbBA_SelectedIndexChanged;
            // 
            // lblBA
            // 
            lblBA.Location = new Point(402, 10);
            lblBA.Name = "lblBA";
            lblBA.Size = new Size(46, 23);
            lblBA.TabIndex = 65;
            lblBA.Text = "BA:";
            lblBA.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblGrpLbl3
            // 
            lblGrpLbl3.Location = new Point(759, 22);
            lblGrpLbl3.Name = "lblGrpLbl3";
            lblGrpLbl3.Size = new Size(87, 23);
            lblGrpLbl3.TabIndex = 143;
            lblGrpLbl3.Text = "Categorisation";
            lblGrpLbl3.TextAlign = ContentAlignment.BottomRight;
            // 
            // lblGrpLbl4
            // 
            lblGrpLbl4.Location = new Point(762, 207);
            lblGrpLbl4.Name = "lblGrpLbl4";
            lblGrpLbl4.Size = new Size(121, 23);
            lblGrpLbl4.TabIndex = 144;
            lblGrpLbl4.Text = "Sourcing Information";
            lblGrpLbl4.TextAlign = ContentAlignment.BottomRight;
            // 
            // lblGrpLbl5
            // 
            lblGrpLbl5.Location = new Point(759, 327);
            lblGrpLbl5.Name = "lblGrpLbl5";
            lblGrpLbl5.Size = new Size(74, 23);
            lblGrpLbl5.TabIndex = 145;
            lblGrpLbl5.Text = "Article Data";
            lblGrpLbl5.TextAlign = ContentAlignment.BottomRight;
            // 
            // panel4
            // 
            panel4.BackColor = Color.WhiteSmoke;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label13);
            panel4.Controls.Add(cmbSourcingEntity);
            panel4.Controls.Add(lblSourcingEntity);
            panel4.Controls.Add(chkHarmonised);
            panel4.Controls.Add(cmbNewRepeatEPD);
            panel4.Controls.Add(lblNewRepeatEPD);
            panel4.Location = new Point(759, 233);
            panel4.Name = "panel4";
            panel4.Size = new Size(634, 56);
            panel4.TabIndex = 146;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Red;
            label13.Location = new Point(611, 16);
            label13.Name = "label13";
            label13.Size = new Size(17, 21);
            label13.TabIndex = 160;
            label13.Text = "*";
            // 
            // panel5
            // 
            panel5.BackColor = Color.WhiteSmoke;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label3);
            panel5.Controls.Add(lblCaseDimensions);
            panel5.Controls.Add(lblUnitLength);
            panel5.Controls.Add(txtUnitLength);
            panel5.Controls.Add(lblUnitWidth);
            panel5.Controls.Add(txtUnitWidth);
            panel5.Controls.Add(lblUnitHeight);
            panel5.Controls.Add(txtUnitHeight);
            panel5.Controls.Add(lblCaseLength);
            panel5.Controls.Add(txtCaseLength);
            panel5.Controls.Add(lblCaseWidth);
            panel5.Controls.Add(txtCaseWidth);
            panel5.Controls.Add(lblCaseHeight);
            panel5.Controls.Add(txtCaseHeight);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(txtDisplayID);
            panel5.Controls.Add(lblSingleGenericID);
            panel5.Controls.Add(txtSingleGenericID);
            panel5.Controls.Add(lblCaseSize);
            panel5.Controls.Add(txtPacksize);
            panel5.Location = new Point(759, 353);
            panel5.Name = "panel5";
            panel5.Size = new Size(634, 234);
            panel5.TabIndex = 147;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.Location = new Point(326, 73);
            label3.Name = "label3";
            label3.Size = new Size(122, 23);
            label3.TabIndex = 159;
            label3.Text = "Unit Dimensions";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCaseDimensions
            // 
            lblCaseDimensions.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblCaseDimensions.Location = new Point(93, 73);
            lblCaseDimensions.Name = "lblCaseDimensions";
            lblCaseDimensions.Size = new Size(122, 23);
            lblCaseDimensions.TabIndex = 158;
            lblCaseDimensions.Text = "Case Dimensions";
            lblCaseDimensions.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUnitLength
            // 
            lblUnitLength.Location = new Point(265, 101);
            lblUnitLength.Name = "lblUnitLength";
            lblUnitLength.Size = new Size(78, 23);
            lblUnitLength.TabIndex = 149;
            lblUnitLength.Text = "Length:";
            lblUnitLength.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtUnitLength
            // 
            txtUnitLength.Location = new Point(349, 101);
            txtUnitLength.Name = "txtUnitLength";
            txtUnitLength.Size = new Size(121, 23);
            txtUnitLength.TabIndex = 148;
            // 
            // lblUnitWidth
            // 
            lblUnitWidth.Location = new Point(265, 142);
            lblUnitWidth.Name = "lblUnitWidth";
            lblUnitWidth.Size = new Size(78, 23);
            lblUnitWidth.TabIndex = 147;
            lblUnitWidth.Text = "Width:";
            lblUnitWidth.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtUnitWidth
            // 
            txtUnitWidth.Location = new Point(349, 142);
            txtUnitWidth.Name = "txtUnitWidth";
            txtUnitWidth.Size = new Size(121, 23);
            txtUnitWidth.TabIndex = 146;
            // 
            // lblUnitHeight
            // 
            lblUnitHeight.Location = new Point(265, 185);
            lblUnitHeight.Name = "lblUnitHeight";
            lblUnitHeight.Size = new Size(78, 23);
            lblUnitHeight.TabIndex = 145;
            lblUnitHeight.Text = "Height:";
            lblUnitHeight.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtUnitHeight
            // 
            txtUnitHeight.Location = new Point(349, 185);
            txtUnitHeight.Name = "txtUnitHeight";
            txtUnitHeight.Size = new Size(121, 23);
            txtUnitHeight.TabIndex = 144;
            // 
            // lblCaseLength
            // 
            lblCaseLength.Location = new Point(25, 99);
            lblCaseLength.Name = "lblCaseLength";
            lblCaseLength.Size = new Size(78, 23);
            lblCaseLength.TabIndex = 143;
            lblCaseLength.Text = "Length:";
            lblCaseLength.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtCaseLength
            // 
            txtCaseLength.Location = new Point(109, 99);
            txtCaseLength.Name = "txtCaseLength";
            txtCaseLength.Size = new Size(121, 23);
            txtCaseLength.TabIndex = 142;
            // 
            // lblCaseWidth
            // 
            lblCaseWidth.Location = new Point(25, 140);
            lblCaseWidth.Name = "lblCaseWidth";
            lblCaseWidth.Size = new Size(78, 23);
            lblCaseWidth.TabIndex = 141;
            lblCaseWidth.Text = "Width:";
            lblCaseWidth.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtCaseWidth
            // 
            txtCaseWidth.Location = new Point(109, 140);
            txtCaseWidth.Name = "txtCaseWidth";
            txtCaseWidth.Size = new Size(121, 23);
            txtCaseWidth.TabIndex = 140;
            // 
            // lblCaseHeight
            // 
            lblCaseHeight.Location = new Point(25, 183);
            lblCaseHeight.Name = "lblCaseHeight";
            lblCaseHeight.Size = new Size(78, 23);
            lblCaseHeight.TabIndex = 139;
            lblCaseHeight.Text = "Height:";
            lblCaseHeight.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtCaseHeight
            // 
            txtCaseHeight.Location = new Point(109, 183);
            txtCaseHeight.Name = "txtCaseHeight";
            txtCaseHeight.Size = new Size(121, 23);
            txtCaseHeight.TabIndex = 138;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(0, 32, 96);
            panel6.Controls.Add(label2);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1660, 137);
            panel6.TabIndex = 148;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(35, 47);
            label2.Name = "label2";
            label2.Size = new Size(640, 65);
            label2.TabIndex = 0;
            label2.Text = "New Portfolio Entry Screen";
            // 
            // btnValidate
            // 
            btnValidate.Location = new Point(464, 610);
            btnValidate.Name = "btnValidate";
            btnValidate.Size = new Size(243, 54);
            btnValidate.TabIndex = 149;
            btnValidate.Text = "Validate";
            btnValidate.UseVisualStyleBackColor = true;
            btnValidate.Click += btnValidate_Click;
            // 
            // cmbDBU
            // 
            cmbDBU.BackColor = Color.LightSkyBlue;
            cmbDBU.Enabled = false;
            cmbDBU.FormattingEnabled = true;
            cmbDBU.Location = new Point(1470, 106);
            cmbDBU.Name = "cmbDBU";
            cmbDBU.Size = new Size(151, 23);
            cmbDBU.TabIndex = 155;
            // 
            // lblDBU
            // 
            lblDBU.Location = new Point(1418, 106);
            lblDBU.Name = "lblDBU";
            lblDBU.Size = new Size(46, 23);
            lblDBU.TabIndex = 154;
            lblDBU.Text = "DBU:";
            lblDBU.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cmbGD
            // 
            cmbGD.BackColor = Color.LightSkyBlue;
            cmbGD.FormattingEnabled = true;
            cmbGD.Location = new Point(1470, 145);
            cmbGD.Name = "cmbGD";
            cmbGD.Size = new Size(151, 23);
            cmbGD.TabIndex = 157;
            // 
            // lblGD
            // 
            lblGD.Location = new Point(1418, 145);
            lblGD.Name = "lblGD";
            lblGD.Size = new Size(46, 23);
            lblGD.TabIndex = 156;
            lblGD.Text = "GD:";
            lblGD.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.None;
            panel7.Controls.Add(lblGrpLbl1);
            panel7.Controls.Add(cmbGD);
            panel7.Controls.Add(btnCreatePortfolio);
            panel7.Controls.Add(lblGD);
            panel7.Controls.Add(panel1);
            panel7.Controls.Add(cmbDBU);
            panel7.Controls.Add(panel2);
            panel7.Controls.Add(lblDBU);
            panel7.Controls.Add(lblGrpLbl2);
            panel7.Controls.Add(btnValidate);
            panel7.Controls.Add(panel3);
            panel7.Controls.Add(lblGrpLbl3);
            panel7.Controls.Add(panel5);
            panel7.Controls.Add(lblGrpLbl4);
            panel7.Controls.Add(panel4);
            panel7.Controls.Add(lblGrpLbl5);
            panel7.Location = new Point(12, 143);
            panel7.Name = "panel7";
            panel7.Size = new Size(1639, 688);
            panel7.TabIndex = 158;
            // 
            // PortfolioEntry
            // 
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1660, 839);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Name = "PortfolioEntry";
            Load += PortfolioEntry_Load;
            flpRegions.ResumeLayout(false);
            flpRegions.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            ResumeLayout(false);
        }

        private DateTimePicker dtpOnSaleDate;
        private Label lblOnSaleDate, lblOnSaleWeek, lblOnSaleYear, lblTheme, lblProductClass, lblDescription, lblDayOfWeek, lblAGCCategory;

        private void DtpOnSaleDate_ValueChanged(object sender, EventArgs e)
        {

        }
        private TextBox txtOnSaleDate;
        private TextBox txtOnSaleWeek;
        private TextBox txtOnSaleYear;
        private TextBox txtDescription;
        private TextBox txtTheme;
        private TextBox txtDayOfWeek;
        private Button btnCreatePortfolio;
        private ComboBox cmbCategory;
        private Label lblACGCG;
        private ComboBox cmbCG;
        private ComboBox cmbSCG;
        private Label lblACGSCG;
        private ComboBox cmbBrandOrALDIPL;
        private Label lblBrandOrALDIPL;
        private Label lblRegions;
        private FlowLayoutPanel flpRegions;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private CheckBox checkBox8;
        private CheckBox checkBox7;
        private Button BtnSelectAll;
        private TextBox txtPlannedQuantity;
        private TextBox txtCost;
        private TextBox txtFreightCost;
        private TextBox txtRetail;
        private TextBox txtSales;
        private CheckBox chkGST;
        private Label lblPlannedQuantity;
        private Label lblCost;
        private Label lblFreightCost;
        private Label lblRetail;
        private Label lblSales;
        private TextBox txtContractedQuantity;
        private TextBox txtDuty;
        private TextBox txtEstDeliveredCost;
        private TextBox txtMarginPercent;
        private TextBox txtMargin;
        private Label lblContractedQuantity;
        private Label lblCurrency;
        private Label lblIncoterms;
        private Label lblDuty;
        private Label lblEstDeliveredCost;
        private Label lblMarginPercent;
        private Label lblMargin;
        private ComboBox cmbIncoTerms;
        private ComboBox cmbCurrency;
        private ComboBox cmbProductClass;
        private CheckBox chkHarmonised;
        private ComboBox cmbNewRepeatEPD;
        private Label lblSourcingEntity;
        private Label lblNewRepeatEPD;
        private ComboBox cmbSourcingEntity;
        private TextBox txtPromotionID;
        private Label lblPromotionID;
        private TextBox txtDisplayID;
        private TextBox txtSingleGenericID;
        private TextBox txtPacksize;
        private Label label1;
        private Label lblSingleGenericID;
        private Label lblCaseSize;
        private Panel panel1;
        private Label lblGrpLbl1;
        private Panel panel2;
        private Label lblGrpLbl2;
        private Panel panel3;
        private Label lblGrpLbl3;
        private Label lblGrpLbl4;
        private Label lblGrpLbl5;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Label label2;
        private Button btnValidate;
        private Label lblBA;
        private ComboBox cmbBA;
        private ComboBox cmbEM;
        private Label lblEM;
        private ComboBox cmbBD;
        private Label lblBD;
        private ComboBox cmbDBU;
        private Label lblDBU;
        private ComboBox cmbGD;
        private Label lblGD;
        private Label lblCaseLength;
        private TextBox txtCaseLength;
        private Label lblCaseWidth;
        private TextBox txtCaseWidth;
        private Label lblCaseHeight;
        private TextBox txtCaseHeight;
        private Label lblUnitLength;
        private TextBox txtUnitLength;
        private Label lblUnitWidth;
        private TextBox txtUnitWidth;
        private Label lblUnitHeight;
        private TextBox txtUnitHeight;
        private Label label3;
        private Label lblCaseDimensions;
        private Label label4;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label13;
        private Label label15;
        private Label label23;
        private Label label22;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label14;
        private Panel panel7;
        //private Label lblBA;
        //private ComboBox cmbEmployeeBA;
        //private Label lblEM;
        //private ComboBox cmbEmployeeEM;
        //private ComboBox cmbEmployeeGD;
        //private Label lblGD;
        //private ComboBox cmbEmployeeBD;
        //private Label lblBD;
    }
}
