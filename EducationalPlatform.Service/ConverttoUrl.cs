using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationalPlatform.Application
{
    public static class ConverttoUrl
    {
        public static string ConvertToEmbedUrl(string VideoUrl)
        {
            if (string.IsNullOrWhiteSpace(VideoUrl))
                return string.Empty;

            var uri = new Uri(VideoUrl);
            var query = System.Web.HttpUtility.ParseQueryString(uri.Query);
            var videoId = query["v"];

            return $"https://www.youtube.com/embed/{videoId}";
        }
    }
}
