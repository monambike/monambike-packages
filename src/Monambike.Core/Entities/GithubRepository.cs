using System.Drawing;

namespace Monambike.Core.Entities
{
    /// <summary>
    /// Represents a GitHub repository.
    /// </summary>
    public class GithubRepository
    {
        /// <summary>
        /// Gets or sets the name of the GitHub repository.
        /// </summary>
        public required string Name { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the GitHub repository is private.
        /// </summary>
        public required bool Private { get; set; }

        /// <summary>
        /// Gets or sets the URL of the GitHub repository.
        /// </summary>
        public required string Url { get; set; }

        /// <summary>
        /// Gets or sets the programming language used in the GitHub repository. Can be null.
        /// </summary>
        public string? Language { get; set; } = null;

        /// <summary>
        /// Gets or sets the color associated with the programming language of the GitHub repository. Can be null.
        /// </summary>
        public Color? LanguageColor { get; set; } = null;

        /// <summary>
        /// Gets or sets the date and time when the GitHub repository was created.
        /// </summary>
        public required DateTimeOffset CreateDate { get; set; }

        /// <summary>
        /// Gets or sets the date and time of the last push to the GitHub repository. Can be null.
        /// </summary>
        public required DateTimeOffset? PushDate { get; set; }
    }
}
