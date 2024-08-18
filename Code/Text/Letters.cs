using System.Collections.Generic;

namespace PP1
{
    public static partial class Letters
    {
        public static readonly Letter NoLetter = new Letter("\0");
        public static readonly Letter UnknownLetter = new Letter("?", "?");
        public static readonly Letter EnDash = new Letter("-", "-");
        public static readonly Letter EmDash = new Letter("\u2014");

        public static Letter Lookup(string unicode)
        {
            if (unicodeLookup.ContainsKey(unicode))
            {
                return unicodeLookup[unicode];
            }

            return NoLetter;
        }

        public static void RegisterLetter(Letter letter)
        {
            unicodeLookup.Add(letter.IsolatedForm(), letter);
        }

        public static ICollection<Letter> GetAllLatinCharacters()
        {
            return latinCharacters.Values;
        }

        static Letters()
        {
            RegisterLetter(NoLetter);

            // create the gardiner signs.
            foreach(KeyValuePair<string, string> pair in gardenerSignList)
            {
                // TODO: do not check if we can do an MdC substitution...
                // that will have to be done elsewhere
                string transliteration = CanonicaliseGardinerSign(pair.Key);
                RegisterLetter(new Letter(pair.Value, transliteration));
            }

            hieroglyphShapes = CreateHieroglyphShapes();
            shrinkable = CreateHieroglyphShrinks();
        }

        private static Dictionary<string, Letter> CreateLatinCharacters()
        {
            Dictionary<string, Letter> newDictionary = new Dictionary<string, Letter>();
            int numLetters = 26;
            for(int i = 0; i < numLetters; ++i)
            {
                string lower = char.ConvertFromUtf32('a' + i);
                newDictionary.Add(lower, Letter.FromLatin(lower[0]));
            }
            int numDigits = 10;
            for (int i = 0; i < numDigits; ++i)
            {
                string digit = char.ConvertFromUtf32('0' + i);
                newDictionary.Add(digit, Letter.FromLatin(digit[0]));
            }
            return newDictionary;
        }
        

        private static Dictionary<string, string> CreateReverseLookup(Dictionary<string, string> original)
        {
            Dictionary<string, string> newDictionary = new Dictionary<string, string>();
            foreach(KeyValuePair<string, string> pair in original)
            {
                // NOTE: this stops it being two-way, but allows multiple mappings for the same sign
                if (newDictionary.ContainsKey(pair.Value) == false)
                {
                    newDictionary.Add(pair.Value, pair.Key);
                }
            }

            return newDictionary;
        }

        private static Dictionary<string, Letter> unicodeLookup = new Dictionary<string, Letter>();
        private static readonly Dictionary<string, Letter> latinCharacters = CreateLatinCharacters();
    }
}
