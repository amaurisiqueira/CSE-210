using System;
using System.Collections.Generic;

namespace Develop05
{
    public class Scripture
    {
        private Reference _reference;
        private int _n_hiden;
        private int _n_word_total;
        List<Word> _words;

        private void Cast_String_To_Word(string content)
        {
            _n_hiden = 0;
            _n_word_total = 0;
            string[] array = content.Split(' ');
            foreach (string x in array)
            {
                Word myNew = new Word(x);
                _words.Add(myNew);
                _n_word_total++;

            }

        }
        public Scripture(string book, int chapter, int verse_start, string content)
        {
          
            _reference = new Reference(book, chapter, verse_start, verse_start);
            _words = new List<Word>();
            Cast_String_To_Word(content);


        }//-------------------------

        public Scripture(string book, int chapter, int verse_start, int verse_end, string content)
        {
         
            _reference = new Reference(book, chapter, verse_start, verse_end);
            _words = new List<Word>();
            Cast_String_To_Word(content);

        }//-------------------

        public int GetQuantityWord()
        {

            return _n_word_total;
        }

        public int GetQuantityHiden()
        {

            return _n_hiden;
        }
        public bool IsWorking()
        {
            //    Console.WriteLine($"{GetQuantityWord()} > 0  && {GetQuantityHiden()} <  {GetQuantityWord()}");

            if (GetQuantityWord() > 0 && GetQuantityHiden() < GetQuantityWord()) return true;

            return false;
        }


        public void PrintTexts()
        {
            Console.Write(_reference.GetText() + " ");
            foreach (Word x in _words)
            {
                Console.Write(x.GetWord() + " ");

            }
        }//------------------

        public void HideRandomly()
        {

            List<int> candidate = new List<int>();
            for (int x = 0; x < _words.Count; x++)
            {
                if (_words[x].GetVisible())
                {
                    candidate.Add(x);
                }
            }//end for

            if (candidate.Count > 0)
            {

                Random rnd = new Random();

                //Console.WriteLine(candidate.Count);


                int tmp_candidate = rnd.Next(1, candidate.Count) - 1;
                //Console.WriteLine(candidate[tmp_candidate]);

                _words[candidate[tmp_candidate]].SetUnVisible();
                _n_hiden++;

            }

        }//-----------end of HideRandomly

    }
}
