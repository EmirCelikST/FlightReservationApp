using FlightReservationAppEmirCelik;
using System;
using System.Collections.Generic;

namespace FlightReservationAppEmirCelik
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Rezervasyon> rezervasyonlar = new List<Rezervasyon>();
            List<Ucus> ucuslar = SabitUcuslariOlustur();

            while (true)
            {
                Console.WriteLine("1. Yeni Rezervasyon");
                Console.WriteLine("2. Rezervasyonları Göster");
                Console.WriteLine("3. Uçuşları Göster ve Seç");
                Console.WriteLine("4. Çıkış");
                Console.Write("Seçiminiz: ");

                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        UcuslariGosterVeSec(ucuslar, rezervasyonlar);
                        KayitlariDosyayaYaz("rezervasyonlar.csv", rezervasyonlar); // Save reservations to file immediately
                        break;
                    case "2":
                        RezervasyonlariGoster(rezervasyonlar);
                        break;
                    case "3":
                        UcuslariGoster(ucuslar);
                        break;
                    case "4":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
                        break;
                }
            }
        }

        static void KayitlariDosyayaYaz(string dosyaAdi, List<Rezervasyon> rezervasyonlar)
        {
            try
            {
                // Use FileMode.Append to append data to an existing file
                using (StreamWriter sw = new StreamWriter(dosyaAdi, true))
                {
                    foreach (var rezervasyon in rezervasyonlar)
                    {
                        sw.WriteLine($"ID: {rezervasyon.id}");
                        sw.WriteLine($"Müşteri Adı Soyadı: {rezervasyon.musteriAdiSoyadi}");
                        sw.WriteLine($"Koltuk No: {rezervasyon.koltukNo}");
                        sw.WriteLine($"Uçuş Bilgileri: {rezervasyon.Ucus.Lokasyon.sehir} - {rezervasyon.Ucus.Lokasyon.ulke} -> {rezervasyon.Ucus.saat} {rezervasyon.Ucus.tarih}");
                        sw.WriteLine("--------------------");
                    }
                }

                Console.WriteLine("Rezervasyon kayıtları dosyaya başarıyla yazıldı.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata oluştu: {ex.Message}");
            }
        }

        static List<Ucus> SabitUcuslariOlustur()
        {
            Ucak ucak1 = new Ucak
            {
                id = 1,
                ucakModel = "Boeing 737",
                ucakMarkasi = "Boeing",
                seriNo = "123ABC",
                koltukKapasitesi = 150
            };

            Lokasyon kalkisLokasyon1 = new Lokasyon
            {
                id = 1,
                sehir = "Istanbul",
                ulke = "Turkey",
                havaalani = "IST",
                aktifPasif = true,
                seyehatSuresi = 2
            };

            Lokasyon varisLokasyon1 = new Lokasyon
            {
                id = 2,
                sehir = "New York",
                ulke = "USA",
                havaalani = "JFK",
                aktifPasif = true,
                seyehatSuresi = 10
            };

            Ucus ucus1 = new Ucus
            {
                id = 1,
                Lokasyon = kalkisLokasyon1,
                Ucak = ucak1,
                saat = "18:00",
                tarih = DateTime.Now.AddDays(7)
            };

            Ucak ucak2 = new Ucak
            {
                id = 2,
                ucakModel = "Airbus A320",
                ucakMarkasi = "Airbus",
                seriNo = "456XYZ",
                koltukKapasitesi = 200
            };

            Lokasyon kalkisLokasyon2 = new Lokasyon
            {
                id = 3,
                sehir = "Paris",
                ulke = "France",
                havaalani = "CDG",
                aktifPasif = true,
                seyehatSuresi = 3
            };

            Lokasyon varisLokasyon2 = new Lokasyon
            {
                id = 4,
                sehir = "Tokyo",
                ulke = "Japan",
                havaalani = "NRT",
                aktifPasif = true,
                seyehatSuresi = 12
            };

            Ucus ucus2 = new Ucus
            {
                id = 2,
                Lokasyon = kalkisLokasyon2,
                Ucak = ucak2,
                saat = "22:30",
                tarih = DateTime.Now.AddDays(10)
            };

            Ucak ucak3 = new Ucak
            {
                id = 3,
                ucakModel = "Boeing 747",
                ucakMarkasi = "Boeing",
                seriNo = "789XYZ",
                koltukKapasitesi = 300
            };

            Lokasyon kalkisLokasyon3 = new Lokasyon
            {
                id = 5,
                sehir = "London",
                ulke = "UK",
                havaalani = "LHR",
                aktifPasif = true,
                seyehatSuresi = 4
            };

            Lokasyon varisLokasyon3 = new Lokasyon
            {
                id = 6,
                sehir = "Sydney",
                ulke = "Australia",
                havaalani = "SYD",
                aktifPasif = true,
                seyehatSuresi = 18
            };

            Ucus ucus3 = new Ucus
            {
                id = 3,
                Lokasyon = kalkisLokasyon3,
                Ucak = ucak3,
                saat = "16:45",
                tarih = DateTime.Now.AddDays(15)
            };

            // Yeni Uçuş 2
            Ucak ucak4 = new Ucak
            {
                id = 4,
                ucakModel = "Airbus A380",
                ucakMarkasi = "Airbus",
                seriNo = "ABC123",
                koltukKapasitesi = 500
            };

            Lokasyon kalkisLokasyon4 = new Lokasyon
            {
                id = 7,
                sehir = "Beijing",
                ulke = "China",
                havaalani = "PEK",
                aktifPasif = true,
                seyehatSuresi = 6
            };

            Lokasyon varisLokasyon4 = new Lokasyon
            {
                id = 8,
                sehir = "Los Angeles",
                ulke = "USA",
                havaalani = "LAX",
                aktifPasif = true,
                seyehatSuresi = 12
            };

            Ucus ucus4 = new Ucus
            {
                id = 4,
                Lokasyon = kalkisLokasyon4,
                Ucak = ucak4,
                saat = "20:15",
                tarih = DateTime.Now.AddDays(20)
            };

            List<Ucus> ucuslar = new List<Ucus> { ucus1, ucus2, ucus3, ucus4 };

            return ucuslar;
        }

        static void UcuslariGoster(List<Ucus> ucuslar)
        {
            Console.WriteLine("Uçuşlar:");

            foreach (var ucus in ucuslar)
            {
                Console.WriteLine($"Uçuş ID: {ucus.id}");
                Console.WriteLine($"Kalkış: {ucus.Lokasyon.sehir}, {ucus.Lokasyon.ulke} ({ucus.Lokasyon.havaalani})");
                Console.WriteLine($"Varış: {ucus.Ucak.ucakModel}");
                Console.WriteLine($"Uçak Modeli: {ucus.Ucak.ucakModel}");
                Console.WriteLine($"Koltuk Kapasitesi: {ucus.Ucak.koltukKapasitesi}");
                Console.WriteLine($"Kalkış Saati: {ucus.saat}");
                Console.WriteLine($"Kalkış Tarihi: {ucus.tarih}");
                Console.WriteLine("--------------------");
            }
        }

        static void UcuslariGosterVeSec(List<Ucus> ucuslar, List<Rezervasyon> rezervasyonlar)
        {
            UcuslariGoster(ucuslar);

            Console.Write("Lütfen rezerve etmek istediğiniz uçuşun ID'sini girin: ");
            if (int.TryParse(Console.ReadLine(), out int secilenUcusID))
            {
                Ucus secilenUcus = ucuslar.Find(u => u.id == secilenUcusID);

                if (secilenUcus != null)
                {
                    YeniRezervasyonEkle(rezervasyonlar, secilenUcus);
                }
                else
                {
                    Console.WriteLine("Geçersiz uçuş ID. Lütfen tekrar deneyin.");
                }
            }
            else
            {
                Console.WriteLine("Geçersiz uçuş ID. Lütfen bir tam sayı girin.");
            }
        }

        static void YeniRezervasyonEkle(List<Rezervasyon> rezervasyonlar, Ucus secilenUcus)
        {
            Queue<Rezervasyon> yeniRezervasyonlar = new Queue<Rezervasyon>();

            Console.Write("Bilet Adeti: ");
            if (!int.TryParse(Console.ReadLine(), out int biletAdeti) || biletAdeti <= 0)
            {
                Console.WriteLine("Geçersiz bilet adeti. Lütfen pozitif bir tam sayı girin.");
                return;
            }

            List<string> bosKoltuklar = BosKoltuklariListele(secilenUcus, rezervasyonlar);

            if (bosKoltuklar.Count < biletAdeti)
            {
                Console.WriteLine($"Üzgünüz, bu uçuşta {biletAdeti} adet boş koltuk bulunmamaktadır.");
                return;
            }

            for (int i = 0; i < biletAdeti; i++)
            {
                Console.WriteLine($"\nBilet {i + 1} Bilgileri:");

                Console.Write("Müşteri Adı Soyadı: ");
                string musteriAdiSoyadi = Console.ReadLine();

                Console.Write("Yaş: ");
                if (!int.TryParse(Console.ReadLine(), out int yas))
                {
                    Console.WriteLine("Geçersiz yaş. Lütfen bir tam sayı girin.");
                    i--; // Geçersiz giriş yapıldığında i'yi azaltarak aynı bilet için tekrar sor
                    continue;
                }

                Console.Write("Müşteri Cep Telefonu: ");
                if (!double.TryParse(Console.ReadLine(), out double musteriCepTelefonu))
                {
                    Console.WriteLine("Geçersiz cep telefonu. Lütfen bir sayı girin.");
                    i--; // Geçersiz giriş yapıldığında i'yi azaltarak aynı bilet için tekrar sor
                    continue;
                }

                Console.WriteLine("Boş Koltuklar:");

                for (int j = 0; j < bosKoltuklar.Count; j++)
                {
                    Console.Write($"{bosKoltuklar[j]} ");

                    if ((j + 1) % (secilenUcus.Ucak.koltukKapasitesi / 5) == 0) // Her satırda 5 koltuk olsun
                    {
                        Console.WriteLine();
                    }
                }

                Console.WriteLine();

                Console.Write("Lütfen bir veya birkaç koltuk seçin (örnek: A1 B3 C5): ");
                string[] secilenKoltuklar = Console.ReadLine().Split(' ');

                // Check if the selected seats are valid
                if (secilenKoltuklar.Any(koltuk => !bosKoltuklar.Contains(koltuk)))
                {
                    Console.WriteLine("Geçersiz koltuk numarası. Lütfen tekrar deneyin.");
                    i--; // Geçersiz giriş yapıldığında i'yi azaltarak aynı bilet için tekrar sor
                    continue;
                }

                // Remove the selected seats from the list of available seats
                foreach (var secilenKoltuk in secilenKoltuklar)
                {
                    bosKoltuklar.Remove(secilenKoltuk);
                }

                Rezervasyon rezervasyon = new Rezervasyon
                {
                    Ucus = secilenUcus,
                    musteriAdiSoyadi = musteriAdiSoyadi,
                    biletAdeti = 1,
                    koltukNo = string.Join(" ", secilenKoltuklar),
                    musteriCepTelefonu = musteriCepTelefonu,
                    yas = yas
                };

                yeniRezervasyonlar.Enqueue(rezervasyon);
            }

            while (yeniRezervasyonlar.Count > 0)
            {
                rezervasyonlar.Add(yeniRezervasyonlar.Dequeue());
            }

            Console.WriteLine("Rezervasyon başarıyla eklendi.\n");
        }


        static List<string> BosKoltuklariListele(Ucus secilenUcus, List<Rezervasyon> rezervasyonlar)
        {
            // Use Ucus.Ucak.koltukKapasitesi to get the total number of seats
            int koltukKapasitesi = secilenUcus.Ucak.koltukKapasitesi;

            // Generate a list of all seat numbers based on the total capacity
            List<string> tumKoltuklar = Enumerable.Range(1, koltukKapasitesi).Select(x => x.ToString()).ToList();

            List<string> rezervasyonluKoltuklar = rezervasyonlar
                .Where(r => r.Ucus.id == secilenUcus.id)
                .Select(r => r.koltukNo)
                .ToList();

            // Calculate the number of seats to be randomly occupied
            int randomOccupiedSeatCount = new Random().Next(1, koltukKapasitesi);

            // Randomly select seats to be occupied
            List<string> randomOccupiedSeats = tumKoltuklar.Except(rezervasyonluKoltuklar)
                .OrderBy(x => Guid.NewGuid())
                .Take(randomOccupiedSeatCount)
                .ToList();

            return randomOccupiedSeats;
        }



        static void RezervasyonlariGoster(List<Rezervasyon> rezervasyonlar)
        {
            Console.WriteLine("Rezervasyonlar:");

            try
            {
                // Read reservations from the file
                string[] lines = File.ReadAllLines("rezervasyonlar.csv");

                // Process lines in groups of 5 (assuming each reservation has 5 lines of information)
                for (int i = 0; i < lines.Length; i += 5)
                {
                    Console.WriteLine($"ID: {lines[i]}");
                    Console.WriteLine($"Müşteri Adı Soyadı: {lines[i + 1]}");
                    Console.WriteLine($"Koltuk No: {lines[i + 2]}");
                    Console.WriteLine($"Uçuş Bilgileri: {lines[i + 3]}");
                    Console.WriteLine("--------------------");
                }

                Console.WriteLine();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Rezervasyonlar dosyası bulunamadı.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata oluştu: {ex.Message}");
            }
        }
    }
}
