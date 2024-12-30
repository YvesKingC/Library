using MySql.Data.MySqlClient;
using System.Data;

namespace LSP_Library
{
    public partial class FormPeminjaman : Form
    {
        public FormPeminjaman()
        {
            InitializeComponent();
        }

        static string connectionString = "server=127.0.0.1;uid=root;pwd=;database=library;";
        public MySqlConnection sqlConnect = new MySqlConnection(connectionString);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;

        DataTable katalogTable = new DataTable();

        private void loadDGV()
        {

            // Set DGVKatalog font to 11pt Segoe UI then make the columns to fill the width of the DGV and the columns to expand depending on the content
            DGVKatalog.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DGVKatalog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVKatalog.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DGVKatalog.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            katalogTable.Clear();

            sqlQuery = "SELECT Katalog.KatalogID, Katalog.Judul, Katalog.Penulis, Katalog.Penerbit, Genre.Genre, Katalog.StokBuku " +
                          "FROM Katalog " +
                          "INNER JOIN Genre ON Katalog.GenreID = Genre.GenreID";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(katalogTable);
            DGVKatalog.DataSource = katalogTable;
        }
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
        private void FormPeminjaman_Load(object sender, EventArgs e)
        {
            sqlConnect.Open();
            loadDGV();
            loadcbox();
            sqlConnect.Close();
        }

        private void BtnDaftar_Click(object sender, EventArgs e)
        {
            FormAnggotaBaru formAnggotaBaru = new FormAnggotaBaru();
            formAnggotaBaru.ShowDialog();
            this.Hide();
        }

        private void BtnPinjam_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGVKatalog.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Pilih buku yang ingin dipinjam.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Get the selected book's details
                int selectedKatalogID = Convert.ToInt32(DGVKatalog.SelectedRows[0].Cells["KatalogID"].Value);
                string judulBuku = DGVKatalog.SelectedRows[0].Cells["Judul"].Value.ToString();

                // Validate Anggota selection
                if (cboxAnggota.SelectedIndex == -1)
                {
                    MessageBox.Show("Pilih anggota yang meminjam buku.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Retrieve AnggotaID based on the selected name
                sqlQuery = "SELECT AnggotaID FROM Anggota WHERE Nama = @Nama";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.Parameters.AddWithValue("@Nama", cboxAnggota.Text);
                sqlConnect.Open();
                int anggotaID = Convert.ToInt32(sqlCommand.ExecuteScalar());
                sqlConnect.Close();

                if (anggotaID == 0)
                {
                    MessageBox.Show("Anggota tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string namaAnggota = cboxAnggota.Text;

                // Dates for borrowing and deadline
                DateTime tglPinjam = DTPHariini.Value;
                DateTime batasPengembalian = tglPinjam.AddDays(7);

                // Open the database connection
                sqlConnect.Open();

                // Insert into Peminjaman table
                sqlQuery = "INSERT INTO Peminjaman (AnggotaID, TglPinjam, BatasPengembalian, TglKembali) VALUES (@AnggotaID, @TglPinjam, @BatasPengembalian, NULL)";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.Parameters.AddWithValue("@AnggotaID", anggotaID);
                sqlCommand.Parameters.AddWithValue("@TglPinjam", tglPinjam);
                sqlCommand.Parameters.AddWithValue("@BatasPengembalian", batasPengembalian);
                sqlCommand.ExecuteNonQuery();

                // Get the last inserted PeminjamanID
                sqlQuery = "SELECT LAST_INSERT_ID()";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                int peminjamanID = Convert.ToInt32(sqlCommand.ExecuteScalar());

                // Insert into DetailPeminjaman table
                sqlQuery = "INSERT INTO DetailPeminjaman (PeminjamanID, KatalogID, Jumlah) VALUES (@PeminjamanID, @KatalogID, @Jumlah)";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.Parameters.AddWithValue("@PeminjamanID", peminjamanID);
                sqlCommand.Parameters.AddWithValue("@KatalogID", selectedKatalogID);
                sqlCommand.Parameters.AddWithValue("@Jumlah", 1); // Borrowing 1 copy
                sqlCommand.ExecuteNonQuery();

                // Reduced Katalog Stock for borrowed book
                sqlQuery = "UPDATE Katalog SET StokBuku = StokBuku - 1 WHERE KatalogID = @KatalogID";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.Parameters.AddWithValue("@KatalogID", selectedKatalogID);
                sqlCommand.ExecuteNonQuery();

                // Show success notification
                MessageBox.Show($"Buku '{judulBuku}' berhasil dipinjam oleh {namaAnggota}.\n" +
                                $"Tanggal Pinjam: {tglPinjam:yyyy-MM-dd}\n" +
                                $"Batas Pengembalian: {batasPengembalian:yyyy-MM-dd}",
                                "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh the DataGridView
                this.Close();
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
