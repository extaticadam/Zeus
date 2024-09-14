using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Dapper;
using Npgsql;
using PortfolioLibrary.Models;
using PortfolioLibrary.DataAccess;
using System.Globalization;
using PortfolioLibrary;
using System.Configuration;
using System.Diagnostics;
using System.Reflection;
using System.Drawing.Printing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using System.Drawing.Text;

namespace PortfolioUI
{
    public partial class PortfolioEntry : Form
    {
        private IDbConnection _connection;
        private int? selectedDbuno = null;

        public PortfolioEntry()
        {
            InitializeComponent();
            // Initialize the connection with the connection string from the config file
            string connectionString = ConfigurationManager.ConnectionStrings["LIVEDB"].ConnectionString;
            _connection = new NpgsqlConnection(connectionString);

            this.Load += PortfolioEntry_Load;
            this.Text = "Portfolio Entry";
        }

        private void PortfolioEntry_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadEmployeeBA();
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            cmbCG.SelectedIndexChanged += cmbCG_SelectedIndexChanged;
            //LoadcmbNewRepeatEPD();
        }


        private bool ValidateForm(out string errorMessage)
        {
            errorMessage = string.Empty;

            bool isValid = true;

            // Validate Description
            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                errorMessage += "Description is required.\n";
                isValid = false;
            }

            // Validate Theme
            if (string.IsNullOrWhiteSpace(txtTheme.Text))
            {
                errorMessage += "Theme is required.\n";
                isValid = false;
            }

            // Validate ProductClass
            if (cmbProductClass.SelectedIndex == -1)
            {
                errorMessage += "Product Class must be selected.\n";
                isValid = false;
            }


            // Validate OnSaleDate
            if (dtpOnSaleDate.Value.Date < DateTime.Today)
            {
                errorMessage += "On Sale Date cannot be in the past.\n";
                isValid = false;
            }

            bool isPlannedQuantityValid = int.TryParse(txtPlannedQuantity.Text, out int plannedQuantity);
            bool isContractQuantityValid = int.TryParse(txtContractedQuantity.Text, out int contractQuantity);
            bool isCostValid = double.TryParse(txtCost.Text, out double cost);
            bool isRetailValid = double.TryParse(txtRetail.Text, out double retail);
            bool isDutyValid = double.TryParse(txtDuty.Text, out double duty);
            bool isFreightValid = double.TryParse(txtFreightCost.Text, out double freight);

            if (!isPlannedQuantityValid && !isContractQuantityValid)
            {
                errorMessage += "Please enter a quantity.\n";
                isValid = false;
            }

            if (!isCostValid || !isDutyValid || !isFreightValid)
            {
                errorMessage += "Please enter all costs.\n";
                isValid = false;
            }

            if (!isRetailValid)
            {
                errorMessage += "Please enter a retail.\n";
                isValid = false;
            }

            bool isDisplayValid = int.TryParse(txtDisplayID.Text, out int DisplayID);
            bool isSellableValid = int.TryParse(txtSingleGenericID.Text, out int SellableID);
            bool isPacksizeValid = int.TryParse(txtPacksize.Text, out int packsize);
            string displayIDString = DisplayID.ToString();
            string sellableIDString = SellableID.ToString();

            if (!isDisplayValid)
            {
                errorMessage += "Enter a Display ID.\n";
                isValid = false;
            }

            if (!isSellableValid)
            {
                errorMessage += "Enter a Single/Generic ID.\n";
                isValid = false;
            }

            if (!isPacksizeValid)
            {
                errorMessage += "Enter a Case Size.\n";
                isValid = false;
            }

            if (displayIDString.Length != 6)
            {
                errorMessage += "Display ID must be exactly 6 digits.\n";
                isValid = false;
            }

            if (sellableIDString.Length != 6)
            {
                errorMessage += "Sellable ID must be exactly 6 digits.\n";
                isValid = false;
            }

