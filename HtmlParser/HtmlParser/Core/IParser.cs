using AngleSharp.Html.Dom;

namespace HtmlParser.Core
{
    interface IParser<T> where T : class
    {
        T Parse(IHtmlDocument document, string className);
    }
}
