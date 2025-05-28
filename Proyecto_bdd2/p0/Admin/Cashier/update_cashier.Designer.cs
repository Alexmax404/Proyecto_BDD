namespace Proyecto_bdd2.p0.Admin
{
    partial class update_cashier
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
            label4 = new Label();
            label2 = new Label();
            update_lbl_mont_to_add = new TextBox();
            update_cb_cashier_state = new ComboBox();
            label7 = new Label();
            panel1 = new Panel();
            update_btn_cashier = new Button();
            label6 = new Label();
            panel2 = new Panel();
            label9 = new Label();
            cashier_cb_update_selectID = new ComboBox();
            cashier_cb_updateBranch = new ComboBox();
            label8 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 60);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 20;
            label4.Text = "Estado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 141);
            label2.Name = "label2";
            label2.Size = new Size(203, 20);
            label2.TabIndex = 22;
            label2.Text = "Cuanto dinero deseo agregar";
            // 
            // update_lbl_mont_to_add
            // 
            update_lbl_mont_to_add.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            update_lbl_mont_to_add.Location = new Point(12, 164);
            update_lbl_mont_to_add.Name = "update_lbl_mont_to_add";
            update_lbl_mont_to_add.Size = new Size(436, 38);
            update_lbl_mont_to_add.TabIndex = 21;
            // 
            // update_cb_cashier_state
            // 
            update_cb_cashier_state.DropDownStyle = ComboBoxStyle.DropDownList;
            update_cb_cashier_state.FormattingEnabled = true;
            update_cb_cashier_state.Location = new Point(12, 93);
            update_cb_cashier_state.Name = "update_cb_cashier_state";
            update_cb_cashier_state.Size = new Size(203, 28);
            update_cb_cashier_state.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(85, 18);
            label7.Name = "label7";
            label7.Size = new Size(291, 46);
            label7.TabIndex = 29;
            label7.Text = "Actualizar Cajero";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(update_btn_cashier);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(update_cb_cashier_state);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(update_lbl_mont_to_add);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(0, 203);
            panel1.Name = "panel1";
            panel1.Size = new Size(459, 387);
            panel1.TabIndex = 34;
            // 
            // update_btn_cashier
            // 
            update_btn_cashier.Location = new Point(181, 227);
            update_btn_cashier.Name = "update_btn_cashier";
            update_btn_cashier.Size = new Size(94, 29);
            update_btn_cashier.TabIndex = 0;
            update_btn_cashier.Text = "Actualizar";
            update_btn_cashier.UseVisualStyleBackColor = true;
            update_btn_cashier.Click += update_btn_cashier_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(11, 31);
            label6.Name = "label6";
            label6.Size = new Size(124, 20);
            label6.TabIndex = 35;
            label6.Text = "Actualizar Datos";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(label9);
            panel2.Controls.Add(cashier_cb_update_selectID);
            panel2.Controls.Add(cashier_cb_updateBranch);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(0, 81);
            panel2.Name = "panel2";
            panel2.Size = new Size(459, 140);
            panel2.TabIndex = 35;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(12, 31);
            label9.Name = "label9";
            label9.Size = new Size(143, 20);
            label9.TabIndex = 36;
            label9.Text = "Seleccione el cajero\r\n";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cashier_cb_update_selectID
            // 
            cashier_cb_update_selectID.DropDownStyle = ComboBoxStyle.DropDownList;
            cashier_cb_update_selectID.FormattingEnabled = true;
            cashier_cb_update_selectID.Location = new Point(238, 89);
            cashier_cb_update_selectID.Name = "cashier_cb_update_selectID";
            cashier_cb_update_selectID.Size = new Size(210, 28);
            cashier_cb_update_selectID.TabIndex = 33;
            // 
            // cashier_cb_updateBranch
            // 
            cashier_cb_updateBranch.DropDownStyle = ComboBoxStyle.DropDownList;
            cashier_cb_updateBranch.FormattingEnabled = true;
            cashier_cb_updateBranch.Location = new Point(12, 90);
            cashier_cb_updateBranch.Name = "cashier_cb_updateBranch";
            cashier_cb_updateBranch.Size = new Size(203, 28);
            cashier_cb_updateBranch.TabIndex = 32;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(238, 67);
            label8.Name = "label8";
            label8.Size = new Size(24, 20);
            label8.TabIndex = 31;
            label8.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 67);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 18;
            label3.Text = "Sucursal";
            // 
            // update_cashier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 495);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label7);
            Name = "update_cashier";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label2;
        private TextBox update_lbl_mont_to_add;
        private ComboBox update_cb_cashier_state;
        private Label label7;
        private Panel panel1;
        private Label label6;
        private Panel panel2;
        private Label label9;
        private ComboBox cashier_cb_update_selectID;
        private Button update_btn_cashier;
        private ComboBox cashier_cb_updateBranch;
        private Label label8;
        private Label label3;
    }
}