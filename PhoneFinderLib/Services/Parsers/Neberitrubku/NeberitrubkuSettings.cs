using Potapov.PhoneFinder.PhoneFinderLib.Core.Interfaces;

namespace Potapov.PhoneFinder.PhoneFinderLib.Services.Parsers.Neberitrubku
{
    public class NeberitrubkuSettings : IParserSettings
    {
        public string PageUrl { get; set; } = "https://www.neberitrubku.ru/nomer-telefona";
        public string PhoneNumber { get; }

        public NeberitrubkuSettings(string phoneNumber)
        {
            PhoneNumber = phoneNumber;
        }
    }
}
