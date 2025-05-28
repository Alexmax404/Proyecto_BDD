namespace Proyecto_bdd2.p0.Admin
{
    partial class create_or_update_cashier
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
            btn_update_cashier = new Button();
            btn_create_cashier = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(151, 9);
            label1.Name = "label1";
            label1.Size = new Size(137, 46);
            label1.TabIndex = 11;
            label1.Text = "Cajeros";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_update_cashier
            // 
            btn_update_cashier.Location = new Point(222, 104);
            btn_update_cashier.Name = "btn_update_cashier";
            btn_update_cashier.Size = new Size(143, 43);
            btn_update_cashier.TabIndex = 13;
            btn_update_cashier.Text = "Acutalizar";
            btn_update_cashier.UseVisualStyleBackColor = true;
            btn_update_cashier.Click += btn_update_Click;
            // 
            // btn_create_cashier
            // 
            btn_create_cashier.Location = new Point(73, 104);
            btn_create_cashier.Name = "btn_create_cashier";
            btn_create_cashier.Size = new Size(143, 43);
            btn_create_cashier.TabIndex = 14;
            btn_create_cashier.Text = "Crear";
            btn_create_cashier.UseVisualStyleBackColor = true;
            btn_create_cashier.Click += btn_create_Click;
            // 
            // create_or_update_cashier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 194);
            Controls.Add(btn_create_cashier);
            Controls.Add(btn_update_cashier);
            Controls.Add(label1);
            Name = "create_or_update_cashier";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_update_cashier;
        private Button btn_create_cashier;
    }
}