namespace Proyecto_bdd2
{
    partial class p02_login
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
            p02_btn_login = new Button();
            p02_pn_login = new Panel();
            p02_tb_username = new TextBox();
            p02_tb_numAccount = new TextBox();
            p03_lb_user = new Label();
            p03_lb_numAccount = new Label();
            p02_pn_login.SuspendLayout();
            SuspendLayout();
            // 
            // p02_btn_login
            // 
            p02_btn_login.Location = new Point(61, 282);
            p02_btn_login.Name = "p02_btn_login";
            p02_btn_login.Size = new Size(132, 29);
            p02_btn_login.TabIndex = 0;
            p02_btn_login.Text = "Iniciar Sesion";
            p02_btn_login.UseVisualStyleBackColor = true;
            //p02_btn_login.Click += this.p02_btn_login_Click;
            // 
            // p02_pn_login
            // 
            p02_pn_login.Controls.Add(p03_lb_numAccount);
            p02_pn_login.Controls.Add(p03_lb_user);
            p02_pn_login.Controls.Add(p02_tb_numAccount);
            p02_pn_login.Controls.Add(p02_tb_username);
            p02_pn_login.Controls.Add(p02_btn_login);
            p02_pn_login.Location = new Point(280, 56);
            p02_pn_login.Name = "p02_pn_login";
            p02_pn_login.Size = new Size(250, 332);
            p02_pn_login.TabIndex = 1;
            // 
            // p02_tb_username
            // 
            p02_tb_username.Location = new Point(61, 83);
            p02_tb_username.Name = "p02_tb_username";
            p02_tb_username.Size = new Size(132, 27);
            p02_tb_username.TabIndex = 1;
            // 
            // p02_tb_numAccount
            // 
            p02_tb_numAccount.Location = new Point(59, 153);
            p02_tb_numAccount.Name = "p02_tb_numAccount";
            p02_tb_numAccount.Size = new Size(132, 27);
            p02_tb_numAccount.TabIndex = 2;
            // 
            // p03_lb_user
            // 
            p03_lb_user.AutoSize = true;
            p03_lb_user.Location = new Point(95, 60);
            p03_lb_user.Name = "p03_lb_user";
            p03_lb_user.Size = new Size(59, 20);
            p03_lb_user.TabIndex = 3;
            p03_lb_user.Text = "Usuario";
            // 
            // p03_lb_numAccount
            // 
            p03_lb_numAccount.AutoSize = true;
            p03_lb_numAccount.Location = new Point(61, 130);
            p03_lb_numAccount.Name = "p03_lb_numAccount";
            p03_lb_numAccount.Size = new Size(132, 20);
            p03_lb_numAccount.TabIndex = 4;
            p03_lb_numAccount.Text = "Numero de cuenta";
            // 
            // p02_login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(p02_pn_login);
            Name = "p02_login";
            Text = " ";
            p02_pn_login.ResumeLayout(false);
            p02_pn_login.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button p02_btn_login;
        private Panel p02_pn_login;
        private Label p03_lb_numAccount;
        private Label p03_lb_user;
        private TextBox p02_tb_numAccount;
        private TextBox p02_tb_username;
    }
}