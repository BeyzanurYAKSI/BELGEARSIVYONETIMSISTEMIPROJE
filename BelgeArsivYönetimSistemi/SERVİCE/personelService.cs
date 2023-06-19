using BelgeArsivYönetimSistemi.DAL;
using BelgeArsivYönetimSistemi.DOMAİN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelgeArsivYönetimSistemi.SERVİCE
{
     class personelService
     {
        internal void personelKaydet(string gPersonelAd, string gPersonelSifre, string gPersonelEmail, string gPersonelTelefon)
        {
            new PersonelDAO().personelKaydet(new Personel(gPersonelAd, Convert.ToInt32(gPersonelSifre), gPersonelEmail, gPersonelTelefon));
        }
     }
}
