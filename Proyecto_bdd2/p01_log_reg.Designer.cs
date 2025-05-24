namespace Proyecto_bdd2
{
    partial class p01_log_reg
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
            p01_btn_login = new Button();
            p01_btn_register = new Button();
            p01_btn_back = new Button();
            p01_pn_log_reg = new Panel();
            p01_pn_log_reg.SuspendLayout();
            SuspendLayout();
            // 
            // p01_btn_login
            // 
            p01_btn_login.Location = new Point(278, 181);
            p01_btn_login.Name = "p01_btn_login";
            p01_btn_login.Size = new Size(217, 49);
            p01_btn_login.TabIndex = 0;
            p01_btn_login.Text = "Iniciar Sesion";
            p01_btn_login.UseVisualStyleBackColor = true;
            p01_btn_login.Click += p01_btn_login_Click;
            // 
            // p01_btn_register
            // 
            p01_btn_register.Location = new Point(278, 236);
            p01_btn_register.Name = "p01_btn_register";
            p01_btn_register.Size = new Size(217, 49);
            p01_btn_register.TabIndex = 1;
            p01_btn_register.Text = "Registrarse";
            p01_btn_register.UseVisualStyleBackColor = true;
            p01_btn_register.Click += p01_btn_register_Click;
            // 
            // p01_btn_back
            // 
            p01_btn_back.Location = new Point(12, 12);
            p01_btn_back.Name = "p01_btn_back";
            p01_btn_back.Size = new Size(31, 31);
            p01_btn_back.TabIndex = 2;
            p01_btn_back.Text = "←";
            p01_btn_back.UseVisualStyleBackColor = true;
            p01_btn_back.Click += p01_btn_back_Click;
            // 
            // p01_pn_log_reg
            // 
            p01_pn_log_reg.Controls.Add(p01_btn_back);
            p01_pn_log_reg.Dock = DockStyle.Fill;
            p01_pn_log_reg.Location = new Point(0, 0);
            p01_pn_log_reg.Name = "p01_pn_log_reg";
            p01_pn_log_reg.Size = new Size(800, 450);
            p01_pn_log_reg.TabIndex = 3;
            // 
            // p01_log_reg
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(p01_btn_register);
            Controls.Add(p01_btn_login);
            Controls.Add(p01_pn_log_reg);
            Name = "p01_log_reg";
            Text = "Form2";
            p01_pn_log_reg.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button p01_btn_login;
        private Button p01_btn_register;
        private Button p01_btn_back;
        private Panel p01_pn_log_reg;
    }
}