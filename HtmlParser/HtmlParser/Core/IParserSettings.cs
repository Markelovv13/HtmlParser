namespace HtmlParser.Core
{
    interface IParserSettings
    {
        string BaseUrl { get; set; }
        string SiteName { get; set; }
        string Desc { get; set; }
        string ClassName { get; set; }
        string Prefix { get; set; }
        int StartPoint { get; set; }
        int EndPoint { get; set; }
    }
}
