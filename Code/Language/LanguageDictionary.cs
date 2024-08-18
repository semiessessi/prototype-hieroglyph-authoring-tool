using System;
using System.Collections.Generic;
using System.Text;

namespace PP1
{
    public static class LanguageDictionary
    {
        public static ICollection<Translation> GetEgyptianWords()
        {
            return egyptian.Values;
        }

        public static ICollection<Translation> GetEnglishWords()
        {
            return english.Values;
        }

        private struct Entry
        {
            public Entry(
                string egyptian,
                string english,
                Word.Usage usage = Word.Usage.Name,
                string egyptianAlternative = "",
                string englishAlternative = "",
                string special = "", string comments = "")
            {
                English = english;
                MdCEgyptian = egyptian;
                EnglishAlternatives = new List<string>();
                MdCEgyptianAlternatives = new List<string>();
                Usage = usage;
                SpecialTransliteration = special;
                Comments = comments;
            }

            public string English;
            public string MdCEgyptian;
            public List<string> EnglishAlternatives;
            public List<string> MdCEgyptianAlternatives;
            public Word.Usage Usage;
            public string SpecialTransliteration;
            public string Comments;
        }

        private static SortedDictionary<Word, Translation> CreateEgyptianLookup()
        {
            SortedDictionary<Word, Translation> dictionary = new SortedDictionary<Word, Translation>();
            foreach(Entry entry in entries)
            {
                Word english = Word.FromLatin(entry.English, entry.Usage);
                Word egyptian = Word.FromMdC(entry.MdCEgyptian, entry.Usage);
                Translation translation = new Translation(egyptian, english);
                dictionary.Add(egyptian, translation);
            }

            return dictionary;
        }

        private static SortedDictionary<Word, Translation> CreateEnglishLookup()
        {
            SortedDictionary<Word, Translation> dictionary = new SortedDictionary<Word, Translation>();
            foreach (Entry entry in entries)
            {
                Word english = Word.FromLatin(entry.English, entry.Usage);
                Word egyptian = Word.FromMdC(entry.MdCEgyptian, entry.Usage);
                Translation translation = new Translation(english, egyptian);
                if (dictionary.ContainsKey(english) == false)
                {
                    dictionary.Add(english, translation);
                    // error?
                }
            }

            return dictionary;
        }

        private static Entry[] entries = new Entry[]
        {
            new Entry("i A26",              "O",                        Word.Usage.Interjection, "i A1", "Hail", "yA"),
            new Entry("r a rA C2a",         "Ra",                       Word.Usage.Name, "", "the Sun", "rA"),
            new Entry("m",                  "from",                     Word.Usage.Conjunction),
            new Entry("n",                  "of",                       Word.Usage.Preposition),
            new Entry("n t",                "of",                       Word.Usage.Preposition),
            new Entry("nb",                 "lord",                     Word.Usage.Noun),
            new Entry("nbw",                "gold",                     Word.Usage.Noun),
            new Entry("iwn nw niwt",        "Heliopolis",               Word.Usage.Name, "", "", "iwnw", "(Iunu)"),
            new Entry("pr r D54",           "coming",                   Word.Usage.Verb, "", "", "pr"),
            new Entry("w x s W10 D54 Z1",   "Usekh the Far-Strider",    Word.Usage.Name, "", "", "wsx"),
            new Entry("ni iri A4",          "I have not",               Word.Usage.Adverb, "", "", "ni iri-i"),
            new Entry("i s f t wr Z3",      "done Isefet",              Word.Usage.Verb, "", "", "isft"),
            new Entry("sw t",               "King",                     Word.Usage.Name, "", "", "nswt"),
            new Entry("sw t Htp Di",        "Offering",                 Word.Usage.Name, "", "", "Htp Di nswt"),
            new Entry("nTr",                "god",                      Word.Usage.Noun, "", "", "nswt"),
            new Entry("nfr",                "beautiful",                Word.Usage.Adjective, "", "", "nswt"),
            new Entry("kA",                 "living soul",              Word.Usage.Noun, "", "", "nswt"),
            new Entry("rA wsr mAat",        "Usermaatre",               Word.Usage.Name, "", "", "wsrmAatrA"),
            new Entry("rA stp n",           "Setepenre",                Word.Usage.Name, "", "", "stpnrA"),
            new Entry("rA mAat kA",         "Maatkare",                 Word.Usage.Name, "", "", "mAatkArA"),
            new Entry("rA nfr kA",          "Neferkare",                Word.Usage.Name, "", "", "nfrkArA"),
        };

        private static SortedDictionary<Word, Translation> egyptian = CreateEgyptianLookup();
        private static SortedDictionary<Word, Translation> english = CreateEnglishLookup();
    }
}
