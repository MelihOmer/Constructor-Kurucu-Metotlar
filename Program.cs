using System;

namespace Kurucu_Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
             Calisan calisan1 = new Calisan("Melih Ömer","Kamar",12345678,"Software Developer");
            System.Console.WriteLine("Çalışan 1");
            calisan1.CalisanBilgileri();
            System.Console.WriteLine("Çalışan 2");


            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Deniz";
            calisan2.Soyad = "Arda";
            calisan2.No=87654321;
            calisan2.Departman ="İnsan Kaynakları";
            calisan2.CalisanBilgileri();
            System.Console.WriteLine("Çalışan 3");
            Calisan calisan3 = new Calisan("Zikriye","Ürkmez");
            calisan3.CalisanBilgileri();
        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public Calisan(string ad, string soyad, int no, string departman)
        {
            this.Ad=ad;
            this.Soyad=soyad;
            this.No=no;
            this.Departman=departman;
        }
        public Calisan(string ad, string soyad)
        {
            this.Ad=ad;
            this.Soyad=soyad;
        }
        public Calisan(){}
        
        public void CalisanBilgileri()
        {
            System.Console.WriteLine("Çalışan Adı :{0}",Ad);
            System.Console.WriteLine("Çalışan Soy Adı :{0}",Soyad);
            System.Console.WriteLine("Çalışan Numarası :{0}",No);
            System.Console.WriteLine("Çalışan Departmanı :{0}",Departman);
        }
    }
}
