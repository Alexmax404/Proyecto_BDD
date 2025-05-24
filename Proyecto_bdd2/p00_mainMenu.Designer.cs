namespace Proyecto_bdd2
{
    partial class p00_mainMenu
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
            p0_btn_UsarCajero = new Button();
            p0_btn_Acceder = new Button();
            p0_lb_Bienvenido = new Label();
            SuspendLayout();
            // 
            // p0_btn_UsarCajero
            // 
            p0_btn_UsarCajero.Location = new Point(112, 409);
            p0_btn_UsarCajero.Name = "p0_btn_UsarCajero";
            p0_btn_UsarCajero.Size = new Size(94, 29);
            p0_btn_UsarCajero.TabIndex = 1;
            p0_btn_UsarCajero.Text = "Usar Cajero";
            p0_btn_UsarCajero.UseVisualStyleBackColor = true;
            p0_btn_UsarCajero.Click += p0_btn_UsarCajero_Click;
            // 
            // p0_btn_Acceder
            // 
            p0_btn_Acceder.Location = new Point(3, 409);
            p0_btn_Acceder.Name = "p0_btn_Acceder";
            p0_btn_Acceder.Size = new Size(94, 29);
            p0_btn_Acceder.TabIndex = 2;
            p0_btn_Acceder.Text = "Acceder";
            p0_btn_Acceder.UseVisualStyleBackColor = true;
            p0_btn_Acceder.Click += p0_btn_Acceder_Click;
            // 
            // p0_lb_Bienvenido
            // 
            p0_lb_Bienvenido.AutoSize = true;
            p0_lb_Bienvenido.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            p0_lb_Bienvenido.Location = new Point(21, 33);
            p0_lb_Bienvenido.Name = "p0_lb_Bienvenido";
            p0_lb_Bienvenido.Size = new Size(185, 46);
            p0_lb_Bienvenido.TabIndex = 3;
            p0_lb_Bienvenido.Text = "Bienvenido";
            p0_lb_Bienvenido.Click += p0_lb_Bienvenido_Click;
            // 
            // p00_mainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(p0_lb_Bienvenido);
            Controls.Add(p0_btn_Acceder);
            Controls.Add(p0_btn_UsarCajero);
            Name = "p00_mainMenu";
            Text = " ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button p0_btn_UsarCajero;
        private Button p0_btn_Acceder;
        private Label p0_lb_Bienvenido;
    }
}
