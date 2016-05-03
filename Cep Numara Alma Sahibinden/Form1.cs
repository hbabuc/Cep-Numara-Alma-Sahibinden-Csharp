using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;

namespace Cep_Numara_Alma_Sahibinden
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        WebResponse wRes;
        HttpWebRequest wReq;
        StreamReader sr;
        StreamWriter sw;
        int sira = -1;
        string yol;
        Thread th;
        bool adresBittimi = false;
        int sure = 0;
        System.Timers.Timer timer1;

        

        public string veriCek(string qq)
        {
            wReq = (HttpWebRequest)WebRequest.Create(qq);

            wReq.Credentials = CredentialCache.DefaultCredentials;

            wReq.UserAgent = "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; Trident/5.0)";

            wRes = wReq.GetResponse();

            sr = new StreamReader(wRes.GetResponseStream());

            string s = sr.ReadToEnd();

            sr.Close();

            wReq.Abort();

            wRes.Close();

            return s;
        }

        public void sayfaAdresleriCek()
        {
            cekilenList.Items.Clear();

            string link = (linkTxt.Text.Contains("query_text")) ? linkTxt.Text + "&pagingSize=" + kactaneTxt.Text + "&pagingOffset=" + baslangicTxt.Text : linkTxt.Text + "?pagingSize=" + kactaneTxt.Text + "&pagingOffset=" + baslangicTxt.Text;

            string s = veriCek(link);

            durumYaz("Durum : Site adresleri çekildi...");

            string[] d = Regex.Split(s, "<a href=\"/ilan/");

            string[] c;

            for (int i = 1; i < d.Length; i++)
            {
                c = Regex.Split(d[i], "/detay\">");
                cekilenList.Items.Add("http://www.sahibinden.com/ilan/" + c[0] + "/detay");
            }

            if (cekilenList.Items.Count < Int32.Parse(kactaneTxt.Text))
            {
                adresBittimi = true;
            }

            durumYaz("Durum : " + baslangicTxt.Text + "'dan başlayıp " + cekilenList.Items.Count + " adet adres çekildi...");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yol = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\cep-no-" + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + "-" + DateTime.Now.Hour + "-" + DateTime.Now.Minute + "-" + DateTime.Now.Second + ".txt";

            if (!File.Exists(yol))
            {
                File.Create(yol);
            }

            tumuTxt.Text = "";    

            button1.Enabled = false;

            sayfaAdresleriCek();

            timer1.Start();
           
        }

        void timer1_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            sira++;
            th = new Thread(new ThreadStart(telefonCek));

            th.Start();
        }

        public void dosyayaYaz(string s)
        {
            sw = new StreamWriter(yol,true);

            sw.WriteLine(s);

            sw.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            th = new Thread(new ThreadStart(telefonCek));

            durumYaz("Durum : Başlatılma bekleniyor...");

            CheckForIllegalCrossThreadCalls = false;

            timer1 = new System.Timers.Timer();

            timer1.Elapsed += new System.Timers.ElapsedEventHandler(timer1_Elapsed);

            timer1.AutoReset = false;

            timer1.Interval = 5000;

        }


        public void telefonCek()
        {
            if (sira <= cekilenList.Items.Count - 1)
            {
                
                try
                {
                    cekilenList.SelectedIndex = sira;

                    string gg = veriCek(cekilenList.Items[sira].ToString());

                    durumYaz("Durum : " + (sira + 1).ToString() + " sayfa çekildi...");

                    string[] ss = Regex.Split(gg, "<strong>Cep</strong>");

                    string[] dd = Regex.Split(ss[1], "</li>");

                    dosyayaYaz(dd[0].Replace("<span>", "").Replace("</span>", "").Trim());

                    tumuTxt.Text += dd[0].Replace("<span>","").Replace("</span>","").Trim() + Environment.NewLine;
                }
                catch (Exception)
                {

                    durumYaz("Durum : " + sira.ToString() + ". sıradaki sayfada cep nosu yok veya banlandı. bu hatayı çok alıyorsanız banlanmışsınızdır.");
                }
            }
            else
            {

                if (adresBittimi)
                {
                    durumYaz("Durum : Çekilen adresler bitti program durduruldu.");

                    sira = -1;

                    timer1.Stop();

                    timer1.Enabled = false;

                    button1.Enabled = true;

                    th.Abort();

                    //MessageBox.Show("Adresler bitti.");

                }
                else
                {
                    durumYaz("Durum : Şuanki çekilen adresler bitti yeni adresler çekiliyor...");

                    durumList.Items.Clear();

                    sira = -1;

                    baslangicTxt.Text = (Int32.Parse(baslangicTxt.Text) + Int32.Parse(kactaneTxt.Text)).ToString();

                    sayfaAdresleriCek();

                    //th.Abort();

                    // timer1.Start();
                }
                
            }

            sure = new Random().Next(Int32.Parse(kacSaniyeTxt.Text),Int32.Parse(kacSaniyede2.Text));

            durumYaz("Durum : " + sure.ToString() + " saniye sonra tekrar numara çekilecek...");

            timer1.Interval = sure * 1000;

            // timer1.Start();
        }

        public void durumYaz(string s)
        {
            durumList.Items.Add(s);
            durumList.TopIndex = durumList.Items.Count - 5;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (th.IsAlive) th.Abort();
        }
    }
}
