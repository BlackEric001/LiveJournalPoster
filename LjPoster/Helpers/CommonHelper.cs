using System;
using System.Collections.Generic;
using System.Text;

namespace LjPoster.Helpers
{
    public class CommonHelper
    {
        /// <summary>
        /// Get iframe for posting video from youtube
        /// </summary>
        /// <param name="url"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public static string GetYoutubeIframe(string url, int width = 560, int height = 315, int frameborder = 0, bool allowfullscreen = true)
        {
            string videoId = GetYoutubeVideoId(url);
            string fullScreen = allowfullscreen ? "allowfullscreen" : string.Empty;
            return $"<iframe src=\"https://www.youtube.com/embed/{videoId}\" width=\"{width}\" height=\"{height}\" frameborder=\"{frameborder}\" {fullScreen} data-link=\"https://youtube.com/watch?v={videoId}\"></iframe>";
        }

        private static string GetYoutubeVideoId(string url)
        {
            return url.Substring(url.LastIndexOf('/'));
        }
    }
}
