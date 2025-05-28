namespace Proyecto_bdd2.p3
{
    partial class p34_retire
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
            p34_btn_retirar = new Button();
            p34_tb_cuantoARetirar = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // p34_btn_retirar
            // 
            p34_btn_retirar.Location = new Point(104, 186);
            p34_btn_retirar.Name = "p34_btn_retirar";
            p34_btn_retirar.Size = new Size(94, 29);
            p34_btn_retirar.TabIndex = 15;
            p34_btn_retirar.Text = "retirar";
            p34_btn_retirar.UseVisualStyleBackColor = true;
            p34_btn_retirar.Click += p34_btn_retirar_Click;
            // 
            // p34_tb_cuantoARetirar
            // 
            p34_tb_cuantoARetirar.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            p34_tb_cuantoARetirar.Location = new Point(23, 122);
            p34_tb_cuantoARetirar.Name = "p34_tb_cuantoARetirar";
            p34_tb_cuantoARetirar.Size = new Size(254, 38);
            p34_tb_cuantoARetirar.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 99);
            label2.Name = "label2";
            label2.Size = new Size(163, 20);
            label2.TabIndex = 13;
            label2.Text = "¿Cuanto deseas retirar?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(64, 39);
            label1.Name = "label1";
            label1.Size = new Size(176, 38);
            label1.TabIndex = 12;
            label1.Text = "Retira dinero";
            // 
            // p34_retire
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(298, 254);
            Controls.Add(p34_btn_retirar);
            Controls.Add(p34_tb_cuantoARetirar);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "p34_retire";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button p34_btn_retirar;
        private TextBox p34_tb_cuantoARetirar;
        private Label label2;
        private Label label1;
    }
}