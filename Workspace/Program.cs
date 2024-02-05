using Business.Concrete;
using Entities.Concrete;

internal class Program
{
    private static void Main(string[] args)
    {
       


        //string ogrenci1 = "Engin";
        //string ogrenci2 = "Kerem";
        //string ogrenci3 = "Berkay";

     

        //string[] ogrenciler = new string[3];
        //ogrenciler[0] = "Engin";
        //ogrenciler[1] = "Kerem";
        //ogrenciler[2] = "Berkay";

        //ogrenciler = new string[4];
        //ogrenciler[3] = "İlker";

        //for (int i = 0; i < ogrenciler.Length; i++)
        //{
        //    Console.WriteLine(ogrenciler[i]);
        //}

        //string[] sehirler1 = new[] { "Ankara", "İstanbul", "izmir" };
        //string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

        //sehirler2 = sehirler1;
        //sehirler1[0] = "Adana";
        //Console.WriteLine(sehirler2[0]);

        Person person1 = new Person();
        person1.FirstName = "Kazım";
        person1.LastName = "Başar";
        person1.DateOfBirthYear = 1995;
        person1.NationalIdentity = 123123;


        Person person2 = new Person();
        person2.FirstName = "Murat";

        //foreach (string sehir in sehirler1)
        //{
        //    Console.WriteLine(sehir);
        //}

   
        //List<string> yeniSehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };
        //yeniSehirler1.Add("Adana 1");
        //foreach (var sehir in yeniSehirler1)
        //{
        //    Console.WriteLine(sehir);
        //}

        PttManager pttManager = new PttManager(new CitizenManager());
        pttManager.GiveMask(person1);

        Console.ReadLine();
    }

  

//    static int Topla(int sayi1 = 5, int sayi2 = 10)
//    {
//        int sonuc = sayi1 + sayi2;
//        Console.WriteLine("Toplam : " + sonuc.ToString());
//        return sonuc;
//    }

}