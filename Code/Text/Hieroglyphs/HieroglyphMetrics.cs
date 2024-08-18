using System;
using System.Collections.Generic;
using System.Text;

namespace PP1
{
    public static partial class Letters
    {
        public enum HieroglyphShape
        {
            FullSquare = 0,
            HalfHeight,
            ThirdHeight,
            QuarterHeight,
            TwoThirdHeight,
            HalfWidth,
            ThirdWidth,
            QuarterWidth,
            TwoThirdWidth,
            QuarterSquare,
        }

        public static HieroglyphShape GetHieroglyphShape(
            Letter letter, CustomGlyphLibrary glyphLibrary)
        {
            // always do little squares as little squares
            HieroglyphShape lookupShape = HieroglyphShape.FullSquare;
            if (hieroglyphShapes.ContainsKey(letter))
            {
                lookupShape = hieroglyphShapes[letter];
                // SE - TODO: erm... no sure why i wanted to exclude some cases?
                // maybe if the images are more accurate??
                if(lookupShape != HieroglyphShape.FullSquare)
                {
                    return lookupShape;
                }
            }

            if ((glyphLibrary == null) || glyphLibrary.IsSquareImages())
            {
                return lookupShape;
            }

            bool square = true;
            ICustomGlyphSource glyphOverride = glyphLibrary.GetOverrideForLetter(letter, out square);
            if(square)
            {
                return lookupShape;
            }

            if(glyphOverride is PNGGlyphOverride)
            {
                PNGGlyphOverride pngOverride = glyphOverride as PNGGlyphOverride;
                int width = pngOverride.GetWidth();
                int height = pngOverride.GetHeight();
                int width2 = width + width;
                int width3 = width + width2;
                int height2 = height + height;
                int height3 = height + height2;

                if(width3 <= height)
                {
                    return HieroglyphShape.ThirdWidth;
                }

                if (width2 <= height)
                {
                    return HieroglyphShape.HalfWidth;
                }

                if (width3 <= height2)
                {
                    return HieroglyphShape.TwoThirdWidth;
                }

                if (height3 <= width)
                {
                    return HieroglyphShape.ThirdHeight;
                }

                if (height2 <= width)
                {
                    return HieroglyphShape.HalfHeight;
                }

                if (height3 <= width2)
                {
                    return HieroglyphShape.TwoThirdHeight;
                }
            }

            return lookupShape;
        }

        public static bool CanShrink(Letter letter)
        {
            return shrinkable.Contains(letter);
        }

        private static Dictionary<Letter, HieroglyphShape> CreateHieroglyphShapes()
        {
            return new Dictionary<Letter, HieroglyphShape>
            {
                { Letter.FromMdC("A"), HieroglyphShape.TwoThirdWidth },
                { Letter.FromMdC("Anx"), HieroglyphShape.HalfWidth },
                { Letter.FromMdC("a"), HieroglyphShape.HalfHeight },
                { Letter.FromMdC("b"), HieroglyphShape.HalfWidth },
                { Letter.FromMdC("d"), HieroglyphShape.HalfHeight },
                { Letter.FromMdC("Di"), HieroglyphShape.HalfWidth },
                { Letter.FromMdC("f"), HieroglyphShape.HalfHeight },
                { Letter.FromMdC("Htp"), HieroglyphShape.ThirdHeight },
                { Letter.FromMdC("i"), HieroglyphShape.QuarterWidth },
                { Letter.FromMdC("im"), HieroglyphShape.ThirdHeight },
                { Letter.FromMdC("iri"), HieroglyphShape.HalfHeight },
                { Letter.FromMdC("iwn"), HieroglyphShape.HalfWidth },
                { Letter.FromMdC("mAat"), HieroglyphShape.HalfWidth },
                { Letter.FromMdC("mri"), HieroglyphShape.ThirdHeight },
                { Letter.FromMdC("n"), HieroglyphShape.ThirdHeight },
                { Letter.FromMdC("nfr"), HieroglyphShape.ThirdWidth },
                { Letter.FromMdC("nTr"), HieroglyphShape.ThirdWidth },
                { Letter.FromMdC("ni"), HieroglyphShape.HalfHeight },
                { Letter.FromMdC("niwt"), HieroglyphShape.QuarterSquare },
                { Letter.FromMdC("nw"), HieroglyphShape.QuarterSquare },
                { Letter.FromMdC("p"), HieroglyphShape.QuarterSquare },
                { Letter.FromMdC("pr"), HieroglyphShape.HalfHeight },
                { Letter.FromMdC("q"), HieroglyphShape.QuarterSquare },
                { Letter.FromMdC("r"), HieroglyphShape.HalfHeight },
                { Letter.FromMdC("rA"), HieroglyphShape.QuarterSquare },
                { Letter.FromMdC("s"), HieroglyphShape.QuarterWidth },
                { Letter.FromMdC("sbA"), HieroglyphShape.TwoThirdWidth },
                { Letter.FromMdC("stp"), HieroglyphShape.HalfHeight },
                { Letter.FromMdC("sw"), HieroglyphShape.ThirdWidth },
                { Letter.FromMdC("t"), HieroglyphShape.QuarterSquare },
                { Letter.FromMdC("w"), HieroglyphShape.HalfWidth },
                { Letter.FromMdC("wsr"), HieroglyphShape.ThirdWidth },
                { Letter.FromMdC("x"), HieroglyphShape.QuarterSquare },
                { Letter.FromMdC("y"), HieroglyphShape.TwoThirdWidth },
                { Letter.FromMdC("z"), HieroglyphShape.ThirdHeight },

                { Letter.FromMdC("A1"), HieroglyphShape.TwoThirdWidth },
                { Letter.FromMdC("A2"), HieroglyphShape.TwoThirdWidth },
                { Letter.FromMdC("A3"), HieroglyphShape.TwoThirdWidth },
                { Letter.FromMdC("A4"), HieroglyphShape.TwoThirdWidth },

                { Letter.FromMdC("A30"), HieroglyphShape.TwoThirdWidth },

                { Letter.FromMdC("C2"), HieroglyphShape.TwoThirdWidth },
                { Letter.FromMdC("C2a"), HieroglyphShape.TwoThirdWidth },
                //{ Letter.FromMdC("C10"), HieroglyphShape.HalfWidth },
                { Letter.FromMdC("C10a"), HieroglyphShape.HalfWidth },

                { Letter.FromMdC("D54"), HieroglyphShape.HalfHeight },

                { Letter.FromMdC("W10"), HieroglyphShape.QuarterSquare },

                { Letter.FromMdC("Y1"), HieroglyphShape.QuarterHeight },
                { Letter.FromMdC("Y1a"), HieroglyphShape.QuarterWidth },

                { Letter.FromMdC("Z1"), HieroglyphShape.QuarterSquare },
                { Letter.FromMdC("Z2"), HieroglyphShape.HalfHeight },
                { Letter.FromMdC("Z3"), HieroglyphShape.QuarterWidth },
                { Letter.FromMdC("Z5A"), HieroglyphShape.QuarterWidth },
            };
        }

        private static HashSet<Letter> CreateHieroglyphShrinks()
        {
            return new HashSet<Letter>
            {            
                Letter.FromMdC("A1"),
                Letter.FromMdC("C1"),
            };
        }

        private static Dictionary<Letter, HieroglyphShape> hieroglyphShapes = null;
        private static HashSet<Letter> shrinkable = null;
    }
}
