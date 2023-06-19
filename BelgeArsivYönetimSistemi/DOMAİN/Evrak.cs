using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelgeArsivYönetimSistemi.DOMAİN
{
   
    public class Evrak
    {
        public Evrak(string gAd, string gKategori, string gDetay, string gTarih, string gKayıtAlanAd, int gDolapNo, int gRafNo)
        {
            this.Ad = gAd;
            this.Kategori = gKategori; 
            this.Detay = gDetay;    
            this.Tarih = gTarih;
            this.KayıtAlanAd = gKayıtAlanAd;
            this.DolapNo = gDolapNo;
            this.RafNo = gRafNo;  
        }
        public Evrak(int gId,string gAd, string gKategori, string gDetay, string gTarih, string gKayıtAlanAd, int gDolapNo, int gRafNo)
        {
            this.Id= gId;
            this.Ad = gAd;
            this.Kategori = gKategori;
            this.Detay = gDetay;
            this.Tarih = gTarih;
            this.KayıtAlanAd = gKayıtAlanAd;
            this.DolapNo = gDolapNo;
            this.RafNo = gRafNo;
        }
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string ad;
        public string Ad
        {
            get { return ad; }
            set { ad = value; } 
        }
        private string kategori;
        public string Kategori
        {
            get { return kategori; }
            set { kategori = value; }   
        }
        private string detay;
        public string Detay
        {
            get { return detay; }   
            set { detay = value; }  
        }
        private string tarih;
        public string Tarih
        {
            get { return tarih; }   
            set { tarih = value; }  
        }
        private string kayıtAlanAd;
        public string KayıtAlanAd
        {
            get { return kayıtAlanAd; }
            set { kayıtAlanAd = value; }
        }
        int dolapNo;
        public int DolapNo
        {
            get { return dolapNo; }
            set { dolapNo = value; }
        }
        private int rafNo;
        public int RafNo
        {
            get { return rafNo; }
            set { rafNo = value; }  
        }
        public override string ToString()
        {
            return this.Tarih + "(" + this.Detay + ")";
        }
    }
}
