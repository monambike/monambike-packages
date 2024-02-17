using Monambike.Core.Data;
using Monambike.Core.Entities;
using Octokit;

namespace Monambike.Core.Models
{
    /// <summary>
    /// Provides methods for interacting with GitHub repositories.
    /// </summary>
    public static class Github
    {
        /// <summary>
        /// Gets the product header value for API requests.
        /// </summary>
        private static ProductHeaderValue ProductHeaderValue => new("monambike-core");

        /// <summary>
        /// Gets the GitHub client instance for making API requests.
        /// </summary>
        private static GitHubClient GitHub => new(ProductHeaderValue) { Credentials = new Credentials(Config.GitHubToken) };

        /// <summary>
        /// Asynchronously retrieves a list of repositories for the current user.
        /// </summary>
        /// <returns>A task representing the asynchronous operation, containing a list of repositories.</returns>
        private static async Task<IReadOnlyList<Repository>> GetRepositories() => await GitHub.Repository.GetAllForCurrent();

        public static List<GithubRepository> GetGithubRepositories()
        {
            // Fetch repositories from GitHub.
            var repositories = GetRepositories().Result;

            // Fetch language colors from GitHub by a third-party API.
            var languageColors = GithubLanguage.GetLanguageColors().Result;

            // Initialize a list to store GitHub repositories.
            var githubRepositories = new List<GithubRepository>();

            // Iterate through each repository to map language colors.
            foreach (var repository in repositories)
            {
                // Retrieve the language color corresponding to the repository's language.
                var languageColor = languageColors.SingleOrDefault(language => language.Name == repository.Language);

                // Create a GithubRepository object and populate its properties.
                var test = new GithubRepository
                {
                    Name = repository.Name,
                    CreateDate = repository.CreatedAt,
                    PushDate = repository.PushedAt,
                    Private = repository.Private,
                    Url = repository.Url,
                    Language = languageColor?.Name,
                    LanguageColor = languageColor?.RgbColor
                };

                // Add the GithubRepository object to the list.
                githubRepositories.Add(test);
            }

            // Return the GithubRepositories object list.
            return githubRepositories;
        }
    }
}