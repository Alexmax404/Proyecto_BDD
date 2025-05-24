namespace Proyecto_bdd2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            p0_btn_acceder = new Button();
            SuspendLayout();
            // 
            // p0_btn_acceder
            // 
            p0_btn_acceder.Location = new Point(12, 409);
            p0_btn_acceder.Name = "p0_btn_acceder";
            p0_btn_acceder.Size = new Size(94, 29);
            p0_btn_acceder.TabIndex = 0;
            p0_btn_acceder.Text = "Acceder";
            p0_btn_acceder.UseVisualStyleBackColor = true;
            p0_btn_acceder.Click += button1_Click_2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(p0_btn_acceder);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button p0_btn_acceder;
    }
}
