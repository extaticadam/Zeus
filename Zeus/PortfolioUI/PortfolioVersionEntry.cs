using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using System.Configuration;

namespace PortfolioUI
{
    public partial class PortfolioVersionEntry : Form
    {
        private IDbConnection _connection;
        private string _portfolioID;

        public PortfolioVersionEntry(string portfolioID)
        {
            InitializeComponent();

            // Initialize the connection with the connection string from the config file
            string connectionString = ConfigurationManager.ConnectionStrings["LIVEDB"].ConnectionString;
            _connection = new NpgsqlConnection(connectionString);

            _portfolioID = portfolioID;

            // Load the available versions and display the most recent one
            LoadAvailableVersions();
        }

        private void LoadAvailableVersions()
        {
            try
            {
                string query = @"
                SELECT portfolioversionnumber
                FROM portfolioversion
                WHERE portfolioid = @portfolioID
                ORDER BY portfolioversionnumber DESC";

                using (var command = new NpgsqlCommand(query, (NpgsqlConnection)_connection))
                {
                    command.Parameters.AddWithValue("portfolioID", _portfolioID);
                    _connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        // Clear existing items
                        cmbVersions.Items.Clear();

                        while (reader.Read())
                        {
                            int versionNumber = reader.GetInt32(0);
                            cmbVersions.Items.Add(versionNumber);
                        }
                    }
                    _connection.Close();
                }

                if (cmbVersions.Items.Count > 0)
                {
                    cmbVersions.SelectedIndex = 0; // Select the most recent version
                    LoadVersionDetails((int)cmbVersions.SelectedItem); // Load details for the most recent version
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading versions: " + ex.Message);
            }
        }

        private void cmbVersions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbVersions.SelectedItem != null)
            {
                int selectedVersion = (int)cmbVersions.SelectedItem;
                LoadVersionDetails(selectedVersion);
            }
        }

        private void LoadVersionDetails(int versionNumber)
        {
            try
            {
                string query = @"
                SELECT *
                FROM portfolioversion
                WHERE portfolioid = @portfolioID AND portfolioversionnumber = @versionNumber";

                using (var command = new NpgsqlCommand(query, (NpgsqlConnection)_connection))
                {
                    command.Parameters.AddWithValue("portfolioID", _portfolioID);
                    command.Parameters.AddWithValue("versionNumber", versionNumber);
                    _connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Example of populating form controls with version details
                            txtDescription.Text = reader["description"].ToString();
                            txtDisplayID.Text = reader["displayid"].ToString();
                            // Add other fields as needed
                        }
                    }
                    _connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading version details: " + ex.Message);
            }
        }
    }
}
