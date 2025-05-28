namespace Proyecto_bdd2.p1
{
    partial class p11_lending_mm
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
            p11_lbl_message = new Label();
            p11_btn_request = new Button();
            p11_btn_pay = new Button();
            p01_btn_back = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(p11_lbl_message);
            panel1.Location = new Point(8, 91);
            panel1.Name = "panel1";
            panel1.Size = new Size(652, 271);
            panel1.TabIndex = 0;
            // 
            // p11_lbl_message
            // 
            p11_lbl_message.AutoSize = true;
            p11_lbl_message.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            p11_lbl_message.Location = new Point(21, 16);
            p11_lbl_message.Name = "p11_lbl_message";
            p11_lbl_message.Size = new Size(91, 38);
            p11_lbl_message.TabIndex = 0;
            p11_lbl_message.Text = "label1";
            // 
            // p11_btn_request
            // 
            p11_btn_request.Location = new Point(538, 411);
            p11_btn_request.Name = "p11_btn_request";
            p11_btn_request.Size = new Size(122, 29);
            p11_btn_request.TabIndex = 1;
            p11_btn_request.Text = "Pedir prestamo";
            p11_btn_request.UseVisualStyleBackColor = true;
            p11_btn_request.Click += p11_btn_request_Click;
            // 
            // p11_btn_pay
            // 
            p11_btn_pay.Location = new Point(666, 411);
            p11_btn_pay.Name = "p11_btn_pay";
            p11_btn_pay.Size = new Size(122, 29);
            p11_btn_pay.TabIndex = 2;
            p11_btn_pay.Text = "Pagar prestamo";
            p11_btn_pay.UseVisualStyleBackColor = true;
            p11_btn_pay.Click += p11_btn_pay_Click;
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
            // p11_lending_mm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(p01_btn_back);
            Controls.Add(p11_btn_pay);
            Controls.Add(p11_btn_request);
            Controls.Add(panel1);
            Name = "p11_lending_mm";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label p11_lbl_message;
        private Button p11_btn_request;
        private Button p11_btn_pay;
        private Button p01_btn_back;
    }
}