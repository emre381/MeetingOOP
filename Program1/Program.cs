using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
     class Program
    {
        class Insan { 
        private string isim;
        private int yas;
        public void selamver()
        {
            Console.WriteLine("Merhaba");
        }
        public void bilgileriSor()
        {
            Console.WriteLine("Adın ne ve kaç yaşındasın ? ");
        }
        public void cevapVer()
        {
            Console.WriteLine("Benim adım"+ isim + "ve yaşım" + yas );
        }
        public void isimVeYasDuzenleme(string isim, int yas)
        {
            this.isim = isim;
            this.yas = yas; 
        }
        }
        static void Main(string[] args)
        {
            Insan i1 = new Insan();
            Insan i2 = new Insan();
            i1.isimVeYasDuzenleme("Emre",24);
            i2.isimVeYasDuzenleme("Ahmet", 33);

            i1.selamver();
            i2.selamver();
            i1.bilgileriSor();
            i2.cevapVer();
            i2.bilgileriSor();
            i1.cevapVer();

            Console.ReadLine();

        }
    }
}
