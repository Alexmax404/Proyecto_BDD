namespace Proyecto_bdd2
{
    partial class p03_register
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
            panel1 = new Panel();
            p03_tb_phone = new TextBox();
            p03_tb_email = new TextBox();
            p03_tb_name = new TextBox();
            p03_btn_register = new Button();
            p03_pn_register = new Panel();
            p03_btn_back = new Button();
            panel1.SuspendLayout();
            p03_pn_register.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(p03_tb_phone);
            panel1.Controls.Add(p03_tb_email);
            panel1.Controls.Add(p03_tb_name);
            panel1.Location = new Point(210, 130);
            panel1.Name = "panel1";
            panel1.Size = new Size(413, 171);
            panel1.TabIndex = 0;
            // 
            // p03_tb_phone
            // 
            p03_tb_phone.Font = new Font("Segoe UI", 16.2F);
            p03_tb_phone.Location = new Point(14, 112);
            p03_tb_phone.Name = "p03_tb_phone";
            p03_tb_phone.PlaceholderText = "Teléfono";
            p03_tb_phone.Size = new Size(385, 43);
            p03_tb_phone.TabIndex = 2;
            // 
            // p03_tb_email
            // 
            p03_tb_email.Font = new Font("Segoe UI", 16.2F);
            p03_tb_email.Location = new Point(14, 63);
            p03_tb_email.Name = "p03_tb_email";
            p03_tb_email.PlaceholderText = "Correo";
            p03_tb_email.Size = new Size(385, 43);
            p03_tb_email.TabIndex = 1;
            // 
            // p03_tb_name
            // 
            p03_tb_name.AccessibleName = "";
            p03_tb_name.Font = new Font("Segoe UI", 16.2F);
            p03_tb_name.Location = new Point(14, 14);
            p03_tb_name.Name = "p03_tb_name";
            p03_tb_name.PlaceholderText = "Nombre Completo";
            p03_tb_name.Size = new Size(385, 43);
            p03_tb_name.TabIndex = 0;
            // 
            // p03_btn_register
            // 
            p03_btn_register.Location = new Point(350, 399);
            p03_btn_register.Name = "p03_btn_register";
            p03_btn_register.Size = new Size(124, 39);
            p03_btn_register.TabIndex = 1;
            p03_btn_register.Text = "Registrarse";
            p03_btn_register.UseVisualStyleBackColor = true;
            p03_btn_register.Click += p03_btn_register_Click;
            // 
            // p03_pn_register
            // 
            p03_pn_register.Controls.Add(p03_btn_back);
            p03_pn_register.Dock = DockStyle.Fill;
            p03_pn_register.Location = new Point(0, 0);
            p03_pn_register.Name = "p03_pn_register";
            p03_pn_register.Size = new Size(800, 450);
            p03_pn_register.TabIndex = 2;
            // 
            // p03_btn_back
            // 
            p03_btn_back.Location = new Point(12, 12);
            p03_btn_back.Name = "p03_btn_back";
            p03_btn_back.Size = new Size(31, 31);
            p03_btn_back.TabIndex = 3;
            p03_btn_back.Text = "←";
            p03_btn_back.UseVisualStyleBackColor = true;
            p03_btn_back.Click += p03_btn_back_Click;
            // 
            // p03_register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(p03_btn_register);
            Controls.Add(panel1);
            Controls.Add(p03_pn_register);
            Name = "p03_register";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            p03_pn_register.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox p03_tb_phone;
        private TextBox p03_tb_email;
        private TextBox p03_tb_name;
        private Button p03_btn_register;
        private Panel p03_pn_register;
        private Button p03_btn_back;
    }
}