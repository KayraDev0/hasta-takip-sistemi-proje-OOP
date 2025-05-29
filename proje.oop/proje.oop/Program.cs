using proje.oop;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        List<hasta> hastalar = new List<hasta>();
        List<doktor> doktorlar = new List<doktor>();
        List<randevu> randevular = new List<randevu>();
        List<recete> receteler = new List<recete>();

        doktor dr1 = new doktor { DoktorId = 1, Isim = "Dr. Kayra", Uzmanlik = "Kardiyoloji" };
        doktorlar.Add(dr1);
        doktor dr2 = new doktor { DoktorId = 2, Isim = "Dr. Mehmet", Uzmanlik = "Kardiyoloji" };
        doktorlar.Add(dr2); 
        doktor dr4 = new doktor { DoktorId = 3, Isim = "Dr. Can", Uzmanlik = "Kardiyoloji" };
        doktorlar.Add(dr4);
        doktor dr5 = new doktor { DoktorId = 4, Isim = "Dr. Seda", Uzmanlik = "Kardiyoloji" };
        doktorlar.Add(dr5);
        doktor dr6 = new doktor { DoktorId = 5, Isim = "Dr. Murat", Uzmanlik = "Kardiyoloji" };
        doktorlar.Add(dr6);
        doktor dr7 = new doktor { DoktorId = 6, Isim = "Dr. Zeynep", Uzmanlik = "Kardiyoloji" };
        doktorlar.Add(dr7);
        doktor dr8 = new doktor { DoktorId = 7, Isim = "Dr. Ahmet", Uzmanlik = "Kardiyoloji" };
        doktorlar.Add(dr8);
        doktor dr9 = new doktor { DoktorId = 8, Isim = "Dr. Fatma", Uzmanlik = "Kardiyoloji" };
        doktorlar.Add(dr9);
        doktor dr10 = new doktor { DoktorId = 9, Isim = "Dr. Cem", Uzmanlik = "Kardiyoloji" };
        doktorlar.Add(dr10);



        hasta hastaEfsun = new hasta { HastaId = 1, Isim = "Efsun", DogumTarihi = new DateTime(1985, 5, 20), Telefon = "05551234567" };
        hastalar.Add(hastaEfsun);
        hasta hasta2 = new hasta { HastaId = 2, Isim = "Murat", DogumTarihi = new DateTime(1990, 8, 15), Telefon = "05559876543" };
        hastalar.Add(hasta2);
        hasta hasta3 = new hasta { HastaId = 3, Isim = "Selin", DogumTarihi = new DateTime(1978, 12, 5), Telefon = "05557654321" };
        hastalar.Add(hasta3);
        hasta hasta4 = new hasta { HastaId = 4, Isim = "Kemal", DogumTarihi = new DateTime(2000, 1, 10), Telefon = "05551112233" };
        hastalar.Add(hasta4);
        hasta hasta5 = new hasta { HastaId = 5, Isim = "Zeynep", DogumTarihi = new DateTime(1995, 3, 25), Telefon = "05554443322" };
        hastalar.Add(hasta5);
        hasta hasta6 = new hasta { HastaId = 6, Isim = "Ahmet", DogumTarihi = new DateTime(1982, 7, 30), Telefon = "05553332211" };
        hastalar.Add(hasta6);
        hasta hasta7 = new hasta { HastaId = 7, Isim = "Deniz", DogumTarihi = new DateTime(1998, 11, 18), Telefon = "05559998877" };
        hastalar.Add(hasta7);
        hasta hasta8 = new hasta { HastaId = 8, Isim = "Seda", DogumTarihi = new DateTime(1987, 4, 9), Telefon = "05556667788" };
        hastalar.Add(hasta8);
        hasta hasta9 = new hasta { HastaId = 9, Isim = "Emre", DogumTarihi = new DateTime(1975, 6, 12), Telefon = "05558887766" };
        hastalar.Add(hasta9);


        while (true)
        {
            Console.WriteLine("\n-Sağlık Yönetim Sistemi-");
            Console.WriteLine("1.Randevu Oluştur");
            Console.WriteLine("2.Reçete Yaz");
            Console.WriteLine("3.Hasta Bilgilerini Göster");
            Console.WriteLine("4.Randevuları Listele");
            Console.WriteLine("5.Reçeteleri Listele");
            Console.WriteLine("0.Çıkış");
            Console.Write("Seçim: ");
            string secim = Console.ReadLine();

            switch (secim)
            {
                case "1":
                    Console.WriteLine("Hasta ID giriniz:");
                    int hId = Convert.ToInt32(Console.ReadLine());
                    hasta secilenHasta = hastalar.FirstOrDefault(h => h.HastaId == hId);
                    if (secilenHasta == null)
                    {
                        Console.WriteLine("Hasta bulunamadı.");
                        break;
                    }

                    Console.WriteLine("Doktor ID giriniz:");
                    int dId = Convert.ToInt32(Console.ReadLine());
                    doktor secilenDoktor = doktorlar.FirstOrDefault(d => d.DoktorId == dId);
                    if (secilenDoktor == null)
                    {
                        Console.WriteLine("Doktor bulunamadı.");
                        break;
                    }

                    Console.WriteLine("Randevu tarihi ve saati (yyyy-MM-dd HH:mm):");
                    DateTime tarihSaat = Convert.ToDateTime(Console.ReadLine());

                    randevu yeniRandevu = new randevu
                    {
                        RandevuId = randevular.Count + 1,
                        Hasta = secilenHasta,
                        Doktor = secilenDoktor,
                        TarihSaat = tarihSaat
                    };

                    randevular.Add(yeniRandevu);
                    secilenHasta.Randevular.Add(yeniRandevu);
                    secilenDoktor.Randevular.Add(yeniRandevu);

                    Console.WriteLine("Randevu başarıyla oluşturuldu.");
                    break;


                case "2":
                    Console.WriteLine("Hasta ID giriniz:");
                    int hastaIdRecete = Convert.ToInt32(Console.ReadLine());
                    hasta secilenHastaRecete = hastalar.FirstOrDefault(h => h.HastaId == hastaIdRecete);
                    if (secilenHastaRecete == null)
                    {
                        Console.WriteLine("Hasta bulunamadı.");
                        break;
                    }

                    Console.WriteLine("Doktor ID giriniz:");
                    int doktorIdRecete = Convert.ToInt32(Console.ReadLine());
                    doktor secilenDoktorRecete = doktorlar.FirstOrDefault(d => d.DoktorId == doktorIdRecete);
                    if (secilenDoktorRecete == null)
                    {
                        Console.WriteLine("Doktor bulunamadı.");
                        break;
                    }

                    Console.WriteLine("Kaç ilaç yazacaksınız?");
                    int ilacSayisi = Convert.ToInt32(Console.ReadLine());

                    List<string> ilaclar = new List<string>();
                    for (int i = 0; i < ilacSayisi; i++)
                    {
                        Console.Write($"İlaç {i + 1}: ");
                        ilaclar.Add(Console.ReadLine());
                    }

                    recete yeniRecete = new recete
                    {
                        ReceteId = receteler.Count + 1,
                        Hasta = secilenHastaRecete,
                        Doktor = secilenDoktorRecete,
                        IlacListesi = ilaclar,
                        Tarih = DateTime.Now
                    };

                    receteler.Add(yeniRecete);
                    secilenHastaRecete.Receteler.Add(yeniRecete);

                    Console.WriteLine("Reçete başarıyla oluşturuldu.");
                    break;

                case "3":
                    Console.WriteLine("Hasta ID giriniz:");
                    int hastaIdGor = Convert.ToInt32(Console.ReadLine());
                    hasta hastaGoster = hastalar.FirstOrDefault(h => h.HastaId == hastaIdGor);
                    if (hastaGoster == null)
                    {
                        Console.WriteLine("Hasta bulunamadı.");
                        break;
                    }

                    Console.WriteLine($"\nHasta: {hastaGoster.Isim}");
                    Console.WriteLine($"Doğum Tarihi: {hastaGoster.DogumTarihi.ToShortDateString()}");
                    Console.WriteLine($"Telefon: {hastaGoster.Telefon}");

                    Console.WriteLine("\nRandevular:");
                    foreach (var randevu in hastaGoster.Randevular)
                    {
                        Console.WriteLine($"- {randevu.TarihSaat} Doktor: {randevu.Doktor.Isim} ({randevu.Doktor.Uzmanlik}) Durum: {randevu.Durum}");
                    }

                    Console.WriteLine("\nReçeteler:");
                    foreach (var recete in hastaGoster.Receteler)
                    {
                        Console.WriteLine($"- Tarih: {recete.Tarih}");
                        Console.WriteLine($"  Doktor: {recete.Doktor.Isim}");
                        Console.WriteLine($"  İlaçlar: {string.Join(", ", recete.IlacListesi)}");
                    }
                    break;

                case "4": 
                    if (randevular.Count == 0)
                    {
                        Console.WriteLine("Henüz hiç randevu yok.");
                    }
                    else
                    {
                        Console.WriteLine("\nTüm Randevular:");
                        foreach (var randevu in randevular)
                        {
                            Console.WriteLine($"Randevu ID: {randevu.RandevuId} - Tarih: {randevu.TarihSaat} - Hasta: {randevu.Hasta.Isim} - Doktor: {randevu.Doktor.Isim} ({randevu.Doktor.Uzmanlik}) - Durum: {randevu.Durum}");
                        }
                    }
                    break;

                case "5": 
                    if (receteler.Count == 0)
                    {
                        Console.WriteLine("Henüz hiç reçete yok.");
                    }
                    else
                    {
                        Console.WriteLine("\nTüm Reçeteler:");
                        foreach (var recete in receteler)
                        {
                            Console.WriteLine($"Reçete ID: {recete.ReceteId} - Tarih: {recete.Tarih}");
                            Console.WriteLine($"Hasta: {recete.Hasta.Isim}");
                            Console.WriteLine($"Doktor: {recete.Doktor.Isim} ({recete.Doktor.Uzmanlik})");
                            Console.WriteLine($"İlaçlar: {string.Join(", ", recete.IlacListesi)}");
                            Console.WriteLine("------------------------------");
                        }
                    }
                    break;


                case "0":
                    Console.WriteLine("Programdan çıkılıyor...");
                    return;
            }
        }
    }
            }