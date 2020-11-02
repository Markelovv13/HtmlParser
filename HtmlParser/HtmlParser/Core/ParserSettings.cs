using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlParser.Core
{
    class ParserSettings : IParserSettings
    {
        public string BaseUrl { get; set; }
        public string Prefix { get; set; }
        public string SiteName { get; set; }
        public string Desc { get; set; }
        public string ClassName { get; set; }
        public int StartPoint { get; set; }
        public int EndPoint { get; set; }
    }
}
