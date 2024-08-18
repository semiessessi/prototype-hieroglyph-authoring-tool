using System;
using System.Collections.Generic;
using System.Text;

namespace PP1
{
    public static partial class Letters
    {
        public static Letter LookupGardinerSign(string gardinerSign)
        {
            if (gardenerSignList.ContainsKey(gardinerSign.ToUpper()))
            {
                return unicodeLookup[gardenerSignList[gardinerSign.ToUpper()]];
            }

            return NoLetter;
        }

        public static string MdCToGardinerSign(string MdC)
        {
            if (gardenerSignList.ContainsKey(MdC.ToUpper()))
            {
                return MdC.ToUpper();
            }

            if (gardinerSignFromMdC.ContainsKey(MdC))
            {
                return gardinerSignFromMdC[MdC];
            }

            return "?";
        }

        public static string GardinerSignToMdC(string gardiner)
        {
            string key = gardiner.ToUpper();
            if (MdCFromGardinerSign.ContainsKey(key))
            {
                return MdCFromGardinerSign[key];
            }

            if (gardenerSignList.ContainsKey(key))
            {
                return CanonicaliseGardinerSign(gardiner);
            }

            return "?";
        }

        public static ICollection<Letter> GetAllGardinerSigns()
        {
            // TODO: better
            return unicodeLookup.Values;
        }

        public static string CanonicaliseGardinerSign(string gardiner)
        {
            if (gardiner.Length < 2)
            {
                return gardiner;
            }

            if (gardiner.Length == 2)
            {
                return gardiner.ToUpper();
            }

            if(gardiner.StartsWith("AA"))
            {
                return "Aa" + gardiner.Substring(2, gardiner.Length - 2).ToLower();
            }

            return gardiner.Substring(0, 2).ToUpper()
                + gardiner.Substring(2, gardiner.Length - 2).ToLower();
        }

        public static string ConvertToTransliterationSymbols(string input)
        {
            string output = "";
            foreach(char c in input)
            {
                if(transliterationSymbolList.ContainsKey(c.ToString()))
                {
                    output += transliterationSymbolList[c.ToString()];
                }
                else
                {
                    output += c;
                }
            }

            return output;
        }

