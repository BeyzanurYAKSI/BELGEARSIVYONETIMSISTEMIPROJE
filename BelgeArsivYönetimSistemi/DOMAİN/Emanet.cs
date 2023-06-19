using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelgeArsivYönetimSistemi.DOMAİN
{
    public class Emanet
    {
        public Emanet(string gAd, string gATarih, string TTarih, string gTAAd, string gTATelefon, int gVKisiId )
        {
            this.Ad = gAd;
            this.ATarih = gATarih;
            this.TTarih = TTarih;
            this.TAAd = gTAAd;
            this.TATelefon = gTATelefon;
            this.VKisiId = gVKisiId;
        }
        public Emanet (int gId,string gAd, string gATarih, string TTarih, string gTAAd, string gTATelefon, int gVKisiId)
        {
            this.Id = gId;
            this.ATarih = gATarih;
            this.TTarih = TTarih;
            this.TAAd = gTAAd;
            this.TATelefon = gTATelefon;
            this.VKisiId = gVKisiId;
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
        private string aTarih;
        public string ATarih
        {
            get { return aTarih; }  
            set { aTarih = value; }
        }
        private string tTarih;
        public string TTarih
        {
            get { return tTarih; }
            set { tTarih = value; }
        }
        private string tAAd;
        public string TAAd
        {
            get { return tAAd; }    
            set { tAAd = value; }
        }
        private string tATelefon;
        public string TATelefon
        {
            get { return tATelefon; }   
            set { tATelefon = value; }  
        }
        private int vKisiId;
        public int VKisiId
        {
            get { return vKisiId; }
            set { vKisiId = value;}
        }
        public override string ToString()
        {
            return this.Id + "-" + this.Ad + "-" + this.aTarih + "-" + this.TAAd + "-" + this.TATelefon + "-" + this.VKisiId ; 
        }
    }
}
