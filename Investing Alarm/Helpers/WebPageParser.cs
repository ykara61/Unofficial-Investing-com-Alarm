using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investing_Alarm.Helpers
{
    public class WebPageParser
    {
        public float value = 0;
        public float changeInInstrument = 0;
        public string title = "";
        
        public void ParseAllHtml(string html)
        {
            value = currenyValueParser(html);
            changeInInstrument = GetChangeInValue(html);
            title = currenyTitleParser(html);
        }
        
        public float GetChangeInValue(string html)
        {
            var output = html.Replace(@"\u003C", "<");
            var tokens = output.Split(new[] { "instrument-price-change" }, StringSplitOptions.None)[1].Split('\u003C')[0].ToString();
            var value = tokens.Split('>')[1];
            float.TryParse(value, out float _value);
            return _value;
        }

        public float currenyValueParser(string html)
        {
            var output = html.Replace(@"\u003C", "<");
            var tokens = output.Split(new[] { "instrument-price-last" }, StringSplitOptions.None)[1].Split('\u003C')[0].ToString();
            var value = tokens.Split('>')[1];
            float.TryParse(value, out float _value);
            return _value;
        }

        public string currenyTitleParser(string html)
        {
            var output = html.Replace(@"\u003C", "<");
            var tokens = output.Split(new[] { "inv-link bold datatable_cell--name" }, StringSplitOptions.None)[1].Split('\u003C')[0].ToString();
            var value = tokens.Split('>')[1];
            return value;
        }
    }
}
