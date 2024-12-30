using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BCrypt.Net;

namespace LSP_Library
{
    public partial class FormEditUser : Form
    {
        public FormEditUser()
        {
            InitializeComponent();
        }
        static string connectionString = "server=127.0.0.1;uid=root;pwd=;database=library;";
        public MySqlConnection sqlConnect = new MySqlConnection(connectionString);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;

        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();

        private void loadDGV()
        {
            // Set DGVAdmin and Anggota font to 11pt Segoe UI then make the columns to fill the width of the DGV and the columns to expand depending on the content
            DGVAdmin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DGVAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVAdmin.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DGVAdmin.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            DGVAnggota.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DGVAnggota.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVAnggota.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DGVAnggota.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Clear existing data in DataTables
            dt.Clear();
            dt2.Clear();

            //Load DGVAdmin
            sqlQuery = "Select * From Admin";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dt);
            DGVAdmin.DataSource = dt;

            //Load DGVAnggota
            sqlQuery = "Select * From Anggota";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dt2);
            DGVAnggota.DataSource = dt2;
        }
        private void loadcbox()
        {
            //cbox Admin//

            // Clear existing items in the ComboBox
            cboxAdmin.Items.Clear();

            // Load data into the ComboBox
            sqlQuery = "SELECT Nama FROM Admin";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            sqlAdapter.Fill(dt);

            // Add items to the ComboBox
            foreach (DataRow row in dt.Rows)
            {
                cboxAdmin.Items.Add(row["Nama"].ToString());
            }

            //cbox Anggota//
            cboxAnggota.Items.Clear();

            sqlQuery = "select Nama From Anggota";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            DataTable dt2 = new DataTable();
            sqlAdapter.Fill(dt2);

            // Add items to the ComboBox
            foreach (DataRow row in dt2.Rows)
            {
                cboxAnggota.Items.Add(row["Nama"].ToString());
            }
        }


        private void FormEditUser_Load(object sender, EventArgs e)
        {
            sqlConnect.Open();
            loadDGV();
            loadcbox();
            sqlConnect.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            sqlConnect.Open();
            // Add new Admin with hashed password using 
            if (string.IsNullOrWhiteSpace(tboxNama.Text) || string.IsNullOrWhiteSpace(tboxPass.Text))
            {
                MessageBox.Show("Nama dan Password tidak boleh kosong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Hash the password
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(tboxPass.Text);

            // Insert the new admin into the database
            sqlQuery = "INSERT INTO Admin (Nama, Pass) VALUES (@Nama, @Pass)";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.Parameters.AddWithValue("@Nama", tboxNama.Text);
            sqlCommand.Parameters.AddWithValue("@Pass", hashedPassword);

            int rowsAffected = sqlCommand.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Admin berhasil ditambahkan.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadDGV();
                loadcbox();
                sqlConnect.Close();
            }
            else
            {
                MessageBox.Show("Gagal menambahkan admin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sqlConnect.Close();
            }
        }

        private void BtnRemoveAdmin_Click(object sender, EventArgs e)
        {
            sqlConnect.Open();

            sqlQuery = "SELECT COUNT(*) FROM Admin";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            int adminCount = Convert.ToInt32(sqlCommand.ExecuteScalar());

            if (adminCount <= 1)
            {
                MessageBox.Show("Tidak dapat menghapus admin terakhir.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //remove admin based on name
            if (string.IsNullOrWhiteSpace(cboxAdmin.Text))
            {
                MessageBox.Show("Nama tidak boleh kosong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            // Confirm deletion
            DialogResult dialogResult = MessageBox.Show($"Apakah Anda yakin ingin menghapus admin '{cboxAdmin.Text}'?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            // Remove the admin from the database
            sqlQuery = "DELETE FROM Admin WHERE Nama = @Nama";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.Parameters.AddWithValue("@Nama", cboxAdmin.Text);

            int rowsAffected = sqlCommand.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Admin berhasil dihapus.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadDGV();
                loadcbox();
            }
            else
            {
                MessageBox.Show("Admin tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            sqlConnect.Close();
        }

        private void BtnEditAnggota_Click(object sender, EventArgs e)
        {
            sqlConnect.Open();
            if (string.IsNullOrWhiteSpace(cboxAnggota.Text))
            {
                MessageBox.Show("Nama anggota tidak boleh kosong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            sqlQuery = "UPDATE Anggota SET Alamat = @Alamat, NoTelp = @NoTelp, Email = @Email WHERE Nama = @Nama";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.Parameters.AddWithValue("@Nama", cboxAnggota.Text);
            sqlCommand.Parameters.AddWithValue("@Alamat", tboxAlamat.Text);
            sqlCommand.Parameters.AddWithValue("@NoTelp", tboxNoTelp.Text);
            sqlCommand.Parameters.AddWithValue("@Email", tboxEmail.Text);

            int rowsAffected = sqlCommand.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Anggota berhasil diperbarui.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadDGV(); // Refresh the DataGridView to reflect changes
                tboxAlamat.Clear();
                tboxNoTelp.Clear();
                tboxEmail.Clear();
            }
            else
            {
                MessageBox.Show("Anggota tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            sqlConnect.Close();
        }

        private void BtnRemoveAnggota_Click(object sender, EventArgs e)
        {
            sqlConnect.Open();
            //remove admin based on name
            if (string.IsNullOrWhiteSpace(cboxAnggota.Text))
            {
                MessageBox.Show("Nama tidak boleh kosong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Confirm deletion
            DialogResult dialogResult = MessageBox.Show($"Apakah Anda yakin ingin menghapus '{cboxAnggota.Text}'?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            // Remove the admin from the database
            sqlQuery = "DELETE FROM Anggota WHERE Nama = @Nama";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.Parameters.AddWithValue("@Nama", cboxAnggota.Text);

            int rowsAffected = sqlCommand.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Anggota berhasil dihapus.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadDGV();
                loadcbox();
            }
            else
            {
                MessageBox.Show("Anggota tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            sqlConnect.Close();
        }
    }
}
