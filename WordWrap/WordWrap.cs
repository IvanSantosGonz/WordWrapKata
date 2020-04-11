namespace WordWrap
{
    public class WordWrap
    {
        public string Wrap(string text, int columns)
        {
            if (text.Length <= columns)
            {
                return text;
            }

            var recucedText = text.Substring(0, columns) + "\n";
            var restOfTheText = text.Substring(columns);

            return recucedText + restOfTheText;
        }
    }
}