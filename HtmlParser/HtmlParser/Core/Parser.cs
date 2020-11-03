using AngleSharp.Html.Dom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlParser.Core.Habra
{
    class Parser : IParser<string[]>
    {
        public string[] Parse(IHtmlDocument document, string className, string querySelector)
        {
            var list = new List<string>();
            var items = document.QuerySelectorAll(querySelector).Where(item => item.ClassName != null && item.ClassName.Contains(className));

            foreach (var item in items)
            {
                list.Add(item.TextContent);
            }

            return list.ToArray();
        }
    }
}
