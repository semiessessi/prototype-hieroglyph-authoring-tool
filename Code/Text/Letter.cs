using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace PP1
{
    public class Letter: IComparable<Letter>, IEquatable<Letter>
    {
        public Letter(string character, string transliterationString = "")
        {
            unicodeIsolated = character;
            transliteration = transliterationString;
        }

        public static Letter FromLatin(char latinLetter)
        {
            string latinString = new string(new char[] { latinLetter });
            Letter found = Letters.Lookup(latinString.ToLower());
            if (found != Letters.NoLetter)
            {
                return found;
            }

            Letter newLetter = new Letter(latinString.ToLower(), latinString.ToLower());
            newLetter.unicodeCapital = latinString.ToUpper();

            Letters.RegisterLetter(newLetter);

            return newLetter;
        }

        public static Letter FromUnicode(char unicode)
        {
            string unicodeString = new string(new char[] { unicode });
            Letter found = Letters.Lookup(unicodeString);
            if (found != Letters.NoLetter)
            {
                return found;
            }

            Letter newLetter = new Letter(unicodeString, unicodeString);

            Letters.RegisterLetter(newLetter);

            return newLetter;
        }

        public static Letter FromMdC(string MdC)
        {
            if (MdC.ContainsDigit() == false)
            {
                return FromGardinerSign(Letters.MdCToGardinerSign(MdC));
            }

            return FromGardinerSign(MdC);
        }

        public static Letter FromGardinerSign(string gardinerSign)
        {
            return Letters.LookupGardinerSign(gardinerSign);
        }

        public string IsolatedForm()
        {
            return unicodeIsolated;
        }

        public string LowerCase()
        {
            return IsolatedForm();
        }

        public string UpperCase()
        {
            if (unicodeCapital != NullCharacter)
            {
                return unicodeCapital;
            }

            return unicodeIsolated;
        }

        public string InitialForm()
        {
            if (unicodeInitial != NullCharacter)
            {
                return unicodeInitial;
            }

            return unicodeIsolated;
        }

        public string MedialForm()
        {
            if (unicodeMedial != NullCharacter)
            {
                return unicodeMedial;
            }

            return unicodeIsolated;
        }

        public string FinalForm()
        {
            if (unicodeFinal != NullCharacter)
            {
                return unicodeFinal;
            }

            return unicodeIsolated;
        }

        public string Transliteration()
        {
            return transliteration;
        }

        public float GetAspectRatio()
        {
            return proportions;
        }

        public bool HasCapital()
        {
            return unicodeCapital != NullCharacter;
        }

        public bool HasInitial()
        {
            return unicodeInitial != NullCharacter;
        }

        public bool HasMedial()
        {
            return unicodeMedial != NullCharacter;
        }

        public bool HasFinal()
        {
            return unicodeFinal != NullCharacter;
        }

        public int CompareTo([AllowNull] Letter other)
        {
            int result = unicodeIsolated.CompareTo(other.unicodeIsolated);
            // TODO: more?
            return result;
        }

        public bool Equals([AllowNull] Letter other)
        {
            return CompareTo(other) == 0;
        }

        private float proportions = 1.0f;
        // we must use strings since surrogate pairs and blah.
        private string unicodeIsolated;
        private string unicodeCapital = NullCharacter;
        private string unicodeInitial = NullCharacter;
        private string unicodeMedial = NullCharacter;
        private string unicodeFinal = NullCharacter;
        private string transliteration = "";

        private const string NullCharacter = "\0";
    }
}
