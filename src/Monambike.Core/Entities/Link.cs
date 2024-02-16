namespace Monambike.Core.Entities
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Link"/> class with the specified URL.
    /// </summary>
    /// <param name="url">The URL of the link.</param>
    public class Link(string url)
    {
        /// <summary>
        /// Gets the URL of the link.
        /// </summary>
        public Uri Url => new($"https://{url}");

        /// <summary>
        /// Returns the URL as string.
        /// </summary>
        /// <returns>The URL as <see cref="string"/>.</returns>
        public override string ToString() => Url.ToString();
    }
}
