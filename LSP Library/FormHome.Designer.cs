namespace LSP_Library
{
    partial class FormHome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tBoxSearch = new TextBox();
            DGVKatalog = new DataGridView();
            BtnPinjam = new Button();
            BtnAdvanced = new Button();
            BtnPengembalian = new Button();
            BtnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)DGVKatalog).BeginInit();
            SuspendLayout();
            // 
            // tBoxSearch
            // 
            tBoxSearch.BackColor = SystemColors.HighlightText;
            tBoxSearch.BorderStyle = BorderStyle.FixedSingle;
            tBoxSearch.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            tBoxSearch.Location = new Point(45, 42);
            tBoxSearch.Name = "tBoxSearch";
            tBoxSearch.Size = new Size(1187, 36);
            tBoxSearch.TabIndex = 0;
            tBoxSearch.TextChanged += tBoxSearch_TextChanged;
            // 
            // DGVKatalog
            // 
            DGVKatalog.BackgroundColor = SystemColors.HighlightText;
            DGVKatalog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVKatalog.GridColor = Color.PaleTurquoise;
            DGVKatalog.Location = new Point(45, 116);
            DGVKatalog.Name = "DGVKatalog";
            DGVKatalog.RowTemplate.Height = 25;
            DGVKatalog.Size = new Size(941, 526);
            DGVKatalog.TabIndex = 1;
            // 
            // BtnPinjam
            // 
            BtnPinjam.BackColor = SystemColors.HighlightText;
            BtnPinjam.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtnPinjam.Location = new Point(1026, 290);
            BtnPinjam.Name = "BtnPinjam";
            BtnPinjam.Size = new Size(206, 63);
            BtnPinjam.TabIndex = 2;
            BtnPinjam.Text = "Pinjam buku";
            BtnPinjam.UseVisualStyleBackColor = false;
            BtnPinjam.Click += BtnPinjam_Click;
            // 
            // BtnAdvanced
            // 
            BtnAdvanced.BackColor = Color.MistyRose;
            BtnAdvanced.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BtnAdvanced.Location = new Point(1026, 612);
            BtnAdvanced.Name = "BtnAdvanced";
            BtnAdvanced.Size = new Size(206, 30);
            BtnAdvanced.TabIndex = 3;
            BtnAdvanced.Text = "Advanced";
            BtnAdvanced.UseVisualStyleBackColor = false;
            BtnAdvanced.Click += BtnEditor_Click;
            // 
            // BtnPengembalian
            // 
            BtnPengembalian.BackColor = SystemColors.HighlightText;
            BtnPengembalian.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            BtnPengembalian.Location = new Point(1026, 359);
            BtnPengembalian.Name = "BtnPengembalian";
            BtnPengembalian.Size = new Size(206, 63);
            BtnPengembalian.TabIndex = 4;
            BtnPengembalian.Text = "Pengembalian Buku";
            BtnPengembalian.UseVisualStyleBackColor = false;
            BtnPengembalian.Click += BtnPengembalian_Click;
            // 
            // BtnRefresh
            // 
            BtnRefresh.BackColor = Color.PaleGreen;
            BtnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BtnRefresh.Location = new Point(1026, 116);
            BtnRefresh.Name = "BtnRefresh";
            BtnRefresh.Size = new Size(206, 34);
            BtnRefresh.TabIndex = 5;
            BtnRefresh.Text = "Refresh";
            BtnRefresh.UseVisualStyleBackColor = false;
            BtnRefresh.Click += BtnRefresh_Click;
            // 
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1264, 681);
            Controls.Add(BtnRefresh);
            Controls.Add(BtnPengembalian);
            Controls.Add(BtnAdvanced);
            Controls.Add(BtnPinjam);
            Controls.Add(DGVKatalog);
            Controls.Add(tBoxSearch);
            Name = "FormHome";
            Text = "Home";
            Load += FormHome_Load;
            ((System.ComponentModel.ISupportInitialize)DGVKatalog).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tBoxSearch;
        private DataGridView DGVKatalog;
        private Button BtnPinjam;
        private Button BtnAdvanced;
        private Button BtnPengembalian;
        private Button BtnRefresh;
    }
}