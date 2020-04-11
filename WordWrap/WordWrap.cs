namespace WordWrap
{
    public class WordWrap
    {
        public string Wrap(string text, int columns)
        {
            var reducedText = "";
            if (text.Length <= columns)
            {
                return reducedText + text;
            }

            reducedText += text.Substring(0, columns) + "\n";
            text = text.Substring(columns);
            
            if (text.Length <= columns)
            {
                return reducedText + text;
            }

            reducedText += text.Substring(0, columns) + "\n";
            text = text.Substring(columns);
            
            return reducedText + text;
        }
    }
}