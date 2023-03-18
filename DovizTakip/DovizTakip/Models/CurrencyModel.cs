using System;

namespace DovizTakip.Models
{
    public class CurrencyModel
    {
        //Tabloda kullanılacak
        public int Id { get; set; }
        public int Birim { get; set; }

        //Tabloda kullanılacak
        public DateTime Tarih { get; set; }
        public string Ad { get; set; }

        //Tabloda kullanılacak
        public string KurAdi { get; set; }

        //Satış Değeri
        public float DegerSatis { get; set; }

        //Alış değeri
        //Tabloda kullanılacak
        public float DegerAlis { get; set; }
        public float BanknotSatis { get; set; }
        public float BanknotAlis { get; set; }

    }
}
