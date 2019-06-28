using System.Collections.Generic;

namespace Contracts.GoogleBooksApi.Volume.Common
{
    public class VolumeInfo
    {
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public List<Authors> Authors { get; set; }
        public string Publisher { get; set; }
        public string PublishedDate { get; set; }
        public string Description { get; set; }
        //public List<IndustryIdentifiers> IndustryIdentifiers { get; set; }
        //public string industryIdentifiers[].type { get; set; }
        //public string industryIdentifiers[].identifier { get; set; }
        //public int pageCount { get; set; }
        //public object dimensions { get; set; }
        //public string dimensions.height { get; set; }
        //public string dimensions.width { get; set; }
        //public string dimensions.thickness { get; set; }
        //public string printType { get; set; }
        //public list categories[] { get; set; }
        //public double averageRating { get; set; }
        //public int ratingsCount { get; set; }
        //public string contentVersion { get; set; }
        //public object imageLinks { get; set; }
        //public string imageLinks.thumbnail { get; set; }
        //public string imageLinks.small { get; set; }
        //public string imageLinks.medium { get; set; }
        //public string imageLinks.large { get; set; }
        //public string imageLinks.smallThumbnail { get; set; }
        //public string imageLinks.extraLarge { get; set; }
        //public string language { get; set; }
        //public string mainCategory { get; set; }
        //public string previewLink { get; set; }
    }
}