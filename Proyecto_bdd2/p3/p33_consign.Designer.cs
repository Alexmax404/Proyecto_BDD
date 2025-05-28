namespace Proyecto_bdd2.p3
{
    partial class p33_consign
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
            p33_btn_enviar = new Button();
            p33_tb_cuantoAConsignar = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // p33_btn_enviar
            // 
            p33_btn_enviar.Location = new Point(105, 197);
            p33_btn_enviar.Name = "p33_btn_enviar";
            p33_btn_enviar.Size = new Size(94, 29);
            p33_btn_enviar.TabIndex = 11;
            p33_btn_enviar.Text = "Enviar";
            p33_btn_enviar.UseVisualStyleBackColor = true;
            p33_btn_enviar.Click += p33_btn_enviar_Click;
            // 
            // p33_tb_cuantoAConsignar
            // 
            p33_tb_cuantoAConsignar.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            p33_tb_cuantoAConsignar.Location = new Point(24, 133);
            p33_tb_cuantoAConsignar.Name = "p33_tb_cuantoAConsignar";
            p33_tb_cuantoAConsignar.Size = new Size(254, 38);
            p33_tb_cuantoAConsignar.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 110);
            label2.Name = "label2";
            label2.Size = new Size(187, 20);
            label2.TabIndex = 7;
            label2.Text = "¿Cuanto deseas consignar?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 50);
            label1.Name = "label1";
            label1.Size = new Size(277, 38);
            label1.TabIndex = 6;
            label1.Text = "Consigna a tu cuenta";
            // 
            // p33_consign
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(298, 254);
            Controls.Add(p33_btn_enviar);
            Controls.Add(p33_tb_cuantoAConsignar);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "p33_consign";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button p33_btn_enviar;
        private TextBox p33_tb_cuantoAConsignar;
        private Label label2;
        private Label label1;
    }
}