            // Additional validations as needed
            return isValid;
        }

        private void btnCreatePortfolio_Click(object sender, EventArgs e)
        {
            if (ValidateForm(out string errorMessage))
            {


                PortfolioModel portfolioModel = new PortfolioModel
                {

                    CreationDate = DateTime.Now,
                    LastModifiedDate = DateTime.Now

                };

                PortfolioModel portfolio = GlobalConfig.Connections.First().CreatePortfolio(portfolioModel);

                PortfolioVersionModel versionModel = null; // Declare outside

                if (!string.IsNullOrEmpty(portfolio.PortfolioID))
                {

                    int productClassValue = 0;
                    int? seasonIDValue = null;
                    //Setting up the ProductClass and Seasonal ID values
                    if (cmbProductClass.SelectedIndex == 0)
                    {
                        productClassValue = 3;
                        seasonIDValue = null;
                    }

                    else if (cmbProductClass.SelectedIndex == 1)
                    {
                        productClassValue = 4;
                        seasonIDValue = 1; //Easter
                    }

                    else if (cmbProductClass.SelectedIndex == 2)
                    {
                        productClassValue = 4;
                        seasonIDValue = 2; //Christmas
                    }
                    


                    int DisplayValue = int.TryParse(txtDisplayID.Text, out int DisplayIDy) ? DisplayIDy : 0;
                    MessageBox.Show(DisplayValue.ToString());

                    // Initialize versionModel inside the block
                    versionModel = new PortfolioVersionModel
                    {
                        PortfolioID = portfolio.PortfolioID,  // Ensure PortfolioID is set here
                        Description = txtDescription.Text,
                        OnSaleDate = dtpOnSaleDate.Value,
                        Theme = txtTheme.Text,
                        ProductClass = productClassValue,
                        PromotionID = long.TryParse(txtPromotionID.Text, out long PromotionNumber) ? PromotionNumber : 0,
                        CategoryNo = (int)cmbCategory.SelectedValue,
                        cgno = (int)cmbCG.SelectedValue,
                        Scgno = (int)cmbSCG.SelectedValue,
                        BrandOrALDIPL = cmbBrandOrALDIPL.Text,
                        seasonid = seasonIDValue,
                        Harmonised = chkHarmonised.Checked ? 1 : 0,
                        SourcingEntity = cmbSourcingEntity.Text,
                        NewRepeatEPD = cmbNewRepeatEPD.Text,
                        DisplayID = int.TryParse(txtDisplayID.Text, out int DisplayID) ? DisplayID : 0,
                        SellableID = int.TryParse(txtSingleGenericID.Text, out int SellableID) ? SellableID : 0,
                        Packsize = int.TryParse(txtPacksize.Text, out int Packsize) ? Packsize : 0,
                        DBUNo = (int)cmbDBU.SelectedValue,
                        GD = (int)cmbGD.SelectedValue,
                        BD = (int)cmbBD.SelectedValue,
                        EM = (int)cmbEM.SelectedValue,
                        BA = (int)cmbBA.SelectedValue,
                        CaseLength = int.TryParse(txtCaseLength.Text, out int CaseLengthValue) ? CaseLengthValue : 0,
                        CaseWidth = int.TryParse(txtCaseWidth.Text, out int CaseWidthValue) ? CaseWidthValue : 0,
                        CaseHeight = int.TryParse(txtCaseHeight.Text, out int CaseHeightValue) ? CaseHeightValue : 0,
                        UnitLength = int.TryParse(txtUnitLength.Text, out int UnitLengthValue) ? UnitLengthValue : 0,
                        UnitWidth = int.TryParse(txtUnitWidth.Text, out int UnitWidthValue) ? UnitWidthValue : 0,
                        UnitHeight = int.TryParse(txtUnitHeight.Text, out int UnitHeightValue) ? UnitHeightValue : 0,





                    };

                    // Create portfolio version and handle the result
                    var portfolioVersion = GlobalConfig.Connections.First().CreatePortfolioVersion(versionModel);

                    // Handle the portfolioVersion if needed
                    // For example, you might want to show a confirmation message
                    MessageBox.Show("Portfolio version created successfully.");
                }
                else
                {
                    MessageBox.Show("PortfolioID is not generated.");
                }

                //Region Checkboxes section
                var salesOfficeMapping = new Dictionary<string, string>

               //Region assignment Legacy to SAP here
               {
                    { "MIN","GR01" },
                    { "DER","GR02" },
                    { "STP","GR03" },
                    { "PRE","GR04" },
                    { "DAN","GR05" },
                    { "BRE","GR06" },
                    { "RGY","GR07" },
                    { "JKT","GR08" },
               };

                // Add checkbox values into the array
                CheckBox[] checkBoxes = { checkBox1, checkBox2, checkBox3, checkBox4, checkBox5, checkBox6, checkBox7, checkBox8 };
                foreach (var checkBox in checkBoxes)
                {
                    var salesOffice = salesOfficeMapping.ContainsKey(checkBox.Text)
                        ? salesOfficeMapping[checkBox.Text]
                        : checkBox.Text;


                    var salesOfficeListingModel = new SalesOfficeListingModel
                    {
                        PortfolioID = portfolio.PortfolioID, // Use the PortfolioID from the created portfolio
                        PortfolioVersionNumber = versionModel.PortfolioVersionNumber,
                        Sales_office = salesOffice,
                        Active = checkBox.Checked ? 1 : 0
                    };

                    // Create sales office listing
                    GlobalConfig.Connections.First().CreateSalesOfficeListing(salesOfficeListingModel);
                }
                //Create ProductCostings Model
                var productCostingsModel = new ProductCostingsModel
                {
                    PortfolioID = portfolio.PortfolioID,
                    PortfolioVersionNumber = versionModel.PortfolioVersionNumber,

                    PlannedQuantity = int.TryParse(txtPlannedQuantity.Text, out int plannedQuantity) ? plannedQuantity : 0,
                    ContractedQuantity = int.TryParse(txtContractedQuantity.Text, out int contractedQuantity) ? contractedQuantity : 0,

                    Cost = double.TryParse(txtCost.Text, out double cost) ? cost : 0,
                    Currency = cmbCurrency.Text,
                    Incoterms = cmbIncoTerms.Text,

                    FreightCost = double.TryParse(txtFreightCost.Text, out double freightCost) ? freightCost : 0,
                    Duty = double.TryParse(txtDuty.Text, out double duty) ? duty : 0,
                    EstimatedDeliveredCost = double.TryParse(txtEstDeliveredCost.Text, out double estDeliveredCost) ? estDeliveredCost : 0,
                    Retail = double.TryParse(txtRetail.Text, out double retail) ? retail : 0,

                    MarginPercent = double.TryParse(txtMarginPercent.Text, out double marginPercent) ? marginPercent : 0,
                    Sales = double.TryParse(txtSales.Text, out double sales) ? sales : 0,
                    Margin = double.TryParse(txtMargin.Text, out double margin) ? margin : 0,

                    GST = chkGST.Checked ? 1 : 0
                };

                // Create product costings
                GlobalConfig.Connections.First().CreateProductCostings(productCostingsModel);

            }
            else
            {
                MessageBox.Show(errorMessage);
            }
        }


        private void dtpOnSaleDate_ValueChanged(object sender, EventArgs e)
        {
            UpdateDates();
        }



        private void UpdateDates()
        {
            if (dtpOnSaleDate.Value != null)
            {
                DateTime selectedDate = dtpOnSaleDate.Value;
                CultureInfo cultureInfo = CultureInfo.CurrentCulture;
                Calendar calendar = cultureInfo.Calendar;

                int weekNumber = calendar.GetWeekOfYear(selectedDate, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
                int year = selectedDate.Year;
                string abbreviatedDayOfWeek = selectedDate.ToString("ddd");

                txtOnSaleWeek.Text = weekNumber.ToString();
                txtOnSaleYear.Text = year.ToString();
                txtDayOfWeek.Text = abbreviatedDayOfWeek;

            }
        }

        private void LoadCategories()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["LIVEDB"].ConnectionString;

                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT DISTINCT CategoryNo, CategoryDescription FROM ACG";
                    var categories = connection.Query<Category>(query).ToList();

                    Debug.WriteLine($"Number of categories fetched: {categories.Count}");

                    if (categories.Count == 0)
                    {
                        Console.WriteLine("No categories found.");
                    }

                    categories.Insert(0, new Category { CategoryNo = 0, CategoryDescription = "" });

                    cmbCategory.DisplayMember = "CategoryDescription";
                    cmbCategory.ValueMember = "CategoryNo";
                    cmbCategory.DataSource = categories;

                    cmbCategory.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedValue != null && (int)cmbCategory.SelectedValue > 0)
            {
                int selectedCategoryNo = (int)cmbCategory.SelectedValue;
                Console.WriteLine($"Selected CategoryNo: {selectedCategoryNo}");
                LoadCommodityGroups();
            }
            else
            {
                cmbCG.DataSource = null;
                cmbCG.Items.Clear();
                cmbCG.Items.Add("");
                cmbCG.SelectedIndex = 0;
            }
        }

        private void LoadCommodityGroups()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["LIVEDB"].ConnectionString;

            if (cmbCategory.SelectedValue != null && (int)cmbCategory.SelectedValue > 0)
            {
                int selectedCategoryNo = (int)cmbCategory.SelectedValue;

                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT cgno, Description FROM CommodityGroup WHERE CategoryNo = @CategoryNo";
                    var commodities = connection.Query<CommodityGroupModel>(query, new { CategoryNo = selectedCategoryNo }).ToList();

                    if (commodities.Count == 0)
                    {
                        Console.WriteLine($"No commodity groups found for CategoryNo: {selectedCategoryNo}");
                    }
                    else
                    {
                        commodities.Insert(0, new CommodityGroupModel { cgno = 0, Description = "" });

                        cmbCG.DisplayMember = "Description";
                        cmbCG.ValueMember = "cgno";
                        cmbCG.DataSource = commodities;

                        cmbCG.SelectedIndex = 0;
                    }
                }
            }
            else
            {
                cmbCG.DataSource = null;
                cmbCG.Items.Clear();
                cmbCG.Items.Add("");
                cmbCG.SelectedIndex = 0;
            }
        }

        private void cmbCG_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCG.SelectedValue != null && int.TryParse(cmbCG.SelectedValue.ToString(), out int selectedcgno))
            {
                Console.WriteLine($"Selected cgno: {selectedcgno}");
                LoadSubCommodities(selectedcgno);
            }
            else
            {
                cmbSCG.DataSource = null;
                cmbSCG.Items.Clear();
                cmbSCG.Items.Add("");
                cmbSCG.SelectedIndex = 0;
            }
        }

        private void LoadSubCommodities(int cgno)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["LIVEDB"].ConnectionString;

                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT scgno, SubCommodityDescription FROM ACG WHERE cgno = @cgno";
                    var subCommodities = connection.Query<SubCommodityGroupModel>(query, new { cgno = cgno }).ToList();

                    if (subCommodities.Count == 0)
                    {
                        Console.WriteLine($"No sub-commodities found for cgno: {cgno}");

                        cmbSCG.DataSource = null;
                        cmbSCG.Items.Clear();
                        cmbSCG.Items.Add("");
                        cmbSCG.SelectedIndex = 0;
                    }
                    else
                    {
                        subCommodities.Insert(0, new SubCommodityGroupModel { Scgno = 0, SubCommodityDescription = "" });

                        cmbSCG.DisplayMember = "SubCommodityDescription";
                        cmbSCG.ValueMember = "scgno";
                        cmbSCG.DataSource = subCommodities;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        private void BtnSelectAll_Click(object sender, EventArgs e)
        {
            // Determine if we are currently selecting or deselecting
            bool shouldSelect = !flpRegions.Controls.OfType<CheckBox>().All(chkBox => chkBox.Checked);

            foreach (Control control in flpRegions.Controls)
            {
                if (control is CheckBox chkBox)
                {
                    chkBox.Checked = shouldSelect;
                }
            }
        }
        private void txtPlannedQuantity_TextChanged(object sender, EventArgs e)
        {
            UpdateMarginSales();
        }

        private void txtContractedQuantity_TextChanged(object sender, EventArgs e)
        {
            UpdateMarginSales();
        }

        private void txtCost_TextChanged(object sender, EventArgs e)
        {
            UpdateMarginSales();
        }

        private void txtDuty_TextChanged(object sender, EventArgs e)
        {
            UpdateMarginSales();
        }

        private void txtFreightCost_TextChanged(object sender, EventArgs e)
        {
            UpdateMarginSales();
        }

        private void txtRetail_TextChanged(object sender, EventArgs e)
        {
            UpdateMarginSales();
        }

        private void chkGST_CheckedChanged(object sender, EventArgs e)
        {
            UpdateMarginSales();
        }

        //private void LoadcmbNewRepeatEPD()
        //{
        //    // Create and initialize the ComboBox
        //    cmbNewRepeatEPD = new System.Windows.Forms.ComboBox
        //    {
        //        Enabled = true, // Make sure ComboBox is enabled
        //        Items = { "New", "Repeat", "Evolved Product Description" },
        //        SelectedItem = "New",
        //        Location = new System.Drawing.Point(1494, 433),
        //        Name = "cmbNewRepeatEPD",
        //        Size = new System.Drawing.Size(121, 23),
        //        TabIndex = 124
        //    };

        //    // Add the ComboBox to the form's controls
        //    this.Controls.Add(cmbNewRepeatEPD);
        //}



        private void UpdateMarginSales()
        {
            // Try to parse values from text boxes
            bool isPlannedQuantityValid = int.TryParse(txtPlannedQuantity.Text, out int plannedQuantity);
            bool isContractQuantityValid = int.TryParse(txtContractedQuantity.Text, out int contractQuantity);
            bool isCostValid = double.TryParse(txtCost.Text, out double cost);
            bool isRetailValid = double.TryParse(txtRetail.Text, out double retail);


            // Default Duty and Freight to 0 if invalid or empty
            double duty = double.TryParse(txtDuty.Text, out double parsedDuty) ? parsedDuty : 0;
            double freight = double.TryParse(txtFreightCost.Text, out double parsedFreight) ? parsedFreight : 0;

            double totalCost = cost + duty + freight;
            txtEstDeliveredCost.Text = totalCost.ToString("N2");

            // Determine GST value based on whether the checkbox is checked
            double gstMultiplier = chkGST.Checked ? 1.1 : 1.0;

            double MarginPercent = (((retail / gstMultiplier) - totalCost) / retail) * 100;
            txtMarginPercent.Text = MarginPercent.ToString("N2");

            double sales;
            double marginsales;

            if (string.IsNullOrEmpty(txtContractedQuantity.Text))
            {
                sales = plannedQuantity * retail;
                marginsales = sales * (((retail / gstMultiplier) - totalCost) / retail);
                txtSales.Text = sales.ToString("N2");
                txtMargin.Text = marginsales.ToString("N2");
            }
            else
            {
                sales = contractQuantity * retail;
                marginsales = sales * (((retail / gstMultiplier) - totalCost) / retail);
                txtSales.Text = sales.ToString("N2");
                txtMargin.Text = marginsales.ToString("N2");
            }

        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            string errorMessage;

            // Call the ValidateForm method and check if the form is valid
            if (ValidateForm(out errorMessage))
            {
                MessageBox.Show("Form is valid!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Proceed with further logic (e.g., form submission)
            }
            else
            {
                MessageBox.Show($"Form validation failed:\n{errorMessage}", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadEmployeeBA()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["LIVEDB"].ConnectionString;

                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT DISTINCT employeeno, firstname, positionno, dbuno FROM employee where positionno = 4";
                    var employees = connection.Query<EmployeeBA>(query).ToList();

                    Debug.WriteLine($"Number of employees fetched: {employees.Count}");

                    if (employees.Count == 0)
                    {
                        Console.WriteLine("No employees found.");
                    }

                    employees.Insert(0, new EmployeeBA { EmployeeNo = 0, firstName = "" });

                    cmbBA.DisplayMember = "firstname";
                    cmbBA.ValueMember = "employeeno";
                    cmbBA.DataSource = employees;

                    cmbBA.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        private void cmbBA_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if something is selected
            if (cmbBA.SelectedItem is EmployeeBA selectedEmployee && selectedEmployee.EmployeeNo != 0)
            {
                selectedDbuno = selectedEmployee.DBUNo; // Store dbuno in a variable
                LoadEmployeeEM(selectedEmployee.DBUNo);

            }
            else
            {
                selectedDbuno = null; // Reset the value if no valid selection is made
            }
        }
        private void LoadEmployeeEM(int DBUNo)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["LIVEDB"].ConnectionString;

                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT DISTINCT employeeno, firstname, positionno, dbuno FROM employee WHERE positionno = 3 AND dbuno = @DBUNo";

                    // Execute the query and pass the DBUNo parameter
                    var employees = connection.Query<EmployeeEM>(query, new { DBUNo }).ToList();

                    Debug.WriteLine($"Number of employees fetched: {employees.Count}");

                    if (employees.Count == 0)
                    {
                        Console.WriteLine("No employees found.");
                    }

                    employees.Insert(0, new EmployeeEM { EmployeeNo = 0, firstName = "" });

                    cmbEM.DisplayMember = "firstname";
                    cmbEM.ValueMember = "employeeno";
                    cmbEM.DataSource = employees;

                    cmbEM.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

        }

        private void cmbEM_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if something is selected
            if (cmbEM.SelectedItem is EmployeeEM selectedEmployee && selectedEmployee.EmployeeNo != 0)
            {
                //selectedDbuno = selectedEmployee.DBUNo;
                LoadEmployeeBD(selectedEmployee.DBUNo);
            }

        }

        private void LoadEmployeeBD(int DBUNo)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["LIVEDB"].ConnectionString;

                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT DISTINCT employeeno, firstname, positionno, dbuno FROM employee WHERE positionno = 2 AND dbuno = @DBUNo";

                    // Execute the query and pass the DBUNo parameter
                    var employees = connection.Query<EmployeeBD>(query, new { DBUNo }).ToList();

                    Debug.WriteLine($"Number of employees fetched: {employees.Count}");

                    if (employees.Count == 0)
                    {
                        Console.WriteLine("No employees found.");
                    }

                    cmbBD.DisplayMember = "FirstName"; // Ensure this matches the property name
                    cmbBD.ValueMember = "EmployeeNo"; // Ensure this matches the property name
                    cmbBD.DataSource = employees;

                    cmbBD.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }


        private void cmbBD_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if something is selected
            if (cmbBD.SelectedItem is EmployeeBD selectedEmployee && selectedEmployee.EmployeeNo != 0)
            {
                LoadEmployeeGD(selectedEmployee.DBUNo);
                LoadDBU(selectedEmployee.DBUNo);
            }

        }

        private void LoadEmployeeGD(int DBUNo)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["LIVEDB"].ConnectionString;

                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT DISTINCT employeeno, firstname, positionno, dbuno FROM employee WHERE positionno = 1 AND dbuno = @DBUNo";

                    // Execute the query and pass the DBUNo parameter
                    var employees = connection.Query<EmployeeGD>(query, new { DBUNo }).ToList();

                    Debug.WriteLine($"Number of employees fetched: {employees.Count}");

                    if (employees.Count == 0)
                    {
                        Console.WriteLine("No employees found.");
                    }

                    cmbGD.DisplayMember = "firstname";
                    cmbGD.ValueMember = "employeeno";
                    cmbGD.DataSource = employees;

                    cmbGD.SelectedIndex = 0;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

        }

        private void LoadDBU(int DBUNo)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["LIVEDB"].ConnectionString;

                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT DISTINCT dbuno, description FROM dbu WHERE dbuno = @DBUNo";

                    // Execute the query and pass the DBUNo parameter
                    var employees = connection.Query<DBU>(query, new { DBUNo }).ToList();

                    Debug.WriteLine($"Number of employees fetched: {employees.Count}");

                    if (employees.Count == 0)
                    {
                        Console.WriteLine("No employees found.");
                    }

                    cmbDBU.DisplayMember = "description";
                    cmbDBU.ValueMember = "dbuno";
                    cmbDBU.DataSource = employees;

                    cmbDBU.SelectedIndex = 0;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

        }

    }
}
