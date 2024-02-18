using Monambike.Core.Services;
using Newtonsoft.Json;
using System.Drawing;

namespace Monambike.Core.Models
{
    /// <summary>
    /// Provides functionality to retrieve language colors from GitHub using a third-party.
    /// </summary>
    internal static class GithubLanguage
    {
        /// <summary>
        /// Gets the HTTP service instance for making requests to third-party API.
        /// </summary>
        private static HttpService HttpService => new("https://raw.githubusercontent.com/ozh/github-colors/master/");

        /// <summary>
        /// Asynchronously retrieves language colors like from GitHub.
        /// </summary>
        /// <returns>A list of LanguageColor objects representing language names and their corresponding colors.</returns>
        internal static async Task<List<LanguageColor>> GetLanguageColors()
        {
            // Retrieve JSON data containing language colors from GitHub.
            var jsonColors = await HttpService.GetAsync<Dictionary<string, JsonColor>>("colors.json");

            // Throw ArgumentNullException if the retrieved JSON colors are null.
            ArgumentNullException.ThrowIfNull(jsonColors);

            // Create the list for holding the LanguageColor objects.
            var languageColors = new List<LanguageColor>();

            // Convert JSON colors to LanguageColor objects.
            foreach (var jsonColor in jsonColors)
                languageColors.Add(new LanguageColor
                {
                    Name = jsonColor.Key,
                    HexColor = jsonColor.Value.Color
                });

            // Return the list of LanguageColor objects.
            return languageColors;
        }

        /// <summary>
        /// Represents the JSON structure for language colors retrieved from GitHub.
        /// </summary>
        public class JsonColor
        {
            /// <summary>
            /// Gets or initializes the hexadecimal color code.
            /// </summary>

            [JsonProperty("color")]
            public required string Color { get; init; }
        }

        /// <summary>
        /// Represents a programming language with its corresponding color.
        /// </summary>
        public class LanguageColor
        {
            /// <summary>
            /// Gets or initializes the name of the programming language.
            /// </summary>
            public required string Name { get; init; }

            /// <summary>
            /// Gets or initializes the hexadecimal color code.
            /// </summary>
            public required string HexColor { get; init; }

            /// <summary>
            /// Gets the RGB color equivalent of the hexadecimal color code.
            /// </summary>
            public Color RgbColor =>  ColorTranslator.FromHtml(HexColor);
        }
    }
}
