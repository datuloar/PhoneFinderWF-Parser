using Potapov.PhoneFinder.PhoneFinderLib.Core.Interfaces;

namespace Potapov.PhoneFinder.PhoneFinderLib.Services.Parsers
{
    public class HtmlPageLoader
    {
        private readonly string _pageUrl;

        public HtmlPageLoader(IParserSettings settings)
        {
            _pageUrl = $"{settings.PageUrl}/{settings.PhoneNumber}";
        }

        public string GetUrlForParse()
        {
            return _pageUrl;            
        }     
    }
}
