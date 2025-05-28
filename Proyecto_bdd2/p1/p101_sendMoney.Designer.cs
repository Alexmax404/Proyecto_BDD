namespace Proyecto_bdd2
{
    partial class p101_sendMoney
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
            label2 = new Label();
            label3 = new Label();
            p101_tb_whoSend = new TextBox();
            p101_tb_howMany = new TextBox();
            p101_btn_send = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 9F);
            label2.Location = new Point(12, 172);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 1;
            label2.Text = "¿A quién?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 9F);
            label3.Location = new Point(12, 263);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "¿Cuanto?";
            // 
            // p101_tb_whoSend
            // 
            p101_tb_whoSend.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            p101_tb_whoSend.Location = new Point(12, 195);
            p101_tb_whoSend.Name = "p101_tb_whoSend";
            p101_tb_whoSend.Size = new Size(233, 38);
            p101_tb_whoSend.TabIndex = 3;
            // 
            // p101_tb_howMany
            // 
            p101_tb_howMany.Font = new Font("Yu Gothic UI", 13.8F);
            p101_tb_howMany.Location = new Point(12, 286);
            p101_tb_howMany.Name = "p101_tb_howMany";
            p101_tb_howMany.Size = new Size(233, 38);
            p101_tb_howMany.TabIndex = 4;
            // 
            // p101_btn_send
            // 
            p101_btn_send.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            p101_btn_send.Location = new Point(78, 366);
            p101_btn_send.Name = "p101_btn_send";
            p101_btn_send.Size = new Size(94, 29);
            p101_btn_send.TabIndex = 5;
            p101_btn_send.Text = "Enviar";
            p101_btn_send.UseVisualStyleBackColor = true;
            p101_btn_send.Click += p101_btn_send_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(31, 54);
            label4.Name = "label4";
            label4.Size = new Size(194, 46);
            label4.TabIndex = 12;
            label4.Text = "Envia Plata";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // p101_sendMoney
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(257, 407);
            Controls.Add(label4);
            Controls.Add(p101_btn_send);
            Controls.Add(p101_tb_howMany);
            Controls.Add(p101_tb_whoSend);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "p101_sendMoney";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private TextBox p101_tb_whoSend;
        private TextBox p101_tb_howMany;
        private Button p101_btn_send;
        private Label label4;
    }
}