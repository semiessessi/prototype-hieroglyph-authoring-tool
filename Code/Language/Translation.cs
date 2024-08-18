using System;
using System.Collections.Generic;
using System.Text;

namespace PP1
{
    public class Translation
    {
        public Translation(Word from, Word to)
        {
            Original = from;
            Translated = to;
        }

        public Word GetOriginal() { return Original; }
        public Word GetTranslated() { return Translated; }

        private Word Original;
        private Word Translated;
    }
}
