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

            var wrappedWord = text.Substring(0, columns) + "\n";
            var lastSpacePosition = wrappedWord.LastIndexOf(' ');
            var existAnySpace = lastSpacePosition != -1;
            if (!existAnySpace)
            {
                reducedText += wrappedWord;
                text = text.Substring(columns);
            }
            else
            {
                reducedText += text.Substring(0, lastSpacePosition) + "\n";
                text = text.Substring(lastSpacePosition + 1);
            }
            
            return reducedText + Wrap(text, columns);
        }
    }
}