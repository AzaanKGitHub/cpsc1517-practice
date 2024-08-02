namespace Utilities
{
    public class Utilities
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
        /// Checks if the date provided is in the future or not
        /// </summary>
        /// <param name="value"></param>
        /// <returns>True if the value is in the future or now, else false</returns>
        public static bool IsInTheFuture(DateOnly value) =>
            value > DateOnly.FromDateTime(DateTime.Now);

    }
}
