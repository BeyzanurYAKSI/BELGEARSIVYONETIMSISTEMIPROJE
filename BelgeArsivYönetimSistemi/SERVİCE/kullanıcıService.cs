using BelgeArsivYönetimSistemi.DAL;
using BelgeArsivYönetimSistemi.DOMAİN;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BelgeArsivYönetimSistemi.SERVİCE
{
     class kullanıcıService
     {
        internal void kullanıcıKaydet(string gkullanıcıad, string gkullanıcıSifre, string gkullanıcıTc , string gkullanıcıTelefon , string gkullanıcıEmail , string gkullanıcıDepartman)
        {
            new KullanıcıDAO().kullanıcıKaydet(new Kullanıcı(gkullanıcıad, Convert.ToInt32(gkullanıcıSifre), gkullanıcıTc, gkullanıcıTelefon, gkullanıcıEmail, gkullanıcıDepartman));
        }
        internal System.Collections.ArrayList kullanıcılarıGetir()
        {
            return (new KullanıcıDAO()).kullanıcılarıGetir();
        }
        internal void kullanıcıSil(int gId)
        {
            (new KullanıcıDAO()).kullanıcıSil(gId);
        }
     }  
}
