namespace Utilities
{
    public class Utils
    {
        ///<summary>
        /// Test for positive int value 
        ///</summary>
        public static bool IsPositive(int value)
        {
            // returns true value if value is postive else returns false 
            return value > 0 ? true: false;
        }

        /// <summary>
        /// Checks if the value is less than or equal to zero
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsZeroNegative(int value) =>
            value <= 0;

        /// <summary>
        /// Checks if the date provided is in the future or not
        /// </summary>
        /// <param name="value"></param>
        /// <returns>True if the value is in the future or now, else false</returns>
        public static bool IsInTheFuture(DateOnly value) =>
            value > DateOnly.FromDateTime(DateTime.Now);

        /// <summary>
        /// Checks if the string value is null, empty, or whitespace.
        /// Essentially a re-name of the IsNullOrWhiteSpace method.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsNullEmptyOrWhiteSpace(string value) =>
            string.IsNullOrWhiteSpace(value);

    }
}
