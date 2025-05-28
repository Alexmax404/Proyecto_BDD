namespace Proyecto_bdd2.p0.Admin.Branch
{
    partial class create_branch
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
            label3 = new Label();
            branch_tb_name = new TextBox();
            label1 = new Label();
            label2 = new Label();
            branch_tb_address = new TextBox();
            label4 = new Label();
            branch_tb_phone = new TextBox();
            branch_btn_create = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(128, 132);
            label3.Name = "label3";
            label3.Size = new Size(153, 20);
            label3.TabIndex = 19;
            label3.Text = "¿Que nombre tendrá?";
            // 
            // branch_tb_name
            // 
            branch_tb_name.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            branch_tb_name.Location = new Point(128, 155);
            branch_tb_name.Name = "branch_tb_name";
            branch_tb_name.Size = new Size(237, 38);
            branch_tb_name.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(128, 50);
            label1.Name = "label1";
            label1.Size = new Size(244, 46);
            label1.TabIndex = 17;
            label1.Text = "Crear sucursal";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(128, 212);
            label2.Name = "label2";
            label2.Size = new Size(153, 20);
            label2.TabIndex = 21;
            label2.Text = "¿Cual es su dirección?";
            // 
            // branch_tb_address
            // 
            branch_tb_address.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            branch_tb_address.Location = new Point(128, 235);
            branch_tb_address.Name = "branch_tb_address";
            branch_tb_address.Size = new Size(237, 38);
            branch_tb_address.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(128, 292);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 23;
            label4.Text = "Teléfono";
            // 
            // branch_tb_phone
            // 
            branch_tb_phone.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            branch_tb_phone.Location = new Point(135, 315);
            branch_tb_phone.Name = "branch_tb_phone";
            branch_tb_phone.Size = new Size(237, 38);
            branch_tb_phone.TabIndex = 22;
            // 
            // branch_btn_create
            // 
            branch_btn_create.Location = new Point(198, 395);
            branch_btn_create.Name = "branch_btn_create";
            branch_btn_create.Size = new Size(94, 29);
            branch_btn_create.TabIndex = 24;
            branch_btn_create.Text = "crear";
            branch_btn_create.UseVisualStyleBackColor = true;
            branch_btn_create.Click += branch_btn_create_Click;
            // 
            // create_branch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 451);
            Controls.Add(branch_btn_create);
            Controls.Add(label4);
            Controls.Add(branch_tb_phone);
            Controls.Add(label2);
            Controls.Add(branch_tb_address);
            Controls.Add(label3);
            Controls.Add(branch_tb_name);
            Controls.Add(label1);
            Name = "create_branch";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private TextBox branch_tb_name;
        private Label label1;
        private Label label2;
        private TextBox branch_tb_address;
        private Label label4;
        private TextBox branch_tb_phone;
        private Button branch_btn_create;
    }
}