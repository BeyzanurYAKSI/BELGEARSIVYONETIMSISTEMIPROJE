using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelgeArsivYönetimSistemi.DOMAİN
{
     public class Personel
     {
        public Personel(string gAd, int gSifre, string gEmail, string gTelefon)
        {
            this.Ad = gAd;  
            this.Sifre = gSifre;    
            this.Email = gEmail;    
            this.Telefon = gTelefon;    
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
        private int sifre;
        public int Sifre
        {
            get { return sifre; }   
            set { sifre = value; }  
        }
        private string email;
        public string Email
        {
            get { return email; }   
            set { email = value; }  
        }
        private string telefon;
        public string Telefon
        {
            get { return telefon; }
            set {telefon = value;}
        }
     }  

}
