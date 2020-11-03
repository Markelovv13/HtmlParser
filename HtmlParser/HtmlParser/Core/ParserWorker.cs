using AngleSharp.Html.Parser;
using System;
using System.Threading.Tasks;
using Parser = AngleSharp.Html.Parser.HtmlParser;

namespace HtmlParser.Core
{
    class ParserWorker<T> where T : class
    {
        IParser<T> parser;
        IParserSettings parserSettings;
        HtmlLoader htmlLoader;
        bool isActive;

        public IParser<T> Parser
        {
            get
            {
                return parser;
            }
            set
            {
                parser = value;
            }
        }
        public IParserSettings Settings
        {
            get 
            {
                return parserSettings;
            }
            set 
            {
                parserSettings = value;
                htmlLoader = new HtmlLoader(value);
            }
        }
        public bool IsActive
        {
            get 
            {
                return isActive;
            }
        }
        public event Action<object, T> OnNewData;
        public event Action<object> OnCompleted;

        public ParserWorker(IParser<T> parser)
        {
            this.parser = parser;
        }

        public ParserWorker(IParser<T> parser, IParserSettings parserSettings) : this(parser)
        {
            this.parserSettings = parserSettings;
        }

        public void Start()
        {
            isActive = true;
            Worker();
        }

        public void Abort()
        {
            isActive = false;
        }

        private async void Worker()
        {
            for (int i = parserSettings.StartPoint; i <= parserSettings.EndPoint; i++)
            {
                if (!isActive)
                {
                    OnCompleted?.Invoke(this);
                    return;
                }

                var source = await htmlLoader.GetSourceByPageId(i);
                var domParser = new Parser();

                var document = await domParser.ParseDocumentAsync(source);

                var result = parser.Parse(document, Settings.ClassName, Settings.QuerySelector);

                OnNewData?.Invoke(this, result);
            }
            OnCompleted?.Invoke(this);
            isActive = false;
        }
    }
}
