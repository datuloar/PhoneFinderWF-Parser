using HtmlAgilityPack;
using Potapov.PhoneFinder.PhoneFinderLib.Core.Interfaces;
using System;
using System.Linq;
using System.Web;

namespace Potapov.PhoneFinder.PhoneFinderLib.Services.Parsers.Neberitrubku
{
    public class NeberitrubkuParser : IParser<NeberitrubkuPage>
    {
        public NeberitrubkuPage Parse(HtmlDocument document)
        {
            var aboutNumber = document.DocumentNode.
                SelectSingleNode("//*[@class='number']/span[1]")?.InnerText;

            if (aboutNumber == null || aboutNumber == "сотовый телефон")
                throw new Exception("Neberitrubku: No data");

            var containerReviews = document.DocumentNode.SelectNodes("//*[@class='review']");
            var reviews = containerReviews.Select(s =>
            {
                var callType = HttpUtility.HtmlDecode(s
                    .SelectSingleNode(".//h3/span").InnerText);
                var comment = HttpUtility.HtmlDecode(s
                    .SelectSingleNode(".//*[@class='review_comment']").InnerText);

                return new NeberitrubkuReviews(callType, comment);
            });

            return new NeberitrubkuPage(aboutNumber, reviews.ToArray());                                    
        }
    }
}