namespace Potapov.PhoneFinder.PhoneFinderLib.Services.Parsers.Neberitrubku
{
    public class NeberitrubkuReviews
    {
        public string CallType { get; }
        public string Comment { get;  }

        public NeberitrubkuReviews(string callType, string comment)
        {
            CallType = callType;
            Comment = comment;
        }
    }
}
