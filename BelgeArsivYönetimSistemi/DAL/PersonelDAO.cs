using BelgeArsivYönetimSistemi.DOMAİN;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelgeArsivYönetimSistemi.DAL
{
     class PersonelDAO
     {
        public void personelKaydet(Personel gPersonel)
        {
            (new MySqlCommand ("insert into personel (personelAd,personelSifre,personelEmail,personelTelefonNo)values('" + gPersonel.Ad + "', " + gPersonel.Sifre + ",'"+ gPersonel.Email+"'," + gPersonel.Telefon +")"
                , (new dbBaglantı()).baglantiGetir())).ExecuteNonQuery();
        }
     }
}
