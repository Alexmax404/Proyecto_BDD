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
            // p01_log_reg
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(p01_btn_register);
            Controls.Add(p01_btn_login);
            Name = "p01_log_reg";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private Button p01_btn_login;
        private Button p01_btn_register;
    }
}