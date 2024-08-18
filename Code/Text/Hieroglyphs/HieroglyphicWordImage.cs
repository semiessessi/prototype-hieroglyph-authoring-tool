using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PP1
{
    public static class HieroglyphicWordImage
    {
        public const TextFormatFlags TightTextFormatFlags =
            TextFormatFlags.NoPadding
            | TextFormatFlags.NoClipping
            | TextFormatFlags.SingleLine
            | TextFormatFlags.Top
            | TextFormatFlags.Left;

        public static Image CreateSimple(Word word, int width, int height, int fontSize = 256, GlyphLibrary overrideLibrary = null)
        {
            Image image = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            Graphics graphics = Graphics.FromImage(image);
            DrawWordSimple(graphics, word, fontSize);
            return image;
        }

        public static void DrawWord(Graphics graphics, LayoutState state, Word word, int fontSize = 256, GlyphLibrary overrideLibrary = null)
        {
            Project project = Program.GetProject();
            Font font = new Font(GetBaseFont().Name, fontSize);
            GlyphLibrary library = (overrideLibrary != null)
                ? overrideLibrary
                : ((project == null)
                    ? GlyphLibrary.Default
                    : project.FinalGlyphLibrary);

            IList<Letter> letters =
                state.IsTransliterating()
                    ? word.ToTransliterationSymbols()
                    : letters = word.GetLetters();

            int count = letters.Count;
            for(int position = 0; position < count; ++position)
            {
                state.HandleGlyph(letters, position, library as CustomGlyphLibrary);
                library.DrawLetter(graphics, letters[position], 
                    state.GetX(), state.GetY(), state.GetAdvance(), state.GetVertical(), state.ShouldFlipX());
                state.Advance(letters, position);
            }
        }

        public static void DrawWordSimple(Graphics graphics, Word word, int fontSize = 256, GlyphLibrary overrideLibrary = null)
        {
            Project project = Program.GetProject();
            Font font = new Font(GetBaseFont().Name, fontSize);
            int ascend = font.FontFamily.GetCellAscent(font.Style);
            int emHeight = font.FontFamily.GetEmHeight(font.Style);
            float ratio = (float)ascend / emHeight;
            int vertical = (int)(fontSize * ratio);
            int descend = (int)(fontSize * (float)font.FontFamily.GetCellDescent(font.Style) / emHeight);
            int advance = fontSize + (fontSize >> 1);
            int lastAdvance = advance;
            bool upHalf = false;
            int x = 0;
            int lastx = 0;
            int y = 0;// (int)(fontSize * ((float)emHeight)/ascend);
            foreach (Letter letter in word.GetLetters())
            {
                CustomGlyphLibrary library = overrideLibrary as CustomGlyphLibrary; 
                if(library == null)
                {
                    if(project != null)
                    {
                        library = project.FinalGlyphLibrary as CustomGlyphLibrary;
                    }
                }
                Letters.HieroglyphShape shape = Letters.GetHieroglyphShape(letter, library);
                bool small = false;
                if ((shape == Letters.HieroglyphShape.HalfHeight)
                    || (shape == Letters.HieroglyphShape.ThirdHeight)
                    || (shape == Letters.HieroglyphShape.QuarterSquare))
                {
                    upHalf = !upHalf;
                    small = true;
                    if (upHalf == false)
                    {
                        x = lastx;
                    }
                }
                else
                {
                    upHalf = false;
                }

                bool halfWidth = (shape == Letters.HieroglyphShape.HalfWidth)
                    || (shape == Letters.HieroglyphShape.QuarterSquare);

                int yAdjust = upHalf ? (vertical >> 1) : 0;
                int yFinal = y - yAdjust + (vertical >> 1); // <- this is annoying. without it, things are probably better.
                if(overrideLibrary != null)
                {
                    overrideLibrary.DrawLetter(graphics, letter, x, y - yAdjust, advance, vertical);
                }
                else if (project == null)
                {
                    GlyphLibrary.Default.DrawLetter(graphics, letter, x, y - yAdjust, advance, vertical);
                }
                else
                {
                    // TODO: use final glyph library...
                    project.FinalGlyphLibrary.DrawLetter(graphics, letter, x, y - yAdjust, advance, vertical);
                }

                int xStep = halfWidth ? (advance >> 1) : advance;

                if (shape == Letters.HieroglyphShape.ThirdWidth)
                {
                    xStep = advance / 3;
                }
                else if (shape == Letters.HieroglyphShape.TwoThirdWidth)
                {
                    xStep = 2 * advance / 3;
                }
                else if (shape == Letters.HieroglyphShape.QuarterWidth)
                {
                    xStep = advance >> 2;
                }

                if (small && (upHalf == false))
                {
                    xStep = lastAdvance;
                }

                lastAdvance = xStep;
                lastx = x;
                x += xStep;
            }
        }

        public static Font GetBaseFont()
        {
            if (LastFont == null)
            {
                string[] fontNames = new string[] { "Noto Sans SemiBold", "Noto Sans", "Arial", "Segoe UI", "Tahoma" };
                Font font = null;
                foreach (string fontName in fontNames)
                {
                    font = new Font(fontName, 256);
                    if (font.Name == fontName)
                    {
                        break;
                    }
                    else
                    {
                        font = null;
                    }
                };

                LastFont = font;
            }

            return LastFont;
        }

        private static Font LastFont = null;
    }
}
