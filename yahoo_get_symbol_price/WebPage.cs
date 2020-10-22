using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Diagnostics;

namespace yahoo_get_symbol_price
{
    class WebPage
    {
        //private String symbol;
        private String pageHtml;

        public String getPage(String symbol)
        {
            String url = "https://finance.yahoo.com/quote/" + symbol + "?p=" + symbol + "&.tsrc=fin-srch";

            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(url);
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();

            Stream streamResult = res.GetResponseStream();
            StreamReader reader = new StreamReader(streamResult);
            pageHtml = reader.ReadToEnd();

            Debug.Print(pageHtml);

            if (req != null)
                return pageHtml;
            else
                return null;
        }


    }
}
