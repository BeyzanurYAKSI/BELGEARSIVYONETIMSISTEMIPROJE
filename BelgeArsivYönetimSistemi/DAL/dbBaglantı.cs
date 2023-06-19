using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelgeArsivYönetimSistemi.DAL
{
    internal class dbBaglantı
    {
        

        public MySqlConnection baglantiGetir()
        {
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.3; Database=Grup17-2023; Uid=Grup17-2023; Pwd=NyP:974.cc");
            baglanti.Open();
            return baglanti;
        }

    }
}
