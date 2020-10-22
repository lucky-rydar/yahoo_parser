using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yahoo_get_symbol_price
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WebPage page = new WebPage();
            String str_page = page.getPage(SymbolTextEdit.Text);

            Symbol.Text = SymbolTextEdit.Text.ToUpper();

            try
            {
                Parser parser = new Parser();
                parser.Parse(str_page);

                //price
                if (parser.Price == null)
                    parser.Price = "0.0";
                PriceLabel.Text = parser.Price + " $";

                //diference
                if (parser.PriceDifference == null)
                    parser.PriceDifference = "0.0 (0%)";
                PriceDifference.Text = parser.PriceDifference;

                if (parser.PriceDifference.ToArray()[0] == '+')
                    PriceDifference.ForeColor = Color.FromName("LimeGreen");
                else if (parser.PriceDifference.ToArray()[0] == '-')
                    PriceDifference.ForeColor = Color.FromName("Red");
                else
                    PriceDifference.ForeColor = Color.FromName("Black");

                //other params
                if (parser.PreviousClose == null)
                    parser.PreviousClose = "0.0";
                PreviousClose.Text = parser.PreviousClose + " $";
                if (parser.Open == null)
                    parser.Open = "0.0";
                Open.Text = parser.Open + " $";
                if (parser.Volume == null)
                    parser.Volume = "0.0";
                Volume.Text = parser.Volume + " $";
                if (parser.MarketCap == null)
                    parser.MarketCap = "0.0";
                MarketCap.Text = parser.MarketCap + " $";
            }
            catch { }
        }
    }
}
