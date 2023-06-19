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
     class EvrakDAO
     {
        public void evrakKaydet(Evrak gEvrak)
        {
            (new MySqlCommand("insert into evraklar (evrakAd,evrakKategori,evrakDetay,evrakKTarihi,evrakKAlanAd,evrakDolapNo,evrakRafNo) values ('" + gEvrak.Ad + "','" + gEvrak.Kategori + "','" + gEvrak.Detay + "','" + gEvrak.Tarih + "','" + gEvrak.KayıtAlanAd +"','" + gEvrak.DolapNo + "','" + gEvrak.RafNo +"')"
                , (new dbBaglantı()).baglantiGetir())).ExecuteNonQuery();
        }
        internal System.Collections.ArrayList evraklarıtrhListele()
        {
            ArrayList listelenenEvraklarıTrh = new ArrayList();
            MySqlDataReader listelenen = (new MySqlCommand("select * from evraklar", (new dbBaglantı()).baglantiGetir())).ExecuteReader();
            while (listelenen.Read())
            {
                listelenenEvraklarıTrh.Add(new Evrak(Convert.ToInt32(listelenen[0]), listelenen[1].ToString(), listelenen[2].ToString(), listelenen[3].ToString(), listelenen[4].ToString(), listelenen[5].ToString(), Convert.ToInt32(listelenen[6]), Convert.ToInt32(listelenen[7])));

            }
            return listelenenEvraklarıTrh;
        }
     }
}