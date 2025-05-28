namespace Proyecto_bdd2.p3
{
    partial class p31_cashier_verify
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
            p01_btn_back = new Button();
            panel2 = new Panel();
            p31_btn_enter = new Button();
            p31_lbl_chasierNum = new Label();
            p03_tb_name = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(p01_btn_back);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // p01_btn_back
            // 
            p01_btn_back.Location = new Point(12, 12);
            p01_btn_back.Name = "p01_btn_back";
            p01_btn_back.Size = new Size(31, 31);
            p01_btn_back.TabIndex = 12;
            p01_btn_back.Text = "←";
            p01_btn_back.UseVisualStyleBackColor = true;
            p01_btn_back.Click += p01_btn_back_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(p31_btn_enter);
            panel2.Controls.Add(p31_lbl_chasierNum);
            panel2.Controls.Add(p03_tb_name);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(169, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(461, 450);
            panel2.TabIndex = 0;
            // 
            // p31_btn_enter
            // 
            p31_btn_enter.Location = new Point(174, 364);
            p31_btn_enter.Name = "p31_btn_enter";
            p31_btn_enter.Size = new Size(94, 29);
            p31_btn_enter.TabIndex = 14;
            p31_btn_enter.Text = "Entrar";
            p31_btn_enter.UseVisualStyleBackColor = true;
            p31_btn_enter.Click += p31_btn_enter_Click;
            // 
            // p31_lbl_chasierNum
            // 
            p31_lbl_chasierNum.AutoSize = true;
            p31_lbl_chasierNum.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            p31_lbl_chasierNum.Location = new Point(124, 37);
            p31_lbl_chasierNum.Name = "p31_lbl_chasierNum";
            p31_lbl_chasierNum.Size = new Size(44, 31);
            p31_lbl_chasierNum.TabIndex = 13;
            p31_lbl_chasierNum.Text = "***";
            p31_lbl_chasierNum.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // p03_tb_name
            // 
            p03_tb_name.AccessibleName = "";
            p03_tb_name.Font = new Font("Segoe UI", 16.2F);
            p03_tb_name.Location = new Point(38, 249);
            p03_tb_name.Name = "p03_tb_name";
            p03_tb_name.Size = new Size(385, 43);
            p03_tb_name.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(56, 157);
            label2.Name = "label2";
            label2.Size = new Size(345, 62);
            label2.TabIndex = 11;
            label2.Text = "Ingrese el numero de su tarjeta\r\npara ingresar al cajero\r\n";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // p31_cashier_verify
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "p31_cashier_verify";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private TextBox p03_tb_name;
        private Label p31_lbl_chasierNum;
        private Button p31_btn_enter;
        private Button p01_btn_back;
    }
}