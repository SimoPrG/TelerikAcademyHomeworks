namespace StringBuilderSubstring.Extensions
{
    using System;
    using System.Text;

    public static class StringBuilderExtensions
    {
        public static StringBuilder Substring (this StringBuilder text, int index, int length)
        {
            string textToStr = text.ToString();

            if (index < 0 || index + length > textToStr.Length)
            {
                throw new ArgumentOutOfRangeException("Invalid index or length.");
            }

            var result = new StringBuilder();
            result.Append(textToStr.Substring(index, length));

            return result;
        }
    }
}
