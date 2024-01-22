namespace Monambike.Data
{
    public static class Monambike
    {
        public static string Username => "@monambike";

        public static string FirstName => "Vinícius Gabriel";

        public static string SecondName => "Marques de Melo";

        public static DateTime Birthday => new(2002, 11, 24);

        // Personal Website
        public static readonly Link Website = new("https://monambike.com");
        // Instagram Accounts
        public static readonly Link InstagramMonambike = new("https://www.instagram.com/monambike");
        public static readonly Link InstagramMonambikePortfolio = new("https://www.instagram.com/monambike_portfolio");
        // Spotify Account
        public static readonly Link Spotify = new("https://open.spotify.com/user/21jrwvbuag67jrte2nzmplhsy");
        // Steam Account
        public static readonly Link Steam = new("https://steamcommunity.com/id/monambike");
        // YouTube Account
        public static readonly Link YouTubeMonambike = new("https://www.youtube.com/@monambike");
        public static readonly Link YouTubeMonambikePortfolio = new("https://www.youtube.com/@monambike_portfolio");
        public static readonly Link YouTubeMonambikeLive = new("https://www.youtube.com/@monambike_lives");
        // Linkedin Account
        public static readonly Link LinkedIn = new("https://www.linkedin.com/in/monambike/");
        // Code Deploy Account
        public static readonly Link GitHub = new("https://github.com/monambike");
        public static readonly Link ItchIo = new("https://monambike.itch.io/");

        public class Link(string url)
        {
            public string Url { get; set; } = url;
        }
    }
}
