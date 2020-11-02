using System;

namespace HtmlParser.Core.Habra
{
    [Obsolete("Используется базовый класс ParserSettings")]
    class HabraSettings : IParserSettings
    {
        public HabraSettings(int start, int end)
        {
            StartPoint = start;
            EndPoint = end;
        }
        public string BaseUrl { get; set; } = "https://habr.com/ru/";
        public string SiteName { get; set; }
        public string Desc { get; set; }
        public string ClassName { get; set; }
        public string Prefix { get; set; } = "page{CurrentId}";
        public int StartPoint { get; set; }
        public int EndPoint { get; set; }
    }
}