        private static readonly Dictionary<string, string> transliterationSymbolList = new Dictionary<string, string>
        {
            { "A", "ꜣ" },
            { "a", "ꜥ" },
            { "i", "ꞽ" },
            { "H", "ḥ" },
            { "x", "ḫ" },
            { "X", "ẖ" },
            { "S", "š" },
            { "T", "ṯ" },
            { "D", "ḏ" },
        };
        private static readonly Dictionary<string, string> gardenerSignList = CreateGardinerToUnicodeMap();
        private static readonly Dictionary<string, string> gardinerSignFromMdC = new Dictionary<string, string>
        {
            { "A",          "G1" },
            { "i",          "M17" },
            { "y",          "M17A" },
            { "Y",          "Z4" },
            { "a",          "D36" },
            { "w",          "G43" },
            { "W",          "V1" },
            { "b",          "D58" },
            { "p",          "Q3" },
            { "f",          "I9" },
            { "m",          "G17" },
            { "M",          "AA15" },
            { "n",          "N35" },
            { "N",          "S3" },
            { "r",          "D21" },
            { "l",          "E23" },
            { "h",          "O4" },
            { "H",          "V28" },
            { "x",          "AA1" },
            { "X",          "F32" },
            { "z",          "O34" },
            { "s",          "S29" },
            { "S",          "N37" },
            { "q",          "N29" },
            { "k",          "V31" },
            { "K",          "S56" },
            { "g",          "W11" },
            { "t",          "X1" },
            { "T",          "V13" },
            { "d",          "D46" },
            { "D",          "I10" },

            // multi-literal signs
            { "aA",         "O29" },
            { "ab",         "D59" },
            { "ad",         "K3" },
            { "aH",         "T24" },
            { "aHA",        "D34" },
            { "aq",         "G35" },
            { "Ab",         "U23" },
            { "Abd",        "N11" },
            { "Anx",        "S34" },
            { "As",         "Q1" },
            { "Aw",         "F40" },
            { "Ax",         "G25" },
            { "Axt",        "N27" },
            { "bA",         "G29" },
            { "bit",        "L2" },
            { "bz",         "K5" },
            { "db",         "F16" },
            { "di",         "X8" },
            { "dwA",        "N14" },
            { "DA",         "U28" },
            { "Dba",        "D50" },
            { "DbA",        "T25" },
            { "Dd",         "R11" },
            { "DHwty",      "C3" },
            { "Dr",         "M36" },
            { "Dsr",        "D45" },
            { "Dw",         "N26" },
            { "fnD",        "D19" },
            { "gb",         "G38" },
            { "gm",         "G28" },
            { "hrw",        "N5" },
            { "HA",         "F4" },
            { "HH",         "C11" },
            { "Hm",         "N42" },
            //{ "Hm",       "U36" },
            { "Hmt",        "U24" },
            { "Hmwt",        "U24" },
            { "Hnqt",       "W22" },
            { "Hr",         "D2" },
            { "Htp",        "R4" },
            { "ib",         "F34" },
            { "im",         "Aa13" },
            { "Im",         "Z11" },
            { "in",         "K1" },
            { "inb",        "O36" },
            { "inpw",       "C6" },
            { "ir",         "D4" },
            { "iri",        "D4" },
            { "iry",        "A47" },
            { "iwn",        "O28" },
            { "kA",         "D28" },
            { "mA",         "U2" },
            { "mAat",       "C10" },
            { "md",         "S43" },
            { "mi",         "N36" },
            { "mn",         "Y5" },
            { "mniw",       "A33" },
            { "mnw",        "C8" },
            { "mr",         "U7" },
            { "mri",        "N36" },
            { "ms",         "F31" },
            { "mSa",        "A12" },
            { "msi",        "B3" },
            { "mt",         "D52" },
            { "mwt",        "G14" },
            { "MA",         "U1" },
            { "Mi",         "W19" },
            { "Mr",         "U6" },
            { "nb",         "V30" },
            { "nbty",       "G16" },
            { "nbw",        "S12" },
            { "nD",         "Aa27" },
            { "nDm",        "M29" },
            { "ni",         "D35" },
            { "nfr",        "F35" },
            { "niwt",       "O49" },
            { "ns",         "F20" },
            { "nTr",        "R8" },
            { "nTrw",       "R8A" },
            { "nw",         "W24" },
            { "pA",         "G47" },
            { "pH",         "F22" },
            { "pr",         "O1" },
            { "pt",         "N1" },
            { "qiz",        "A38" },
            { "ra",         "N5" },
            { "rA",         "N5" },
            { "rd",         "D56" },
            { "rsw",        "M24" },
            { "sA",         "Aa17" },
            { "sAH",        "D61" },
            { "sbA",        "N14" },
            { "sbq",        "D56" },
            { "sDm",        "F21" },
            { "sf",         "S30" },
            { "sm",         "M21" },
            { "spt",        "D24" },
            { "spty",       "D25" },
            { "sr" ,        "A21" },
            { "srqt",       "L7" },
            { "stp",        "U21" },
            { "stX",        "C7" },
            { "sw",         "M23" },
            { "Sm",         "N40" },
            { "Sn",         "V7" },
            { "Sps",        "A50" },
            { "Spsi",       "A51" },
            { "Sw",         "H6" },
            { "ti",         "U33" },
            { "TA",         "G47" },
            { "tm",         "U15" },
            { "tp",         "D1" },
            { "xa",         "N28" },
            //{ "xA",         "F4" },
            { "xA",         "M12" },
            { "xDt",        "S1" },
            { "xm",         "U36" },
            { "xn",         "G41" },
            { "xr" ,        "A15" },
            { "xrp",        "S42" },
            { "xpr",        "L1" },
            { "XA",         "K4" },
            { "Xnmw",       "C4" },
            { "Xr",         "T28" },
            { "Xrd",        "A17" },
            { "wab",        "D60" },
            { "wAD",        "M13" },
            { "wAs",        "S40" },
            { "wD",         "V24" },
            { "wDA",        "U28" },
            { "wDAt",       "D10" },
            { "wn",         "E34" },
            { "wr",         "G36" },
            { "wsr",        "F12" },
            { "WD",         "M13" },
            { "zA",         "G39" },
            { "zAb",        "E17" },
            { "zx",         "Y3" },
            { "zzmt",       "E6" },
            
            // determinatives
            { "|",          "Z1" },
            { "|||",        "Z2" },
            { "---",        "Z3" },
            
            // numbers
            { "10",         "V20" },
            { "100",        "V1" },
            { "1000",       "M12" },
            
            // TODO: what are these???
            { "R", "D153" }, // ???
            
            
            { "mnD", "D27" },
            { "Sny", "D3" },
            { "gH", "D56" },
            { "gHs", "D56" },
            { "rmi", "D9" },
            { "mAi", "E22" },
            { "rw", "E23" },
            { "Aby", "E24" },
            { "wp", "F13" },
            { "Hw", "F18" },
            { "bH", "F18" },
            { "DrD", "F21" },
            { "idn", "F21" },
            { "msDr", "F21" },
            { "kfA", "F22" },
            { "xpS", "F23" },
            { "wHm", "F25" },
            { "Xn", "F26" },
            { "sti", "F29" },
            { "Sd", "F30" },
            { "sd", "F33" },
            { "zmA", "F36" },
            { "imAx", "F39" },
            { "HAt", "F4" },
            { "spr", "F42" },
            { "isw", "F44" },
            { "iwa", "F44" },
            { "pXr", "F46" },
            { "qAb", "F46" },
            { "SsA", "F5" },
            { "mm", "G18" },
            { "AA", "G2" },
            { "nH", "G21" },
            { "Db", "G22" },
            { "rxyt", "G23" },
            { "dSr", "G27" },
            { "baHi", "G32" },
            { "nDs", "G37" },
            { "tyw", "G4" },
            { "wSA", "G42" },
            { "ww", "G44" },
            { "mAw", "G46" },
            { "snD", "G54" },
            { "pq", "H2" },
            { "wSm", "H2" },
            { "pAq", "H3" },
            { "nr", "H4" },
            { "aSA", "I1" },
            { "DD", "I11" },
            { "Styw", "I2" },
            { "mzH", "I3" },
            { "sbk", "I4" },
            { "sAq", "I5" },
            { "km", "I6" },
            { "Hfn", "I8" },
            { "nSmt", "K6" },
            { "iAm", "M1" },
            { "wdn", "M11" },
            { "Hn", "M2" },
            { "sxt", "M20" },
            { "nn", "M22A" },
            { "Sma", "M26" },
            { "xt", "M3" },
            { "bnr", "M30" },
            { "bdt", "M34" },
            { "rnp", "M4" },
            { "iz", "M40" },
            { "tr", "M6" },
            { "SA", "M8" },
            { "zSn", "M9" },
            { "iaH", "N11" },
            { "dwAt", "N15" },
            { "tA", "N16" },
            { "iw", "N18" },
            { "wDb", "N20" },
            { "spAt", "N24" },
            { "xAst", "N25" },
            { "iAt", "N30" },
            { "mw", "N35A" },
            { "iAdt", "N4" },
            { "idt", "N4" },
            { "id", "N41" },
            { "zw", "N5" },
            { "Hnmmt", "N8" },
            { "pzD", "N9" },
            { "wsxt", "O15" },
            { "kAr", "O18" },
            { "zH", "O22" },
            { "txn", "O25" },
            { "zxnt", "O30" },
            { "zb", "O35" },
            { "qnbt", "O38A" },
            { "Szp", "O42" },
            { "ipt", "O45" },
            { "nxn", "O47" },
            { "zp", "O50" },
            { "Snwt", "O51" },
            { "Hwt", "O6" },
            { "wHa", "P4" },
            { "TAw", "P5" },
            { "nfw", "P5" },
            { "aHa", "P6" },
            { "xrw", "P8" },
            { "st", "Q1" },
            { "wz", "Q2" },
            { "qrsw", "Q6" },
            { "xAt", "R1" },
            { "xAwt", "R1" },
            { "dd", "R11" },
            { "imnt", "R14" },
            { "iAb", "R15" },
            { "wx", "R16" },
            { "kAp", "R5" },
            { "kp", "R5" },
            { "snTr", "R7" },
            { "bd", "R9" },
            { "HDt", "S1" },
            { "mDH", "S10" },
            { "wsx", "S11" },
            { "THn", "S15" },
            { "tHn", "S15" },
            { "mnit", "S18" },
            { "sDAw", "S19" },
            { "xtm", "S20" },
            { "sT", "S22" },
            { "dmD", "S23" },
            { "Tz", "S24" },
            { "Sndyt", "S26" },
            { "mnxt", "S27" },
            { "dSrt", "S3" },
            { "siA", "S32" },
            { "Tb", "S33" },
            { "anx", "S34" },
            { "Swt", "S35" },
            { "xw", "S37" },
            { "HqA", "S38" },
            { "awt", "S39" },
            { "Dam", "S41" },
            { "abA", "S42" },
            { "sxm", "S42" },
            { "Ams", "S44" },
            { "nxxw", "S45" },
            { "sxmty", "S6" },
            { "xprS", "S7" },
            { "Atf", "S8" },
            { "Swty", "S9" },
            { "pD", "T10" },
            { "sXr", "T11" },
            { "zin", "T11" },
            { "zwn", "T11" },
            { "Ai", "T12" },
            { "Ar", "T12" },
            { "rwD", "T12" },
            { "rwd", "T12" },
            { "rs", "T13" },
            { "qmA", "T14" },
            { "wrrt", "T17" },
            { "Sms", "T18" },
            { "qs", "T19" },
            { "wa", "T21" },
            { "sn", "T22" },
            { "iH", "T24" },
            { "nmt", "T29" },
            { "HD", "T3" },
            { "sSm", "T31" },
            { "nm", "T34" },
            { "HDD", "T6" },
            { "pd", "T9" },
            { "it", "U10" },
            { "HqAt", "U11" },
            { "Sna", "U13" },
            { "hb", "U13" },
            { "biA", "U16" },
            { "grg", "U17" },
            { "mnx", "U22" },
            { "wbA", "U26" },
            { "rtH", "U31" },
            { "zmn", "U32" },
            { "xsf", "U34" },
            { "mxAt", "U38" },
            { "arq", "V12" },
            { "iTi", "V15" },
            { "TmA", "V19" },
            { "XAr", "V19" },
            { "mDt", "V19" },
            { "sTA", "V2" },
            { "mD", "V20" },
            { "mH", "V22" },
            { "aD", "V26" },
            { "sk", "V29" },
            { "wAH", "V29" },
            { "sTAw", "V3" },
            { "msn", "V32" },
            { "sSr", "V33" },
            { "idr", "V37" },
            { "wA", "V4" },
            { "snT", "V5" },
            { "sS", "V6" },
            { "iab", "W10" },
            { "nzt", "W11" },
            { "Hz", "W14" },
            { "xnt", "W17" },
            { "bAs", "W2" },
            { "ini", "W25" },
            { "Hb", "W3" },
            { "Xnm", "W9" },
            { "rdi", "X8" },
            { "mDAt", "Y1" },
            { "mnhd", "Y3" },
            { "zS", "Y3" },
            { "ibA", "Y6" },
            { "zSSt", "Y8" },
            { "imi", "Z11" },
        };

        private static readonly Dictionary<string, string> MdCFromGardinerSign = CreateReverseLookup(gardinerSignFromMdC);
    }
}
