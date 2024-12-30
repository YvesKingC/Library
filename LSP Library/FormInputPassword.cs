using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;

namespace LSP_Library
{
    public partial class FormInputPassword : Form
    {
        public FormInputPassword()
        {
            InitializeComponent();
        }
        // Database connection
        static string connectionString = "server=127.0.0.1;uid=root;pwd=;database=library;";
        public MySqlConnection sqlConnect = new MySqlConnection(connectionString);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnect.Open();

                // Use parameterized query to prevent SQL injection
                sqlQuery = "SELECT Pass FROM Admin WHERE Nama = @Nama";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.Parameters.AddWithValue("@Nama", tboxNama.Text);

                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable();
                sqlAdapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    string storedHashedPassword = dt.Rows[0]["Pass"].ToString();

                    // Verify the password
                    bool isPasswordValid = BCrypt.Net.BCrypt.Verify(tboxPass.Text, storedHashedPassword);

                    if (isPasswordValid)
                    {
                        MessageBox.Show("Login Berhasil");

                        // Close the current FormHome instance
                        Form parentForm = this.Owner;
                        parentForm?.Close();

                        this.Hide();

                        // Open FormAdvancedSetting
                        FormAdvancedSetting formAdvancedSetting = new FormAdvancedSetting();
                        formAdvancedSetting.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Login Gagal");
                    }
                }
                else
                {
                    MessageBox.Show("Login Gagal");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlConnect.State == ConnectionState.Open)
                {
                    sqlConnect.Close();
                }
            }
        }
    }
}
