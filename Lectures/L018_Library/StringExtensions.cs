namespace L018_Library
{
    public static class StringExtensions
    {
        public static int WordCount(this string s)
        {
            return s.Split(' ').Length;
        }
        public static string Encapsulate(this string stringToEncapsulate, string encapsulation)
        {
            return $"{encapsulation}{stringToEncapsulate}{encapsulation}";
        }
        public static string Encapsulate(this string stringToEncapsulate, string prefix, string suffix)
        {
            return $"{prefix}{stringToEncapsulate}{suffix}";
        }
    }
}
