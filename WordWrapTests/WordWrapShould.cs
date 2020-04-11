using NUnit.Framework;

/*("test", 7) -> "test"
("hello world", 7) -> "hello--world"
("a lot of words for a single line", 10) -> "a lot of--words for--a single--line"
("this is a test", 4) -> "this--is a--test"
("a longword", 6) -> "a long--word"
("areallylongword", 6) -> "areall--ylongw--ord"*/

namespace WordWrapTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        
        [Test]
        public void text_is_empty()
        {
            var wordWrap = new WordWrap.WordWrap();
            const string text = "test";
            var result = wordWrap.Wrap("", 7);
            
            Assert.AreEqual("", result);
        }

        [Test]
        public void columns_are_bigger_than_text()
        {
            var word = new WordWrap.WordWrap();
            const string text = "test";
            var result = word.Wrap(text, 7);
            
            Assert.AreEqual("test", result);
        }
        
        [Test]
        public void columns_are_shorter_than_text()
        {
            var word = new WordWrap.WordWrap();
            const string text = "hello";
            var result = word.Wrap(text, 3);
            
            Assert.AreEqual("hel\nlo", result);
        }
        
        [Test]
        public void some_columns_without_spaces()
        {
            var word = new WordWrap.WordWrap();
            const string text = "hello";
            var result = word.Wrap(text, 2);
            
            Assert.AreEqual("he\nll\no", result);
        }
        
        [Test]
        public void some_columns_with_spaces()
        {
            var word = new WordWrap.WordWrap();
            const string text = "hello world";
            var result = word.Wrap(text, 7);
            
            Assert.AreEqual("hello\nworld", result);
        }
    }
}