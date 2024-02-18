namespace Monambike.Core.Config
{
    /// <summary>
    /// Provides access to configuration settings.
    /// </summary>
    internal static class PackageConfig
    {
        /// <summary>
        /// Gets the GitHub token from the environment variables.
        /// </summary>
        /// <remarks>
        /// The GitHub token is retrieved from the environment variable "GITHUB_REPOSITORIES_TOKEN".
        /// </remarks>
        internal static string GitHubToken => Environment.GetEnvironmentVariable("GITHUB_REPOSITORIES_TOKEN")!;
    }
}
