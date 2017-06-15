using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSSReaderUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        


        private void btnHaberleriGetir_Click(object sender, EventArgs e)
        {
            
            //RssReader rss = new RssReader();
            //List<Haber> haberlerim = rss.XmlParcala(txtUrl.Text);
            //RssReaderWithXmlReader rss = new RssReaderWithXmlReader();
            //List<Haber> haberlerim = rss.XmlOku(txtUrl.Text);

            // ilgili linkten xml veriyi çek parçala 
            //Haberler listinden ilgili verileri listviewa ekle
           
            //ListViewDoldur(haberlerim,lsvHaberler);
        }

        private void lsvHaberler_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Eğer bir item seçiliyse o item içinden linki oku ve web browser üzerinde göster...

            if (lsvHaberler.SelectedItems.Count>0)
            {
                string link = ((lsvHaberler.SelectedItems[0].Tag) as Haber).Link;
                webHaber.Navigate(link);
            }
        }

        private void ListViewDoldur(List<Haber> haberlerim,ListView listView)
        {

            foreach (Haber item in haberlerim)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.Baslik;
                lvi.SubItems.Add(item.Link);
                lvi.Tag = item;
                listView.Items.Add(lvi);
            }
        }


        private void Haber(string link)
        {
            RssReaderWithXmlReader rss = new RssReaderWithXmlReader();
            List<Haber> haberlerim = rss.XmlOku(link);
            ListViewDoldur(haberlerim, lsvHaberler);


        }
        private void ekonomiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Haber("http://www.ahaber.com.tr/rss/anasayfa.xml");

        }

        private void sporToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Haber("http://www.ahaber.com.tr/rss/gundem.xml");
        }

        private void magazinToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Haber("http://www.ahaber.com.tr/rss/ekonomi.xml");
        }

        private void sporToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            Haber("http://www.ahaber.com.tr/rss/spor.xml");
        }

        private void yaşamToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Haber("http://www.ahaber.com.tr/rss/yasam.xml");
        }

        private void dünyaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Haber("http://www.ahaber.com.tr/rss/dunya.xml");
        }

        private void son24SaatToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Haber("http://www.ahaber.com.tr/rss/son24saat.xml");
        }

        private void teknolojiToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Haber("http://www.ahaber.com.tr/rss/teknoloji.xml");
        }

        private void magazinToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Haber("http://www.ahaber.com.tr/rss/magazin.xml");
        }

        private void otomobilToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Haber("http://www.ahaber.com.tr/rss/otomobil.xml");
        }

        private void manşetToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Haber("http://www.ahaber.com.tr/rss/haberler.xml");
        }

        private void dinToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Haber("http://www.ahaber.com.tr/rss/din.xml");
        }

        private void tarihToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Haber("http://www.ahaber.com.tr/rss/tarih.xml");
        }

        private void analizToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Haber("http://www.ahaber.com.tr/rss/analiz.xml");
        }

        private void sağlıkToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Haber("http://www.ahaber.com.tr/rss/saglik.xml");
        }

        private void yazarlarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Haber("http://www.ahaber.com.tr/rss/yazarlar.xml");
        }

        private void milliyetToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ekonomiToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Haber("http://www.anadoluhaberajans.com/rss/haber/genel.xml");
        }

        private void sporToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Haber("http://www.anadoluhaberajans.com/rss/haber/gundem.xml");
        }

        private void politikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Haber("http://www.anadoluhaberajans.com/rss/haber/spor.xml");
        }

        private void asayişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Haber("http://www.anadoluhaberajans.com/rss/haber/asayis_1.xml");
        }

        private void ekonomiToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Haber("http://www.anadoluhaberajans.com/rss/haber/ekonomi_1.xml");
        }

        private void siyasetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Haber("http://www.anadoluhaberajans.com/rss/haber/siyaset_1.xml");
        }

        private void eğitimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Haber("http://www.anadoluhaberajans.com/rss/haber/egitim.xml");
        }

        private void ilanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Haber("http://www.anadoluhaberajans.com/rss/haber/ilan.xml");
        }

        private void sağlıkToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Haber("http://www.anadoluhaberajans.com/rss/haber/saglik.xml");
        }

        private void teknolojiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Haber("http://www.anadoluhaberajans.com/rss/haber/teknoloji_1.xml");
        }

        private void magazinToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            Haber("http://www.anadoluhaberajans.com/rss/haber/magazin_2.xml");
        }

        private void sonDakikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Haber("http://www.cnnturk.com/feed/rss/all/news");
        }

        private void türkiyeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Haber("http://www.cnnturk.com/feed/rss/turkiye/news");
        }

        private void dünyaToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Haber("http://www.cnnturk.com/feed/rss/dunya/news");
        }

        private void kültürVeSanatToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Haber("http://www.cnnturk.com/feed/rss/kultur-sanat/news");
        }

        private void bilimVeTeknolojiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Haber("http://www.cnnturk.com/feed/rss/bilim-teknoloji/news");
        }

        private void yaşamToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Haber("http://www.cnnturk.com/feed/rss/yasam/news");
        }

        private void magazinToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Haber("http://www.cnnturk.com/feed/rss/magazin/news");
        }

        private void ekonomiToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Haber("http://www.cnnturk.com/feed/rss/ekonomi/news");
        }

        private void sporToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Haber("http://www.cnnturk.com/feed/rss/spor/news");
        }

        private void sağlıkToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Haber("http://www.cnnturk.com/feed/rss/saglik/news");
        }

        private void yazarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Haber("http://www.cnnturk.com/feed/rss/yazarlar");
        }

        private void otomobilToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Haber("http://www.cnnturk.com/feed/rss/otomobil/news");
        }

        private void seyahatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Haber("http://www.cnnturk.com/feed/rss/seyahat/news");
        }

        private void gündemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Haber("http://www.milliyet.com.tr/rss/rssNew/magazinRss.xml");
        }

        private void kİTAPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Haber("http://www.milliyet.com.tr/rss/rssNew/kitapRss.xml");
        }

        private void eĞİTİMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Haber("http://www.milliyet.com.tr/rss/rssNew/egitimRss.xml");
        }

        private void dünyaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Haber("http://www.milliyet.com.tr/rss/rssNew/dunyaRss.xml");
        }

        private void ekonomiToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Haber("http://www.milliyet.com.tr/rss/rssNew/ekonomiRss.xml");
        }

        private void siyasetToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Haber("http://www.milliyet.com.tr/rss/rssNew/siyasetRss.xml");
        }

        private void otomobilToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Haber("http://www.milliyet.com.tr/rss/rssNew/otomobilRss.xml");
        }

        private void teknolojiToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Haber("http://www.milliyet.com.tr/rss/rssNew/teknolojiRss.xml");
        }

        private void sonDakikaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Haber("http://www.milliyet.com.tr/rss/rssNew/SonDakikaRss.xml");
        }

        private void yazarlarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Haber("http://www.milliyet.com.tr/rss/rssNew/YazarlarRss.xml");
        }
    }
}