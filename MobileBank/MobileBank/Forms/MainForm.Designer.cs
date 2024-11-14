namespace MobileBank
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CardTextBox = new System.Windows.Forms.TextBox();
            this.payBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.cardsComboBox = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonComunal = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonArmy = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonCredit = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.buttonInternet = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonPhone = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label_cardNumber = new System.Windows.Forms.Label();
            this.label_cardTo = new System.Windows.Forms.Label();
            this.label_cardCvv = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.currencyLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBoxMasterCard = new System.Windows.Forms.PictureBox();
            this.pictureBoxVisa = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMasterCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVisa)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CardTextBox);
            this.panel1.Controls.Add(this.payBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(139, 545);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 130);
            this.panel1.TabIndex = 0;
            // 
            // CardTextBox
            // 
            this.CardTextBox.Location = new System.Drawing.Point(60, 66);
            this.CardTextBox.Name = "CardTextBox";
            this.CardTextBox.Size = new System.Drawing.Size(228, 22);
            this.CardTextBox.TabIndex = 23;
            // 
            // payBtn
            // 
            this.payBtn.Location = new System.Drawing.Point(284, 22);
            this.payBtn.Name = "payBtn";
            this.payBtn.Size = new System.Drawing.Size(33, 32);
            this.payBtn.TabIndex = 22;
            this.payBtn.Text = ">";
            this.payBtn.UseVisualStyleBackColor = true;
            this.payBtn.Click += new System.EventHandler(this.payBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Przelew na kartę";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MobileBank.Properties.Resources.іконка_карти;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonClose);
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 56);
            this.panel2.TabIndex = 1;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(853, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(35, 35);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::MobileBank.Properties.Resources.pngegg;
            this.pictureBox6.Location = new System.Drawing.Point(647, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(45, 45);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 7;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::MobileBank.Properties.Resources.іcо_історія_покупок;
            this.pictureBox4.Location = new System.Drawing.Point(54, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(45, 45);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::MobileBank.Properties.Resources.іcо_профілю;
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // cardsComboBox
            // 
            this.cardsComboBox.FormattingEnabled = true;
            this.cardsComboBox.Location = new System.Drawing.Point(340, 113);
            this.cardsComboBox.Name = "cardsComboBox";
            this.cardsComboBox.Size = new System.Drawing.Size(195, 24);
            this.cardsComboBox.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonComunal);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.pictureBox8);
            this.panel3.Location = new System.Drawing.Point(139, 681);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(320, 80);
            this.panel3.TabIndex = 1;
            // 
            // buttonComunal
            // 
            this.buttonComunal.Location = new System.Drawing.Point(284, 21);
            this.buttonComunal.Name = "buttonComunal";
            this.buttonComunal.Size = new System.Drawing.Size(33, 32);
            this.buttonComunal.TabIndex = 23;
            this.buttonComunal.Text = ">";
            this.buttonComunal.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Opłaty komunalne";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::MobileBank.Properties.Resources.іcо_комуналка;
            this.pictureBox8.Location = new System.Drawing.Point(3, 3);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(50, 50);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 18;
            this.pictureBox8.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.buttonArmy);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.pictureBox9);
            this.panel4.Location = new System.Drawing.Point(139, 767);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(320, 80);
            this.panel4.TabIndex = 2;
            // 
            // buttonArmy
            // 
            this.buttonArmy.Location = new System.Drawing.Point(284, 23);
            this.buttonArmy.Name = "buttonArmy";
            this.buttonArmy.Size = new System.Drawing.Size(33, 32);
            this.buttonArmy.TabIndex = 21;
            this.buttonArmy.Text = ">";
            this.buttonArmy.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(153, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Pomoc armii";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::MobileBank.Properties.Resources.ico_донат_армії;
            this.pictureBox9.Location = new System.Drawing.Point(3, 3);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(50, 59);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 19;
            this.pictureBox9.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(261, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Karty:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.buttonCredit);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.pictureBox10);
            this.panel5.Location = new System.Drawing.Point(471, 767);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(320, 80);
            this.panel5.TabIndex = 5;
            // 
            // buttonCredit
            // 
            this.buttonCredit.Location = new System.Drawing.Point(278, 15);
            this.buttonCredit.Name = "buttonCredit";
            this.buttonCredit.Size = new System.Drawing.Size(33, 32);
            this.buttonCredit.TabIndex = 26;
            this.buttonCredit.Text = ">";
            this.buttonCredit.UseVisualStyleBackColor = true;
            this.buttonCredit.Click += new System.EventHandler(this.buttonCredit_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(131, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 16);
            this.label12.TabIndex = 21;
            this.label12.Text = "Kredyty";
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::MobileBank.Properties.Resources.ico_кридит;
            this.pictureBox10.Location = new System.Drawing.Point(3, 3);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(50, 50);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 20;
            this.pictureBox10.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.buttonInternet);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.pictureBox7);
            this.panel6.Location = new System.Drawing.Point(471, 681);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(320, 80);
            this.panel6.TabIndex = 4;
            // 
            // buttonInternet
            // 
            this.buttonInternet.Location = new System.Drawing.Point(278, 21);
            this.buttonInternet.Name = "buttonInternet";
            this.buttonInternet.Size = new System.Drawing.Size(33, 32);
            this.buttonInternet.TabIndex = 24;
            this.buttonInternet.Text = ">";
            this.buttonInternet.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Internet i TV";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::MobileBank.Properties.Resources.Ico_Wi_Fi;
            this.pictureBox7.Location = new System.Drawing.Point(3, 3);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(50, 50);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 17;
            this.pictureBox7.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.textBox1);
            this.panel7.Controls.Add(this.buttonPhone);
            this.panel7.Controls.Add(this.label11);
            this.panel7.Controls.Add(this.pictureBox2);
            this.panel7.Location = new System.Drawing.Point(471, 545);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(320, 130);
            this.panel7.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 22);
            this.textBox1.TabIndex = 26;
            // 
            // buttonPhone
            // 
            this.buttonPhone.Location = new System.Drawing.Point(278, 56);
            this.buttonPhone.Name = "buttonPhone";
            this.buttonPhone.Size = new System.Drawing.Size(33, 32);
            this.buttonPhone.TabIndex = 25;
            this.buttonPhone.Text = ">";
            this.buttonPhone.UseVisualStyleBackColor = true;
            this.buttonPhone.Click += new System.EventHandler(this.buttonPhone_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(75, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(227, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "Uzupełnienie telefonu komórkowego";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MobileBank.Properties.Resources.іcо_телефон;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(549, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "Dodać";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label_cardNumber
            // 
            this.label_cardNumber.AutoSize = true;
            this.label_cardNumber.Location = new System.Drawing.Point(242, 336);
            this.label_cardNumber.Name = "label_cardNumber";
            this.label_cardNumber.Size = new System.Drawing.Size(55, 16);
            this.label_cardNumber.TabIndex = 10;
            this.label_cardNumber.Text = "Number";
            // 
            // label_cardTo
            // 
            this.label_cardTo.AutoSize = true;
            this.label_cardTo.Location = new System.Drawing.Point(263, 371);
            this.label_cardTo.Name = "label_cardTo";
            this.label_cardTo.Size = new System.Drawing.Size(24, 16);
            this.label_cardTo.TabIndex = 11;
            this.label_cardTo.Text = "To";
            // 
            // label_cardCvv
            // 
            this.label_cardCvv.AutoSize = true;
            this.label_cardCvv.Location = new System.Drawing.Point(393, 371);
            this.label_cardCvv.Name = "label_cardCvv";
            this.label_cardCvv.Size = new System.Drawing.Size(57, 16);
            this.label_cardCvv.TabIndex = 12;
            this.label_cardCvv.Text = "CVVkod";
            this.label_cardCvv.Click += new System.EventHandler(this.label_cardCvv_Click);
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Location = new System.Drawing.Point(274, 404);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(57, 16);
            this.balanceLabel.TabIndex = 13;
            this.balanceLabel.Text = "Balance";
            // 
            // currencyLabel
            // 
            this.currencyLabel.AutoSize = true;
            this.currencyLabel.Location = new System.Drawing.Point(225, 404);
            this.currencyLabel.Name = "currencyLabel";
            this.currencyLabel.Size = new System.Drawing.Size(43, 16);
            this.currencyLabel.TabIndex = 14;
            this.currencyLabel.Text = "valuta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(186, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Ważne do:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(353, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "CVV";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::MobileBank.Properties.Resources._0vki3lp8c5fde4r1mkpv04kji5_fe2251d1b77d2e638a6bee9e5de4cf86;
            this.pictureBox5.Location = new System.Drawing.Point(843, 62);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(45, 45);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBoxMasterCard
            // 
            this.pictureBoxMasterCard.Image = global::MobileBank.Properties.Resources.карта2;
            this.pictureBoxMasterCard.Location = new System.Drawing.Point(154, 162);
            this.pictureBoxMasterCard.Name = "pictureBoxMasterCard";
            this.pictureBoxMasterCard.Size = new System.Drawing.Size(500, 300);
            this.pictureBoxMasterCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMasterCard.TabIndex = 3;
            this.pictureBoxMasterCard.TabStop = false;
            // 
            // pictureBoxVisa
            // 
            this.pictureBoxVisa.Image = global::MobileBank.Properties.Resources.Карта1;
            this.pictureBoxVisa.Location = new System.Drawing.Point(199, 179);
            this.pictureBoxVisa.Name = "pictureBoxVisa";
            this.pictureBoxVisa.Size = new System.Drawing.Size(500, 300);
            this.pictureBoxVisa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxVisa.TabIndex = 2;
            this.pictureBoxVisa.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 857);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.currencyLabel);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.label_cardCvv);
            this.Controls.Add(this.label_cardTo);
            this.Controls.Add(this.label_cardNumber);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.cardsComboBox);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBoxMasterCard);
            this.Controls.Add(this.pictureBoxVisa);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMasterCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVisa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBoxVisa;
        private System.Windows.Forms.PictureBox pictureBoxMasterCard;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.ComboBox cardsComboBox;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_cardNumber;
        private System.Windows.Forms.Label label_cardTo;
        private System.Windows.Forms.Label label_cardCvv;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Label currencyLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button payBtn;
        private System.Windows.Forms.Button buttonComunal;
        private System.Windows.Forms.Button buttonArmy;
        private System.Windows.Forms.Button buttonCredit;
        private System.Windows.Forms.Button buttonInternet;
        private System.Windows.Forms.Button buttonPhone;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox CardTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
    }
}