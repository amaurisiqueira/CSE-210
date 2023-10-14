using System;
using System.Collections.Generic;

namespace Develop03
{
    public class Scripture
    {
        private Reference references;
        private int _n_hiden;
        private int _n_word_total;
        private List<Word> words = new();
        private void Cast_String_To_Word(string content)
        {
            _n_hiden = 0;
            _n_word_total = 0;
            string[] array = content.Split(' ');
            foreach (string x in array)
            {
                Word myNew = new(x);
                words.Add(myNew);
                _n_word_total++;
            }
        }
        public Scripture(string book, int chapter, int verse_start, string content)
        {
            references = new Reference(book, chapter, verse_start, verse_start);
            Cast_String_To_Word(content);
        }
        public Scripture(string book, int chapter, int verse_start, int verse_end, string content)
        {
            references = new Reference(book, chapter, verse_start, verse_end);
            Cast_String_To_Word(content);
        }
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
            Console.Write(references.GetText() + " ");
            foreach (Word x in words)
            {
                Console.Write(x.GetWord() + " ");
            }
        }
        public void HideRandomly()
        {
            List<int> candidate = new();
            for (int x = 0; x < words.Count; x++)
            {
                if (words[x].GetVisible())
                {
                    candidate.Add(x);
                }
            }
            if (candidate.Count > 0)
            {
                Random rnd = new();
                //Console.WriteLine(candidate.Count);
                int tmp_candidate = rnd.Next(1, candidate.Count) - 1;
                //Console.WriteLine(candidate[tmp_candidate]);
                words[candidate[tmp_candidate]].SetUnVisible();
                _n_hiden++;
            }
        }
    }
}
