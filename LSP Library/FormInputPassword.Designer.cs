namespace LSP_Library
{
    partial class FormInputPassword
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
            tboxNama = new TextBox();
            tboxPass = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            BtnLogin = new Button();
            SuspendLayout();
            // 
            // tboxNama
            // 
            tboxNama.BorderStyle = BorderStyle.FixedSingle;
            tboxNama.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tboxNama.Location = new Point(151, 69);
            tboxNama.Name = "tboxNama";
            tboxNama.Size = new Size(237, 29);
            tboxNama.TabIndex = 0;
            // 
            // tboxPass
            // 
            tboxPass.BorderStyle = BorderStyle.FixedSingle;
            tboxPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tboxPass.Location = new Point(151, 104);
            tboxPass.Name = "tboxPass";
            tboxPass.Size = new Size(237, 29);
            tboxPass.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(86, 71);
            label1.Name = "label1";
            label1.Size = new Size(59, 21);
            label1.TabIndex = 2;
            label1.Text = "Nama :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(62, 106);
            label2.Name = "label2";
            label2.Size = new Size(83, 21);
            label2.TabIndex = 3;
            label2.Text = "Password :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(151, 29);
            label3.Name = "label3";
            label3.Size = new Size(167, 25);
            label3.TabIndex = 4;
            label3.Text = "Advanced Option";
            // 
            // BtnLogin
            // 
            BtnLogin.BackColor = Color.PaleGreen;
            BtnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BtnLogin.Location = new Point(187, 153);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(94, 27);
            BtnLogin.TabIndex = 5;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = false;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // FormInputPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(461, 212);
            Controls.Add(BtnLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tboxPass);
            Controls.Add(tboxNama);
            Name = "FormInputPassword";
            Text = "Admin Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tboxNama;
        private TextBox tboxPass;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button BtnLogin;
    }
}