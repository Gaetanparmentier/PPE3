namespace PEE3_V1._0
{
    partial class Connexion
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
            this.LBL_Username = new System.Windows.Forms.Label();
            this.LBL_Password = new System.Windows.Forms.Label();
            this.TXT_Username = new System.Windows.Forms.TextBox();
            this.TXT_Password = new System.Windows.Forms.TextBox();
            this.CB_ShowPassword = new System.Windows.Forms.CheckBox();
            this.BTN_Login = new System.Windows.Forms.Button();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.Link_Register = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // LBL_Username
            // 
            this.LBL_Username.AutoSize = true;
            this.LBL_Username.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Username.Location = new System.Drawing.Point(37, 39);
            this.LBL_Username.Name = "LBL_Username";
            this.LBL_Username.Size = new System.Drawing.Size(127, 32);
            this.LBL_Username.TabIndex = 5;
            this.LBL_Username.Text = "Username:";
            // 
            // LBL_Password
            // 
            this.LBL_Password.AutoSize = true;
            this.LBL_Password.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Password.Location = new System.Drawing.Point(37, 90);
            this.LBL_Password.Name = "LBL_Password";
            this.LBL_Password.Size = new System.Drawing.Size(117, 32);
            this.LBL_Password.TabIndex = 6;
            this.LBL_Password.Text = "Password:";
            // 
            // TXT_Username
            // 
            this.TXT_Username.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Username.Location = new System.Drawing.Point(182, 39);
            this.TXT_Username.Name = "TXT_Username";
            this.TXT_Username.Size = new System.Drawing.Size(341, 38);
            this.TXT_Username.TabIndex = 7;
            // 
            // TXT_Password
            // 
            this.TXT_Password.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Password.Location = new System.Drawing.Point(182, 90);
            this.TXT_Password.Name = "TXT_Password";
            this.TXT_Password.Size = new System.Drawing.Size(341, 38);
            this.TXT_Password.TabIndex = 8;
            this.TXT_Password.UseSystemPasswordChar = true;
            // 
            // CB_ShowPassword
            // 
            this.CB_ShowPassword.AutoSize = true;
            this.CB_ShowPassword.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_ShowPassword.Location = new System.Drawing.Point(336, 134);
            this.CB_ShowPassword.Name = "CB_ShowPassword";
            this.CB_ShowPassword.Size = new System.Drawing.Size(187, 29);
            this.CB_ShowPassword.TabIndex = 9;
            this.CB_ShowPassword.Text = "Montrer Password";
            this.CB_ShowPassword.UseVisualStyleBackColor = true;
            this.CB_ShowPassword.CheckedChanged += new System.EventHandler(this.CB_ShowPassword_CheckedChanged);
            // 
            // BTN_Login
            // 
            this.BTN_Login.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Login.Location = new System.Drawing.Point(171, 174);
            this.BTN_Login.Name = "BTN_Login";
            this.BTN_Login.Size = new System.Drawing.Size(166, 61);
            this.BTN_Login.TabIndex = 10;
            this.BTN_Login.Text = "Log-in";
            this.BTN_Login.UseVisualStyleBackColor = true;
            this.BTN_Login.Click += new System.EventHandler(this.BTN_Login_Click);
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Cancel.Location = new System.Drawing.Point(357, 174);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(166, 61);
            this.BTN_Cancel.TabIndex = 11;
            this.BTN_Cancel.Text = "Annuler";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            // 
            // Link_Register
            // 
            this.Link_Register.AutoSize = true;
            this.Link_Register.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Link_Register.Location = new System.Drawing.Point(37, 237);
            this.Link_Register.Name = "Link_Register";
            this.Link_Register.Size = new System.Drawing.Size(187, 32);
            this.Link_Register.TabIndex = 12;
            this.Link_Register.TabStop = true;
            this.Link_Register.Text = "Crée un compte";
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(570, 278);
            this.Controls.Add(this.Link_Register);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.BTN_Login);
            this.Controls.Add(this.CB_ShowPassword);
            this.Controls.Add(this.TXT_Password);
            this.Controls.Add(this.TXT_Username);
            this.Controls.Add(this.LBL_Password);
            this.Controls.Add(this.LBL_Username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Connexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Page de Connexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_Username;
        private System.Windows.Forms.Label LBL_Password;
        private System.Windows.Forms.TextBox TXT_Username;
        private System.Windows.Forms.TextBox TXT_Password;
        private System.Windows.Forms.CheckBox CB_ShowPassword;
        private System.Windows.Forms.Button BTN_Login;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.LinkLabel Link_Register;
    }
}