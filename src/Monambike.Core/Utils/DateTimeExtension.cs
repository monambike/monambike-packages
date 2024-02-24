namespace Monambike.Core.Utils
{
    /// <summary>
    /// Provides extension methods for DateTime class.
    /// </summary>
    internal class DateTimeExtension
    {

        /// <summary>
        /// Calculates the age based on the provided birth date.
        /// </summary>
        /// <param name="birthDate">The date of birth.</param>
        /// <returns>The age calculated in years.</returns>
        public static int CalculateAge(DateTime birthDate)
        {
            // Get the current date
            DateTime currentDate = DateTime.Today;

            // Calculate age
            int age = currentDate.Year - birthDate.Year;

            // Check if the birth date hasn't occurred yet this year
            if (birthDate.Date > currentDate.AddYears(-age))
                age--;

            // Return the age
            return age;
        }
    }
}
