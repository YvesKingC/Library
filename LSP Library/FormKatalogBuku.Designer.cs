namespace LSP_Library
{
    partial class FormKatalogBuku
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
            DGVKatalog = new DataGridView();
            DGVGenre = new DataGridView();
            panel5 = new Panel();
            NUDNewStock = new NumericUpDown();
            label1 = new Label();
            cboxGenre = new ComboBox();
            tboxJudul = new TextBox();
            BtnAddBuku = new Button();
            label10 = new Label();
            tboxPenerbit = new TextBox();
            label9 = new Label();
            tboxPenulis = new TextBox();
            label8 = new Label();
            label4 = new Label();
            panel6 = new Panel();
            label7 = new Label();
            panel3 = new Panel();
            BtnEdit = new Button();
            NUDEditStock = new NumericUpDown();
            label2 = new Label();
            cboxJudul = new ComboBox();
            label5 = new Label();
            BtnRemoveBuku = new Button();
            panel4 = new Panel();
            label6 = new Label();
            panel1 = new Panel();
            tboxNewGenre = new TextBox();
            BtnAddGenre = new Button();
            label11 = new Label();
            panel2 = new Panel();
            label12 = new Label();
            panel7 = new Panel();
            BtnRemoveGenre = new Button();
            cboxRemoveGenre = new ComboBox();
            label3 = new Label();
            panel8 = new Panel();
            label13 = new Label();
            ((System.ComponentModel.ISupportInitialize)DGVKatalog).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVGenre).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NUDNewStock).BeginInit();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NUDEditStock).BeginInit();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // DGVKatalog
            // 
            DGVKatalog.BackgroundColor = SystemColors.ButtonFace;
            DGVKatalog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVKatalog.Location = new Point(12, 181);
            DGVKatalog.Name = "DGVKatalog";
            DGVKatalog.RowTemplate.Height = 25;
            DGVKatalog.Size = new Size(808, 365);
            DGVKatalog.TabIndex = 2;
            // 
            // DGVGenre
            // 
            DGVGenre.BackgroundColor = SystemColors.ButtonFace;
            DGVGenre.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVGenre.Location = new Point(826, 181);
            DGVGenre.Name = "DGVGenre";
            DGVGenre.RowTemplate.Height = 25;
            DGVGenre.Size = new Size(386, 365);
            DGVGenre.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Control;
            panel5.Controls.Add(NUDNewStock);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(cboxGenre);
            panel5.Controls.Add(tboxJudul);
            panel5.Controls.Add(BtnAddBuku);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(tboxPenerbit);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(tboxPenulis);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(panel6);
            panel5.Location = new Point(12, 12);
            panel5.Name = "panel5";
            panel5.Size = new Size(513, 163);
            panel5.TabIndex = 8;
            // 
            // NUDNewStock
            // 
            NUDNewStock.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NUDNewStock.Location = new Point(78, 117);
            NUDNewStock.Name = "NUDNewStock";
            NUDNewStock.Size = new Size(120, 29);
            NUDNewStock.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(25, 119);
            label1.Name = "label1";
            label1.Size = new Size(47, 21);
            label1.TabIndex = 14;
            label1.Text = "Stok :";
            // 
            // cboxGenre
            // 
            cboxGenre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboxGenre.FormattingEnabled = true;
            cboxGenre.Location = new Point(327, 79);
            cboxGenre.Name = "cboxGenre";
            cboxGenre.Size = new Size(170, 29);
            cboxGenre.TabIndex = 13;
            // 
            // tboxJudul
            // 
            tboxJudul.BorderStyle = BorderStyle.FixedSingle;
            tboxJudul.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tboxJudul.Location = new Point(78, 47);
            tboxJudul.Name = "tboxJudul";
            tboxJudul.Size = new Size(163, 29);
            tboxJudul.TabIndex = 12;
            // 
            // BtnAddBuku
            // 
            BtnAddBuku.BackColor = Color.PaleGreen;
            BtnAddBuku.Location = new Point(422, 120);
            BtnAddBuku.Name = "BtnAddBuku";
            BtnAddBuku.Size = new Size(75, 23);
            BtnAddBuku.TabIndex = 6;
            BtnAddBuku.Text = "Add";
            BtnAddBuku.UseVisualStyleBackColor = false;
            BtnAddBuku.Click += BtnAddBuku_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(262, 84);
            label10.Name = "label10";
            label10.Size = new Size(59, 21);
            label10.TabIndex = 10;
            label10.Text = "Genre :";
            // 
            // tboxPenerbit
            // 
            tboxPenerbit.BorderStyle = BorderStyle.FixedSingle;
            tboxPenerbit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tboxPenerbit.Location = new Point(327, 47);
            tboxPenerbit.Name = "tboxPenerbit";
            tboxPenerbit.Size = new Size(170, 29);
            tboxPenerbit.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(247, 49);
            label9.Name = "label9";
            label9.Size = new Size(74, 21);
            label9.TabIndex = 8;
            label9.Text = "Penerbit :";
            // 
            // tboxPenulis
            // 
            tboxPenulis.BorderStyle = BorderStyle.FixedSingle;
            tboxPenulis.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tboxPenulis.Location = new Point(78, 82);
            tboxPenulis.Name = "tboxPenulis";
            tboxPenulis.Size = new Size(163, 29);
            tboxPenulis.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(6, 84);
            label8.Name = "label8";
            label8.Size = new Size(66, 21);
            label8.TabIndex = 6;
            label8.Text = "Penulis :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(13, 49);
            label4.Name = "label4";
            label4.Size = new Size(54, 21);
            label4.TabIndex = 2;
            label4.Text = "Judul :";
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ControlDark;
            panel6.Controls.Add(label7);
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(664, 33);
            panel6.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(3, 4);
            label7.Name = "label7";
            label7.Size = new Size(103, 21);
            label7.TabIndex = 1;
            label7.Text = "Tambah Buku";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(BtnEdit);
            panel3.Controls.Add(NUDEditStock);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(cboxJudul);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(BtnRemoveBuku);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(531, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(289, 163);
            panel3.TabIndex = 9;
            // 
            // BtnEdit
            // 
            BtnEdit.BackColor = Color.PaleGreen;
            BtnEdit.Location = new Point(194, 117);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(75, 23);
            BtnEdit.TabIndex = 16;
            BtnEdit.Text = "Edit";
            BtnEdit.UseVisualStyleBackColor = false;
            BtnEdit.Click += BtnEdit_Click;
            // 
            // NUDEditStock
            // 
            NUDEditStock.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NUDEditStock.Location = new Point(73, 80);
            NUDEditStock.Name = "NUDEditStock";
            NUDEditStock.Size = new Size(196, 29);
            NUDEditStock.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(20, 82);
            label2.Name = "label2";
            label2.Size = new Size(47, 21);
            label2.TabIndex = 16;
            label2.Text = "Stok :";
            // 
            // cboxJudul
            // 
            cboxJudul.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboxJudul.FormattingEnabled = true;
            cboxJudul.Location = new Point(73, 46);
            cboxJudul.Name = "cboxJudul";
            cboxJudul.Size = new Size(196, 29);
            cboxJudul.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(8, 48);
            label5.Name = "label5";
            label5.Size = new Size(54, 21);
            label5.TabIndex = 2;
            label5.Text = "Judul :";
            // 
            // BtnRemoveBuku
            // 
            BtnRemoveBuku.BackColor = Color.MistyRose;
            BtnRemoveBuku.Location = new Point(113, 117);
            BtnRemoveBuku.Name = "BtnRemoveBuku";
            BtnRemoveBuku.Size = new Size(75, 23);
            BtnRemoveBuku.TabIndex = 1;
            BtnRemoveBuku.Text = "Remove";
            BtnRemoveBuku.UseVisualStyleBackColor = false;
            BtnRemoveBuku.Click += BtnRemoveBuku_Click;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlDark;
            panel4.Controls.Add(label6);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(312, 33);
            panel4.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(3, 4);
            label6.Name = "label6";
            label6.Size = new Size(187, 21);
            label6.TabIndex = 1;
            label6.Text = "Edit Stock / Remove Buku";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(tboxNewGenre);
            panel1.Controls.Add(BtnAddGenre);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(826, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(189, 163);
            panel1.TabIndex = 18;
            // 
            // tboxNewGenre
            // 
            tboxNewGenre.BorderStyle = BorderStyle.FixedSingle;
            tboxNewGenre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tboxNewGenre.Location = new Point(73, 46);
            tboxNewGenre.Name = "tboxNewGenre";
            tboxNewGenre.Size = new Size(105, 29);
            tboxNewGenre.TabIndex = 16;
            // 
            // BtnAddGenre
            // 
            BtnAddGenre.BackColor = Color.PaleGreen;
            BtnAddGenre.Location = new Point(103, 123);
            BtnAddGenre.Name = "BtnAddGenre";
            BtnAddGenre.Size = new Size(75, 23);
            BtnAddGenre.TabIndex = 16;
            BtnAddGenre.Text = "Add";
            BtnAddGenre.UseVisualStyleBackColor = false;
            BtnAddGenre.Click += BtnAddGenre_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(8, 49);
            label11.Name = "label11";
            label11.Size = new Size(59, 21);
            label11.TabIndex = 2;
            label11.Text = "Genre :";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Controls.Add(label12);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(312, 33);
            panel2.TabIndex = 0;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(3, 4);
            label12.Name = "label12";
            label12.Size = new Size(88, 21);
            label12.TabIndex = 1;
            label12.Text = "New Genre";
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.Control;
            panel7.Controls.Add(BtnRemoveGenre);
            panel7.Controls.Add(cboxRemoveGenre);
            panel7.Controls.Add(label3);
            panel7.Controls.Add(panel8);
            panel7.Location = new Point(1023, 12);
            panel7.Name = "panel7";
            panel7.Size = new Size(189, 163);
            panel7.TabIndex = 19;
            // 
            // BtnRemoveGenre
            // 
            BtnRemoveGenre.BackColor = Color.MistyRose;
            BtnRemoveGenre.Location = new Point(103, 123);
            BtnRemoveGenre.Name = "BtnRemoveGenre";
            BtnRemoveGenre.Size = new Size(75, 23);
            BtnRemoveGenre.TabIndex = 18;
            BtnRemoveGenre.Text = "Remove";
            BtnRemoveGenre.UseVisualStyleBackColor = false;
            BtnRemoveGenre.Click += BtnRemoveGenre_Click;
            // 
            // cboxRemoveGenre
            // 
            cboxRemoveGenre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboxRemoveGenre.FormattingEnabled = true;
            cboxRemoveGenre.Location = new Point(73, 47);
            cboxRemoveGenre.Name = "cboxRemoveGenre";
            cboxRemoveGenre.Size = new Size(105, 29);
            cboxRemoveGenre.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(8, 49);
            label3.Name = "label3";
            label3.Size = new Size(59, 21);
            label3.TabIndex = 2;
            label3.Text = "Genre :";
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.ControlDark;
            panel8.Controls.Add(label13);
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(312, 33);
            panel8.TabIndex = 0;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(3, 4);
            label13.Name = "label13";
            label13.Size = new Size(113, 21);
            label13.TabIndex = 1;
            label13.Text = "Remove Genre";
            // 
            // FormKatalogBuku
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1224, 558);
            Controls.Add(panel7);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel5);
            Controls.Add(DGVGenre);
            Controls.Add(DGVKatalog);
            Name = "FormKatalogBuku";
            Text = "FormKatalogBuku";
            Load += FormKatalogBuku_Load;
            ((System.ComponentModel.ISupportInitialize)DGVKatalog).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGVGenre).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NUDNewStock).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NUDEditStock).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DGVKatalog;
        private DataGridView DGVGenre;
        private Panel panel5;
        private TextBox tboxJudul;
        private Button BtnAddBuku;
        private Label label10;
        private TextBox tboxPenerbit;
        private Label label9;
        private TextBox tboxPenulis;
        private Label label8;
        private Label label4;
        private Panel panel6;
        private Label label7;
        private NumericUpDown NUDNewStock;
        private Label label1;
        private ComboBox cboxGenre;
        private Panel panel3;
        private NumericUpDown NUDEditStock;
        private Label label2;
        private ComboBox cboxJudul;
        private Label label5;
        private Button BtnRemoveBuku;
        private Panel panel4;
        private Label label6;
        private Button BtnEdit;
        private Panel panel1;
        private TextBox tboxNewGenre;
        private Button BtnAddGenre;
        private Label label11;
        private Panel panel2;
        private Label label12;
        private Panel panel7;
        private Button BtnRemoveGenre;
        private ComboBox cboxRemoveGenre;
        private Label label3;
        private Panel panel8;
        private Label label13;
    }
}