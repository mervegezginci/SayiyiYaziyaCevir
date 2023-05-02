/****************************************************************************
**				   SAKARYA ÜNİVERSİTESİ
**		  BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**			  BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**			 NESNEYE DAYALI PROGRAMLAMA DERSİ
**                2021-2022 BAHAR DÖNEMİ
**
**				ÖDEV NUMARASI: 2
**				ÖĞRENCİ ADI: MERVE GEZGİNCİ
**				ÖĞRENCİ NUMARASI: B201210085
**				DERSİN ALINDIĞI GRUP: B
****************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        char[] ayrac = { ',', '.' };
        int virgulOncesi = 0;
        int virgulSonrasi = 0;
        string yazi;
        int basamakSayisi;
        public Form1()
        {
            InitializeComponent();
        }
        private string yaziyaCevir(string Sayi)
        {
            // Fonksiyon Hesabı
            if (txtSayi.Text != "")
            {
                yazi = " ";
                string sayi = txtSayi.Text.Trim();
                double rakamliSayi = Convert.ToDouble(sayi);

                string[] parcalar = sayi.Split(ayrac);
                int virgul_OncesiSonrasi = parcalar.Length;

                if (virgul_OncesiSonrasi == 1)
                {
                    virgulOncesi = Convert.ToInt32(parcalar[0]);
                    virgulSonrasi = 0;
                }
                if (virgul_OncesiSonrasi == 2)
                {
                    virgulOncesi = Convert.ToInt32(parcalar[0]);
                    virgulSonrasi = Convert.ToInt32(parcalar[1]);
                }
                string virgulOncesiSayi = Convert.ToString(virgulOncesi);
                string virgulSonrasiSayi = Convert.ToString(virgulSonrasi);
                if(virgulSonrasi==0)
                {
                    basamakSayisi = virgulOncesiSayi.Length + (virgulSonrasiSayi.Length - 1);
                }
                if(virgulSonrasi!=0)
                {
                    basamakSayisi = virgulOncesiSayi.Length + virgulSonrasiSayi.Length;
                }

                if (basamakSayisi <= 6)
                {
                    if (virgulOncesi <= 999999 && virgulOncesi >= 0)
                    {
                        switch (virgulOncesi / 100000)
                        {
                            case 9: yazi += "Dokuzyüz "; break;
                            case 8: yazi += "Sekizyüz "; break;
                            case 7: yazi += "Yediyüz "; break;
                            case 6: yazi += "Altıyüz "; break;
                            case 5: yazi += "Beşyüz "; break;
                            case 4: yazi += "Dörtyüz "; break;
                            case 3: yazi += "Üçyüz "; break;
                            case 2: yazi += "İkiyüz "; break;
                            case 1: yazi += "Yüz "; break;
                        }
                        switch ((virgulOncesi % 100000) / 10000)
                        {
                            case 9: yazi += "Doksan "; break;
                            case 8: yazi += "Seksen "; break;
                            case 7: yazi += "Yetmiş "; break;
                            case 6: yazi += "Altmış "; break;
                            case 5: yazi += "Elli "; break;
                            case 4: yazi += "Kırk "; break;
                            case 3: yazi += "Otuz "; break;
                            case 2: yazi += "Yirmi "; break;
                            case 1: yazi += "On "; break;
                        }
                        switch ((virgulOncesi % 10000) / 1000)
                        {
                            case 9: yazi += "Dokuzbin "; break;
                            case 8: yazi += "Sekizbin "; break;
                            case 7: yazi += "Yedibin "; break;
                            case 6: yazi += "Altıbin "; break;
                            case 5: yazi += "Beşbin "; break;
                            case 4: yazi += "Dörtbin "; break;
                            case 3: yazi += "Üçbin "; break;
                            case 2: yazi += "İkibin "; break;
                            case 1: yazi += "Birbin "; break;
                        }
                        switch ((virgulOncesi % 1000) / 100)
                        {
                            case 9: yazi += "Dokuzyüz "; break;
                            case 8: yazi += "Sekizyüz "; break;
                            case 7: yazi += "Yediyüz "; break;
                            case 6: yazi += "Altıyüz "; break;
                            case 5: yazi += "Beşyüz "; break;
                            case 4: yazi += "Dörtyüz "; break;
                            case 3: yazi += "Üçyüz "; break;
                            case 2: yazi += "İkiyüz "; break;
                            case 1: yazi += "Yüz "; break;
                        }
                        switch ((virgulOncesi % 100) / 10)
                        {
                            case 9: yazi += "Doksan "; break;
                            case 8: yazi += "Seksen "; break;
                            case 7: yazi += "Yetmiş "; break;
                            case 6: yazi += "Altmış "; break;
                            case 5: yazi += "Elli "; break;
                            case 4: yazi += "Kırk "; break;
                            case 3: yazi += "Otuz "; break;
                            case 2: yazi += "Yirmi "; break;
                            case 1: yazi += "On "; break;
                        }
                        switch ((virgulOncesi % 10))
                        {
                            case 9: yazi += "Dokuz "; break;
                            case 8: yazi += "Sekiz "; break;
                            case 7: yazi += "Yedi "; break;
                            case 6: yazi += "Altı "; break;
                            case 5: yazi += "Beş "; break;
                            case 4: yazi += "Dört "; break;
                            case 3: yazi += "Üç "; break;
                            case 2: yazi += "İki "; break;
                            case 1: yazi += "Bir "; break;
                        }
                        if (virgulOncesi == 0)
                            yazi = "Sıfır";
                        yazi += "TL ";
                    }

                    if (virgulSonrasi >= 0 && virgulSonrasi <= 99)
                    {
                        if (virgulSonrasi > 0 && virgulSonrasi <= 99)
                        {
                            switch ((virgulSonrasi % 100) / 10)
                            {
                                case 9: yazi += "Doksan "; break;
                                case 8: yazi += "Seksen "; break;
                                case 7: yazi += "Yetmiş "; break;
                                case 6: yazi += "Altmış "; break;
                                case 5: yazi += "Elli "; break;
                                case 4: yazi += "Kırk "; break;
                                case 3: yazi += "Otuz "; break;
                                case 2: yazi += "Yirmi "; break;
                                case 1: yazi += "On "; break;
                            }
                            switch ((virgulSonrasi % 10))
                            {
                                case 9: yazi += "Dokuz "; break;
                                case 8: yazi += "Sekiz "; break;
                                case 7: yazi += "Yedi "; break;
                                case 6: yazi += "Altı "; break;
                                case 5: yazi += "Beş "; break;
                                case 4: yazi += "Dört "; break;
                                case 3: yazi += "Üç "; break;
                                case 2: yazi += "İki "; break;
                                case 1: yazi += "Bir "; break;
                            }
                            yazi += "Krş ";
                        }
                    }
                    else
                    {
                        string mesaj2 = "Geçersiz Sayı!";
                        MessageBox.Show(mesaj2, "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    string mesaj1 = "Girdiğiniz Sayı 6 basamaktan büyük!";
                    MessageBox.Show(mesaj1, "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                string mesaj3 = "BOŞ!";
                MessageBox.Show(mesaj3, "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return yazi;
        }
        private void BtnHesapla_Click_1(object sender, EventArgs e)
        {
            lblSonuc.Text = yaziyaCevir(Convert.ToString(txtSayi.Text));
        }
    }
}