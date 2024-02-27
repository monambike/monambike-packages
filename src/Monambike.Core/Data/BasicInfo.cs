using Monambike.Core.Utils;

namespace Monambike.Core.Data
{
    /// <summary>
    /// Class that provides basic information about Monambike.
    /// </summary>
    public static class BasicInfo
    {
        /// <summary>
        /// Monambike's first name.
        /// </summary>
        public static string FirstName => "Vinícius Gabriel";

        /// <summary>
        /// Monambike's second name.
        /// </summary>
        public static string SecondName => "Marques de Melo";

        /// <summary>
        /// Monambike's username.
        /// </summary>
        public static string Username => "Monambike";

        /// <summary>
        /// Monambike's social media username. (with an '@' symbol behind).
        /// </summary>
        public static string SocialMediaUsername => $"@{Username.ToLower()}";

        /// <summary>
        /// Monambike's birthday.
        /// </summary>
        public static DateTime Birthday => new(2002, 11, 24);

        /// <summary>
        /// Monambike's age.
        /// </summary>
        public static int Age => DateTimeExtension.CalculateAge(Birthday);
    }
}
