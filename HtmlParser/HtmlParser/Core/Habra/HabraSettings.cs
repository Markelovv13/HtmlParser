namespace HtmlParser.Core.Habra
{
    class HabraSettings : IParserSettings
    {
        public string BaseUrl { get; set; } = "https://habr.com/ru/";
        public string Prefix { get; set; } = "page";
        public int StartPoint { get; set; }
        public int EndPoint { get; set; }
    }
}
