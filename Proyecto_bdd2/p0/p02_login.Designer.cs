﻿namespace Proyecto_bdd2
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
            p03_lb_numAccount = new Label();
            p03_lb_user = new Label();
            p02_tb_numAccount = new TextBox();
            p02_tb_username = new TextBox();
            p02_pn = new Panel();
            admin_button = new Button();
            test_button = new Button();
            p02_btn_back = new Button();
            p02_pn_login.SuspendLayout();
            p02_pn.SuspendLayout();
            SuspendLayout();
            // 
            // p02_btn_login
            // 
            p02_btn_login.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            p02_btn_login.Location = new Point(61, 282);
            p02_btn_login.Name = "p02_btn_login";
            p02_btn_login.Size = new Size(132, 29);
            p02_btn_login.TabIndex = 0;
            p02_btn_login.Text = "Iniciar Sesion";
            p02_btn_login.UseVisualStyleBackColor = true;
            p02_btn_login.Click += p02_btn_login_Click;
            // 
            // p02_pn_login
            // 
            p02_pn_login.BorderStyle = BorderStyle.FixedSingle;
            p02_pn_login.Controls.Add(p03_lb_numAccount);
            p02_pn_login.Controls.Add(p03_lb_user);
            p02_pn_login.Controls.Add(p02_tb_numAccount);
            p02_pn_login.Controls.Add(p02_tb_username);
            p02_pn_login.Controls.Add(p02_btn_login);
            p02_pn_login.Location = new Point(278, 52);
            p02_pn_login.Name = "p02_pn_login";
            p02_pn_login.Size = new Size(250, 332);
            p02_pn_login.TabIndex = 1;
            // 
            // p03_lb_numAccount
            // 
            p03_lb_numAccount.AutoSize = true;
            p03_lb_numAccount.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            p03_lb_numAccount.Location = new Point(61, 130);
            p03_lb_numAccount.Name = "p03_lb_numAccount";
            p03_lb_numAccount.Size = new Size(132, 20);
            p03_lb_numAccount.TabIndex = 4;
            p03_lb_numAccount.Text = "Numero de cuenta";
            // 
            // p03_lb_user
            // 
            p03_lb_user.AutoSize = true;
            p03_lb_user.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            p03_lb_user.Location = new Point(95, 60);
            p03_lb_user.Name = "p03_lb_user";
            p03_lb_user.Size = new Size(59, 20);
            p03_lb_user.TabIndex = 3;
            p03_lb_user.Text = "Usuario";
            // 
            // p02_tb_numAccount
            // 
            p02_tb_numAccount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            p02_tb_numAccount.Location = new Point(39, 153);
            p02_tb_numAccount.Name = "p02_tb_numAccount";
            p02_tb_numAccount.Size = new Size(175, 34);
            p02_tb_numAccount.TabIndex = 2;
            // 
            // p02_tb_username
            // 
            p02_tb_username.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            p02_tb_username.Location = new Point(39, 83);
            p02_tb_username.Name = "p02_tb_username";
            p02_tb_username.Size = new Size(175, 34);
            p02_tb_username.TabIndex = 1;
            // 
            // p02_pn
            // 
            p02_pn.Controls.Add(admin_button);
            p02_pn.Controls.Add(test_button);
            p02_pn.Controls.Add(p02_btn_back);
            p02_pn.Controls.Add(p02_pn_login);
            p02_pn.Dock = DockStyle.Fill;
            p02_pn.Location = new Point(0, 0);
            p02_pn.Name = "p02_pn";
            p02_pn.Size = new Size(800, 450);
            p02_pn.TabIndex = 2;
            // 
            // admin_button
            // 
            admin_button.BackColor = SystemColors.Control;
            admin_button.ForeColor = SystemColors.ControlText;
            admin_button.Location = new Point(649, 355);
            admin_button.Name = "admin_button";
            admin_button.Size = new Size(104, 29);
            admin_button.TabIndex = 5;
            admin_button.Text = "admin";
            admin_button.UseVisualStyleBackColor = false;
            admin_button.Click += admin_button_Click;
            // 
            // test_button
            // 
            test_button.BackColor = SystemColors.Control;
            test_button.ForeColor = SystemColors.ControlText;
            test_button.Location = new Point(649, 275);
            test_button.Name = "test_button";
            test_button.Size = new Size(104, 29);
            test_button.TabIndex = 4;
            test_button.Text = "test";
            test_button.UseVisualStyleBackColor = false;
            test_button.Click += test_button_Click;
            // 
            // p02_btn_back
            // 
            p02_btn_back.Location = new Point(12, 12);
            p02_btn_back.Name = "p02_btn_back";
            p02_btn_back.Size = new Size(31, 31);
            p02_btn_back.TabIndex = 3;
            p02_btn_back.Text = "←";
            p02_btn_back.UseVisualStyleBackColor = true;
            p02_btn_back.Click += p01_btn_back_Click;
            // 
            // p02_login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(p02_pn);
            Name = "p02_login";
            Text = " ";
            p02_pn_login.ResumeLayout(false);
            p02_pn_login.PerformLayout();
            p02_pn.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button p02_btn_login;
        private Panel p02_pn_login;
        private Label p03_lb_numAccount;
        private Label p03_lb_user;
        private TextBox p02_tb_numAccount;
        private TextBox p02_tb_username;
        private Panel p02_pn;
        private Button p02_btn_back;
        private Button test_button;
        private Button admin_button;
    }
}