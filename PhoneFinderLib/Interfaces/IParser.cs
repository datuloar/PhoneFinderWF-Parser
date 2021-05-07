using HtmlAgilityPack;

namespace Potapov.PhoneFinder.PhoneFinderLib.Core.Interfaces
{
    public interface IParser<T> where T : class
    {
        T Parse(HtmlDocument document);
    }
}
