Console.WriteLine("Sayı tahmini için 1'i dört işlem için 2'i çıkış için x'e terminali temizlemek için c'e basınız:");

string karakter = Console.ReadLine();

if (karakter == "1")
{
    Console.Clear();
    Console.WriteLine("Tahmin ettiğiniz bir sayıyı giriniz(1 ile 101 arasında sayı giriniz[1 ile 101 dahil olmayacak)]");
    int tahmin_edilen_sayı = Convert.ToInt32(Console.ReadLine());
    Random rnd = new Random();
    int rastgele_sayı = rnd.Next(1, 101);
    if (tahmin_edilen_sayı > rastgele_sayı)
    {
        Console.Clear();
        Console.WriteLine("Tahmin ettiğin sayı gerçek[Rastgele] sayıdan büyük", rastgele_sayı);
    }
    else if (tahmin_edilen_sayı < rastgele_sayı)
    {
        Console.Clear();
        Console.WriteLine("Tahmin ettiğin sayı gerçek[Rastgele] sayıdan küçük", rastgele_sayı);
    }
    else
    {
        Console.Clear();
        Console.WriteLine("TEBRİKLER! Tahmin ettiğin sayı gerçek[Rastgele] sayıya eşit", rastgele_sayı);
    }
}
else if (karakter == "2")
{
    Console.Clear();
    Console.WriteLine("Sayıları giriniz(Girilen değerler metin,karakter ve ondalık sayı olmayacak)");
    int sayı1 = Convert.ToInt32(Console.ReadLine());
    int sayı2 = Convert.ToInt32(Console.ReadLine());
    double sonuç;
    Console.Clear() ;
    Console.WriteLine("İşlem İşaretini Seçiniz:x,:,+,-");
    string işlem = Console.ReadLine();
    if(işlem == "x")
    {
        Console.Clear();
        sonuç = sayı1 * sayı2;
        Console.WriteLine("Sonuç:", sonuç);
    }
    else if(işlem == ":")
    {
        Console.Clear();
        sonuç = sayı1 / sayı2;
        Console.WriteLine("Sonuç:", sonuç);
    }
    else if(işlem == "+")
    {
        Console.Clear();
        sonuç = sayı1 + sayı2;
        Console.WriteLine("Sonuç:", sonuç);
    }
    else if(işlem == "-")
    {
        Console.Clear();
        sonuç = sayı1 - sayı2;
        Console.WriteLine("Sonuç:", sonuç);
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Sadece bu karakterleri girebilirsiniz:x,:,+,-");
    }
}
else if(karakter == "c")
{
    Console.Clear();
}
else if(karakter == "x")
{
    Environment.Exit(0);
}
else
{
    Console.WriteLine("Listedeki tuşlardan birine basabilirsiniz:1,2,x,c");
}
Console.ReadLine();