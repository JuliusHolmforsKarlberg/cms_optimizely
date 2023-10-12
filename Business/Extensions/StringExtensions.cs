namespace Nackademin2023v2.Business.Extensions
{
    public static class StringExtensions
    {
        public static bool IsNotNullOrWhiteSpace(this string value)
        {
            return !string.IsNullOrWhiteSpace(value);
        }
    }
}
