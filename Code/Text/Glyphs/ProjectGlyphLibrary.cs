using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace PP1
{
    class ProjectGlyphLibrary : CustomGlyphLibrary
    {
        public ProjectGlyphLibrary(Project owningProject, GlyphLibrary baseGlyphLibrary)
        {
            project = owningProject;
            baseLibrary = baseGlyphLibrary;
        }

        public override void DrawLetter(Graphics graphics, Letter letter, int x, int y, int width, int height, bool flippedX = false)
        {
            baseLibrary.DrawLetter(graphics, letter, x, y, width, height, flippedX);
        }

        public override void Load(string path)
        {
            // NOPE (!!!)
        }

        public override void Save(string path)
        {
            // TODO: ...
        }

        public override bool HasPath()
        {
            return false;
        }

        public override bool IsReadOnly()
        {
            return true;
        }

        public override string GetPath()
        {
            return "";
        }

        public override int GetOverrideCount()
        {
            return baseLibrary.GetOverrideCount();
        }

        public override ICustomGlyphSource GetOverride(int index)
        {
            return baseLibrary.GetOverride(index);
        }

        public override void RemoveOverride(string identifier)
        {
            baseLibrary.RemoveOverride(identifier);
        }

        public override bool IsSquareImages()
        {
            CustomGlyphLibrary library = baseLibrary as CustomGlyphLibrary;
            if(library != null)
            {
                return library.IsSquareImages();
            }

            return true;
        }

        public override ICustomGlyphSource GetOverrideForLetter(Letter letter, out bool isSquare)
        {
            isSquare = true;
            CustomGlyphLibrary library = baseLibrary as CustomGlyphLibrary;
            if (library != null)
            {
                return library.GetOverrideForLetter(letter, out isSquare);
            }

            return null;
        }

        private Project project;
        private GlyphLibrary baseLibrary = GlyphLibrary.Default;
    }
}
