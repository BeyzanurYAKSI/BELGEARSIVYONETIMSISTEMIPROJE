using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelgeArsivYönetimSistemi.DOMAİN
{
     class Kullanıcı
     {
        public Kullanıcı(string gAd, int gSifre, string gEmail, string gTelefon, string gDepartman, string gTc)
        {
            this.Ad = gAd;
            this.Sifre = gSifre;    
            this.Email = gEmail;
            this.Telefon = gTelefon;
            this.Departman = gDepartman;
            this.Tc = gTc;

        }
        public Kullanıcı (int gId,string gAd,int gSifre, string gEmail, string gTelefon, string gDepartman, string gTc )
        {
            this.Id = gId;  
            this.Ad = gAd;
            this.Sifre = gSifre; 
            this.Email = gEmail;
            this.Telefon = gTelefon;
            this.Departman = gDepartman;
            this.Tc = gTc;
        }
        private int ıd;
            public int Id
            {
              get { return ıd; }
              set { ıd = value; }
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
        private string tc;

           public string Tc               
           {
             get { return tc; }
             set { tc = value; }
           }
        private string telefon;

           public string Telefon              
           {
             get { return telefon; }
             set { telefon = value; }
           }
        private string email;
            public string Email
            {
              get { return email; }   
              set { email = value; }
            }
        private string departman;
            public string Departman
            {
              get { return departman; }
              set { departman = value; }  
            }
        public override string ToString()
        {
            return this.Id + "-" + this.Ad + "-" + this.Sifre + "-" + this.Tc + "-" + this.Telefon + "-" + this.Email + "-" + this.Departman;
        }
    }  
}
