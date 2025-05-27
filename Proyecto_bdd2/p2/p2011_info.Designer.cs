namespace Proyecto_bdd2
{
    partial class p2011_info
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            p2011_lbl_owner = new Label();
            p2011_lbl_fechaVencimiento = new Label();
            p2011_lbl_noTarjeta = new Label();
            p2011_lbl_cvv = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(83, 29);
            label1.Name = "label1";
            label1.Size = new Size(308, 46);
            label1.TabIndex = 10;
            label1.Text = "Detalles de tarjeta";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 95);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 11;
            label2.Text = "N° de tarjeta:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 128);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 12;
            label3.Text = "Valida hasta: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 164);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 13;
            label4.Text = "Propietario";
            // 
            // p2011_lbl_owner
            // 
            p2011_lbl_owner.AutoSize = true;
            p2011_lbl_owner.Location = new Point(220, 164);
            p2011_lbl_owner.Name = "p2011_lbl_owner";
            p2011_lbl_owner.Size = new Size(18, 20);
            p2011_lbl_owner.TabIndex = 14;
            p2011_lbl_owner.Text = "...";
            // 
            // p2011_lbl_fechaVencimiento
            // 
            p2011_lbl_fechaVencimiento.AutoSize = true;
            p2011_lbl_fechaVencimiento.Location = new Point(220, 128);
            p2011_lbl_fechaVencimiento.Name = "p2011_lbl_fechaVencimiento";
            p2011_lbl_fechaVencimiento.Size = new Size(18, 20);
            p2011_lbl_fechaVencimiento.TabIndex = 15;
            p2011_lbl_fechaVencimiento.Text = "...";
            // 
            // p2011_lbl_noTarjeta
            // 
            p2011_lbl_noTarjeta.AutoSize = true;
            p2011_lbl_noTarjeta.Location = new Point(220, 95);
            p2011_lbl_noTarjeta.Name = "p2011_lbl_noTarjeta";
            p2011_lbl_noTarjeta.Size = new Size(18, 20);
            p2011_lbl_noTarjeta.TabIndex = 16;
            p2011_lbl_noTarjeta.Text = "...";
            // 
            // p2011_lbl_cvv
            // 
            p2011_lbl_cvv.AutoSize = true;
            p2011_lbl_cvv.Location = new Point(220, 203);
            p2011_lbl_cvv.Name = "p2011_lbl_cvv";
            p2011_lbl_cvv.Size = new Size(18, 20);
            p2011_lbl_cvv.TabIndex = 18;
            p2011_lbl_cvv.Text = "...";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(37, 203);
            label9.Name = "label9";
            label9.Size = new Size(36, 20);
            label9.TabIndex = 17;
            label9.Text = "CVV";
            // 
            // p2011_info
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 232);
            Controls.Add(p2011_lbl_cvv);
            Controls.Add(label9);
            Controls.Add(p2011_lbl_noTarjeta);
            Controls.Add(p2011_lbl_fechaVencimiento);
            Controls.Add(p2011_lbl_owner);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "p2011_info";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label p2011_lbl_owner;
        private Label p2011_lbl_fechaVencimiento;
        private Label p2011_lbl_noTarjeta;
        private Label p2011_lbl_cvv;
        private Label label9;
    }
}