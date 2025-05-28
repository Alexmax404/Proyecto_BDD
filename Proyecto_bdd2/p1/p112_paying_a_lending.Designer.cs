namespace Proyecto_bdd2.p1
{
    partial class p112_paying_a_lending
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
            p112_btn_pay = new Button();
            label2 = new Label();
            p112_tb_moneyTopay = new TextBox();
            p111_btn_payAll = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 10);
            label1.Name = "label1";
            label1.Size = new Size(166, 92);
            label1.TabIndex = 11;
            label1.Text = "Paga tu \r\nprestamo";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // p112_btn_pay
            // 
            p112_btn_pay.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            p112_btn_pay.Location = new Point(12, 214);
            p112_btn_pay.Name = "p112_btn_pay";
            p112_btn_pay.Size = new Size(94, 29);
            p112_btn_pay.TabIndex = 10;
            p112_btn_pay.Text = "Abonar";
            p112_btn_pay.UseVisualStyleBackColor = true;
            p112_btn_pay.Click += p112_btn_pay_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 118);
            label2.Name = "label2";
            label2.Size = new Size(158, 20);
            label2.TabIndex = 9;
            label2.Text = "¿Cuanto vas a abonar?";
            // 
            // p112_tb_moneyTopay
            // 
            p112_tb_moneyTopay.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            p112_tb_moneyTopay.Location = new Point(12, 141);
            p112_tb_moneyTopay.Name = "p112_tb_moneyTopay";
            p112_tb_moneyTopay.Size = new Size(237, 38);
            p112_tb_moneyTopay.TabIndex = 8;
            // 
            // p111_btn_payAll
            // 
            p111_btn_payAll.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            p111_btn_payAll.Location = new Point(155, 214);
            p111_btn_payAll.Name = "p111_btn_payAll";
            p111_btn_payAll.Size = new Size(94, 29);
            p111_btn_payAll.TabIndex = 12;
            p111_btn_payAll.Text = "pagar todo";
            p111_btn_payAll.UseVisualStyleBackColor = true;
            p111_btn_payAll.Click += p111_btn_payAll_Click;
            // 
            // p112_paying_a_lending
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(261, 255);
            Controls.Add(p111_btn_payAll);
            Controls.Add(label1);
            Controls.Add(p112_btn_pay);
            Controls.Add(label2);
            Controls.Add(p112_tb_moneyTopay);
            Name = "p112_paying_a_lending";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button p112_btn_pay;
        private Label label2;
        private TextBox p112_tb_moneyTopay;
        private Button p111_btn_payAll;
    }
}