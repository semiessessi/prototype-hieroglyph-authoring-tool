using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace PP1
{
    public class LayoutState
    {
        public enum Positioning
        {
            Simple = 0,
            Cadrat = 1,
        }

        public enum Direction
        {
            Left = 0,
            Right,
            VerticalLeftToRight,
            VerticalRightToLeft
        }

        public bool ShouldFlipX()
        {
            return direction == Direction.Left || direction == Direction.VerticalRightToLeft;
        }

        public void ResetFont(Font font, int fontSize, Direction direction = Direction.Right)
        {
            ascend = font.FontFamily.GetCellAscent(font.Style);
            emHeight = font.FontFamily.GetEmHeight(font.Style);
            float ratio = (float)ascend / emHeight;
            size = fontSize;
            vertical = (int)(size * ratio);
            descend = (int)(size * (float)font.FontFamily.GetCellDescent(font.Style) / emHeight);
            advance = size + (size >> 1); // a terrible guess.
            for(int i = 0; i < 4; ++i)
            {
                filledCadratBlocks[i] = false;
            }

            OnResetFont();
        }

        public virtual void OnResetFont()
        {

        }

        public void ResetPositonAndSize(int x, int y, int width, int height)
        {
            blockX = x;
            if (direction == Direction.Left || direction == Direction.VerticalRightToLeft)
            {
                blockX += width;
                blockX -= advance;
            }
            blockY = y;
            startX = x;
            startY = blockY;
            nextX = blockX;
            nextY = blockY;
            totalWidth = width;
            totalHeight = height;
        }

        public virtual void ResetForNewWord()
        {
            if (positioning == Positioning.Cadrat)
            {
                bool anyFilled = false;
                for (int i = 0; i < 4; ++i)
                {
                    anyFilled = filledCadratBlocks[i] || anyFilled;
                    filledCadratBlocks[i] = false;
                }

                if (anyFilled)
                {
                    for (int i = 0; i < 4; ++i)
                    {
                        filledCadratBlocks[i] = true;
                    }

                    StandardAdvance();
                }
            }
            else
            {
                StartNewLine();
            }
        }

        public void ResetLayoutType(Text.Layout textLayout)
        {
            switch(textLayout)
            {
                default:
                case Text.Layout.PreviewWordLines:
                {
                    direction = Direction.Right;
                    positioning = Positioning.Simple;
                    break;
                }

                case Text.Layout.VerticalLeftToRight:
                {
                    direction = Direction.VerticalLeftToRight;
                    positioning = Positioning.Cadrat;
                    break;
                }

                case Text.Layout.VerticalRightToLeft:
                {
                    direction = Direction.VerticalRightToLeft;
                    positioning = Positioning.Cadrat;
                    break;
                }

                case Text.Layout.LeftToRight:
                {
                    direction = Direction.Right;
                    positioning = Positioning.Cadrat;
                    break;
                }

                case Text.Layout.RightToLeft:
                {
                    direction = Direction.Left;
                    positioning = Positioning.Cadrat;
                    break;
                }

                case Text.Layout.Transliteration:
                {
                    direction = Direction.Right;
                    positioning = Positioning.Simple;
                    shouldTransliterate = true;
                    break;
                }
            }
        }

        protected bool IsShortGlyph(Letters.HieroglyphShape shape)
        {
            return (shape == Letters.HieroglyphShape.QuarterSquare)
                || (shape == Letters.HieroglyphShape.QuarterHeight)
                || (shape == Letters.HieroglyphShape.ThirdHeight)
                || (shape == Letters.HieroglyphShape.HalfHeight);
        }

        protected bool IsTallGlyph(Letters.HieroglyphShape shape)
        {
            return (shape == Letters.HieroglyphShape.HalfWidth)
                || (shape == Letters.HieroglyphShape.ThirdWidth)
                || (shape == Letters.HieroglyphShape.QuarterWidth);
        }

        public virtual bool HandleGlyph(IList<Letter> letters, int position, CustomGlyphLibrary library)
        {
            // skip if out of bounds.
            if ((blockX > (startX + totalWidth))
                && (blockY > (startY + totalHeight)))
            {
                return false;
            }

            if (positioning == Positioning.Simple)
            {
                return true;
            }

            nextX = blockX;
            nextY = blockY;
            Letters.HieroglyphShape primaryShape
                = Letters.GetHieroglyphShape(letters[position], library);
            Letters.HieroglyphShape nextShape =
                ((position + 1) < letters.Count)
                    ? Letters.GetHieroglyphShape(letters[position + 1], library)
                    : Letters.HieroglyphShape.FullSquare;
            bool shortHeight = IsShortGlyph(primaryShape);
            bool nextIsShort = IsShortGlyph(nextShape);
            bool thinTall = IsTallGlyph(primaryShape);
            bool nextIsTall = IsTallGlyph(nextShape);
            bool done = false;
            bool bottomEmpty = !(filledCadratBlocks[2])
                && !(filledCadratBlocks[3]);
            if (bottomEmpty)
            {
                bool empty = !(filledCadratBlocks[0])
                    && !(filledCadratBlocks[1]);
                // have we just filled the top left?
                bool topLeftOnly = filledCadratBlocks[0]
                    && !(filledCadratBlocks[1]);
                if (empty)
                {
                    // totally empty
                    // adjust height if we are short enough. so we go on the top row...
                    if (shortHeight)
                    {
                        nextY -= vertical >> 1;
                        filledCadratBlocks[0] = true;
                        bool isSquare = primaryShape == Letters.HieroglyphShape.QuarterSquare;
                        filledCadratBlocks[1] = !isSquare;

                        // TODO: if the next shape is not a quarter shape, and this one is
                        // place it in the centre of the top or the 'left' accordingly

                        if (isSquare && (nextShape != Letters.HieroglyphShape.QuarterSquare))
                        {
                            if (nextIsShort)
                            {
                                filledCadratBlocks[1] = true;
                                nextX += advance >> 2;
                            }
                            else if (nextIsTall)
                            {
                                filledCadratBlocks[2] = true;
                                nextY += vertical >> 1;
                            }
                        }
                        else if ((primaryShape == Letters.HieroglyphShape.QuarterSquare)
                            || nextIsTall) // two squares in a row. long followed by tall et.
                        {
                            // adjust horizontally if going left
                            if (direction == Direction.Left || direction == Direction.VerticalRightToLeft)
                            {
                                nextX += advance >> 1;
                            }
                            if (direction == Direction.VerticalRightToLeft
                                || direction == Direction.VerticalLeftToRight)// if vertical, do a cheaty half block and fill everything, and center ourselves.
                            {
                                if (nextIsTall)
                                {
                                    filledCadratBlocks[2] = true;
                                    filledCadratBlocks[3] = true;
                                    blockY -= vertical >> 1;
                                }
                                else if (nextShape != Letters.HieroglyphShape.QuarterSquare)
                                {
                                    nextX += advance >> 2;
                                }
                            }
                        }
                    }
                    else if (thinTall)
                    {
                        filledCadratBlocks[0] = true;
                        filledCadratBlocks[2] = true;
                        // adjust horizontally if going left
                        if (direction == Direction.Left || direction == Direction.VerticalRightToLeft)
                        {
                            nextX += advance >> 1;
                        }

                        if(nextIsShort)
                        {
                            // if we are vertical, centre ourselves and fill the block
                            // otherwise do a cheaty half block move left/right
                            if (direction == Direction.Left)
                            {
                                blockX += advance >> 1;
                            }
                            else if (direction == Direction.Right)
                            {
                                blockX -= advance >> 1;
                            }
                            else
                            {
                                // TODO: is this right?
                                nextX += advance >> 2;
                            }
                            filledCadratBlocks[1] = true;
                            filledCadratBlocks[3] = true;
                        }
                    }
                    else if ((primaryShape == Letters.HieroglyphShape.FullSquare)
                        || (primaryShape == Letters.HieroglyphShape.TwoThirdHeight)
                        || (primaryShape == Letters.HieroglyphShape.TwoThirdWidth))
                    {
                        for (int i = 0; i < 4; ++i)
                        {
                            filledCadratBlocks[i] = true;
                        }
                    }
                    done = true;
                }
                else if (topLeftOnly)
                {
                    if (primaryShape == Letters.HieroglyphShape.QuarterSquare)
                    {
                        if (nextIsTall) // fill the block below
                        {
                            filledCadratBlocks[2] = true;
                            // adjust horizontally if going left
                            if (direction == Direction.Left || direction == Direction.VerticalRightToLeft)
                            {
                                nextX += advance >> 1;
                            }
                        }
                        else
                        {
                            // fill the top right
                            // adjust horizontally if going right
                            if (direction != Direction.Left && direction != Direction.VerticalRightToLeft)
                            {
                                nextX += advance >> 1;
                            }
                            
                            nextY -= vertical >> 1;
                            filledCadratBlocks[1] = true;
                        }
                        done = true;
                    }
                }
                else if (shortHeight) // just the bottom
                {
                    filledCadratBlocks[2] = true;
                    bool finalFilled = primaryShape != Letters.HieroglyphShape.QuarterSquare
                        || nextShape != Letters.HieroglyphShape.QuarterSquare;
                    filledCadratBlocks[3] = finalFilled;
                    // centre square glyphs if we can fit them.
                    if((primaryShape == Letters.HieroglyphShape.QuarterSquare)
                        && (nextShape != Letters.HieroglyphShape.QuarterSquare))
                    {
                        nextX += advance >> 2;
                    }
                    //nextY -= vertical >> 1;
                    done = true;
                }

                if(done == false)
                {
                    // ... otherwise we fill the block
                    //if(shortHeight)
                    //{
                    //    nextY += vertical >> 1;
                    //}
                    filledCadratBlocks[0] = true;
                    filledCadratBlocks[1] = true;
                    filledCadratBlocks[2] = true;
                    filledCadratBlocks[3] = true;
                }
            }
            else if(filledCadratBlocks[3] == false) // bottom 'right' is still empty
            {
                // is the top 'right' empty? are we tall and thin?
                if(thinTall && filledCadratBlocks[1] == false)
                {
                    if (direction != Direction.Left && direction != Direction.VerticalRightToLeft)
                    {
                        nextX += advance >> 1;
                    }
                    filledCadratBlocks[1] = true;
                    filledCadratBlocks[3] = true;
                }
                else if(primaryShape == Letters.HieroglyphShape.QuarterSquare)
                {
                    if (direction != Direction.Left && direction != Direction.VerticalRightToLeft)
                    {
                        nextX += advance >> 1;
                    }
                    if (filledCadratBlocks[1] == false)
                    {
                        nextY -= vertical >> 1;
                        filledCadratBlocks[1] = true;
                    }
                    else
                    {
                        filledCadratBlocks[3] = true;
                    }
                }
                else // ... otherwise we fill the block
                {
                    filledCadratBlocks[0] = true;
                    filledCadratBlocks[1] = true;
                    filledCadratBlocks[2] = true;
                    filledCadratBlocks[3] = true;
                }
            }

            // whatever else, lets fill the whole thing if the next shape is a whole square...
            // just to be sure.
            if((nextShape == Letters.HieroglyphShape.FullSquare)
                || (nextShape == Letters.HieroglyphShape.TwoThirdHeight)
                || (nextShape == Letters.HieroglyphShape.TwoThirdWidth))
            {
                // if only the left is filled and we are going horizontally
                // do a cheaty half advance by stepping back a bit.
                if (filledCadratBlocks[0]
                    && filledCadratBlocks[2]
                    && (filledCadratBlocks[1] == false)
                    && (filledCadratBlocks[3] == false))
                {
                    // TODO: if we were tall and thin, centralise?

                    if (direction == Direction.Left)
                    {
                        blockX += advance >> 1;
                    }
                    else if (direction == Direction.Right)
                    {
                        blockX -= advance >> 1;
                    }
                }

                filledCadratBlocks[0] = true;
                filledCadratBlocks[1] = true;
                filledCadratBlocks[2] = true;
                filledCadratBlocks[3] = true;
            }

            // skip if out of bounds.
            if ((blockX > (startX + totalWidth))
                && (blockY > (startY + totalHeight)))
            {
                return false;
            }

            return true;
        }

        public virtual void Advance(IList<Letter> letters, int position)
        {
            StandardAdvance();
        }

        protected void FitToRectangle(int x, int y, int width, int height, Letter letter, CustomGlyphLibrary glyphLibrary)
        {
            Letters.HieroglyphShape shape = Letters.GetHieroglyphShape(letter, glyphLibrary);
            bool square = true;
            ICustomGlyphSource glyphOverride = glyphLibrary.GetOverrideForLetter(letter, out square);
            float xRatio = 1.0f;
            float yRatio = 1.0f;
            if (glyphOverride is PNGGlyphOverride)
            {
                PNGGlyphOverride pngOverride = glyphOverride as PNGGlyphOverride;
                int glyphWidth = pngOverride.GetWidth();
                int glyphHeight = pngOverride.GetHeight();
                xRatio = Math.Min((float)glyphWidth / (float)glyphHeight, 1.0f);
                yRatio = Math.Min((float)glyphHeight / (float)glyphWidth, 1.0f);
            }
            
            float xBoxRatio = Math.Min((float)width / (float)height, 1.0f);
            float yBoxRatio = Math.Min((float)height / (float)width, 1.0f);

            if (xBoxRatio < xRatio) // area is thinner than glyph
            {
                if (xRatio < yRatio)
                {
                    // tall/thin glyph
                    // scale glyph to fit width
                    // pad top and bottom.    
                }
                else
                {
                    // square or flat/wide-glyph
                    // scale glyph to fit height
                    // pad left and right
                }
            }
            else // area precisely fits, or is wider than glyph
            {
                if (xRatio < yRatio)
                {
                    // tall/thin glyph
                    // scale glyph to fit height
                    // pad left and right    
                }
                else
                {
                    // square or flat/wide-glyph
                    // scale glyph to fit width
                    // pad top and bottom
                }
            }
        }

        protected void StandardAdvance()
        {
            bool cadratDone = (positioning == Positioning.Cadrat)
                && filledCadratBlocks[0] && filledCadratBlocks[1]
                && filledCadratBlocks[2] && filledCadratBlocks[3];
            
            if (cadratDone)
            {
                if (direction == Direction.Right)
                {
                    // just advance naively until we hit the width.
                    blockX += advance;
                    if ((blockX + advance) >= totalWidth)
                    {
                        StartNewLine();
                    }
                }
                else if (direction == Direction.Left)
                {
                    blockX -= advance;
                    if ((blockX - advance) <= 0)
                    {
                        StartNewLine();
                    }
                }
                else
                {
                    // it must be vertical.
                    int yStep = size + descend;
                    blockY += yStep;
                    if ((blockY + yStep) >= totalHeight)
                    {
                        StartNewLine();
                    }
                }

                for (int i = 0; i < 4; ++i)
                {
                    filledCadratBlocks[i] = false;
                }
            }
            else if (positioning == Positioning.Simple)
            {
                if (direction == Direction.Right)
                {
                    // just advance naively until we hit the width.
                    nextX += advance;
                    if ((nextX + advance) >= totalWidth)
                    {
                        StartNewLine();
                    }
                }
                else if (direction == Direction.Left)
                {
                    nextX -= advance;
                    if ((nextX - advance) <= 0)
                    {
                        StartNewLine();
                    }
                }
                else
                {
                    // it must be vertical.
                    int yStep = size + descend;
                    nextY += yStep;
                    if ((nextY + yStep) >= totalHeight)
                    {
                        StartNewLine();
                    }
                }
            }
        }

        public void StartNewLine()
        {
            if (direction == Direction.Right)
            {
                blockX = startX;
                blockY += advance; // ?
            }
            else if(direction == Direction.Left)
            {
                blockX = startX + totalWidth - advance;
                blockY += advance; // ?
            }
            else if(direction == Direction.VerticalLeftToRight)
            {
                blockX += advance;
                blockY = startY;
            }
            else if (direction == Direction.VerticalRightToLeft)
            {
                blockX -= advance;
                blockY = startY;
            }

            nextX = blockX;
            nextY = blockY;
        }

        public int GetX()
        {
            return nextX;
        }

        public int GetY()
        {
            return nextY;
        }

        public int GetAdvance()
        {
            return advance;
        }

        public int GetVertical()
        {
            return vertical;
        }

        public void StartTransliterating()
        {
            shouldTransliterate = true;
        }

        public void StopTransliterating()
        {
            shouldTransliterate = false;
        }

        public bool IsTransliterating()
        {
            return shouldTransliterate;
        }

        protected void FillAllCadrats()
        {
            for(int i = 0; i < 4; ++i)
            {
                filledCadratBlocks[i] = true;
            }
        }

        protected Positioning positioning = Positioning.Simple;
        protected Direction direction = Direction.Right;
        protected bool[] filledCadratBlocks = new bool[4];

        protected int startX = 0;
        protected int startY = 0;
        protected int blockX = 0;
        protected int blockY = 0;
        protected int nextX = 0;
        protected int nextY = 0;
        protected int ascend = 0;
        protected int emHeight = 0;
        protected int size = 0;
        protected int vertical = 0;
        protected int descend = 0;
        protected int advance = 0;
        protected int totalWidth = 0;
        protected int totalHeight = 0;
        
        protected bool shouldTransliterate = false;

        const int TopFirstQuad = 0;
        const int TopSecondQuad = 1;
        const int BottomFirstQuad = 2;
        const int BottomSecondQuad = 3;
    }
}
