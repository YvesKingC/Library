namespace LSP_Library
{
    partial class FormLogPeminjaman
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
            label2 = new Label();
            cboxAnggota = new ComboBox();
            label4 = new Label();
            panel6 = new Panel();
            label7 = new Label();
            DGVKatalog = new DataGridView();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVKatalog).BeginInit();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Control;
            panel5.Controls.Add(label2);
            panel5.Controls.Add(cboxAnggota);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(panel6);
            panel5.Location = new Point(12, 12);
            panel5.Name = "panel5";
            panel5.Size = new Size(1200, 104);
            panel5.TabIndex = 9;
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
            cboxAnggota.Size = new Size(1061, 29);
            cboxAnggota.TabIndex = 7;
            cboxAnggota.SelectedIndexChanged += cboxAnggota_SelectedIndexChanged;
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
            label7.Location = new Point(3, 6);
            label7.Name = "label7";
            label7.Size = new Size(126, 21);
            label7.TabIndex = 1;
            label7.Text = "Log Peminjaman";
            // 
            // DGVKatalog
            // 
            DGVKatalog.BackgroundColor = SystemColors.ButtonFace;
            DGVKatalog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVKatalog.Location = new Point(12, 122);
            DGVKatalog.Name = "DGVKatalog";
            DGVKatalog.RowTemplate.Height = 25;
            DGVKatalog.Size = new Size(1200, 424);
            DGVKatalog.TabIndex = 10;
            // 
            // FormLogPeminjaman
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1224, 558);
            Controls.Add(DGVKatalog);
            Controls.Add(panel5);
            Name = "FormLogPeminjaman";
            Text = "Log Peminjaman";
            Load += FormLogPeminjaman_Load;
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVKatalog).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel5;
        private Label label2;
        private ComboBox cboxAnggota;
        private Label label4;
        private Panel panel6;
        private Label label7;
        private DataGridView DGVKatalog;
    }
}