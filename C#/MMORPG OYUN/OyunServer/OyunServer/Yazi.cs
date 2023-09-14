using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OyunServer
{
    class Yazi
    {

        public static void Bilgi_Yazi(string text,Color? renk = null)
        { 
            if (Sabitler.server.richTextBox2.Text.Length != 0)
            {
                Control.CheckForIllegalCrossThreadCalls = false;
                //Aynı anda erişilebilirliği açmak için kullanıyoruz
                Sabitler.server.richTextBox2.AppendText(Environment.NewLine + text);
                //Yeni Satıra yazımızı yazmak için kullanıyoruz
                Sabitler.server.richTextBox2.Select(Sabitler.server.richTextBox2.Text.Length - text.Length,text.Length);
                //Bizim yazımızın uzunluğu kadar bir yeri işaretlettiriyoruz
                Sabitler.server.richTextBox2.SelectionColor = renk ?? Color.Green;
                //Seçtiğimiz değer null ise yeşil renk'e boyuyacak
                Sabitler.server.richTextBox2.SelectionStart = Sabitler.server.richTextBox2.Text.Length;
                Sabitler.server.richTextBox2.ScrollToCaret();  
            }
        }
        public static void Hata_Yaz(string text)
        {
            if (Sabitler.server.richTextBox2.Text.Length != 0)
            {
                Control.CheckForIllegalCrossThreadCalls = false;
                //Aynı anda erişilebilirliği açmak için kullanıyoruz
                Sabitler.server.richTextBox2.AppendText(Environment.NewLine + text);
                //Yeni Satıra yazımızı yazmak için kullanıyoruz
                Sabitler.server.richTextBox2.Select(Sabitler.server.richTextBox2.Text.Length - text.Length, text.Length);
                //Bizim yazımızın uzunluğu kadar bir yeri işaretlettiriyoruz
                Sabitler.server.richTextBox2.SelectionColor =Color.Red;
                //Seçtiğimiz değeri kırmızı renge boyuyacak
                Sabitler.server.richTextBox2.SelectionStart = Sabitler.server.richTextBox2.Text.Length;
                Sabitler.server.richTextBox2.ScrollToCaret();
            }
        }

        public static void Log_Yaz(string text, Color? renk = null)
        {
            if (Sabitler.server.richTextBox1.Text.Length != 0)
            {
                Control.CheckForIllegalCrossThreadCalls = false;
                //Aynı anda erişilebilirliği açmak için kullanıyoruz
                Sabitler.server.richTextBox1.AppendText(Environment.NewLine + text);
                //Yeni Satıra yazımızı yazmak için kullanıyoruz
                Sabitler.server.richTextBox1.Select(Sabitler.server.richTextBox1.Text.Length - text.Length, text.Length);
                //Bizim yazımızın uzunluğu kadar bir yeri işaretlettiriyoruz
                Sabitler.server.richTextBox1.SelectionColor = renk ?? Color.Green;
                //Seçtiğimiz değer null ise yeşil renk'e boyuyacak
                Sabitler.server.richTextBox1.SelectionStart = Sabitler.server.richTextBox1.Text.Length;
                Sabitler.server.richTextBox1.ScrollToCaret();
            }
        }

        public static void Gelen_Mesaj(string text)
        {
            if (Sabitler.server.richTextBox1.Text.Length != 0)
            {
                Control.CheckForIllegalCrossThreadCalls = false;
                //Aynı anda erişilebilirliği açmak için kullanıyoruz
                Sabitler.server.richTextBox1.AppendText(Environment.NewLine + text);
                //Yeni Satıra yazımızı yazmak için kullanıyoruz
                Sabitler.server.richTextBox1.Select(Sabitler.server.richTextBox1.Text.Length - text.Length, text.Length);
                //Bizim yazımızın uzunluğu kadar bir yeri işaretlettiriyoruz
                Sabitler.server.richTextBox1.SelectionColor = Color.Black;
                //Seçtiğimiz değeri kırmızı renge boyuyacak
                Sabitler.server.richTextBox1.SelectionStart = Sabitler.server.richTextBox1.Text.Length;
                Sabitler.server.richTextBox1.ScrollToCaret();
            }
        }
    }
}
