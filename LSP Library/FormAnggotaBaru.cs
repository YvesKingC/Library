using MySql.Data.MySqlClient;
using System.Data;

namespace LSP_Library
{
    public partial class FormAnggotaBaru : Form
    {
        public FormAnggotaBaru()
        {
            InitializeComponent();
        }
        static string connectionString = "server=127.0.0.1;uid=root;pwd=;database=library;";
        public MySqlConnection sqlConnect = new MySqlConnection(connectionString);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;

        /// <summary>Handles the Click event of the BtnDaftarAnggota control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        /// 
        private void BtnDaftarAnggota_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnect.Open();

                // Check if the member name is provided
                if (string.IsNullOrWhiteSpace(tboxAnggota.Text))
                {
                    MessageBox.Show("Nama anggota tidak boleh kosong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                // Check if the member name already exists
                sqlQuery = "SELECT COUNT(*) FROM Anggota WHERE Nama = @Nama";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.Parameters.AddWithValue("@Nama", tboxAnggota.Text);
                int nameCount = Convert.ToInt32(sqlCommand.ExecuteScalar());

                if (nameCount > 0)
                {
                    MessageBox.Show("Nama sudah ada. Silakan masukkan nama lain.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Insert the new member details
                sqlQuery = "INSERT INTO Anggota (Nama, Alamat, NoTelp, Email) VALUES (@Nama, @Alamat, @NoTelp, @Email)";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.Parameters.AddWithValue("@Nama", tboxAnggota.Text);
                sqlCommand.Parameters.AddWithValue("@Alamat", tboxAlamat.Text);
                sqlCommand.Parameters.AddWithValue("@NoTelp", tboxNoTelp.Text);
                sqlCommand.Parameters.AddWithValue("@Email", tboxEmail.Text);

                int rowsAffected = sqlCommand.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Anggota berhasil ditambahkan.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tboxAnggota.Clear();
                    tboxAlamat.Clear();
                    tboxNoTelp.Clear();
                    tboxEmail.Clear();
                }
                else
                {
                    MessageBox.Show("Gagal menambahkan anggota.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
