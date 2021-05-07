using HtmlAgilityPack;
using Potapov.PhoneFinder.PhoneFinderLib.Core.Interfaces;

namespace Potapov.PhoneFinder.PhoneFinderLib.Services.Parsers
{
    public class ParserWorker<T> where T : class
    {
        private HtmlPageLoader _loader;        

        private IParser<T> _parser;
        public IParser<T> Parser
        {
            get
            {
                return _parser;
            }
            set
            {
                _parser = value;
            }
        }

        private IParserSettings _settings;
        public IParserSettings Settings
        {
            get
            {
                return _settings;
            }
            set
            {
                _settings = value;
                _loader = new HtmlPageLoader(value);
            }
        }

        public ParserWorker(IParser<T> parser)
        {
            _parser = parser;
        }

        public ParserWorker(IParser<T> parser, IParserSettings settings)
            : this(parser)
        {
            _settings = settings;
        }

        public T GetParsedPage()
        {
            var web = new HtmlWeb();

            var urlForParse = _loader.GetUrlForParse();

            var document = web.Load(urlForParse);

            return _parser.Parse(document);
        }
    }
}
