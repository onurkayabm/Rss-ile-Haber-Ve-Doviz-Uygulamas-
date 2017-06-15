using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace RSSReaderUygulaması
{
    class RssReaderWithXmlReader
    {
        public List<Haber> XmlOku(string url)
        {
            List<Haber> haberlerim = new List<Haber>();
            XmlReader reader = XmlReader.Create(url);
            bool itemMi = false;
            while (itemMi || reader.Read())
            {
               
                if (reader.Name=="item")
                {
                    itemMi = false;
                    Haber haber = new Haber();
                    bool okuyayimMi = true;
                    while (okuyayimMi && reader.Read())
                    {
                        if (reader.IsStartElement())
                        {
                            
                        switch (reader.Name)
                        {
                            case "title":
                                reader.Read();
                                haber.Baslik = reader.Value;
                                break;
                            case "link":
                                reader.Read();
                                haber.Link = reader.Value;
                                break;
                            case "description":
                                reader.Read();
                                haber.Aciklama = reader.Value;
                                break;
                            case "pubDate":
                                reader.Read();
                                haber.Tarih = reader.Value;
                                break;
                            case "item":
                             
                                okuyayimMi = false;
                                itemMi = true;
                                break;
                        }
                        }
                    }
                    haberlerim.Add(haber);
                }
            }
            return haberlerim;
        }

    }
}
