using BelgeArsivYönetimSistemi.DOMAİN;
using MySqlConnector;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelgeArsivYönetimSistemi.DAL
{
     class EmanetDAO
     {
        public void emanetKaydet (Emanet gEmanet)
        {
            (new MySqlCommand ("insert into emanet(evrakAd,ealınmaTarihi,eteslimTarihi,eteslimAlanAd,eteslimAlanIletisim,everenKisininId) values('" +gEmanet.Ad + "','"+ gEmanet.ATarih +"','" + gEmanet.TTarih + "','" + gEmanet.TAAd + "'," + gEmanet.TATelefon +"," + gEmanet.VKisiId + ")"
                , (new dbBaglantı()).baglantiGetir())).ExecuteNonQuery();
        }
        internal System.Collections.ArrayList emanetleriListele()
        {
            ArrayList listelenenEmanetler = new ArrayList();
            MySqlDataReader listelenen = (new MySqlCommand("select * from emanet", (new dbBaglantı()).baglantiGetir())).ExecuteReader();
            while (listelenen.Read())
            {
                listelenenEmanetler.Add(new Emanet(Convert.ToInt32(listelenen[0]), listelenen[1].ToString(), listelenen[2].ToString(), listelenen[3].ToString(), listelenen[4].ToString(), listelenen[5].ToString(),Convert.ToInt32 (listelenen[6])));

            }
            return listelenenEmanetler;
        }
    }
}
