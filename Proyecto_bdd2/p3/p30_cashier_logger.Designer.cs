namespace Proyecto_bdd2.p3
{
    partial class p30_cashier_logger
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
            label1 = new Label();
            panel1 = new Panel();
            p30_cb_cashierBranch_chooser = new ComboBox();
            label3 = new Label();
            p30_cb_cashierChosser = new ComboBox();
            label2 = new Label();
            panel2 = new Panel();
            p01_btn_back = new Button();
            p30_btn_send = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(130, 9);
            label1.Name = "label1";
            label1.Size = new Size(137, 46);
            label1.TabIndex = 10;
            label1.Text = "Cajeros";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(p30_cb_cashierBranch_chooser);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(p30_cb_cashierChosser);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(130, 78);
            panel1.Name = "panel1";
            panel1.Size = new Size(536, 303);
            panel1.TabIndex = 11;
            // 
            // p30_cb_cashierBranch_chooser
            // 
            p30_cb_cashierBranch_chooser.DropDownStyle = ComboBoxStyle.DropDownList;
            p30_cb_cashierBranch_chooser.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            p30_cb_cashierBranch_chooser.FormattingEnabled = true;
            p30_cb_cashierBranch_chooser.Location = new Point(63, 106);
            p30_cb_cashierBranch_chooser.Name = "p30_cb_cashierBranch_chooser";
            p30_cb_cashierBranch_chooser.Size = new Size(388, 36);
            p30_cb_cashierBranch_chooser.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(63, 78);
            label3.Name = "label3";
            label3.Size = new Size(369, 25);
            label3.TabIndex = 15;
            label3.Text = "Seleccione la sucursal donde se encuentra";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // p30_cb_cashierChosser
            // 
            p30_cb_cashierChosser.DropDownStyle = ComboBoxStyle.DropDownList;
            p30_cb_cashierChosser.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            p30_cb_cashierChosser.FormattingEnabled = true;
            p30_cb_cashierChosser.Location = new Point(63, 210);
            p30_cb_cashierChosser.Name = "p30_cb_cashierChosser";
            p30_cb_cashierChosser.Size = new Size(388, 36);
            p30_cb_cashierChosser.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(63, 182);
            label2.Name = "label2";
            label2.Size = new Size(179, 25);
            label2.TabIndex = 13;
            label2.Text = "Seleccione el cajero";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(p01_btn_back);
            panel2.Controls.Add(p30_btn_send);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 450);
            panel2.TabIndex = 12;
            // 
            // p01_btn_back
            // 
            p01_btn_back.Location = new Point(12, 12);
            p01_btn_back.Name = "p01_btn_back";
            p01_btn_back.Size = new Size(31, 31);
            p01_btn_back.TabIndex = 11;
            p01_btn_back.Text = "←";
            p01_btn_back.UseVisualStyleBackColor = true;
            p01_btn_back.Click += p01_btn_back_Click;
            // 
            // p30_btn_send
            // 
            p30_btn_send.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            p30_btn_send.Location = new Point(302, 409);
            p30_btn_send.Name = "p30_btn_send";
            p30_btn_send.Size = new Size(183, 29);
            p30_btn_send.TabIndex = 0;
            p30_btn_send.Text = "Ingresar al cajero";
            p30_btn_send.UseVisualStyleBackColor = true;
            p30_btn_send.Click += p30_btn_send_Click;
            // 
            // p30_cashier_logger
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "p30_cashier_logger";
            Text = "p30_cashier_mainMenu";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private ComboBox p30_cb_cashierChosser;
        private Label label2;
        private Panel panel2;
        private ComboBox p30_cb_cashierBranch_chooser;
        private Label label3;
        private Button p30_btn_send;
        private Button p01_btn_back;
    }
}