namespace Potapov.PhoneFinder.PhoneFinderLib.Services.Parsers.Neberitrubku
{
    public class NeberitrubkuPage
    {
        public string AboutNumber { get; }
        public NeberitrubkuReviews[] Reviews { get; }

        public NeberitrubkuPage(string aboutNumber, NeberitrubkuReviews[] reviews)
        {
            AboutNumber = aboutNumber;
            Reviews = reviews;
        }
    }
}
