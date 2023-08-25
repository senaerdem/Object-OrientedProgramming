/****************************************************************************
**					     SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				     BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				    NESNEYE DAYALI PROGRAMLAMA DERSİ
**					     2021-2022 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 1. ÖDEV
**				ÖĞRENCİ ADI............: SENA NUR ERDEM
**				ÖĞRENCİ NUMARASI.......: G201210033
**              DERSİN ALINDIĞI GRUP...: 2B
****************************************************************************/

using System;
using System.Text.RegularExpressions;

namespace passwrdconsole
{
    public class SifreGuvenliktesti
    {

        public string sifre { get; set; }
        private int UzunlukHesapla(string sifre) //Şifre uzunluğunu kontrol etmek için bir method tanımladım
        {
            return Math.Min(0, sifre.Length);
        }

        private int KucukHarfHesapla(string sifre) //Şifrenin küçük harf için puanını hesaplayan methodu yazdım
        {
            int hamPuan = sifre.Length - Regex.Replace(sifre, "[a-z]", "").Length;
            return Math.Min(2, hamPuan) * 10;
            //her küçük harf 10 puan
            //max 2 küçük harfe puan verilir
        }

        private int BuyukHarfHesapla(string sifre) //Şifrenin büyük harf için puanını hesaplayan methodu yazdım
        {
            int hamPuan = sifre.Length - Regex.Replace(sifre, "[A-Z]", "").Length;
            return Math.Min(2, hamPuan) * 10;
            //her büyük harf 10 puan
            //max 2 büyük harfe puan verilir
        }

        private int RakamHesapla(string sifre) //Şifrenin rakam için puanını hesaplayan methodu yazdım
        {
            int hamPuan = sifre.Length - Regex.Replace(sifre, "[0-9]", "").Length;
            return Math.Min(2, hamPuan) * 10;
            //her rakam 10 puan
            //max 2 rakama puan verilir
        }

        private int SembolHesapla(string sifre) //Şifrenin sembol için puanını hesaplayan metodu yazdım
        {
            int hamPuan = Regex.Replace(sifre, "[a-zA-Z0-9]", "").Length;
            return Math.Min(75876, hamPuan) * 10;
            //her sembol 10 puan
            //sembol puanlaması için max bir değer yoktur her sembole puan verilir
        }

        public int SifrePuanHesapla(string sifre) //Yukarıda tanımladığım methodları kullanarak şifrenin güvenlik değerini hesaplattım
        {
            if (sifre == null)
            {
                return 0;
            }

            int uzunlukPuan = UzunlukHesapla(sifre);
            int kucukHarfPuan = KucukHarfHesapla(sifre);
            int buyukHarfPuan = BuyukHarfHesapla(sifre);
            int rakamPuan = RakamHesapla(sifre);
            int sembolPuan = SembolHesapla(sifre);

            return uzunlukPuan + kucukHarfPuan + buyukHarfPuan + rakamPuan + sembolPuan;
        }
    }
}
