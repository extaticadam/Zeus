using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Npgsql;
using System.Configuration;
using Dapper;
using PortfolioLibrary.Models;
using System.Diagnostics;

namespace PortfolioUI
{
    public partial class SearchForm : Form
    {
        private string connectionString;

        public SearchForm()
        {
            InitializeComponent();
            this.Text = "Search Form";

            connectionString = ConfigurationManager.ConnectionStrings["LIVEDB"].ConnectionString;
            LoadEmployeeBD();

            DGVSearch.CellContentClick += DGVSearch_CellContentClick;
        }

        private void LoadDataGridView(string descriptionFilter, string BDFilter, int ProductClassFilter)
        {
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    // Base query
                    string query = @"
                            SELECT *
                            FROM PortfolioSearchQueryView x
                            WHERE x.portfolioid IS NOT NULL";

                    // Add filters
                    if (!string.IsNullOrEmpty(descriptionFilter))
                    {
                        query += " AND x.Description LIKE @descriptionFilter";
                    }

                    if (!string.IsNullOrEmpty(BDFilter) && BDFilter != "-1")
                    {
                        query += " AND e.DirectorEmployeeNo = @BDFilter";
                    }

                    // Product Class and Season filters
                    switch (ProductClassFilter)
                    {
                        case 0:  // Specials
                            query += " AND x.productclass = 3 AND x.seasonid IS NULL";
                            break;
                        case 1:  // Seasonal - Easter
                            query += " AND x.productclass = 4 AND x.seasonid = 1";
                            break;
                        case 2:  // Seasonal - Christmas
                            query += " AND x.productclass = 4 AND x.seasonid = 2";
                            break;
                    }

                    // Handle date filtering if needed
                    // Uncomment and use the code if dates are required
                    //if (selectedDateFrom.HasValue && selectedDateTo.HasValue)
                    //{
                    //    query += " AND x.onsaledate BETWEEN @OSDFrom AND @OSDTo";
                    //}
                    //else if (selectedDateFrom.HasValue)
                    //{
                    //    query += " AND x.onsaledate >= @OSDFrom";
                    //}
                    //else if (selectedDateTo.HasValue)
                    //{
                    //    query += " AND x.onsaledate <= @OSDTo";
                    //}

                    query += " ORDER BY x.onsaledate";

                    using (var cmd = new NpgsqlCommand(query, connection))
                    {
                        // Bind parameters
                        if (!string.IsNullOrEmpty(descriptionFilter))
                        {
                            cmd.Parameters.AddWithValue("@descriptionFilter", $"%{descriptionFilter}%");
                        }

                        if (!string.IsNullOrEmpty(BDFilter) && BDFilter != "-1" && int.TryParse(BDFilter, out int bdFilterValue))
                        {
                            cmd.Parameters.AddWithValue("@BDFilter", bdFilterValue);
                        }

                        // Fill DataTable
                        NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Bind to DataGridView
                        DGVSearch.DataSource = dt;

                        // Check and set custom header text and styles
                        if (DGVSearch.Columns.Contains("On Sale Date"))
                        {
                            DGVSearch.Columns["On Sale Date"].HeaderText = "Sale Date";
                            DGVSearch.Columns["On Sale Date"].DisplayIndex = 0;  // First column
                        }

                        if (DGVSearch.Columns.Contains("ProductClass"))
                        {
                            DGVSearch.Columns["ProductClass"].HeaderText = "Product Class";
                            DGVSearch.Columns["ProductClass"].DisplayIndex = 1;  // Second column
                        }

                        if (DGVSearch.Columns.Contains("Description"))
                        {
                            // Remove and re-add column to apply hyperlink formatting
                            DGVSearch.Columns.Remove("Description");
                            DataGridViewLinkColumn descriptionLinkColumn = new DataGridViewLinkColumn
                            {
                                HeaderText = "Description",
                                DataPropertyName = "Description",
                                Name = "DescriptionLink",  // Unique name for the column
                                LinkBehavior = LinkBehavior.HoverUnderline,
                                TrackVisitedState = false
                            };
                            DGVSearch.Columns.Add(descriptionLinkColumn);
                            DGVSearch.Columns["DescriptionLink"].DisplayIndex = 2;  // Third column
                        }

                        if (DGVSearch.Columns.Contains("Version"))
                        {
                            DGVSearch.Columns["Version"].HeaderText = "Version";
                            DGVSearch.Columns["Version"].DisplayIndex = 3;  // Fourth column
                        }

                        if (DGVSearch.Columns.Contains("DisplayID"))
                        {
                            DGVSearch.Columns["DisplayID"].HeaderText = "Display ID";
                            DGVSearch.Columns["DisplayID"].DisplayIndex = 4;  // Fifth column
                        }

                        if (DGVSearch.Columns.Contains("ACG"))
                        {
                            DGVSearch.Columns["ACG"].HeaderText = "ACG";
                            DGVSearch.Columns["ACG"].DisplayIndex = 5;  // Sixth column
                        }

                        if (DGVSearch.Columns.Contains("Director"))
                        {
                            DGVSearch.Columns["Director"].HeaderText = "Director";
                            DGVSearch.Columns["Director"].DisplayIndex = 6;  // Seventh column
                        }

                        if (DGVSearch.Columns.Contains("Assistant"))
                        {
                            DGVSearch.Columns["Assistant"].HeaderText = "Assistant";
                            DGVSearch.Columns["Assistant"].DisplayIndex = 7;  // Eighth column
                        }

                        if (DGVSearch.Columns.Contains("Status"))
                        {
                            DGVSearch.Columns["Status"].HeaderText = "Status";
                            DGVSearch.Columns["Status"].DisplayIndex = 8;  // Ninth column
                        }

                        // Hide the PortfolioID column (but still available for use programmatically)
                        if (DGVSearch.Columns.Contains("PortfolioID"))
                        {
                            DGVSearch.Columns["PortfolioID"].Visible = false;
                        }

                        // Set column styles
                        foreach (DataGridViewColumn column in DGVSearch.Columns)
                        {
                            column.HeaderCell.Style.Font = new Font("Arial", 10, FontStyle.Bold);
                            column.HeaderCell.Style.BackColor = Color.FromArgb(0, 32, 96);
                            column.HeaderCell.Style.ForeColor = Color.White;
                            column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        }

                        // Auto-size columns
                        DGVSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void DGVSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked column is the Description hyperlink column
            if (DGVSearch.Columns[e.ColumnIndex] is DataGridViewLinkColumn && e.RowIndex >= 0)
            {
                // Get the PortfolioID from the clicked row
                string portfolioID = DGVSearch.Rows[e.RowIndex].Cells["PortfolioID"].Value.ToString();

                // Open PortfolioVersionEntry form and pass the PortfolioID
                PortfolioVersionEntry portfolioEntryForm = new PortfolioVersionEntry(portfolioID);
                portfolioEntryForm.Show();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Get the description entered by the user
            string description = txtDescription.Text.Trim();
            string BDFilter = cmbBD.SelectedValue?.ToString();
            int ProductClassFilter = cmbProductClass.SelectedIndex;
            // DateTime selectedDateFrom = dtpOnSaleDateFrom.Value; (commented out if not used)
            // DateTime selectedDateTo = dtpOnSaleDateTo.Value; (commented out if not used)

            // Call the LoadDataGridView method with the filter
            LoadDataGridView(description, BDFilter, ProductClassFilter);
        }

        private void LoadEmployeeBD()
        {
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT DISTINCT employeeno, firstname, positionno, dbuno FROM employee WHERE positionno = 2";
                    var employees = connection.Query<EmployeeBD>(query).ToList();

                    Debug.WriteLine($"Number of employees fetched: {employees.Count}");

                    if (employees.Count == 0)
                    {
                        Console.WriteLine("No employees found.");
                    }

                    employees.Insert(0, new EmployeeBD { EmployeeNo = -1, firstName = "" });

                    cmbBD.DisplayMember = "firstName";
                    cmbBD.ValueMember = "EmployeeNo";
                    cmbBD.DataSource = employees;

                    cmbBD.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while loading employees: {ex.Message}");
            }
        }
    }

    public class EmployeeBD
    {
        public int EmployeeNo { get; set; }
        public string firstName { get; set; }
        public int positionno { get; set; }
        public string dbuno { get; set; }
    }
}
