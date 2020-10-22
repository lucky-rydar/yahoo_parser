using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace yahoo_get_symbol_price
{
    class Parser
    {
        private String page;
        
        
        public String Price;
        public String PriceDifference;
        
        public String PreviousClose;
        public String MarketCap;
        public String Volume;
        public String Open;

        public void Parse(String page)
        {
            this.page = page;

            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(page);

            Price = doc.DocumentNode.SelectSingleNode("//div[@class = 'D(ib) Va(m) Maw(65%) Ov(h)']/div[1]/span[1]").InnerText;

            PriceDifference = doc.DocumentNode.SelectSingleNode("//div[@class = 'D(ib) Va(m) Maw(65%) Ov(h)']/div[1]/span[2]").InnerText;

            PreviousClose = doc.DocumentNode.SelectSingleNode("//table[@class = 'W(100%)']/tbody/tr[1]/td[2]/span").InnerText;

            Open = doc.DocumentNode.SelectSingleNode("//table[@class = 'W(100%)']/tbody/tr[2]/td[2]/span").InnerText;

            Volume = doc.DocumentNode.SelectSingleNode("//table[@class = 'W(100%)']/tbody/tr[7]/td[2]/span").InnerText;

            MarketCap = doc.DocumentNode.SelectSingleNode("//table[@class = 'W(100%) M(0) Bdcl(c)']/tbody/tr[1]/td[2]/span").InnerText;
        }


    }
}
