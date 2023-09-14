using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OyunServer
{
    class Sabitler
    {
        public static GameServer server = ((GameServer)Application.OpenForms.OfType<GameServer>().SingleOrDefault());
        //Bu kodu yazmamızın sebebi açık olan formu yakalayıp o formdaki nesnelere erişebilmek.
        public static Dictionary<int, Client> bagli_client = new Dictionary<int, Client>();

        public static void oyuncu_baglandi(string connectionID)
        {
            bagli_kullanici_sayisi++;
            Yazi.Log_Yaz("Kullanıcı Server'a Bağlandı" + connectionID);
            Sabitler.server.listBox1.Items.Add(connectionID);
        }
        public static void oyuncu_cikdi(string connectionID)
        {
            bagli_kullanici_sayisi--;
            Yazi.Log_Yaz("Kullanıcı Server'dan Ayrıldı" + connectionID);
            Sabitler.server.listBox1.Items.Remove(connectionID);
        }

        private static int bagli_kullanici_sayisi_ = 0;

        private static int bagli_kullanici_sayisi
        {
            get
            {
                return bagli_kullanici_sayisi;
            }
            set
            {
                bagli_kullanici_sayisi = value;
                server.label1.Text = "Bağlı Kullanıcı Sayısı" + bagli_kullanici_sayisi.ToString();
            }
        }

    }
}
