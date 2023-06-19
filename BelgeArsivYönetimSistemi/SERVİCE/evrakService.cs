using BelgeArsivYönetimSistemi.DAL;
using BelgeArsivYönetimSistemi.DOMAİN;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace BelgeArsivYönetimSistemi.SERVİCE
{
     class evrakService
     {
		internal void evrakKaydet(string gEvrakAd, string gEvrakKategori, string gEvrakDetay, string gEvrakTarih, string gEvrakKAlanAd, string gEvrakDolapNo, string gEvrakRafNo)
		{
			(new EvrakDAO()).evrakKaydet(new Evrak(gEvrakAd, gEvrakKategori, gEvrakDetay, gEvrakTarih, gEvrakKAlanAd,Convert.ToInt32( gEvrakDolapNo), Convert.ToInt32(gEvrakRafNo)));
	    }
        internal System.Collections.ArrayList evraklarıtrhListele()
        {
            return (new EvrakDAO()).evraklarıtrhListele();
        }






     }
}
