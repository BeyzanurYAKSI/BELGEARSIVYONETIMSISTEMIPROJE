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
     class KullanıcıDAO
     {
        public void kullanıcıKaydet(Kullanıcı gKullanıcı)
        {
            (new MySqlCommand("insert into kullanici (kullaniciAd,kullaniciSifre,kullaniciEmail,kullaniciTelefonNo,kullaniciDepartman,kullaniciTcNo) values ('" + gKullanıcı.Ad + "'," + gKullanıcı.Sifre + ",'" + gKullanıcı.Email + "'," + gKullanıcı.Telefon + ",'" + gKullanıcı.Departman + "'," + gKullanıcı.Tc + ")"
                , (new dbBaglantı()).baglantiGetir())).ExecuteNonQuery();
        }
        internal System.Collections.ArrayList kullanıcılarıGetir()
        {
            ArrayList getirilenKullanıcılar = new ArrayList();
            MySqlDataReader getirilen = (new MySqlCommand("select * from kullanici", (new dbBaglantı()).baglantiGetir())).ExecuteReader();
            while (getirilen.Read())
            {
                getirilenKullanıcılar.Add(new Kullanıcı(Convert.ToInt32(getirilen[0]), getirilen[1].ToString(), Convert.ToInt32 (getirilen[2]), getirilen[3].ToString(), getirilen[4].ToString(), getirilen[5].ToString(), getirilen[6].ToString()));
                
            }
            return getirilenKullanıcılar;
        }
        internal void kullanıcıSil(int gId)
        {
            (new MySqlCommand("delete from kullanici where kullaniciId=" +gId,(new dbBaglantı()).baglantiGetir())).ExecuteNonQuery();
        }
     }
}
