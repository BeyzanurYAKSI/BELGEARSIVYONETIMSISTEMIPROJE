using BelgeArsivYönetimSistemi.DAL;
using BelgeArsivYönetimSistemi.DOMAİN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelgeArsivYönetimSistemi.SERVİCE
{
     class emanetService
     {
        internal void emanetKaydet(string gEmanetAd,string gEmanetATarih,string gEmanetTTarih, string gEmanetTAAd,string gEmanetTATelefon,string gEmanetVKisiId)
        {
            new EmanetDAO().emanetKaydet(new Emanet(gEmanetAd, gEmanetATarih, gEmanetTTarih, gEmanetTAAd, gEmanetTATelefon, Convert.ToInt32(gEmanetVKisiId)));
        }
        internal System.Collections.ArrayList emanetleriListele()
        {
            return (new EmanetDAO()).emanetleriListele();
        }
    }
}
