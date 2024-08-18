using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace PP1
{
    public class LayoutStateV1 : LayoutState
    {
        public LayoutStateV1()
        {
            cleanStart = true;
        }

        public override void OnResetFont()
        {
            advance = vertical;
        }

        public override void ResetForNewWord()
        {
            cleanStart = true;
            base.ResetForNewWord();
        }

        public override bool HandleGlyph(IList<Letter> letters, int position, CustomGlyphLibrary library)
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

            bool verticalDirection = direction == Direction.VerticalLeftToRight || direction == Direction.VerticalRightToLeft;
            if(cleanStart)
            {
                Letters.HieroglyphShape shape = Letters.GetHieroglyphShape(letters[position], library);
                Letters.HieroglyphShape nextShape =
                    ((position + 1) < letters.Count)
                        ? Letters.GetHieroglyphShape(letters[position + 1], library)
                        : Letters.HieroglyphShape.FullSquare;
                Letters.HieroglyphShape thirdShape =
                    ((position + 2) < letters.Count)
                        ? Letters.GetHieroglyphShape(letters[position + 2], library)
                        : Letters.HieroglyphShape.FullSquare;
                // if the next letter is just a square...
                if (shape == Letters.HieroglyphShape.FullSquare)
                {
                    // is there no next shape?
                    if(position == letters.Count - 1)
                    {
                        // done.
                        FillAllCadrats();
                        return true;
                    }

                    if(nextShape == Letters.HieroglyphShape.FullSquare)
                    {
                        if(Letters.CanShrink(letters[position])
                            && Letters.CanShrink(letters[position + 1]))
                        {
                            // we are going vertical? line em up horizontally.
                            if(verticalDirection)
                            {

                            }
                            else
                            {
                                // line them up vertically

                            }
                        }
                    }
                }
            }

            return true;
        }

        public override void Advance(IList<Letter> letters, int position)
        {
            StandardAdvance();
            //cleanStart = true;
        }

        protected int glyphStackingState = 0;
        protected int glyphRowState = 0;
        protected int glyphStackingCount = 0;
        protected int glyphRowCount = 0;
        protected bool cleanStart = true;
    }
}
