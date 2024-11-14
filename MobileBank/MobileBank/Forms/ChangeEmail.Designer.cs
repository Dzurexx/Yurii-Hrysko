namespace MobileBank.Forms
{
    partial class ChangeEmail
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
            this.CloseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chandeEmailBtn = new System.Windows.Forms.Button();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(744, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(44, 40);
            this.CloseButton.TabIndex = 54;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(65, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 32);
            this.label1.TabIndex = 60;
            this.label1.Text = "Wprowadź nowy E-mail";
            // 
            // chandeEmailBtn
            // 
            this.chandeEmailBtn.Location = new System.Drawing.Point(63, 183);
            this.chandeEmailBtn.Name = "chandeEmailBtn";
            this.chandeEmailBtn.Size = new System.Drawing.Size(310, 35);
            this.chandeEmailBtn.TabIndex = 59;
            this.chandeEmailBtn.Text = "Zmienić E-mail";
            this.chandeEmailBtn.UseVisualStyleBackColor = true;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(63, 133);
            this.EmailTextBox.Multiline = true;
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(310, 44);
            this.EmailTextBox.TabIndex = 58;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(390, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 40);
            this.button1.TabIndex = 57;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ChangeEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 240);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chandeEmailBtn);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangeEmail";
            this.Text = "ChangeEmail";
            this.Load += new System.EventHandler(this.ChangeEmail_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChangeEmail_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button chandeEmailBtn;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Button button1;
    }
}