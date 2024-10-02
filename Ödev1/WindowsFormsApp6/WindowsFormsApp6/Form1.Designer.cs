
namespace WindowsFormsApp6
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Sayfa_AnaEkran = new System.Windows.Forms.TabPage();
            this.İleriButton1 = new System.Windows.Forms.Button();
            this.CalistirButton = new System.Windows.Forms.Button();
            this.checkBox_karakter = new System.Windows.Forms.CheckBox();
            this.checkBox_sayi = new System.Windows.Forms.CheckBox();
            this.checkBox_metin = new System.Windows.Forms.CheckBox();
            this.ifadeGir = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.metinGir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Sayfa_AnalizSonucları = new System.Windows.Forms.TabPage();
            this.İleriButton2 = new System.Windows.Forms.Button();
            this.SonucTemizleButton = new System.Windows.Forms.Button();
            this.GeriButton1 = new System.Windows.Forms.Button();
            this.AnalizSonuc = new System.Windows.Forms.TextBox();
            this.Sayfa_Loglama = new System.Windows.Forms.TabPage();
            this.LoglamaListe = new System.Windows.Forms.ListView();
            this.ListeTemizleButton = new System.Windows.Forms.Button();
            this.GeriButton2 = new System.Windows.Forms.Button();
            this.AnaEkranButton = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabControl1.SuspendLayout();
            this.Sayfa_AnaEkran.SuspendLayout();
            this.Sayfa_AnalizSonucları.SuspendLayout();
            this.Sayfa_Loglama.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Sayfa_AnaEkran);
            this.tabControl1.Controls.Add(this.Sayfa_AnalizSonucları);
            this.tabControl1.Controls.Add(this.Sayfa_Loglama);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(772, 471);
            this.tabControl1.TabIndex = 0;
            // 
            // Sayfa_AnaEkran
            // 
            this.Sayfa_AnaEkran.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Sayfa_AnaEkran.Controls.Add(this.İleriButton1);
            this.Sayfa_AnaEkran.Controls.Add(this.CalistirButton);
            this.Sayfa_AnaEkran.Controls.Add(this.checkBox_karakter);
            this.Sayfa_AnaEkran.Controls.Add(this.checkBox_sayi);
            this.Sayfa_AnaEkran.Controls.Add(this.checkBox_metin);
            this.Sayfa_AnaEkran.Controls.Add(this.ifadeGir);
            this.Sayfa_AnaEkran.Controls.Add(this.label2);
            this.Sayfa_AnaEkran.Controls.Add(this.metinGir);
            this.Sayfa_AnaEkran.Controls.Add(this.label1);
            this.Sayfa_AnaEkran.Location = new System.Drawing.Point(4, 25);
            this.Sayfa_AnaEkran.Name = "Sayfa_AnaEkran";
            this.Sayfa_AnaEkran.Padding = new System.Windows.Forms.Padding(3);
            this.Sayfa_AnaEkran.Size = new System.Drawing.Size(764, 442);
            this.Sayfa_AnaEkran.TabIndex = 0;
            this.Sayfa_AnaEkran.Text = "Ana Ekran";
            // 
            // İleriButton1
            // 
            this.İleriButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.İleriButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.İleriButton1.Location = new System.Drawing.Point(299, 337);
            this.İleriButton1.Name = "İleriButton1";
            this.İleriButton1.Size = new System.Drawing.Size(172, 39);
            this.İleriButton1.TabIndex = 12;
            this.İleriButton1.Text = "İleri >";
            this.İleriButton1.UseVisualStyleBackColor = false;
            this.İleriButton1.Click += new System.EventHandler(this.İleriButton1_Click);
            // 
            // CalistirButton
            // 
            this.CalistirButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CalistirButton.Location = new System.Drawing.Point(299, 278);
            this.CalistirButton.Name = "CalistirButton";
            this.CalistirButton.Size = new System.Drawing.Size(172, 39);
            this.CalistirButton.TabIndex = 11;
            this.CalistirButton.Text = "Çalıştır";
            this.CalistirButton.UseVisualStyleBackColor = false;
            this.CalistirButton.Click += new System.EventHandler(this.CalistirButton_Click);
            // 
            // checkBox_karakter
            // 
            this.checkBox_karakter.AutoSize = true;
            this.checkBox_karakter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox_karakter.Location = new System.Drawing.Point(421, 224);
            this.checkBox_karakter.Name = "checkBox_karakter";
            this.checkBox_karakter.Size = new System.Drawing.Size(86, 22);
            this.checkBox_karakter.TabIndex = 10;
            this.checkBox_karakter.Text = "Karakter";
            this.checkBox_karakter.UseVisualStyleBackColor = true;
            // 
            // checkBox_sayi
            // 
            this.checkBox_sayi.AutoSize = true;
            this.checkBox_sayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox_sayi.Location = new System.Drawing.Point(357, 224);
            this.checkBox_sayi.Name = "checkBox_sayi";
            this.checkBox_sayi.Size = new System.Drawing.Size(58, 22);
            this.checkBox_sayi.TabIndex = 9;
            this.checkBox_sayi.Text = "Sayı";
            this.checkBox_sayi.UseVisualStyleBackColor = true;
            // 
            // checkBox_metin
            // 
            this.checkBox_metin.AutoSize = true;
            this.checkBox_metin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox_metin.Location = new System.Drawing.Point(285, 224);
            this.checkBox_metin.Name = "checkBox_metin";
            this.checkBox_metin.Size = new System.Drawing.Size(66, 22);
            this.checkBox_metin.TabIndex = 8;
            this.checkBox_metin.Text = "Metin";
            this.checkBox_metin.UseVisualStyleBackColor = true;
            // 
            // ifadeGir
            // 
            this.ifadeGir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ifadeGir.Location = new System.Drawing.Point(256, 196);
            this.ifadeGir.Name = "ifadeGir";
            this.ifadeGir.Size = new System.Drawing.Size(310, 22);
            this.ifadeGir.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(115, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Aranacak İfade:";
            // 
            // metinGir
            // 
            this.metinGir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metinGir.Location = new System.Drawing.Point(256, 60);
            this.metinGir.Multiline = true;
            this.metinGir.Name = "metinGir";
            this.metinGir.Size = new System.Drawing.Size(310, 130);
            this.metinGir.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(115, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Metni Giriniz:";
            // 
            // Sayfa_AnalizSonucları
            // 
            this.Sayfa_AnalizSonucları.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Sayfa_AnalizSonucları.Controls.Add(this.İleriButton2);
            this.Sayfa_AnalizSonucları.Controls.Add(this.SonucTemizleButton);
            this.Sayfa_AnalizSonucları.Controls.Add(this.GeriButton1);
            this.Sayfa_AnalizSonucları.Controls.Add(this.AnalizSonuc);
            this.Sayfa_AnalizSonucları.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sayfa_AnalizSonucları.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Sayfa_AnalizSonucları.Location = new System.Drawing.Point(4, 25);
            this.Sayfa_AnalizSonucları.Name = "Sayfa_AnalizSonucları";
            this.Sayfa_AnalizSonucları.Padding = new System.Windows.Forms.Padding(3);
            this.Sayfa_AnalizSonucları.Size = new System.Drawing.Size(764, 442);
            this.Sayfa_AnalizSonucları.TabIndex = 1;
            this.Sayfa_AnalizSonucları.Text = "Analiz Sonuçları";
            // 
            // İleriButton2
            // 
            this.İleriButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.İleriButton2.Location = new System.Drawing.Point(439, 362);
            this.İleriButton2.Name = "İleriButton2";
            this.İleriButton2.Size = new System.Drawing.Size(128, 29);
            this.İleriButton2.TabIndex = 3;
            this.İleriButton2.Text = "İleri";
            this.İleriButton2.UseVisualStyleBackColor = false;
            this.İleriButton2.Click += new System.EventHandler(this.İleriButton2_Click);
            // 
            // SonucTemizleButton
            // 
            this.SonucTemizleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SonucTemizleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SonucTemizleButton.Location = new System.Drawing.Point(305, 362);
            this.SonucTemizleButton.Name = "SonucTemizleButton";
            this.SonucTemizleButton.Size = new System.Drawing.Size(128, 29);
            this.SonucTemizleButton.TabIndex = 2;
            this.SonucTemizleButton.Text = "Temizle";
            this.SonucTemizleButton.UseVisualStyleBackColor = false;
            this.SonucTemizleButton.Click += new System.EventHandler(this.SonucTemizleButton_Click);
            // 
            // GeriButton1
            // 
            this.GeriButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GeriButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GeriButton1.Location = new System.Drawing.Point(171, 362);
            this.GeriButton1.Name = "GeriButton1";
            this.GeriButton1.Size = new System.Drawing.Size(128, 29);
            this.GeriButton1.TabIndex = 1;
            this.GeriButton1.Text = "Geri";
            this.GeriButton1.UseVisualStyleBackColor = false;
            this.GeriButton1.Click += new System.EventHandler(this.GeriButton1_Click);
            // 
            // AnalizSonuc
            // 
            this.AnalizSonuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AnalizSonuc.Location = new System.Drawing.Point(109, 39);
            this.AnalizSonuc.Multiline = true;
            this.AnalizSonuc.Name = "AnalizSonuc";
            this.AnalizSonuc.Size = new System.Drawing.Size(540, 282);
            this.AnalizSonuc.TabIndex = 0;
            // 
            // Sayfa_Loglama
            // 
            this.Sayfa_Loglama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Sayfa_Loglama.Controls.Add(this.LoglamaListe);
            this.Sayfa_Loglama.Controls.Add(this.ListeTemizleButton);
            this.Sayfa_Loglama.Controls.Add(this.GeriButton2);
            this.Sayfa_Loglama.Controls.Add(this.AnaEkranButton);
            this.Sayfa_Loglama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sayfa_Loglama.Location = new System.Drawing.Point(4, 25);
            this.Sayfa_Loglama.Name = "Sayfa_Loglama";
            this.Sayfa_Loglama.Padding = new System.Windows.Forms.Padding(3);
            this.Sayfa_Loglama.Size = new System.Drawing.Size(764, 442);
            this.Sayfa_Loglama.TabIndex = 2;
            this.Sayfa_Loglama.Text = "Loglama";
            // 
            // LoglamaListe
            // 
            this.LoglamaListe.BackColor = System.Drawing.SystemColors.Window;
            this.LoglamaListe.HideSelection = false;
            this.LoglamaListe.Location = new System.Drawing.Point(66, 42);
            this.LoglamaListe.Name = "LoglamaListe";
            this.LoglamaListe.Size = new System.Drawing.Size(632, 292);
            this.LoglamaListe.TabIndex = 8;
            this.LoglamaListe.UseCompatibleStateImageBehavior = false;
            this.LoglamaListe.View = System.Windows.Forms.View.List;
            // 
            // ListeTemizleButton
            // 
            this.ListeTemizleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ListeTemizleButton.Location = new System.Drawing.Point(443, 361);
            this.ListeTemizleButton.Name = "ListeTemizleButton";
            this.ListeTemizleButton.Size = new System.Drawing.Size(128, 29);
            this.ListeTemizleButton.TabIndex = 7;
            this.ListeTemizleButton.Text = "Temizle";
            this.ListeTemizleButton.UseVisualStyleBackColor = false;
            this.ListeTemizleButton.Click += new System.EventHandler(this.ListeTemizleButton_Click);
            // 
            // GeriButton2
            // 
            this.GeriButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GeriButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GeriButton2.Location = new System.Drawing.Point(309, 361);
            this.GeriButton2.Name = "GeriButton2";
            this.GeriButton2.Size = new System.Drawing.Size(128, 29);
            this.GeriButton2.TabIndex = 6;
            this.GeriButton2.Text = "< Geri";
            this.GeriButton2.UseVisualStyleBackColor = false;
            this.GeriButton2.Click += new System.EventHandler(this.GeriButton2_Click);
            // 
            // AnaEkranButton
            // 
            this.AnaEkranButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AnaEkranButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AnaEkranButton.Location = new System.Drawing.Point(175, 361);
            this.AnaEkranButton.Name = "AnaEkranButton";
            this.AnaEkranButton.Size = new System.Drawing.Size(128, 29);
            this.AnaEkranButton.TabIndex = 5;
            this.AnaEkranButton.Text = "Ana Ekran";
            this.AnaEkranButton.UseVisualStyleBackColor = false;
            this.AnaEkranButton.Click += new System.EventHandler(this.AnaEkranButton_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(772, 471);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödev - 1";
            this.tabControl1.ResumeLayout(false);
            this.Sayfa_AnaEkran.ResumeLayout(false);
            this.Sayfa_AnaEkran.PerformLayout();
            this.Sayfa_AnalizSonucları.ResumeLayout(false);
            this.Sayfa_AnalizSonucları.PerformLayout();
            this.Sayfa_Loglama.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Sayfa_AnaEkran;
        private System.Windows.Forms.TabPage Sayfa_AnalizSonucları;
        private System.Windows.Forms.TabPage Sayfa_Loglama;
        private System.Windows.Forms.CheckBox checkBox_karakter;
        private System.Windows.Forms.CheckBox checkBox_sayi;
        private System.Windows.Forms.CheckBox checkBox_metin;
        private System.Windows.Forms.TextBox ifadeGir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox metinGir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button İleriButton1;
        private System.Windows.Forms.Button CalistirButton;
        private System.Windows.Forms.Button İleriButton2;
        private System.Windows.Forms.Button SonucTemizleButton;
        private System.Windows.Forms.Button GeriButton1;
        private System.Windows.Forms.TextBox AnalizSonuc;
        private System.Windows.Forms.Button ListeTemizleButton;
        private System.Windows.Forms.Button GeriButton2;
        private System.Windows.Forms.Button AnaEkranButton;
        private System.Windows.Forms.ListView LoglamaListe;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

