namespace LSP_Library
{
    partial class FormAnggotaBaru
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
            tboxAnggota = new TextBox();
            BtnDaftarAnggota = new Button();
            tboxEmail = new TextBox();
            label10 = new Label();
            tboxNoTelp = new TextBox();
            label9 = new Label();
            tboxAlamat = new TextBox();
            label8 = new Label();
            label4 = new Label();
            panel6 = new Panel();
            label7 = new Label();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Control;
            panel5.Controls.Add(tboxAnggota);
            panel5.Controls.Add(BtnDaftarAnggota);
            panel5.Controls.Add(tboxEmail);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(tboxNoTelp);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(tboxAlamat);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(panel6);
            panel5.Location = new Point(12, 12);
            panel5.Name = "panel5";
            panel5.Size = new Size(337, 233);
            panel5.TabIndex = 9;
            // 
            // tboxAnggota
            // 
            tboxAnggota.BorderStyle = BorderStyle.FixedSingle;
            tboxAnggota.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tboxAnggota.Location = new Point(98, 47);
            tboxAnggota.Name = "tboxAnggota";
            tboxAnggota.Size = new Size(222, 29);
            tboxAnggota.TabIndex = 12;
            // 
            // BtnDaftarAnggota
            // 
            BtnDaftarAnggota.BackColor = Color.PaleGreen;
            BtnDaftarAnggota.Location = new Point(245, 192);
            BtnDaftarAnggota.Name = "BtnDaftarAnggota";
            BtnDaftarAnggota.Size = new Size(75, 23);
            BtnDaftarAnggota.TabIndex = 6;
            BtnDaftarAnggota.Text = "Daftar";
            BtnDaftarAnggota.UseVisualStyleBackColor = false;
            BtnDaftarAnggota.Click += BtnDaftarAnggota_Click;
            // 
            // tboxEmail
            // 
            tboxEmail.BorderStyle = BorderStyle.FixedSingle;
            tboxEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tboxEmail.Location = new Point(98, 151);
            tboxEmail.Name = "tboxEmail";
            tboxEmail.Size = new Size(222, 29);
            tboxEmail.TabIndex = 11;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(37, 153);
            label10.Name = "label10";
            label10.Size = new Size(55, 21);
            label10.TabIndex = 10;
            label10.Text = "Email :";
            // 
            // tboxNoTelp
            // 
            tboxNoTelp.BorderStyle = BorderStyle.FixedSingle;
            tboxNoTelp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tboxNoTelp.Location = new Point(98, 117);
            tboxNoTelp.Name = "tboxNoTelp";
            tboxNoTelp.Size = new Size(222, 29);
            tboxNoTelp.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(26, 119);
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
            tboxAlamat.Size = new Size(222, 29);
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
            // FormAnggotaBaru
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(363, 255);
            Controls.Add(panel5);
            Name = "FormAnggotaBaru";
            Text = "Pendaftaran";
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel5;
        private TextBox tboxAnggota;
        private Button BtnEditAnggota;
        private TextBox tboxEmail;
        private Label label10;
        private TextBox tboxNoTelp;
        private Label label9;
        private TextBox tboxAlamat;
        private Label label8;
        private Label label4;
        private Panel panel6;
        private Label label7;
        private Button BtnDaftarAnggota;
    }
}