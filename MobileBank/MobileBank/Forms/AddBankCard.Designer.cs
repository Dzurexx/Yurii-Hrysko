namespace MobileBank.Forms
{
    partial class AddBankCard
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
            this.CloseButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addCardButton = new System.Windows.Forms.Button();
            this.cardTypeСomboBox = new System.Windows.Forms.ComboBox();
            this.currencyComboBox = new System.Windows.Forms.ComboBox();
            this.paymentSystemComboBox = new System.Windows.Forms.ComboBox();
            this.numericUpDownPin = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPin)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.Location = new System.Drawing.Point(237, 9);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(26, 25);
            this.CloseButton.TabIndex = 32;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "Typ karty";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "System płatniści";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "PIN kod";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 36;
            this.label4.Text = "Waluta";
            // 
            // addCardButton
            // 
            this.addCardButton.Location = new System.Drawing.Point(15, 329);
            this.addCardButton.Name = "addCardButton";
            this.addCardButton.Size = new System.Drawing.Size(248, 44);
            this.addCardButton.TabIndex = 37;
            this.addCardButton.Text = "Tworzyć";
            this.addCardButton.UseVisualStyleBackColor = true;
            this.addCardButton.Click += new System.EventHandler(this.addCardButton_Click);
            // 
            // cardTypeСomboBox
            // 
            this.cardTypeСomboBox.FormattingEnabled = true;
            this.cardTypeСomboBox.Location = new System.Drawing.Point(15, 69);
            this.cardTypeСomboBox.Name = "cardTypeСomboBox";
            this.cardTypeСomboBox.Size = new System.Drawing.Size(248, 24);
            this.cardTypeСomboBox.TabIndex = 38;
            // 
            // currencyComboBox
            // 
            this.currencyComboBox.FormattingEnabled = true;
            this.currencyComboBox.Location = new System.Drawing.Point(12, 131);
            this.currencyComboBox.Name = "currencyComboBox";
            this.currencyComboBox.Size = new System.Drawing.Size(248, 24);
            this.currencyComboBox.TabIndex = 39;
            // 
            // paymentSystemComboBox
            // 
            this.paymentSystemComboBox.FormattingEnabled = true;
            this.paymentSystemComboBox.Location = new System.Drawing.Point(12, 204);
            this.paymentSystemComboBox.Name = "paymentSystemComboBox";
            this.paymentSystemComboBox.Size = new System.Drawing.Size(248, 24);
            this.paymentSystemComboBox.TabIndex = 40;
            // 
            // numericUpDownPin
            // 
            this.numericUpDownPin.Location = new System.Drawing.Point(15, 274);
            this.numericUpDownPin.Name = "numericUpDownPin";
            this.numericUpDownPin.Size = new System.Drawing.Size(245, 22);
            this.numericUpDownPin.TabIndex = 41;
            // 
            // AddBankCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 385);
            this.Controls.Add(this.numericUpDownPin);
            this.Controls.Add(this.paymentSystemComboBox);
            this.Controls.Add(this.currencyComboBox);
            this.Controls.Add(this.cardTypeСomboBox);
            this.Controls.Add(this.addCardButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddBankCard";
            this.Text = "AddBankCard";
            this.Load += new System.EventHandler(this.AddBankCard_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddBankCard_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addCardButton;
        private System.Windows.Forms.ComboBox cardTypeСomboBox;
        private System.Windows.Forms.ComboBox currencyComboBox;
        private System.Windows.Forms.ComboBox paymentSystemComboBox;
        private System.Windows.Forms.NumericUpDown numericUpDownPin;
    }
}