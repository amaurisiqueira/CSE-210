using System;
namespace Develop03
{
    public class Reference
    {
        private int _verse_start;
        private int _verse_end;
        private int _chapter;
        private string _book;
        public Reference(string book, int chapter, int verse_start, int verse_end)
        {
            _book = book;
            _chapter = chapter;
            _verse_start = verse_start;
            _verse_end = verse_end;
        }
        public string GetText()
        {
            string tmp = $"{_book} {_chapter}:{_verse_start}";
            if (_verse_end != _verse_start)
            {
                tmp += $"-{_verse_end}";
            }
            return tmp;
        }
    }
}
