using Monambike.Core.Entities;

namespace Monambike.Core.Data
{
    /// <summary>
    /// Links for Monambike's accounts.
    /// </summary>
    public class Links
    {
        /// <summary>
        /// Personal Website. 
        /// </summary>
        public static Link Website => new("monambike.com");

        /// <summary>
        /// Blog Website.
        /// </summary>
        public static Link WebsiteBlog => new("blog.monambike.com");

        /// <summary>
        /// Learn Website.
        /// </summary>
        public static Link WebsiteLearn => new("learn.monambike.com");

        // Instagram Accounts
        /// <summary>
        /// Main Instagram account. (@monambike)
        /// </summary>
        public static Link InstagramMonambike => new("instagram.com/monambike");

        /// <summary>
        /// Portfolio Instagram account. (@monambike_portfolio)
        /// </summary>
        public static Link InstagramMonambikePortfolio => new("instagram.com/monambike_portfolio");

        /// <summary>
        /// Spotify account.
        /// </summary>
        public static Link Spotify => new("open.spotify.com/user/21jrwvbuag67jrte2nzmplhsy");

        /// <summary>
        /// Steam account.
        /// </summary>
        public static Link Steam => new("steamcommunity.com/id/monambike");

        /// <summary>
        /// Main YouTube account
        /// </summary>
        public static Link YouTubeMonambike => new("youtube.com/@monambike");

        /// <summary>
        /// Portfolio YouTube account.
        /// </summary>
        public static Link YouTubeMonambikePortfolio => new("youtube.com/@monambike_portfolio");

        /// <summary>
        /// Live YouTube account.
        /// </summary>
        public static Link YouTubeMonambikeLive => new("youtube.com/@monambike_lives");

        /// <summary>
        /// Linkedin account.
        /// </summary>
        public static Link LinkedIn => new("linkedin.com/in/monambike");

        /// <summary>
        /// GitHub account.
        /// </summary>
        public static Link GitHub => new("github.com/monambike");

        /// <summary>
        /// Itch.Io account.
        /// </summary>
        public static Link ItchIo => new("monambike.itch.io/");
    }
}
