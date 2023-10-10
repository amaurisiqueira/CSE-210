using System;
namespace Develop05
{
    public class Word
    {
        private string  _word;
        private bool    _visible;
        public Word(string word)
        {
            _word = word;
            _visible = true;
        }

        public bool GetVisible()
        {
            return _visible;
        }

        public void SetUnVisible()
        {
            _visible = false;
        }

        public string GetWord()
        {
            if (!_visible)
            {

                string _myreturn = "";
                for(int x=0;x< _word.Length; x++)
                {
                    _myreturn += "_";
                }
                return _myreturn;
            }

            return _word;
        }

    }
}
