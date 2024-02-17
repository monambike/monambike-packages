using Monambike.Core.Entities;

namespace Monambike.Core.Data
{
    /// <summary>
    /// Links for Monambike's accounts.
    /// </summary>
    public class Links
    {
        /// <summary>
        /// Represents a link for my Personal Website. 
        /// </summary>
        public static Link Website => new("monambike.com");

        /// <summary>
        /// Represents a link for my Blog Website.
        /// </summary>
        public static Link WebsiteBlog => new("blog.monambike.com");

        /// <summary>
        /// Represents a link for my Learn Website.
        /// </summary>
        public static Link WebsiteLearn => new("learn.monambike.com");

        // Instagram Accounts
        /// <summary>
        /// Represents a link for my Instagram main account. (@monambike)
        /// </summary>
        public static Link InstagramMonambike => new("instagram.com/monambike");

        /// <summary>
        /// Portfolio Instagram account. (@monambike_portfolio)
        /// </summary>
        public static Link InstagramMonambikePortfolio => new("instagram.com/monambike_portfolio");

        /// <summary>
        /// Represents a link for my Spotify account.
        /// </summary>
        public static Link Spotify => new("open.spotify.com/user/21jrwvbuag67jrte2nzmplhsy");

        /// <summary>
        /// Represents a link for my Steam account.
        /// </summary>
        public static Link Steam => new("steamcommunity.com/id/monambike");

        /// <summary>
        /// Represents a link for my YouTube main account
        /// </summary>
        public static Link YouTubeMonambike => new("youtube.com/@monambike");

        /// <summary>
        /// Represents a link for my YouTube portfolio account.
        /// </summary>
        public static Link YouTubeMonambikePortfolio => new("youtube.com/@monambike_portfolio");

        /// <summary>
        /// Represents a link for my YouTube live account.
        /// </summary>
        public static Link YouTubeMonambikeLive => new("youtube.com/@monambike_lives");

        /// <summary>
        /// Represents a link for my Linkedin account.
        /// </summary>
        public static Link LinkedIn => new("linkedin.com/in/monambike");

        /// <summary>
        /// Represents a link for my GitHub account.
        /// </summary>
        public static Link GitHub => new("github.com/monambike");

        /// <summary>
        /// Represents a link for my Itch.Io account.
        /// </summary>
        public static Link ItchIo => new("monambike.itch.io/");
    }
}
