using Abstraction_Practice;

ProjeYoeticisi projeYoeticisi = new ProjeYoeticisi();
YazilimGelistirici yazilimGelistirici = new YazilimGelistirici();
SatisTemsilcisi satisTemsilcisi = new SatisTemsilcisi();

Console.WriteLine("Proje Yoneticisi");
Console.WriteLine("Adiniz:");
projeYoeticisi.Ad = Console.ReadLine();
Console.WriteLine("Soyadiniz:");
projeYoeticisi.Soyad = Console.ReadLine();
Console.WriteLine("Departmaniniz");
projeYoeticisi.Departman = Console.ReadLine();
Console.WriteLine("Proje Yoneticisi Bilgileri:");
Console.WriteLine($"Ad: {projeYoeticisi.Ad}");
Console.WriteLine($"Soyad: {projeYoeticisi.Soyad}");
Console.WriteLine($"Departman: {projeYoeticisi.Departman}");
projeYoeticisi.Gorev();


Console.WriteLine("\nYazilim Gelistirici");
Console.WriteLine("Adiniz:");
yazilimGelistirici.Ad = Console.ReadLine();
Console.WriteLine("Soyadiniz:");
yazilimGelistirici.Soyad = Console.ReadLine();
Console.WriteLine("Departmaniniz");
yazilimGelistirici.Departman = Console.ReadLine();
Console.WriteLine("Yazilim Gelistirici Bilgileri:");
Console.WriteLine($"Ad: {yazilimGelistirici.Ad}");
Console.WriteLine($"Soyad: {yazilimGelistirici.Soyad}");
Console.WriteLine($"Departman: {yazilimGelistirici.Departman}");
yazilimGelistirici.Gorev();

Console.WriteLine("\nSatis Temsilcisi");
Console.WriteLine("Adiniz:");
satisTemsilcisi.Ad = Console.ReadLine();

Console.WriteLine("Soyadiniz:");
satisTemsilcisi.Soyad = Console.ReadLine();
Console.WriteLine("Departmaniniz");
satisTemsilcisi.Departman = Console.ReadLine();
Console.WriteLine("Satis Temsilcisi Bilgileri:");
Console.WriteLine($"Ad: {satisTemsilcisi.Ad}");
Console.WriteLine($"Soyad: {satisTemsilcisi.Soyad}");
Console.WriteLine($"Departman: {satisTemsilcisi.Departman}");
satisTemsilcisi.Gorev();



