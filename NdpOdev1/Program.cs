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

namespace passwrdconsole
{
    class Program
    {

        static void Main(string[] args)
        {
            SifreGuvenliktesti kontrol = new SifreGuvenliktesti();

            int puan;
            bool boslukKontrol = true; //boşluk var mı kontrol etmek için bir booelan tanımladım ve bunu while döngsünde kullandım 

            while (boslukKontrol)
            {
                string str;
                int toplamBuyukHarf, toplamKucukHarf, toplamRakam, toplamSembol, i, l;
                toplamBuyukHarf = toplamKucukHarf = toplamRakam = toplamSembol = i = 0;

                Console.WriteLine("Lütfen bir şifre giriniz:");
                str = kontrol.sifre = Console.ReadLine();
                l = str.Length;

                puan = kontrol.SifrePuanHesapla(kontrol.sifre);



                if (kontrol.sifre.Contains(" ")) //şifre boşluk içeriyorsa
                {
                    Console.WriteLine("Şifreniz boşluk içeremez !");
                }


                else //şifre boşluk içermiyorsa
                {
                    while (i < l) //şifredeki toplam büyük harf, küçük harf, rakam ve sembol sayısını hesaplamak için bir while döngüsü yazdım
                    {
                        if (str[i] >= 'a' && str[i] <= 'z')
                        {
                            toplamKucukHarf++;
                        }
                        else if (str[i] >= 'A' && str[i] <= 'Z')
                        {
                            toplamBuyukHarf++;
                        }
                        else if (str[i] >= '0' && str[i] <= '9')
                        {
                            toplamRakam++;
                        }
                        else
                        {
                            toplamSembol++;
                        }
                        i++;
                    }

                    if (toplamKucukHarf == 0 || toplamBuyukHarf == 0 || toplamRakam == 0 || toplamSembol == 0) //büyük harf, küçük harf, rakam ve sembolden en az birini içermiyorsa
                    {
                        Console.WriteLine("Lütfen en az 1 büyük harf, 1 küçük harf, 1 rakam ve 1 sembol giriniz!");
                    }


                    else //büyük harf, küçük harf, rakam ve sembolün her birini içeriyorsa
                    {

                        if (kontrol.sifre.Length < 9) //9 karakterden azsa geçerli değil
                        {
                            Console.WriteLine("Şifreniz en az 9 karakterli olmalıdır !");
                        }

                        else if (kontrol.sifre.Length == 9)
                        {
                            Console.WriteLine("Puan: " + (puan + 10)); //Şifre 9 karakterliyse 10 puan eklenir
                            if (puan < 70)
                            {
                                Console.WriteLine("ZAYIF! Şifre kabul edilemez.");
                            }

                            else if (puan < 90)
                            {
                                Console.WriteLine("NORMAL! Şifre kabul edilebilir.");
                            }

                            else
                            {
                                Console.WriteLine("GÜÇLÜ!");
                            }

                            Console.WriteLine("*****************************************************");//şifre içeriğini ekrana yazdırdım
                            Console.WriteLine("Şifredeki büyük harf sayısı: " + toplamBuyukHarf);
                            Console.WriteLine("Şifredeki küçük harf sayısı: " + toplamKucukHarf);
                            Console.WriteLine("Şifredeki rakam sayısı: " + toplamRakam);
                            Console.WriteLine("Şifredeki sembol sayısı: " + toplamSembol);
                            Console.WriteLine("*****************************************************");
                        }

                        else //şifre 9 karakterden büyükse
                        {
                            Console.WriteLine("Puan: " + puan);
                            if (puan < 70)
                            {
                                Console.WriteLine("ZAYIF! Şifre kabul edilemez.");
                            }

                            else if (puan < 90)
                            {
                                Console.WriteLine("NORMAL! Şifre kabul edilebilir.");
                            }

                            else
                            {
                                Console.WriteLine("GÜÇLÜ!");
                            }

                            Console.WriteLine("*****************************************");//şifre içeriğini ekrana yazdırdım
                            Console.WriteLine("Şifredeki büyük harf sayısı: " + toplamBuyukHarf);
                            Console.WriteLine("Şifredeki küçük harf sayısı: " + toplamKucukHarf);
                            Console.WriteLine("Şifredeki rakam sayısı: " + toplamRakam);
                            Console.WriteLine("Şifredeki sembol sayısı: " + toplamSembol);
                            Console.WriteLine("*****************************************");
                        }
                    }
                }

                Console.Write("Çıkış yapmak için 'Q' ya , devam etmek için herhangi bir tuşa basınız.");
                if (Console.ReadKey().Key == ConsoleKey.Q)
                    return;
                Console.Clear();
            }
        }
    }
}
