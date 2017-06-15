using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Xml;

namespace RSSReaderUygulaması
{
    class RssReader
    {


        //İlgili xml dosyasını bu tarafa çekme
        private XmlDocument XmlCek(string url) 
        {
            WebClient webClient = new WebClient();
            webClient.Encoding = Encoding.UTF8;
            string rssData = webClient.DownloadString(url);
            XmlDocument xmlDosyasi = new XmlDocument();
            xmlDosyasi.LoadXml(rssData);
            return xmlDosyasi;
        }

        //Çektiğim xml dosyayı uygun nesne modeline parçala

        public List<Haber> XmlParcala(string url)
        {
            List<Haber> haberlerim = new List<Haber>();
            XmlDocument xml = XmlCek(url);
            XmlNodeList nodeList = xml.SelectNodes("rss/channel/item");
            foreach (XmlNode item in nodeList)
            {
                Haber haber = new Haber();
                haber.Baslik = item.SelectSingleNode("title").InnerText;
                haber.Link = item.SelectSingleNode("link").InnerText;
                haber.Aciklama = item.SelectSingleNode("description").InnerText;
                haber.Tarih = item.SelectSingleNode("pubDate").InnerText;
                haberlerim.Add(haber);
            }
            return haberlerim;

        }
    }
}
