namespace Hastane
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtİsim = new System.Windows.Forms.TextBox();
            this.masktxtTc = new System.Windows.Forms.MaskedTextBox();
            this.masktxtTel = new System.Windows.Forms.MaskedTextBox();
            this.masktxtDogum = new System.Windows.Forms.MaskedTextBox();
            this.Kaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboCinsiyet = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtİsim
            // 
            this.txtİsim.Location = new System.Drawing.Point(232, 129);
            this.txtİsim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtİsim.Name = "txtİsim";
            this.txtİsim.Size = new System.Drawing.Size(139, 20);
            this.txtİsim.TabIndex = 0;
            // 
            // masktxtTc
            // 
            this.masktxtTc.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.masktxtTc.Location = new System.Drawing.Point(232, 104);
            this.masktxtTc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.masktxtTc.Mask = "00000000000";
            this.masktxtTc.Name = "masktxtTc";
            this.masktxtTc.Size = new System.Drawing.Size(139, 22);
            this.masktxtTc.TabIndex = 1;
            this.masktxtTc.ValidatingType = typeof(int);
            // 
            // masktxtTel
            // 
            this.masktxtTel.Location = new System.Drawing.Point(232, 154);
            this.masktxtTel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.masktxtTel.Mask = "(999) 000-0000";
            this.masktxtTel.Name = "masktxtTel";
            this.masktxtTel.Size = new System.Drawing.Size(139, 20);
            this.masktxtTel.TabIndex = 2;
            // 
            // masktxtDogum
            // 
            this.masktxtDogum.Location = new System.Drawing.Point(232, 203);
            this.masktxtDogum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.masktxtDogum.Mask = "0000/00/00";
            this.masktxtDogum.Name = "masktxtDogum";
            this.masktxtDogum.Size = new System.Drawing.Size(139, 20);
            this.masktxtDogum.TabIndex = 4;
            this.masktxtDogum.ValidatingType = typeof(System.DateTime);
            // 
            // Kaydet
            // 
            this.Kaydet.Location = new System.Drawing.Point(170, 248);
            this.Kaydet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Kaydet.Name = "Kaydet";
            this.Kaydet.Size = new System.Drawing.Size(97, 41);
            this.Kaydet.TabIndex = 5;
            this.Kaydet.Text = "Kaydet";
            this.Kaydet.UseVisualStyleBackColor = true;
            this.Kaydet.Click += new System.EventHandler(this.Kaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(112, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 54);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hasta Kayıt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label2.Location = new System.Drawing.Point(66, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tc Kimlik Numarası :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label3.Location = new System.Drawing.Point(172, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "İsim :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label4.Location = new System.Drawing.Point(148, 147);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Telefon :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label5.Location = new System.Drawing.Point(146, 171);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cinsiyet :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label6.Location = new System.Drawing.Point(105, 197);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Doğum Tarihi :";
            // 
            // comboCinsiyet
            // 
            this.comboCinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCinsiyet.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboCinsiyet.FormattingEnabled = true;
            this.comboCinsiyet.Items.AddRange(new object[] {
            "E",
            "K"});
            this.comboCinsiyet.Location = new System.Drawing.Point(232, 176);
            this.comboCinsiyet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboCinsiyet.Name = "comboCinsiyet";
            this.comboCinsiyet.Size = new System.Drawing.Size(139, 21);
            this.comboCinsiyet.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(6, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 34);
            this.button1.TabIndex = 13;
            this.button1.Text = "Anasayfa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(444, 328);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboCinsiyet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Kaydet);
            this.Controls.Add(this.masktxtDogum);
            this.Controls.Add(this.masktxtTel);
            this.Controls.Add(this.masktxtTc);
            this.Controls.Add(this.txtİsim);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtİsim;
        private System.Windows.Forms.MaskedTextBox masktxtTc;
        private System.Windows.Forms.MaskedTextBox masktxtTel;
        private System.Windows.Forms.MaskedTextBox masktxtDogum;
        private System.Windows.Forms.Button Kaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboCinsiyet;
        private System.Windows.Forms.Button button1;
    }
}

