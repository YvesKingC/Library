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

namespace LSP_Library
{
    public partial class FormKatalogBuku : Form
    {
        public FormKatalogBuku()
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
            DGVKatalog.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DGVKatalog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVKatalog.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DGVKatalog.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            DGVGenre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DGVGenre.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVGenre.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DGVGenre.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dt.Clear();
            dt2.Clear();

            //load DGVKatalog
            sqlQuery = "SELECT Katalog.KatalogID, Katalog.Judul, Katalog.Penulis, Katalog.Penerbit, Genre.Genre, Katalog.StokBuku " +
                          "FROM Katalog " +
                          "INNER JOIN Genre ON Katalog.GenreID = Genre.GenreID";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dt);
            DGVKatalog.DataSource = dt;

            //load DGVGenre
            sqlQuery = "SELECT * From Genre";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dt2);
            DGVGenre.DataSource = dt2;
        }

        private void loadcbox()
        {
            //Load cboxGenre
            cboxGenre.Items.Clear();

            sqlQuery = "SELECT Genre FROM Genre";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            DataTable cboxgenre = new DataTable();
            cboxgenre.Clear();
            sqlAdapter.Fill(cboxgenre);

            foreach (DataRow row in cboxgenre.Rows)
            {
                cboxGenre.Items.Add(row["Genre"].ToString());
            }

            //Load cboxJudul
            cboxJudul.Items.Clear();

            sqlQuery = "Select Judul from Katalog";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            DataTable cboxjudul = new DataTable();
            cboxjudul.Clear();
            sqlAdapter.Fill(cboxjudul);

            foreach (DataRow row in cboxjudul.Rows)
            {
                cboxJudul.Items.Add(row["Judul"].ToString());
            }

            //Load cboxRemoveGenre
            foreach (DataRow row in cboxgenre.Rows)
            {
                cboxRemoveGenre.Items.Add(row["Genre"].ToString());
            }
        }

        private void FormKatalogBuku_Load(object sender, EventArgs e)
        {
            sqlConnect.Open();
            loadDGV();
            loadcbox();
            sqlConnect.Close();
        }

        private void BtnAddBuku_Click(object sender, EventArgs e)
        {
            sqlConnect.Open();

            if (string.IsNullOrWhiteSpace(tboxJudul.Text))
            {
                MessageBox.Show("Judul buku tidak boleh kosong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cboxGenre.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih genre buku.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            sqlQuery = "SELECT GenreID FROM Genre WHERE Genre = @Genre";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.Parameters.AddWithValue("@Genre", cboxGenre.Text);

            int genreID = Convert.ToInt32(sqlCommand.ExecuteScalar());

            sqlQuery = "INSERT INTO Katalog (GenreID, Judul, Penulis, Penerbit, StokBuku) VALUES (@GenreID, @Judul, @Penulis, @Penerbit, @StokBuku)";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.Parameters.AddWithValue("@GenreID", genreID); // Assuming cboxGenre is bound to GenreID
            sqlCommand.Parameters.AddWithValue("@Judul", tboxJudul.Text);
            sqlCommand.Parameters.AddWithValue("@Penulis", tboxPenulis.Text);
            sqlCommand.Parameters.AddWithValue("@Penerbit", tboxPenerbit.Text);
            sqlCommand.Parameters.AddWithValue("@StokBuku", NUDNewStock.Value); // Assuming nudStokBuku is a numeric up/down control for stock

            int rowsAffected = sqlCommand.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Buku berhasil ditambahkan.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadDGV();
                loadcbox();
            }
            else
            {
                MessageBox.Show("Gagal menambahkan buku.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            sqlConnect.Close();
        }

        private void BtnRemoveBuku_Click(object sender, EventArgs e)
        {
            sqlConnect.Open();

            if (string.IsNullOrWhiteSpace(cboxJudul.Text))
            {
                MessageBox.Show("Judul tidak boleh kosong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult dialogResult = MessageBox.Show($"Apakah Anda yakin ingin menghapus buku '{cboxJudul.Text}'?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            sqlQuery = "DELETE FROM Katalog WHERE Judul = @Judul";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.Parameters.AddWithValue("@Judul", cboxJudul.Text);

            int rowsAffected = sqlCommand.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Buku berhasil dihapus.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadDGV();
                loadcbox();
                cboxJudul.Items.Clear();
            }
            else
            {
                MessageBox.Show("Buku tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            sqlConnect.Close();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            sqlConnect.Open();

            if (string.IsNullOrWhiteSpace(cboxJudul.Text))
            {
                MessageBox.Show("Judul tidak boleh kosong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult dialogResult = MessageBox.Show($"Apakah Anda yakin ingin mengedit buku '{cboxJudul.Text}'?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            sqlQuery = "UPDATE Katalog SET StokBuku = @StokBuku WHERE Judul = @Judul";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect); sqlCommand.Parameters.AddWithValue("@StokBuku", NUDEditStock.Value);
            sqlCommand.Parameters.AddWithValue("@Judul", cboxJudul.Text);

            int rowsAffected = sqlCommand.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Buku berhasil diperbarui.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadDGV();
                loadcbox();
                cboxJudul.Items.Clear();
                NUDEditStock.Value = 0;
            }
            else
            {
                MessageBox.Show("Buku tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            sqlConnect.Close();
        }

        private void BtnAddGenre_Click(object sender, EventArgs e)
        {
            sqlConnect.Open();

            if (string.IsNullOrWhiteSpace(tboxNewGenre.Text))
            {
                MessageBox.Show("Genre tidak boleh kosong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            sqlQuery = "INSERT INTO Genre (Genre) VALUES (@Genre)"; sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.Parameters.AddWithValue("@Genre", tboxNewGenre.Text);

            int rowsAffected = sqlCommand.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Genre berhasil ditambahkan.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadDGV();
                loadcbox();
                tboxNewGenre.Clear();
            }
            else
            {
                MessageBox.Show("Genre tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            sqlConnect.Close();
        }

        private void BtnRemoveGenre_Click(object sender, EventArgs e)
        {
            sqlConnect.Open();

            if (string.IsNullOrWhiteSpace(cboxRemoveGenre.Text))
            {
                MessageBox.Show("Genre tidak boleh kosong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            sqlQuery = "DELETE FROM Genre WHERE Genre = @Genre";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.Parameters.AddWithValue("@Genre", cboxRemoveGenre.Text);

            int rowsAffected = sqlCommand.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Genre berhasil dihapus.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadcbox();
                loadDGV();
                cboxRemoveGenre.Items.Clear();
            }
            else
            {
                MessageBox.Show("Genre tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            sqlConnect.Close();
        }
    }
}
