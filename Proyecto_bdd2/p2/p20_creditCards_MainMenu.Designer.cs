namespace Proyecto_bdd2.p2
{
    partial class p20_creditCards_MainMenu
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
            p20_cb_creditCard = new ComboBox();
            p20_btn_addCreditCard = new Button();
            p20_btn_removeCreditCard = new Button();
            p20_btn_info = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(89, 9);
            label1.Name = "label1";
            label1.Size = new Size(385, 46);
            label1.TabIndex = 8;
            label1.Text = "Tus Tarjetas De Crédito";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // p20_cb_creditCard
            // 
            p20_cb_creditCard.DropDownStyle = ComboBoxStyle.DropDownList;
            p20_cb_creditCard.FormattingEnabled = true;
            p20_cb_creditCard.Location = new Point(168, 124);
            p20_cb_creditCard.Name = "p20_cb_creditCard";
            p20_cb_creditCard.Size = new Size(232, 28);
            p20_cb_creditCard.TabIndex = 9;
            p20_cb_creditCard.SelectedIndexChanged += p20_cb_creditCard_SelectedIndexChanged;
            // 
            // p20_btn_addCreditCard
            // 
            p20_btn_addCreditCard.Location = new Point(168, 209);
            p20_btn_addCreditCard.Name = "p20_btn_addCreditCard";
            p20_btn_addCreditCard.Size = new Size(94, 55);
            p20_btn_addCreditCard.TabIndex = 11;
            p20_btn_addCreditCard.Text = "Añadir tarjeta";
            p20_btn_addCreditCard.UseVisualStyleBackColor = true;
            p20_btn_addCreditCard.Click += p20_btn_addCreditCard_Click;
            // 
            // p20_btn_removeCreditCard
            // 
            p20_btn_removeCreditCard.Location = new Point(306, 209);
            p20_btn_removeCreditCard.Name = "p20_btn_removeCreditCard";
            p20_btn_removeCreditCard.Size = new Size(94, 55);
            p20_btn_removeCreditCard.TabIndex = 12;
            p20_btn_removeCreditCard.Text = "Eliminar tarjeta";
            p20_btn_removeCreditCard.UseVisualStyleBackColor = true;
            p20_btn_removeCreditCard.Click += p20_btn_removeCreditCard_Click;
            // 
            // p20_btn_info
            // 
            p20_btn_info.Location = new Point(525, 235);
            p20_btn_info.Name = "p20_btn_info";
            p20_btn_info.Size = new Size(31, 29);
            p20_btn_info.TabIndex = 13;
            p20_btn_info.Text = "ℹ";
            p20_btn_info.UseVisualStyleBackColor = true;
            p20_btn_info.Click += p20_btn_info_Click;
            // 
            // p20_creditCards_MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 276);
            Controls.Add(p20_btn_info);
            Controls.Add(p20_btn_removeCreditCard);
            Controls.Add(p20_btn_addCreditCard);
            Controls.Add(p20_cb_creditCard);
            Controls.Add(label1);
            Name = "p20_creditCards_MainMenu";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox p20_cb_creditCard;
        private Button p20_btn_addCreditCard;
        private Button p20_btn_removeCreditCard;
        private Button p20_btn_info;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}