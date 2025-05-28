namespace Proyecto_bdd2.p0.Admin
{
    partial class create_cashier
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
            cashier_tb_monto = new TextBox();
            cashier_btn_create = new Button();
            cashier_cb_sucursalDeCajero = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(129, 20);
            label1.Name = "label1";
            label1.Size = new Size(211, 46);
            label1.TabIndex = 11;
            label1.Text = "Crear cajero";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(261, 141);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(115, 102);
            label3.Name = "label3";
            label3.Size = new Size(191, 20);
            label3.TabIndex = 14;
            label3.Text = "¿En que sucursal va a estar?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(115, 181);
            label4.Name = "label4";
            label4.Size = new Size(196, 20);
            label4.TabIndex = 16;
            label4.Text = "¿Cuanto efectivo va a tener?";
            // 
            // cashier_tb_monto
            // 
            cashier_tb_monto.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cashier_tb_monto.Location = new Point(115, 204);
            cashier_tb_monto.Name = "cashier_tb_monto";
            cashier_tb_monto.PlaceholderText = "$$$$";
            cashier_tb_monto.Size = new Size(237, 38);
            cashier_tb_monto.TabIndex = 15;
            // 
            // cashier_btn_create
            // 
            cashier_btn_create.Location = new Point(186, 268);
            cashier_btn_create.Name = "cashier_btn_create";
            cashier_btn_create.Size = new Size(94, 29);
            cashier_btn_create.TabIndex = 17;
            cashier_btn_create.Text = "crear";
            cashier_btn_create.UseVisualStyleBackColor = true;
            cashier_btn_create.Click += cashier_btn_create_Click;
            // 
            // cashier_cb_sucursalDeCajero
            // 
            cashier_cb_sucursalDeCajero.FormattingEnabled = true;
            cashier_cb_sucursalDeCajero.Location = new Point(115, 133);
            cashier_cb_sucursalDeCajero.Name = "cashier_cb_sucursalDeCajero";
            cashier_cb_sucursalDeCajero.Size = new Size(237, 28);
            cashier_cb_sucursalDeCajero.TabIndex = 18;
            // 
            // create_cashier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 322);
            Controls.Add(cashier_cb_sucursalDeCajero);
            Controls.Add(cashier_btn_create);
            Controls.Add(label4);
            Controls.Add(cashier_tb_monto);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "create_cashier";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox cashier_tb_monto;
        private Button cashier_btn_create;
        private ComboBox cashier_cb_sucursalDeCajero;
    }
}