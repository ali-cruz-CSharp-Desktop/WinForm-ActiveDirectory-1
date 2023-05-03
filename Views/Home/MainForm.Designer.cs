
namespace LoginActiveDirectory02.Views.Home
{
    partial class MainForm
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
            this.TxbUser = new System.Windows.Forms.TextBox();
            this.LblUser = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.LblPassword = new System.Windows.Forms.Label();
            this.TxbPassword = new System.Windows.Forms.TextBox();
            this.LblMensajes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxbUser
            // 
            this.TxbUser.Location = new System.Drawing.Point(91, 28);
            this.TxbUser.Name = "TxbUser";
            this.TxbUser.Size = new System.Drawing.Size(458, 20);
            this.TxbUser.TabIndex = 0;
            // 
            // LblUser
            // 
            this.LblUser.AutoSize = true;
            this.LblUser.Location = new System.Drawing.Point(31, 33);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(29, 13);
            this.LblUser.TabIndex = 1;
            this.LblUser.Text = "User";
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(470, 101);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(78, 33);
            this.BtnLogin.TabIndex = 2;
            this.BtnLogin.Text = "Entrar";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Location = new System.Drawing.Point(30, 71);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(53, 13);
            this.LblPassword.TabIndex = 4;
            this.LblPassword.Text = "Password";
            // 
            // TxbPassword
            // 
            this.TxbPassword.Location = new System.Drawing.Point(90, 66);
            this.TxbPassword.Name = "TxbPassword";
            this.TxbPassword.Size = new System.Drawing.Size(458, 20);
            this.TxbPassword.TabIndex = 1;
            // 
            // LblMensajes
            // 
            this.LblMensajes.AutoSize = true;
            this.LblMensajes.Location = new System.Drawing.Point(97, 149);
            this.LblMensajes.Name = "LblMensajes";
            this.LblMensajes.Size = new System.Drawing.Size(0, 13);
            this.LblMensajes.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 251);
            this.Controls.Add(this.LblMensajes);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.TxbPassword);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.LblUser);
            this.Controls.Add(this.TxbUser);
            this.Name = "MainForm";
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxbUser;
        private System.Windows.Forms.Label LblUser;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.TextBox TxbPassword;
        private System.Windows.Forms.Label LblMensajes;
    }
}