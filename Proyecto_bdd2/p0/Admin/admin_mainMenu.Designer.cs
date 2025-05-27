namespace Proyecto_bdd2.p0.Admin
{
    partial class admin_mainMenu
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
            p01_btn_back = new Button();
            panel1 = new Panel();
            label1 = new Label();
            admin_btn_sucursales = new Button();
            admin_btn_cajeros = new Button();
            p10_pn_properties = new Panel();
            p10_btn_back = new Button();
            p10_lbl_accountNumber = new Label();
            panel1.SuspendLayout();
            p10_pn_properties.SuspendLayout();
            SuspendLayout();
            // 
            // p01_btn_back
            // 
            p01_btn_back.Location = new Point(12, 12);
            p01_btn_back.Name = "p01_btn_back";
            p01_btn_back.Size = new Size(31, 31);
            p01_btn_back.TabIndex = 3;
            p01_btn_back.Text = "←";
            p01_btn_back.UseVisualStyleBackColor = true;
            p01_btn_back.Click += p01_btn_back_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(admin_btn_sucursales);
            panel1.Controls.Add(admin_btn_cajeros);
            panel1.Controls.Add(p10_pn_properties);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(246, 44);
            label1.Name = "label1";
            label1.Size = new Size(211, 46);
            label1.TabIndex = 10;
            label1.Text = "Administrar";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // admin_btn_sucursales
            // 
            admin_btn_sucursales.Location = new Point(495, 161);
            admin_btn_sucursales.Name = "admin_btn_sucursales";
            admin_btn_sucursales.Size = new Size(186, 182);
            admin_btn_sucursales.TabIndex = 3;
            admin_btn_sucursales.Text = "Sucursales";
            admin_btn_sucursales.UseVisualStyleBackColor = true;
            // 
            // admin_btn_cajeros
            // 
            admin_btn_cajeros.Location = new Point(246, 161);
            admin_btn_cajeros.Name = "admin_btn_cajeros";
            admin_btn_cajeros.Size = new Size(186, 182);
            admin_btn_cajeros.TabIndex = 2;
            admin_btn_cajeros.Text = "Cajeros";
            admin_btn_cajeros.UseVisualStyleBackColor = true;
            // 
            // p10_pn_properties
            // 
            p10_pn_properties.BorderStyle = BorderStyle.FixedSingle;
            p10_pn_properties.Controls.Add(p10_btn_back);
            p10_pn_properties.Controls.Add(p10_lbl_accountNumber);
            p10_pn_properties.Dock = DockStyle.Left;
            p10_pn_properties.Location = new Point(0, 0);
            p10_pn_properties.Name = "p10_pn_properties";
            p10_pn_properties.Size = new Size(155, 450);
            p10_pn_properties.TabIndex = 1;
            // 
            // p10_btn_back
            // 
            p10_btn_back.Location = new Point(11, 11);
            p10_btn_back.Name = "p10_btn_back";
            p10_btn_back.Size = new Size(31, 31);
            p10_btn_back.TabIndex = 4;
            p10_btn_back.Text = "←";
            p10_btn_back.UseVisualStyleBackColor = true;
            // 
            // p10_lbl_accountNumber
            // 
            p10_lbl_accountNumber.AutoSize = true;
            p10_lbl_accountNumber.BorderStyle = BorderStyle.FixedSingle;
            p10_lbl_accountNumber.Location = new Point(45, 241);
            p10_lbl_accountNumber.Name = "p10_lbl_accountNumber";
            p10_lbl_accountNumber.Size = new Size(55, 22);
            p10_lbl_accountNumber.TabIndex = 1;
            p10_lbl_accountNumber.Text = "Admin";
            // 
            // admin_mainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(p01_btn_back);
            Controls.Add(panel1);
            Name = "admin_mainMenu";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            p10_pn_properties.ResumeLayout(false);
            p10_pn_properties.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button p01_btn_back;
        private Panel panel1;
        private Button admin_btn_sucursales;
        private Button admin_btn_cajeros;
        private Panel p10_pn_properties;
        private Button p10_btn_back;
        private Label p10_lbl_accountNumber;
        private Label label1;
    }
}