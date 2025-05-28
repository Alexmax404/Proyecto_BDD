namespace Proyecto_bdd2.p3
{
    partial class p32_cashier_Menu
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
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            panel3 = new Panel();
            label3 = new Label();
            panel2 = new Panel();
            button3 = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(18, 153);
            button2.Name = "button2";
            button2.Size = new Size(135, 135);
            button2.TabIndex = 2;
            button2.Text = "Consignar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(647, 153);
            button1.Name = "button1";
            button1.Size = new Size(135, 135);
            button1.TabIndex = 1;
            button1.Text = "retirar";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlDark;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label3);
            panel3.Location = new Point(169, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(461, 125);
            panel3.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(209, 44);
            label3.Name = "label3";
            label3.Size = new Size(44, 31);
            label3.TabIndex = 13;
            label3.Text = "***";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(button3);
            panel2.Location = new Point(169, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(461, 447);
            panel2.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkGray;
            button3.FlatStyle = FlatStyle.System;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(166, 360);
            button3.Name = "button3";
            button3.Size = new Size(135, 73);
            button3.TabIndex = 15;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = false;
            // 
            // p32_cashier_Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "p32_cashier_Menu";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button button1;
        private Panel panel2;
        private Label label3;
        private Panel panel3;
        private Button button3;
    }
}