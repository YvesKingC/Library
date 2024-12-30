namespace LSP_Library
{
    partial class FormEditUser
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
            panel1 = new Panel();
            tboxPass = new TextBox();
            tboxNama = new TextBox();
            label3 = new Label();
            label2 = new Label();
            BtnAdd = new Button();
            panel2 = new Panel();
            label1 = new Label();
            DGVAdmin = new DataGridView();
            panel3 = new Panel();
            cboxAdmin = new ComboBox();
            label5 = new Label();
            BtnRemoveAdmin = new Button();
            panel4 = new Panel();
            label6 = new Label();
            DGVAnggota = new DataGridView();
            panel5 = new Panel();
            BtnEditAnggota = new Button();
            tboxEmail = new TextBox();
            label10 = new Label();
            tboxNoTelp = new TextBox();
            label9 = new Label();
            tboxAlamat = new TextBox();
            label8 = new Label();
            cboxAnggota = new ComboBox();
            label4 = new Label();
            BtnRemoveAnggota = new Button();
            panel6 = new Panel();
            label7 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVAdmin).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVAnggota).BeginInit();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(tboxPass);
            panel1.Controls.Add(tboxNama);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(BtnAdd);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(262, 163);
            panel1.TabIndex = 0;
            // 
            // tboxPass
            // 
            tboxPass.BorderStyle = BorderStyle.FixedSingle;
            tboxPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tboxPass.Location = new Point(98, 88);
            tboxPass.Name = "tboxPass";
            tboxPass.Size = new Size(151, 29);
            tboxPass.TabIndex = 5;
            // 
            // tboxNama
            // 
            tboxNama.BorderStyle = BorderStyle.FixedSingle;
            tboxNama.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tboxNama.Location = new Point(98, 47);
            tboxNama.Name = "tboxNama";
            tboxNama.Size = new Size(151, 29);
            tboxNama.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(9, 90);
            label3.Name = "label3";
            label3.Size = new Size(83, 21);
            label3.TabIndex = 3;
            label3.Text = "Password :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(33, 49);
            label2.Name = "label2";
            label2.Size = new Size(59, 21);
            label2.TabIndex = 2;
            label2.Text = "Nama :";
            // 
            // BtnAdd
            // 
            BtnAdd.BackColor = Color.PaleGreen;
            BtnAdd.Location = new Point(174, 123);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(75, 23);
            BtnAdd.TabIndex = 1;
            BtnAdd.Text = "Add";
            BtnAdd.UseVisualStyleBackColor = false;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(312, 33);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 4);
            label1.Name = "label1";
            label1.Size = new Size(114, 21);
            label1.TabIndex = 1;
            label1.Text = "Tambah Admin";
            // 
            // DGVAdmin
            // 
            DGVAdmin.BackgroundColor = SystemColors.ButtonFace;
            DGVAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVAdmin.Location = new Point(12, 181);
            DGVAdmin.Name = "DGVAdmin";
            DGVAdmin.RowTemplate.Height = 25;
            DGVAdmin.Size = new Size(530, 365);
            DGVAdmin.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(cboxAdmin);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(BtnRemoveAdmin);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(280, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(262, 163);
            panel3.TabIndex = 6;
            // 
            // cboxAdmin
            // 
            cboxAdmin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboxAdmin.FormattingEnabled = true;
            cboxAdmin.Location = new Point(98, 47);
            cboxAdmin.Name = "cboxAdmin";
            cboxAdmin.Size = new Size(151, 29);
            cboxAdmin.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(33, 49);
            label5.Name = "label5";
            label5.Size = new Size(59, 21);
            label5.TabIndex = 2;
            label5.Text = "Nama :";
            // 
            // BtnRemoveAdmin
            // 
            BtnRemoveAdmin.BackColor = Color.MistyRose;
            BtnRemoveAdmin.Location = new Point(174, 123);
            BtnRemoveAdmin.Name = "BtnRemoveAdmin";
            BtnRemoveAdmin.Size = new Size(75, 23);
            BtnRemoveAdmin.TabIndex = 1;
            BtnRemoveAdmin.Text = "Remove";
            BtnRemoveAdmin.UseVisualStyleBackColor = false;
            BtnRemoveAdmin.Click += BtnRemoveAdmin_Click;
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
            label6.Size = new Size(117, 21);
            label6.TabIndex = 1;
            label6.Text = "Remove Admin";
            // 
            // DGVAnggota
            // 
            DGVAnggota.BackgroundColor = SystemColors.ButtonFace;
            DGVAnggota.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVAnggota.Location = new Point(548, 181);
            DGVAnggota.Name = "DGVAnggota";
            DGVAnggota.RowTemplate.Height = 25;
            DGVAnggota.Size = new Size(664, 365);
            DGVAnggota.TabIndex = 7;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Control;
            panel5.Controls.Add(BtnEditAnggota);
            panel5.Controls.Add(tboxEmail);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(tboxNoTelp);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(tboxAlamat);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(cboxAnggota);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(BtnRemoveAnggota);
            panel5.Controls.Add(panel6);
            panel5.Location = new Point(548, 12);
            panel5.Name = "panel5";
            panel5.Size = new Size(664, 163);
            panel5.TabIndex = 7;
            // 
            // BtnEditAnggota
            // 
            BtnEditAnggota.BackColor = Color.PaleGreen;
            BtnEditAnggota.Location = new Point(569, 123);
            BtnEditAnggota.Name = "BtnEditAnggota";
            BtnEditAnggota.Size = new Size(75, 23);
            BtnEditAnggota.TabIndex = 6;
            BtnEditAnggota.Text = "Edit";
            BtnEditAnggota.UseVisualStyleBackColor = false;
            BtnEditAnggota.Click += BtnEditAnggota_Click;
            // 
            // tboxEmail
            // 
            tboxEmail.BorderStyle = BorderStyle.FixedSingle;
            tboxEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tboxEmail.Location = new Point(422, 82);
            tboxEmail.Name = "tboxEmail";
            tboxEmail.Size = new Size(222, 29);
            tboxEmail.TabIndex = 11;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(361, 84);
            label10.Name = "label10";
            label10.Size = new Size(55, 21);
            label10.TabIndex = 10;
            label10.Text = "Email :";
            // 
            // tboxNoTelp
            // 
            tboxNoTelp.BorderStyle = BorderStyle.FixedSingle;
            tboxNoTelp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tboxNoTelp.Location = new Point(422, 48);
            tboxNoTelp.Name = "tboxNoTelp";
            tboxNoTelp.Size = new Size(222, 29);
            tboxNoTelp.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(350, 50);
            label9.Name = "label9";
            label9.Size = new Size(65, 21);
            label9.TabIndex = 8;
            label9.Text = "NoTelp :";
            // 
            // tboxAlamat
            // 
            tboxAlamat.BorderStyle = BorderStyle.FixedSingle;
            tboxAlamat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tboxAlamat.Location = new Point(98, 82);
            tboxAlamat.Name = "tboxAlamat";
            tboxAlamat.Size = new Size(235, 29);
            tboxAlamat.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(26, 84);
            label8.Name = "label8";
            label8.Size = new Size(66, 21);
            label8.TabIndex = 6;
            label8.Text = "Alamat :";
            // 
            // cboxAnggota
            // 
            cboxAnggota.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboxAnggota.FormattingEnabled = true;
            cboxAnggota.Location = new Point(98, 47);
            cboxAnggota.Name = "cboxAnggota";
            cboxAnggota.Size = new Size(235, 29);
            cboxAnggota.TabIndex = 6;
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
            // BtnRemoveAnggota
            // 
            BtnRemoveAnggota.BackColor = Color.MistyRose;
            BtnRemoveAnggota.Location = new Point(474, 123);
            BtnRemoveAnggota.Name = "BtnRemoveAnggota";
            BtnRemoveAnggota.Size = new Size(75, 23);
            BtnRemoveAnggota.TabIndex = 1;
            BtnRemoveAnggota.Text = "Remove";
            BtnRemoveAnggota.UseVisualStyleBackColor = false;
            BtnRemoveAnggota.Click += BtnRemoveAnggota_Click;
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
            label7.Size = new Size(99, 21);
            label7.TabIndex = 1;
            label7.Text = "Edit Anggota";
            // 
            // FormEditUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1224, 558);
            Controls.Add(panel5);
            Controls.Add(DGVAnggota);
            Controls.Add(panel3);
            Controls.Add(DGVAdmin);
            Controls.Add(panel1);
            Name = "FormEditUser";
            Text = "Edit User";
            Load += FormEditUser_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVAdmin).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVAnggota).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private Button BtnAdd;
        private Panel panel2;
        private Label label1;
        private TextBox tboxPass;
        private TextBox tboxNama;
        private DataGridView DGVAdmin;
        private Panel panel3;
        private ComboBox cboxAdmin;
        private Label label5;
        private Button BtnRemoveAdmin;
        private Panel panel4;
        private Label label6;
        private DataGridView DGVAnggota;
        private Panel panel5;
        private TextBox tboxAlamat;
        private Label label8;
        private ComboBox cboxAnggota;
        private Label label4;
        private Button BtnRemoveAnggota;
        private Panel panel6;
        private Label label7;
        private TextBox tboxEmail;
        private Label label10;
        private TextBox tboxNoTelp;
        private Label label9;
        private Button BtnEditAnggota;
    }
}