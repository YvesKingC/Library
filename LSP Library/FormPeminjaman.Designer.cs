namespace LSP_Library
{
    partial class FormPeminjaman
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel5 = new Panel();
            BtnPinjam = new Button();
            BtnDaftar = new Button();
            label2 = new Label();
            cboxAnggota = new ComboBox();
            label4 = new Label();
            panel6 = new Panel();
            label7 = new Label();
            DGVKatalog = new DataGridView();
            DTPHariini = new DateTimePicker();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVKatalog).BeginInit();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Control;
            panel5.Controls.Add(BtnPinjam);
            panel5.Controls.Add(BtnDaftar);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(cboxAnggota);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(panel6);
            panel5.Location = new Point(12, 12);
            panel5.Name = "panel5";
            panel5.Size = new Size(1240, 132);
            panel5.TabIndex = 8;
            // 
            // BtnPinjam
            // 
            BtnPinjam.BackColor = Color.PaleGreen;
            BtnPinjam.Location = new Point(1145, 89);
            BtnPinjam.Name = "BtnPinjam";
            BtnPinjam.Size = new Size(75, 23);
            BtnPinjam.TabIndex = 13;
            BtnPinjam.Text = "Pinjam";
            BtnPinjam.UseVisualStyleBackColor = false;
            BtnPinjam.Click += BtnPinjam_Click;
            // 
            // BtnDaftar
            // 
            BtnDaftar.BackColor = Color.PaleGreen;
            BtnDaftar.Location = new Point(1145, 50);
            BtnDaftar.Name = "BtnDaftar";
            BtnDaftar.Size = new Size(75, 23);
            BtnDaftar.TabIndex = 12;
            BtnDaftar.Text = "Daftar";
            BtnDaftar.UseVisualStyleBackColor = false;
            BtnDaftar.Click += BtnDaftar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(33, 159);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 11;
            // 
            // cboxAnggota
            // 
            cboxAnggota.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboxAnggota.FormattingEnabled = true;
            cboxAnggota.Location = new Point(98, 49);
            cboxAnggota.Name = "cboxAnggota";
            cboxAnggota.Size = new Size(1041, 29);
            cboxAnggota.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(33, 49);
            label4.Name = "label4";
            label4.Size = new Size(59, 21);
            label4.TabIndex = 2;
            label4.Text = "Nama :";
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ControlDark;
            panel6.Controls.Add(label7);
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1240, 33);
            panel6.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(3, 4);
            label7.Name = "label7";
            label7.Size = new Size(97, 21);
            label7.TabIndex = 1;
            label7.Text = "Pinjam Buku";
            // 
            // DGVKatalog
            // 
            DGVKatalog.BackgroundColor = SystemColors.ButtonFace;
            DGVKatalog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVKatalog.Location = new Point(12, 150);
            DGVKatalog.Name = "DGVKatalog";
            DGVKatalog.RowTemplate.Height = 25;
            DGVKatalog.Size = new Size(1240, 519);
            DGVKatalog.TabIndex = 9;
            // 
            // DTPHariini
            // 
            DTPHariini.CalendarFont = new Font("Segoe UI", 4F, FontStyle.Regular, GraphicsUnit.Point);
            DTPHariini.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DTPHariini.Location = new Point(727, 52);
            DTPHariini.Name = "DTPHariini";
            DTPHariini.Size = new Size(322, 29);
            DTPHariini.TabIndex = 14;
            // 
            // FormPeminjaman
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1264, 681);
            Controls.Add(DGVKatalog);
            Controls.Add(panel5);
            Controls.Add(DTPHariini);
            Name = "FormPeminjaman";
            Text = "Peminjaman";
            Load += FormPeminjaman_Load;
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVKatalog).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel5;
        private Label label4;
        private Panel panel6;
        private Label label7;
        private ComboBox cboxAnggota;
        private DataGridView DGVKatalog;
        private Button BtnDaftar;
        private Label label2;
        private DateTimePicker DTPHariini;
        private Button BtnPinjam;
    }
}