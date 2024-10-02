using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //bildirim baloncuğu için gerekli özellikler
            notifyIcon1.BalloonTipText = "Programa Hoş Geldiniz!";
            notifyIcon1.BalloonTipTitle = "Nesne Yönelimli Programlama Ödev 1";

            //ekranda kalması gereken saniyeyi ayarlar
            notifyIcon1.ShowBalloonTip(30000);
        }

        //checkboxlar için gerekli kontrolleri sağlayan fonksiyon
        private bool KeywordMatchesSelectedCriteria(string keyword, bool checkLetter, bool checkNumber, bool checkSymbol)
        {
            bool isMatch = true;
            foreach (char c in keyword)
            {
                if (char.IsLetter(c) && !checkLetter)
                {
                    isMatch = false;
                    break;
                }
                if (char.IsNumber(c) && !checkNumber)
                {
                    isMatch = false;
                    break;
                }
                if (!char.IsLetterOrDigit(c) && !checkSymbol)
                {
                    isMatch = false;
                    break;
                }
            }
            return isMatch;
        }

        private int Analiz_MetinUzunlugu(string metin)
        {
            return metin.Length; //metin uzunluğunu döndürür
        }

        private void CalistirButton_Click(object sender, EventArgs e)
        {
            string metin = metinGir.Text;
            string ifadeAra = ifadeGir.Text;
            bool metin_sec = checkBox_metin.Checked;
            bool sayi_sec = checkBox_sayi.Checked;
            bool karakter_sec = checkBox_karakter.Checked;

            if (string.IsNullOrEmpty(metin)) // Metin kutusu boş mu diye kontrol eder
            {
                MessageBox.Show("Metin kutusu boş bırakılamaz");
                return;
            }

            if (string.IsNullOrEmpty(ifadeAra)) // Aranacak ifade kutusu boş mu diye kontrol eder
            {
                MessageBox.Show("Aranacak ifade kutusu boş bırakılamaz");
                return;
            }

            if (!metin_sec && !sayi_sec && !karakter_sec) // En az bir kutucuğun seçilip seçilmediğini kontrol eder
            {
                MessageBox.Show("Kutucuklardan en az birini seçiniz.");
                return;
            }

            // Anahtar kelimenin seçilen kriterlere uygun olup olmadığını kontrol et
            bool isMatch = KeywordMatchesSelectedCriteria(ifadeAra, metin_sec, sayi_sec, karakter_sec);

            if (!isMatch)
            {
                MessageBox.Show("Seçilen Kutucuk Aranan İfadeye Uygun Değil!");
            }

            //hesaplamalar
            int metin_uzunlugu = Analiz_MetinUzunlugu(metin);
            bool ifade_kontrol = Analiz_Aranan_Kontrol(metin, ifadeAra, out int indexOfifadeAra);
            int ifade_sayisi = Analiz_ifadeSayisi(metin, ifadeAra);

            // Sonuçları ekranda gösterir
            AnalizSonuc.Text = "Metin Uzunluğu: " + metin_uzunlugu + Environment.NewLine;
            AnalizSonuc.Text += "Aranan İfade Var Mı? : " + (ifade_kontrol ? "Evet" : "Hayır") + Environment.NewLine;
            AnalizSonuc.Text += "İlk Geçen İndex: " + (ifade_kontrol ? indexOfifadeAra.ToString() : "Yok") + Environment.NewLine;
            AnalizSonuc.Text += "Aranan İfade Sayısı: " + ifade_sayisi;

            Loglama(ifadeAra, ifade_sayisi, metin_uzunlugu);
        }

        // Metin içinde belirli bir ifadenin olup olmadığını ve ilk geçtiği indeksi döndüren fonksiyon
        private bool Analiz_Aranan_Kontrol(string metin, string ifadeAra, out int indexOfifadeAra)
        {
            indexOfifadeAra = metin.IndexOf(ifadeAra);
            return indexOfifadeAra >= 0;
        }

        // Metin içinde belirli bir ifadenin kaç kez geçtiğini döndüren fonksiyon
        private int Analiz_ifadeSayisi(string metin, string ifadeAra)
        {
            int sayac = 0;
            int index = 0;

            while ((index = metin.IndexOf(ifadeAra, index)) != -1)
                {
                    index += ifadeAra.Length;
                    sayac++;
                }
            return sayac;
        }

        // Loglama listesine sonuçları ekleyen fonksiyon
        private void Loglama(string ifadeAra, int ifade_sayisi, int metin_uzunlugu)
        {
            int ListeIndex = LoglamaListe.Items.Count + 1;
            string sonuc = $"{ListeIndex}. Metinde '{ifadeAra}' ifadesi aranmış ve {ifade_sayisi} defa bulunmuştur. Metnin uzunluğu {metin_uzunlugu}'dir.";

            LoglamaListe.Items.Add(sonuc);
        }

        // İleri ve geri fonksiyonları
        private void İleriButton1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void İleriButton2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void GeriButton1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void AnaEkranButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void GeriButton2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        // Loglama listesini temizleme
        private void ListeTemizleButton_Click(object sender, EventArgs e)
        {
            LoglamaListe.Items.Clear();
        }

        // Analiz sonuç kutusunu temizleme
        private void SonucTemizleButton_Click(object sender, EventArgs e)
        {
            AnalizSonuc.Clear();
        }
    }
}
