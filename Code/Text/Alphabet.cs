using System;
using System.Collections.Generic;
using System.Text;

namespace PP1
{
    public class Alphabet
    {
        public Alphabet(ICollection<Letter> alphabetLetters)
        {
            int length = alphabetLetters.Count;
            letters = new Letter[length];
            int i = 0;
            foreach (Letter c in alphabetLetters)
            {
                letters[i] = c;
                ++i;
            }
        }

        public Alphabet(IEnumerable<Letter> alphabetLetters)
        {
            int length = 0;
            foreach (Letter c in alphabetLetters)
            {
                ++length;
            }
            letters = new Letter[length];
            int i = 0;
            foreach (Letter c in alphabetLetters)
            {
                letters[i] = c;
                ++i;
            }
        }

        public Alphabet(IList<Letter> alphabetLetters)
        {
            int length = alphabetLetters.Count;
            letters = new Letter[length];
            for (int i = 0; i < length; ++i)
            {
                letters[i] = alphabetLetters[i];
                ++i;
            }
        }

        private Letter[] letters;
    }

    public class LatinAlphabet : Alphabet
    {
        public LatinAlphabet()
        : base(Letters.GetAllLatinCharacters())
        {

        }
    }

    public class HieroglyphicAlphabet : Alphabet
    {
        public HieroglyphicAlphabet()
        : base(Letters.GetAllGardinerSigns())
        {

        }
    }

    public class HieraticAlphabet : Alphabet
    {
        public HieraticAlphabet()
        : base(Letters.GetAllGardinerSigns())
        {

        }
    }
}
