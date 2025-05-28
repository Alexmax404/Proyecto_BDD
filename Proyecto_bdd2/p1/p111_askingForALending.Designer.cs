namespace Proyecto_bdd2.p1
{
    partial class p111_askingForALending
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
            p111_tb_moneyToLend = new TextBox();
            label2 = new Label();
            p111_btn_request = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // p111_tb_moneyToLend
            // 
            p111_tb_moneyToLend.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            p111_tb_moneyToLend.Location = new Point(12, 140);
            p111_tb_moneyToLend.Name = "p111_tb_moneyToLend";
            p111_tb_moneyToLend.Size = new Size(237, 38);
            p111_tb_moneyToLend.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 117);
            label2.Name = "label2";
            label2.Size = new Size(146, 20);
            label2.TabIndex = 5;
            label2.Text = "¿Cuanto vas a pedir?";
            // 
            // p111_btn_request
            // 
            p111_btn_request.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            p111_btn_request.Location = new Point(82, 214);
            p111_btn_request.Name = "p111_btn_request";
            p111_btn_request.Size = new Size(94, 29);
            p111_btn_request.TabIndex = 6;
            p111_btn_request.Text = "Solicitar";
            p111_btn_request.UseVisualStyleBackColor = true;
            p111_btn_request.Click += p111_btn_request_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 9);
            label1.Name = "label1";
            label1.Size = new Size(166, 92);
            label1.TabIndex = 7;
            label1.Text = "Pide tu\r\nprestamo";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // p111_askingForALending
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(261, 255);
            Controls.Add(label1);
            Controls.Add(p111_btn_request);
            Controls.Add(label2);
            Controls.Add(p111_tb_moneyToLend);
            Name = "p111_askingForALending";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox p111_tb_moneyToLend;
        private Label label2;
        private Button p111_btn_request;
        private Label label1;
    }
}