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
using MySql.Data.MySqlClient;

namespace LSP_Library
{
    public partial class FormLogPeminjaman : Form
    {
        public FormLogPeminjaman()
        {
            InitializeComponent();
        }

        static string connectionString = "server=127.0.0.1;uid=root;pwd=;database=library;";
        public MySqlConnection sqlConnect = new MySqlConnection(connectionString);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;

        private void loadcbox()
        {
            cboxAnggota.Items.Clear();

            sqlQuery = "SELECT Nama FROM Anggota";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            sqlAdapter.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                cboxAnggota.Items.Add(row["Nama"].ToString());
            }
        }
        private void loadDGV()
        {
            try
            {
                // Set DGVfont to 11pt Segoe UI then make the columns to fill the width of the DGV and the columns to expand depending on the content
                DGVKatalog.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                DGVKatalog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DGVKatalog.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                DGVKatalog.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                if (cboxAnggota.SelectedIndex == -1)
                {
                    MessageBox.Show("Pilih anggota terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Retrieve AnggotaID based on the selected name
                string anggotaNama = cboxAnggota.Text;
                sqlQuery = @"
            SELECT A.Nama, K.Judul, DP.Jumlah, P.TglPinjam, P.BatasPengembalian, P.TglKembali
            FROM Peminjaman P
            INNER JOIN DetailPeminjaman DP ON P.PeminjamanID = DP.PeminjamanID
            INNER JOIN Katalog K ON DP.KatalogID = K.KatalogID
            INNER JOIN Anggota A ON P.AnggotaID = A.AnggotaID
            WHERE A.Nama = @Nama";

                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.Parameters.AddWithValue("@Nama", anggotaNama);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable();
                sqlAdapter.Fill(dt);

                // Bind the data to the DataGridView
                DGVKatalog.DataSource = dt;

                // Set column headers
                DGVKatalog.Columns["Nama"].HeaderText = "Nama Anggota";
                DGVKatalog.Columns["Judul"].HeaderText = "Judul Buku";
                DGVKatalog.Columns["Jumlah"].HeaderText = "Jumlah";
                DGVKatalog.Columns["TglPinjam"].HeaderText = "Tanggal Pinjam";
                DGVKatalog.Columns["BatasPengembalian"].HeaderText = "Deadline Pengembalian";
                DGVKatalog.Columns["TglKembali"].HeaderText = "Tanggal Kembali";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void FormLogPeminjaman_Load(object sender, EventArgs e)
        {
            sqlConnect.Open();

            loadcbox();

            sqlConnect.Close();
        }

        private void cboxAnggota_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlConnect.Open();

            loadDGV();

            sqlConnect.Close();
        }
    }
}
