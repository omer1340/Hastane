namespace Hastane
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTc = new System.Windows.Forms.MaskedTextBox();
            this.buttonSorgu = new System.Windows.Forms.Button();
            this.txtİsim = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtCinsiyet = new System.Windows.Forms.TextBox();
            this.txtDogumTarih = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(11, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta Bilgisi Sorgulama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(23, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tc Kimlik Numarası :";
            // 
            // maskedTc
            // 
            this.maskedTc.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTc.Location = new System.Drawing.Point(190, 135);
            this.maskedTc.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTc.Mask = "00000000000";
            this.maskedTc.Name = "maskedTc";
            this.maskedTc.Size = new System.Drawing.Size(109, 22);
            this.maskedTc.TabIndex = 2;
            this.maskedTc.ValidatingType = typeof(int);
            // 
            // buttonSorgu
            // 
            this.buttonSorgu.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSorgu.Location = new System.Drawing.Point(310, 126);
            this.buttonSorgu.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSorgu.Name = "buttonSorgu";
            this.buttonSorgu.Size = new System.Drawing.Size(89, 35);
            this.buttonSorgu.TabIndex = 3;
            this.buttonSorgu.Text = "Sorgula";
            this.buttonSorgu.UseVisualStyleBackColor = true;
            this.buttonSorgu.Click += new System.EventHandler(this.buttonSorgu_Click);
            // 
            // txtİsim
            // 
            this.txtİsim.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtİsim.Location = new System.Drawing.Point(151, 210);
            this.txtİsim.Margin = new System.Windows.Forms.Padding(2);
            this.txtİsim.Multiline = true;
            this.txtİsim.Name = "txtİsim";
            this.txtİsim.Size = new System.Drawing.Size(122, 30);
            this.txtİsim.TabIndex = 5;
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtTel.Location = new System.Drawing.Point(151, 254);
            this.txtTel.Margin = new System.Windows.Forms.Padding(2);
            this.txtTel.Multiline = true;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(122, 32);
            this.txtTel.TabIndex = 6;
            // 
            // txtCinsiyet
            // 
            this.txtCinsiyet.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtCinsiyet.Location = new System.Drawing.Point(151, 296);
            this.txtCinsiyet.Margin = new System.Windows.Forms.Padding(2);
            this.txtCinsiyet.Multiline = true;
            this.txtCinsiyet.Name = "txtCinsiyet";
            this.txtCinsiyet.Size = new System.Drawing.Size(122, 32);
            this.txtCinsiyet.TabIndex = 7;
            // 
            // txtDogumTarih
            // 
            this.txtDogumTarih.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtDogumTarih.Location = new System.Drawing.Point(151, 339);
            this.txtDogumTarih.Margin = new System.Windows.Forms.Padding(2);
            this.txtDogumTarih.Multiline = true;
            this.txtDogumTarih.Name = "txtDogumTarih";
            this.txtDogumTarih.Size = new System.Drawing.Size(122, 32);
            this.txtDogumTarih.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label3.Location = new System.Drawing.Point(86, 215);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "İsim :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label4.Location = new System.Drawing.Point(63, 261);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Telefon :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label5.Location = new System.Drawing.Point(58, 303);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cinsiyet :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label6.Location = new System.Drawing.Point(13, 346);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Doğum Tarihi :";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 37);
            this.button1.TabIndex = 13;
            this.button1.Text = "Anasayfa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(449, 394);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDogumTarih);
            this.Controls.Add(this.txtCinsiyet);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtİsim);
            this.Controls.Add(this.buttonSorgu);
            this.Controls.Add(this.maskedTc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTc;
        private System.Windows.Forms.Button buttonSorgu;
        private System.Windows.Forms.TextBox txtİsim;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtCinsiyet;
        private System.Windows.Forms.TextBox txtDogumTarih;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}