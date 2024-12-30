using MySql.Data.MySqlClient;
using System.Data;

namespace LSP_Library
{
    public partial class FormPengembalian : Form
    {
        public FormPengembalian()
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
                // Set DGV font to 11pt Segoe UI then make the columns to fill the width of the DGV and the columns to expand depending on the content
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
                sqlQuery = @"SELECT P.PeminjamanID, K.KatalogID, K.Judul, DP.Jumlah, P.TglPinjam, P.BatasPengembalian
                FROM Peminjaman P
                INNER JOIN DetailPeminjaman DP ON P.PeminjamanID = DP.PeminjamanID
                INNER JOIN Katalog K ON DP.KatalogID = K.KatalogID
                INNER JOIN Anggota A ON P.AnggotaID = A.AnggotaID
                WHERE A.Nama = @Nama AND P.TglKembali IS NULL";

                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.Parameters.AddWithValue("@Nama", anggotaNama);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable();
                sqlAdapter.Fill(dt);

                // Bind the data to the DataGridView
                DGVKatalog.DataSource = dt;

                // Set column headers
                DGVKatalog.Columns["Judul"].HeaderText = "Judul Buku";
                DGVKatalog.Columns["Jumlah"].HeaderText = "Jumlah";
                DGVKatalog.Columns["TglPinjam"].HeaderText = "Tanggal Pinjam";
                DGVKatalog.Columns["BatasPengembalian"].HeaderText = "Deadline Pengembalian";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormPengembalian_Load(object sender, EventArgs e)
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

        private void BtnPengembalian_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGVKatalog.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Pilih buku yang ingin dikembalikan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Get the selected book's details
                int selectedPeminjamanID = Convert.ToInt32(DGVKatalog.SelectedRows[0].Cells["PeminjamanID"].Value);
                int selectedKatalogID = Convert.ToInt32(DGVKatalog.SelectedRows[0].Cells["KatalogID"].Value);
                int jumlah = Convert.ToInt32(DGVKatalog.SelectedRows[0].Cells["Jumlah"].Value);
                DateTime tglKembali = DateTime.Now;

                // Update TglKembali in Peminjaman table
                sqlQuery = "UPDATE Peminjaman SET TglKembali = @TglKembali WHERE PeminjamanID = @PeminjamanID";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.Parameters.AddWithValue("@TglKembali", tglKembali);
                sqlCommand.Parameters.AddWithValue("@PeminjamanID", selectedPeminjamanID);
                sqlConnect.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();

                // Update the stock in Katalog table
                sqlQuery = "UPDATE Katalog SET StokBuku = StokBuku + @Jumlah WHERE KatalogID = @KatalogID";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.Parameters.AddWithValue("@Jumlah", jumlah);
                sqlCommand.Parameters.AddWithValue("@KatalogID", selectedKatalogID);
                sqlConnect.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();

                // Show success message
                MessageBox.Show("Buku berhasil dikembalikan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
