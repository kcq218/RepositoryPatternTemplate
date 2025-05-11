namespace DAL
{
    public static class Globals
    {
        // starter global variables
        public static string placeHolder = Environment.GetEnvironmentVariable("placeholder") ?? string.Empty;
    }
}
