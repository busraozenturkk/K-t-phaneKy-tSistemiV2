using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KütüphaneKyıtSistemiV2.Model
{
    public class Kitap
    {
        string baglan = "C:\\edukey\\dosya.txt";
        //Property
        public string Ad { get; set; } //set:kaydetmmek,ayarlamak,içine değer göndermek   get:okumak,veriyi çağırmak
        public string Yazar { get; set; }
        public string Yayınevi { get; set; }
        public string Fiyat { get; set; }


        //sanal kolon oluşturma
        public string AdFiyat
        {
            get
            {
                return Ad + " " + Fiyat;
            }
        }



        /*Kayıt çağırma => get
         * Kayıt Silme => get/set
         * Kaayıt Düzenleme => get/set
         * Kaydetme =>set
         */

        public List<Kitap> Get()
        {
            List<Kitap> kitaplar = new List<Kitap>();
            //
            StreamReader sr = new StreamReader(baglan);
            string oku = sr.ReadLine();

            while(oku!= null)
            {
                string[] parcala = oku.Split('$');
                //
                Kitap ktp=new Kitap();
                ktp.Ad = parcala[0];
                ktp.Yazar = parcala[1];
                ktp.Yayınevi = parcala[2];
                ktp.Fiyat = parcala[3];

                kitaplar.Add(ktp);
                //

                oku = sr.ReadLine();
            }

            sr.Close();
            sr.Dispose();
            //
            return kitaplar;
        }

        public void Kaydet(Kitap Model)
        {
            StreamWriter sw=File.AppendText(baglan);
            sw.WriteLine(
                Model.Ad+'$'+
                Model.Yazar + '$' +
                Model.Yayınevi + '$' +
                Model.Fiyat + '$' );

            sw.Close();
            sw.Dispose();
        }

       
    }
}
