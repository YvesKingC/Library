using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System.Data;

namespace LSP_Library
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }
        // Database connection
        static string connectionString = "server=127.0.0.1;uid=root;pwd=;database=library;";
        public MySqlConnection sqlConnect = new MySqlConnection(connectionString);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;

        DataTable katalogTable = new DataTable();

        // When text in search box changes, update the data grid view
        /// <summary>Handles the TextChanged event of the tBoxSearch control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void tBoxSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = katalogTable.DefaultView;
            //set filter for dataview
            dv.RowFilter = string.Format("Judul LIKE '%{0}%' OR Penulis LIKE '%{0}%' OR Penerbit LIKE '%{0}%' OR Genre LIKE '%{0}%'", tBoxSearch.Text);
            DGVKatalog.DataSource = dv.ToTable();
        }

        // When FormHome Load event is triggered, load the data from database
        /// <summary>Handles the Load event of the FormHome control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void FormHome_Load(object sender, EventArgs e)
        {
            // Set DGVKatalog font to 11pt Segoe UI then make the columns to fill the width of the DGV and the columns to expand depending on the content
            DGVKatalog.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DGVKatalog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVKatalog.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DGVKatalog.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            katalogTable.Clear();
            sqlConnect.Open();
            sqlQuery = "SELECT Katalog.KatalogID, Katalog.Judul, Katalog.Penulis, Katalog.Penerbit, Genre.Genre, Katalog.StokBuku " +
                          "FROM Katalog " +
                          "INNER JOIN Genre ON Katalog.GenreID = Genre.GenreID";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(katalogTable);
            DGVKatalog.DataSource = katalogTable;
            sqlConnect.Close();
        }

        /// <summary>Handles the Click event of the BtnEditor control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void BtnEditor_Click(object sender, EventArgs e)
        {
            FormInputPassword formInputPassword = new FormInputPassword();
            formInputPassword.ShowDialog();
        }

        private void BtnPinjam_Click(object sender, EventArgs e)
        {
            FormPeminjaman formPeminjaman = new FormPeminjaman();
            formPeminjaman.ShowDialog();
        }

        private void BtnPengembalian_Click(object sender, EventArgs e)
        {
            FormPengembalian formPengembalian = new FormPengembalian();
            formPengembalian.ShowDialog();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            FormHome_Load(sender, e);
        }
    }
}