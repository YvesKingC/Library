namespace LSP_Library
{
    partial class FormAdvancedSetting
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
            BtnUserCont = new Button();
            BtnKatalog = new Button();
            BtnLog = new Button();
            panelAdvanced = new Panel();
            SuspendLayout();
            // 
            // BtnUserCont
            // 
            BtnUserCont.BackColor = SystemColors.HighlightText;
            BtnUserCont.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnUserCont.Location = new Point(12, 12);
            BtnUserCont.Name = "BtnUserCont";
            BtnUserCont.Size = new Size(154, 54);
            BtnUserCont.TabIndex = 3;
            BtnUserCont.Text = "User Control";
            BtnUserCont.UseVisualStyleBackColor = false;
            BtnUserCont.Click += BtnUserCont_Click;
            // 
            // BtnKatalog
            // 
            BtnKatalog.BackColor = SystemColors.HighlightText;
            BtnKatalog.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnKatalog.Location = new Point(172, 12);
            BtnKatalog.Name = "BtnKatalog";
            BtnKatalog.Size = new Size(154, 54);
            BtnKatalog.TabIndex = 4;
            BtnKatalog.Text = "Katalog";
            BtnKatalog.UseVisualStyleBackColor = false;
            BtnKatalog.Click += BtnKatalog_Click;
            // 
            // BtnLog
            // 
            BtnLog.BackColor = SystemColors.HighlightText;
            BtnLog.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnLog.Location = new Point(332, 12);
            BtnLog.Name = "BtnLog";
            BtnLog.Size = new Size(154, 54);
            BtnLog.TabIndex = 6;
            BtnLog.Text = "Log Peminjaman";
            BtnLog.UseVisualStyleBackColor = false;
            BtnLog.Click += BtnLog_Click;
            // 
            // panelAdvanced
            // 
            panelAdvanced.BackColor = SystemColors.Control;
            panelAdvanced.Location = new Point(12, 72);
            panelAdvanced.Name = "panelAdvanced";
            panelAdvanced.Size = new Size(1240, 597);
            panelAdvanced.TabIndex = 7;
            // 
            // FormAdvancedSetting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1264, 681);
            Controls.Add(panelAdvanced);
            Controls.Add(BtnLog);
            Controls.Add(BtnKatalog);
            Controls.Add(BtnUserCont);
            Name = "FormAdvancedSetting";
            Text = "FormAdvancedSetting";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnUserCont;
        private Button BtnKatalog;
        private Button BtnLog;
        private Panel panelAdvanced;
    }
}