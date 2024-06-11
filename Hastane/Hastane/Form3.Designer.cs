namespace Hastane
{
    partial class Form3
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedTc = new System.Windows.Forms.MaskedTextBox();
            this.maskedTarih = new System.Windows.Forms.MaskedTextBox();
            this.comboBölüm = new System.Windows.Forms.ComboBox();
            this.comboDoktor = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboSaat = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboDoktor2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.maskedTarih2 = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBölüm2 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(70, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Randevu Al";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(22, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tc Kimlik Numarası :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(118, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bölüm :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(113, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Doktor :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(55, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Randevu Tarihi :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(57, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Randevu Saati :";
            // 
            // maskedTc
            // 
            this.maskedTc.Location = new System.Drawing.Point(196, 139);
            this.maskedTc.Mask = "00000000000";
            this.maskedTc.Name = "maskedTc";
            this.maskedTc.Size = new System.Drawing.Size(136, 20);
            this.maskedTc.TabIndex = 6;
            this.maskedTc.ValidatingType = typeof(int);
            // 
            // maskedTarih
            // 
            this.maskedTarih.Location = new System.Drawing.Point(196, 219);
            this.maskedTarih.Mask = "0000/00/00";
            this.maskedTarih.Name = "maskedTarih";
            this.maskedTarih.Size = new System.Drawing.Size(136, 20);
            this.maskedTarih.TabIndex = 7;
            this.maskedTarih.ValidatingType = typeof(System.DateTime);
            // 
            // comboBölüm
            // 
            this.comboBölüm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBölüm.FormattingEnabled = true;
            this.comboBölüm.Location = new System.Drawing.Point(196, 165);
            this.comboBölüm.Name = "comboBölüm";
            this.comboBölüm.Size = new System.Drawing.Size(136, 21);
            this.comboBölüm.TabIndex = 9;
            this.comboBölüm.SelectedIndexChanged += new System.EventHandler(this.comboBölüm_SelectedIndexChanged);
            // 
            // comboDoktor
            // 
            this.comboDoktor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDoktor.FormattingEnabled = true;
            this.comboDoktor.Location = new System.Drawing.Point(196, 192);
            this.comboDoktor.Name = "comboDoktor";
            this.comboDoktor.Size = new System.Drawing.Size(136, 21);
            this.comboDoktor.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(131, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 43);
            this.button1.TabIndex = 11;
            this.button1.Text = "Randevu Al";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboSaat
            // 
            this.comboSaat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSaat.FormattingEnabled = true;
            this.comboSaat.Location = new System.Drawing.Point(196, 241);
            this.comboSaat.Name = "comboSaat";
            this.comboSaat.Size = new System.Drawing.Size(136, 21);
            this.comboSaat.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(338, 188);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(581, 150);
            this.dataGridView1.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(399, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(366, 54);
            this.label7.TabIndex = 14;
            this.label7.Text = "Randevu Görüntüle";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(349, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Bölüm :";
            // 
            // comboDoktor2
            // 
            this.comboDoktor2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDoktor2.FormattingEnabled = true;
            this.comboDoktor2.Location = new System.Drawing.Point(427, 139);
            this.comboDoktor2.Name = "comboDoktor2";
            this.comboDoktor2.Size = new System.Drawing.Size(136, 21);
            this.comboDoktor2.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(344, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "Doktor :";
            // 
            // maskedTarih2
            // 
            this.maskedTarih2.Location = new System.Drawing.Point(710, 126);
            this.maskedTarih2.Mask = "0000/00/00";
            this.maskedTarih2.Name = "maskedTarih2";
            this.maskedTarih2.Size = new System.Drawing.Size(136, 20);
            this.maskedTarih2.TabIndex = 20;
            this.maskedTarih2.ValidatingType = typeof(System.DateTime);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(569, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 25);
            this.label10.TabIndex = 19;
            this.label10.Text = "Randevu Tarihi :";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(852, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 50);
            this.button2.TabIndex = 23;
            this.button2.Text = "Göster";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBölüm2
            // 
            this.comboBölüm2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBölüm2.FormattingEnabled = true;
            this.comboBölüm2.Location = new System.Drawing.Point(427, 107);
            this.comboBölüm2.Name = "comboBölüm2";
            this.comboBölüm2.Size = new System.Drawing.Size(136, 21);
            this.comboBölüm2.TabIndex = 24;
            this.comboBölüm2.SelectedIndexChanged += new System.EventHandler(this.comboBölüm2_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(13, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 34);
            this.button3.TabIndex = 25;
            this.button3.Text = "Anasayfa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(935, 354);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBölüm2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.maskedTarih2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboDoktor2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboSaat);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboDoktor);
            this.Controls.Add(this.comboBölüm);
            this.Controls.Add(this.maskedTarih);
            this.Controls.Add(this.maskedTc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskedTc;
        private System.Windows.Forms.MaskedTextBox maskedTarih;
        private System.Windows.Forms.ComboBox comboBölüm;
        private System.Windows.Forms.ComboBox comboDoktor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboSaat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboDoktor2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox maskedTarih2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBölüm2;
        private System.Windows.Forms.Button button3;
    }
}