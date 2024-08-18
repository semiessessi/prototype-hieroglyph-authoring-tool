using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace PP1
{
    public class Word : IComparable<Word>
    {
        public enum Usage
        {
            Name = 0,
            Noun,
            Pronoun,
            Verb,
            Adjective,
            Adverb,
            Preposition,
            Conjunction,
            Interjection
        }

        Word() {}

        public string ToSimpleUnicode(bool capitalise = false)
        {
            string result = "";
            if (letters.Length > 0)
            {
                result += capitalise ? letters[0].UpperCase() : letters[0].InitialForm();
            }
            for (int i = 1; i < letters.Length - 1; ++i)
            {
                result += letters[i].MedialForm();
            }
            if (letters.Length > 1)
            {
                result += letters[letters.Length - 1].FinalForm();
            }

            return result;
        }

        public string ToTransliteration(bool allowGardinerSigns = false)
        {
            if(transliterationOverride.Length > 0)
            {
                return transliterationOverride;
            }

            string transliteration = "";
            bool first = true;
            foreach(Letter letter in letters)
            {
                if (!first && allowGardinerSigns)
                {
                    transliteration += "-";
                }

                string gardiner = letter.Transliteration();
                if (Letters.LookupGardinerSign(gardiner) != Letters.NoLetter)
                {
                    string simple = Letters.GardinerSignToMdC(gardiner);
                    if (simple != gardiner)
                    {
                        transliteration += simple;
                    }
                    else if (allowGardinerSigns)
                    {
                        transliteration += letter.Transliteration();
                    }
                }
                else
                {
                    transliteration += letter.Transliteration();
                }

                first = false;
            }

            return transliteration;
        }

        public IList<Letter> ToTransliterationSymbols()
        {
            List <Letter> letterList = new List<Letter>();
            string symbols = Letters.ConvertToTransliterationSymbols(ToTransliteration());
            foreach (char c in symbols)
            {
                letterList.Add(Letter.FromUnicode(c));
            }
            return letterList;
        }

        public static Word FromMdC(string MdC, Usage usage = Usage.Name)
        {
            Word word = new Word();
            helper.Clear();

            // TODO: do we want to keep the positional information?
            string[] parts = MdC.Split(' ');
            foreach (string c in parts)
            {
                helper.Add(Letter.FromMdC(c));
            }

            word.letters = helper.ToArray();
            word.usage = usage;

            return word;
        }

        public static Word FromLatin(string latin, Usage usage = Usage.Name)
        {
            Word word = new Word();
            helper.Clear();

            foreach(char c in latin)
            {
                helper.Add(Letter.FromLatin(c));
            }

            word.letters = helper.ToArray();
            word.usage = usage;

            return word;
        }

        public IList<Letter> GetLetters()
        {
            return letters;
        }

        public Usage GetUsage()
        {
            return usage;
        }

        public override string ToString()
        {
            return ToSimpleUnicode();
        }

        public void OverrideTransliterationString(string transliteration)
        {
            transliterationOverride = transliteration;
        }

        public int CompareTo([AllowNull] Word other)
        {
            if(other == null)
            {
                return 1;
            }

            int minLength = Math.Min(other.letters.Length, letters.Length);
            for(int i = 0; i < minLength; ++i)
            {
                int result = letters[i].CompareTo(other.letters[i]);
                if(result != 0)
                {
                    return result;
                }
            }

            return letters.Length.CompareTo(other.letters.Length);
        }

        private static List<Letter> helper = new List<Letter>();
        
        private Letter[] letters;
        private Usage usage;
        private string transliterationOverride = "";
    }
}
