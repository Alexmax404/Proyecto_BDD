namespace Proyecto_bdd2.p0.Admin.Branch
{
    partial class update_branch
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
            panelBackground = new Panel();
            label9 = new Label();
            branch_cb_pickABranch = new ComboBox();
            panel1 = new Panel();
            label8 = new Label();
            branch_tb_update_address = new TextBox();
            label3 = new Label();
            branch_tb_update_phone = new TextBox();
            branch_btn_delete = new Button();
            branch_btn_update = new Button();
            label6 = new Label();
            branch_cb_update_state = new ComboBox();
            label2 = new Label();
            branch_tb_update_name = new TextBox();
            label4 = new Label();
            label7 = new Label();
            lbl_id = new Label();
            panelBackground.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelBackground
            // 
            panelBackground.Controls.Add(label9);
            panelBackground.Controls.Add(branch_cb_pickABranch);
            panelBackground.Location = new Point(1, 67);
            panelBackground.Name = "panelBackground";
            panelBackground.Size = new Size(459, 140);
            panelBackground.TabIndex = 37;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(12, 31);
            label9.Name = "label9";
            label9.Size = new Size(158, 20);
            label9.TabIndex = 36;
            label9.Text = "Seleccione la sucursal";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // branch_cb_pickABranch
            // 
            branch_cb_pickABranch.DropDownStyle = ComboBoxStyle.DropDownList;
            branch_cb_pickABranch.FormattingEnabled = true;
            branch_cb_pickABranch.Location = new Point(12, 68);
            branch_cb_pickABranch.Name = "branch_cb_pickABranch";
            branch_cb_pickABranch.Size = new Size(210, 28);
            branch_cb_pickABranch.TabIndex = 33;
            // 
            // panel1
            // 
            panel1.Controls.Add(lbl_id);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(branch_tb_update_address);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(branch_tb_update_phone);
            panel1.Controls.Add(branch_btn_delete);
            panel1.Controls.Add(branch_btn_update);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(branch_cb_update_state);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(branch_tb_update_name);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(1, 203);
            panel1.Name = "panel1";
            panel1.Size = new Size(459, 387);
            panel1.TabIndex = 36;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(238, 141);
            label8.Name = "label8";
            label8.Size = new Size(72, 20);
            label8.TabIndex = 41;
            label8.Text = "Direccion";
            // 
            // branch_tb_update_address
            // 
            branch_tb_update_address.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            branch_tb_update_address.Location = new Point(238, 164);
            branch_tb_update_address.Name = "branch_tb_update_address";
            branch_tb_update_address.Size = new Size(210, 38);
            branch_tb_update_address.TabIndex = 40;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(238, 61);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 39;
            label3.Text = "Teléfono\r\n";
            // 
            // branch_tb_update_phone
            // 
            branch_tb_update_phone.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            branch_tb_update_phone.Location = new Point(238, 84);
            branch_tb_update_phone.Name = "branch_tb_update_phone";
            branch_tb_update_phone.Size = new Size(210, 38);
            branch_tb_update_phone.TabIndex = 38;
            // 
            // branch_btn_delete
            // 
            branch_btn_delete.Location = new Point(353, 222);
            branch_btn_delete.Name = "branch_btn_delete";
            branch_btn_delete.Size = new Size(94, 53);
            branch_btn_delete.TabIndex = 37;
            branch_btn_delete.Text = "Borrar Sucursal";
            branch_btn_delete.UseVisualStyleBackColor = true;
            branch_btn_delete.Click += branch_btn_delete_Click;
            // 
            // branch_btn_update
            // 
            branch_btn_update.Location = new Point(184, 288);
            branch_btn_update.Name = "branch_btn_update";
            branch_btn_update.Size = new Size(94, 29);
            branch_btn_update.TabIndex = 36;
            branch_btn_update.Text = "Actualizar";
            branch_btn_update.UseVisualStyleBackColor = true;
            branch_btn_update.Click += branch_btn_update_Click;
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
            // branch_cb_update_state
            // 
            branch_cb_update_state.FormattingEnabled = true;
            branch_cb_update_state.Items.AddRange(new object[] { "Abierta", "Cerrado" });
            branch_cb_update_state.Location = new Point(12, 93);
            branch_cb_update_state.Name = "branch_cb_update_state";
            branch_cb_update_state.Size = new Size(203, 28);
            branch_cb_update_state.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 141);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 22;
            label2.Text = "Nombre";
            // 
            // branch_tb_update_name
            // 
            branch_tb_update_name.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            branch_tb_update_name.Location = new Point(12, 164);
            branch_tb_update_name.Name = "branch_tb_update_name";
            branch_tb_update_name.Size = new Size(210, 38);
            branch_tb_update_name.TabIndex = 21;
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(66, 18);
            label7.Name = "label7";
            label7.Size = new Size(323, 46);
            label7.TabIndex = 37;
            label7.Text = "Actualizar Sucursal";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.Location = new Point(21, 237);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(0, 20);
            lbl_id.TabIndex = 42;
            // 
            // update_branch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 548);
            Controls.Add(label7);
            Controls.Add(panelBackground);
            Controls.Add(panel1);
            Name = "update_branch";
            Text = "Form1";
            panelBackground.ResumeLayout(false);
            panelBackground.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelBackground;
        private Label label9;
        private ComboBox branch_cb_pickABranch;
        private Panel panel1;
        private Label label8;
        private TextBox branch_tb_update_address;
        private Label label3;
        private TextBox branch_tb_update_phone;
        private Button branch_btn_delete;
        private Button branch_btn_update;
        private Label label6;
        private ComboBox branch_cb_update_state;
        private Label label2;
        private TextBox branch_tb_update_name;
        private Label label4;
        private Label label7;
        private Label lbl_id;
    }
}