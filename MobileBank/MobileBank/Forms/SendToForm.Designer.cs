namespace MobileBank.Forms
{
    partial class SendToForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxCVV = new System.Windows.Forms.TextBox();
            this.TextBoxCardTo = new System.Windows.Forms.TextBox();
            this.TextBoxCard = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxCardDestination = new System.Windows.Forms.TextBox();
            this.TextBoxSum = new System.Windows.Forms.TextBox();
            this.SendBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TextBoxCVV);
            this.panel1.Controls.Add(this.TextBoxCardTo);
            this.panel1.Controls.Add(this.TextBoxCard);
            this.panel1.Location = new System.Drawing.Point(79, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 199);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "CVV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ważność";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Numer karty";
            // 
            // TextBoxCVV
            // 
            this.TextBoxCVV.Location = new System.Drawing.Point(175, 117);
            this.TextBoxCVV.Name = "TextBoxCVV";
            this.TextBoxCVV.Size = new System.Drawing.Size(62, 22);
            this.TextBoxCVV.TabIndex = 5;
            // 
            // TextBoxCardTo
            // 
            this.TextBoxCardTo.Location = new System.Drawing.Point(12, 117);
            this.TextBoxCardTo.Name = "TextBoxCardTo";
            this.TextBoxCardTo.Size = new System.Drawing.Size(79, 22);
            this.TextBoxCardTo.TabIndex = 4;
            // 
            // TextBoxCard
            // 
            this.TextBoxCard.Location = new System.Drawing.Point(12, 44);
            this.TextBoxCard.Name = "TextBoxCard";
            this.TextBoxCard.Size = new System.Drawing.Size(225, 22);
            this.TextBoxCard.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.TextBoxCardDestination);
            this.panel2.Location = new System.Drawing.Point(79, 322);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(384, 75);
            this.panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Karta odbiorcy";
            // 
            // TextBoxCardDestination
            // 
            this.TextBoxCardDestination.Location = new System.Drawing.Point(12, 40);
            this.TextBoxCardDestination.Name = "TextBoxCardDestination";
            this.TextBoxCardDestination.Size = new System.Drawing.Size(225, 22);
            this.TextBoxCardDestination.TabIndex = 6;
            // 
            // TextBoxSum
            // 
            this.TextBoxSum.Location = new System.Drawing.Point(91, 441);
            this.TextBoxSum.Name = "TextBoxSum";
            this.TextBoxSum.Size = new System.Drawing.Size(93, 22);
            this.TextBoxSum.TabIndex = 2;
            // 
            // SendBtn
            // 
            this.SendBtn.Location = new System.Drawing.Point(79, 495);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(438, 61);
            this.SendBtn.TabIndex = 3;
            this.SendBtn.Text = "Wysłać";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 422);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Suma";
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(553, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(35, 35);
            this.CloseButton.TabIndex = 10;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SendToForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.TextBoxSum);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SendToForm";
            this.Text = "SendToForm";
            this.Load += new System.EventHandler(this.SendToForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxCVV;
        private System.Windows.Forms.TextBox TextBoxCardTo;
        private System.Windows.Forms.TextBox TextBoxCard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxCardDestination;
        private System.Windows.Forms.TextBox TextBoxSum;
        private System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CloseButton;
    }
}