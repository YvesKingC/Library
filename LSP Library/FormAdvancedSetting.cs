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
    public partial class FormAdvancedSetting : Form
    {
        public FormAdvancedSetting()
        {
            InitializeComponent();
        }
        // Database connection
        static string connectionString = "server=127.0.0.1;uid=root;pwd=;database=library;";
        public MySqlConnection sqlConnect = new MySqlConnection(connectionString);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;


        //when user click the button, it will open form in the panel
        private void BtnUserCont_Click(object sender, EventArgs e)
        {
            panelAdvanced.Controls.Clear();
            FormEditUser formUserControl = new FormEditUser();
            formUserControl.TopLevel = false;
            panelAdvanced.Controls.Add(formUserControl);
            formUserControl.Show();
        }

        private void BtnKatalog_Click(object sender, EventArgs e)
        {
            panelAdvanced.Controls.Clear();
            FormKatalogBuku formKatalog = new FormKatalogBuku();
            formKatalog.TopLevel = false;
            panelAdvanced.Controls.Add(formKatalog);
            formKatalog.Show();
        }

        private void BtnLog_Click(object sender, EventArgs e)
        {
            panelAdvanced.Controls.Clear();
            FormLogPeminjaman formlogpeminjaman = new FormLogPeminjaman();
            formlogpeminjaman.TopLevel = false;
            panelAdvanced.Controls.Add(formlogpeminjaman);
            formlogpeminjaman.Show();
        }
    }
}
