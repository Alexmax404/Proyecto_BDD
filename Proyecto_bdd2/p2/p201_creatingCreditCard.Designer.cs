namespace Proyecto_bdd2
{
    partial class p201_creatingCreditCard
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
            p201_cb_CardType = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            p201_btn_addCreditCard = new Button();
            SuspendLayout();
            // 
            // p201_cb_CardType
            // 
            p201_cb_CardType.FormattingEnabled = true;
            p201_cb_CardType.Location = new Point(95, 133);
            p201_cb_CardType.Name = "p201_cb_CardType";
            p201_cb_CardType.Size = new Size(241, 28);
            p201_cb_CardType.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(95, 27);
            label1.Name = "label1";
            label1.Size = new Size(241, 46);
            label1.TabIndex = 9;
            label1.Text = "Añadir tarjeta";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 110);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 10;
            label2.Text = "Tipo de tarjeta";
            // 
            // p201_btn_addCreditCard
            // 
            p201_btn_addCreditCard.Location = new Point(168, 219);
            p201_btn_addCreditCard.Name = "p201_btn_addCreditCard";
            p201_btn_addCreditCard.Size = new Size(94, 29);
            p201_btn_addCreditCard.TabIndex = 11;
            p201_btn_addCreditCard.Text = "Añadir";
            p201_btn_addCreditCard.UseVisualStyleBackColor = true;
            p201_btn_addCreditCard.Click += P201_btn_addCreditCard_Click;
            // 
            // p201_creatingCreditCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 300);
            Controls.Add(p201_btn_addCreditCard);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(p201_cb_CardType);
            Name = "p201_creatingCreditCard";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox p201_cb_CardType;
        private Label label1;
        private Label label2;
        private Button p201_btn_addCreditCard;
    }
}