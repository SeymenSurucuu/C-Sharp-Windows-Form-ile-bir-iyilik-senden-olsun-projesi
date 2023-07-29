namespace gorselprogramlamaproje
{
    partial class kayit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kullaniciaditext = new System.Windows.Forms.TextBox();
            this.sifretext = new System.Windows.Forms.TextBox();
            this.adsoyadtext = new System.Windows.Forms.TextBox();
            this.button_kaydet = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.erkek = new System.Windows.Forms.RadioButton();
            this.kadin = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(36, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adınız Soyadınız: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(36, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kullanıcı Adı: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(36, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifreniz: ";
            // 
            // kullaniciaditext
            // 
            this.kullaniciaditext.Location = new System.Drawing.Point(222, 157);
            this.kullaniciaditext.Name = "kullaniciaditext";
            this.kullaniciaditext.Size = new System.Drawing.Size(176, 22);
            this.kullaniciaditext.TabIndex = 4;
            // 
            // sifretext
            // 
            this.sifretext.Location = new System.Drawing.Point(222, 207);
            this.sifretext.Name = "sifretext";
            this.sifretext.Size = new System.Drawing.Size(176, 22);
            this.sifretext.TabIndex = 5;
            // 
            // adsoyadtext
            // 
            this.adsoyadtext.Location = new System.Drawing.Point(222, 112);
            this.adsoyadtext.Name = "adsoyadtext";
            this.adsoyadtext.Size = new System.Drawing.Size(176, 22);
            this.adsoyadtext.TabIndex = 6;
            this.adsoyadtext.TextChanged += new System.EventHandler(this.adsoyadtext_TextChanged);
            // 
            // button_kaydet
            // 
            this.button_kaydet.BackColor = System.Drawing.Color.Transparent;
            this.button_kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_kaydet.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button_kaydet.Location = new System.Drawing.Point(251, 293);
            this.button_kaydet.Name = "button_kaydet";
            this.button_kaydet.Size = new System.Drawing.Size(147, 36);
            this.button_kaydet.TabIndex = 7;
            this.button_kaydet.Text = "Kayıt Ol";
            this.button_kaydet.UseVisualStyleBackColor = false;
            this.button_kaydet.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button2.Location = new System.Drawing.Point(41, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 36);
            this.button2.TabIndex = 8;
            this.button2.Text = "Giriş Ekranı";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::gorselprogramlamaproje.Properties.Resources._2080904;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(79, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 63);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(177, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 39);
            this.label4.TabIndex = 10;
            this.label4.Text = "Kayıt Ekranı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(36, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cinsiyetiniz: ";
            // 
            // erkek
            // 
            this.erkek.AutoSize = true;
            this.erkek.BackColor = System.Drawing.Color.Transparent;
            this.erkek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.erkek.Location = new System.Drawing.Point(222, 248);
            this.erkek.Name = "erkek";
            this.erkek.Size = new System.Drawing.Size(62, 21);
            this.erkek.TabIndex = 12;
            this.erkek.TabStop = true;
            this.erkek.Text = "Erkek";
            this.erkek.UseVisualStyleBackColor = false;
            // 
            // kadin
            // 
            this.kadin.AutoSize = true;
            this.kadin.BackColor = System.Drawing.Color.Transparent;
            this.kadin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.kadin.Location = new System.Drawing.Point(326, 248);
            this.kadin.Name = "kadin";
            this.kadin.Size = new System.Drawing.Size(62, 21);
            this.kadin.TabIndex = 13;
            this.kadin.TabStop = true;
            this.kadin.Text = "Kadın";
            this.kadin.UseVisualStyleBackColor = false;
            // 
            // kayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::gorselprogramlamaproje.Properties.Resources._360_F_355607062_zYMS8jaz4SfoykpWz5oViRVKL32IabTP;
            this.ClientSize = new System.Drawing.Size(419, 351);
            this.Controls.Add(this.kadin);
            this.Controls.Add(this.erkek);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_kaydet);
            this.Controls.Add(this.adsoyadtext);
            this.Controls.Add(this.sifretext);
            this.Controls.Add(this.kullaniciaditext);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "kayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıt Formu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox kullaniciaditext;
        private System.Windows.Forms.TextBox sifretext;
        private System.Windows.Forms.TextBox adsoyadtext;
        private System.Windows.Forms.Button button_kaydet;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton erkek;
        private System.Windows.Forms.RadioButton kadin;
    }
}

