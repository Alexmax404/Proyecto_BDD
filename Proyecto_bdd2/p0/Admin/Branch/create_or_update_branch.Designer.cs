namespace Proyecto_bdd2.p0.Admin.Branch
{
    partial class create_or_update_branch
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
            btn_create_branch = new Button();
            btn_update_branch = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn_create_branch
            // 
            btn_create_branch.DialogResult = DialogResult.No;
            btn_create_branch.Location = new Point(80, 123);
            btn_create_branch.Name = "btn_create_branch";
            btn_create_branch.Size = new Size(143, 43);
            btn_create_branch.TabIndex = 17;
            btn_create_branch.Text = "Crear";
            btn_create_branch.UseVisualStyleBackColor = true;
            btn_create_branch.Click += btn_create_branch_Click;
            // 
            // btn_update_branch
            // 
            btn_update_branch.Location = new Point(229, 123);
            btn_update_branch.Name = "btn_update_branch";
            btn_update_branch.Size = new Size(143, 43);
            btn_update_branch.TabIndex = 16;
            btn_update_branch.Text = "Acutalizar";
            btn_update_branch.UseVisualStyleBackColor = true;
            btn_update_branch.Click += btn_update_branch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(136, 28);
            label1.Name = "label1";
            label1.Size = new Size(187, 46);
            label1.TabIndex = 15;
            label1.Text = "Sucursales";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // create_or_update_branch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 194);
            Controls.Add(btn_create_branch);
            Controls.Add(btn_update_branch);
            Controls.Add(label1);
            Name = "create_or_update_branch";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_create_branch;
        private Button btn_update_branch;
        private Label label1;
    }
}