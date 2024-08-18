using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PP1
{
    public class Project
    {
        public enum PageLayout
        {
            Page,
            Book,
            TopToBottom,
            LeftToRight,
            RightToLeft
        }

        public static string GetLayoutName(PageLayout layout)
        {
            switch(layout)
            {
                case PageLayout.Page:           return "Single Page";
                case PageLayout.Book:           return "Book";
                case PageLayout.TopToBottom:    return "Top -> Bottom";
                case PageLayout.LeftToRight:    return "Left -> Right";
                case PageLayout.RightToLeft:    return "Right <- Left";
            }

            return "(unknown layout)";
        }

        public Project()
        {
            glyphLibrary = new ProjectGlyphLibrary(this, baseGlyphLibrary);
        }

        public string GenerateTextData()
        {
            // header
            string data = "PP1F\n" + Program.Name + " Project File Version 1\n";
            
            data += name + "\n";
            data += (int)layout + "\n";
            data += maxHeightMM.ToString() + "\n";
            data += maxwidthMM.ToString() + "\n";
            data += baseGlyphLibrary.GetPath().ToString() + "\n";

            foreach (string path in relativeSourcePaths)
            {
                data += path + "\n";
            }

            return data;
        }

        public void WriteToFile(string path)
        {
            string data = GenerateTextData();
            File.WriteAllText(path, data);
            bDirty = false;
        }

        public static Project LoadFromFile(string path)
        {
            Text.ResetSections();
            return CreateFromString(File.ReadAllText(path));
        }

        public bool IsDirty()
        {
            return bDirty;
        }

        public void AddSourceFile(string path)
        {
            if(File.Exists(path))
            {
                relativeSourcePaths.Add(path);
                contentSources.Add(Content.CreateFromFile(path));
                bDirty = true;
            }
        }

        public void RemoveSourceFile(string path)
        {
            relativeSourcePaths.Remove(path);
            // TODO: remove as content source.
            bDirty = true;
        }

        public void AddNewText()
        {
            unsavedNewContent.Add(new TextContent());
        }

        public int GetFileCount()
        {
            return unsavedNewContent.Count + contentSources.Count;
        }

        public Content GetContentForFile(int index)
        {
            if(index >= contentSources.Count)
            {
                int newIndex = index - contentSources.Count;
                return unsavedNewContent.ElementAt(newIndex);
            }

            return contentSources.ElementAt(index);
        }

        public static Project CreateFromString(string inputString)
        {
            // check 4cc...
            if(inputString.StartsWith("PP1F") == false)
            {
                // error (!)
                return null;
            }

            // TODO: versions.
            string[] lines = inputString.Split('\n');

            if(lines.Length < 6)
            {
                // error (!)
                return null;
            }

            Project newProject = new Project();
            newProject.name = lines[2];
            newProject.layout = (PageLayout)Convert.ToInt32(lines[3]);
            newProject.maxHeightMM = Convert.ToSingle(lines[4]);
            newProject.maxwidthMM = Convert.ToSingle(lines[5]);
            //newProject.glyphLibraryPath = lines[6];
            if(lines[6].Length >= 1)
            {
                // TODO: load glyph library
                newProject.baseGlyphLibrary =
                    CustomGlyphLibrary.CreateFromFile(lines[6]);
            }

            for(int i = 7; i < lines.Length; ++i)
            {
                Content newContent = Content.CreateFromFile(lines[i]);
                if(newContent == null)
                {
                    continue;
                }

                newProject.relativeSourcePaths.Add(lines[i]);
                newProject.contentSources.Add(newContent);
            }

            newProject.glyphLibrary = new ProjectGlyphLibrary(
                newProject, newProject.baseGlyphLibrary);
            return newProject;
        }

        public void ReplaceBaseGlyphLibrary(GlyphLibrary newLibrary)
        {
            baseGlyphLibrary = newLibrary;
            glyphLibrary = new ProjectGlyphLibrary(
                this, baseGlyphLibrary);
            bDirty = true;
        }

        public string Name { get { return name; } set { name = value; } }
        public GlyphLibrary BaseGlyphLibrary { get { return baseGlyphLibrary; } }
        public GlyphLibrary FinalGlyphLibrary { get { return glyphLibrary; } }


        private SortedSet<string> relativeSourcePaths = new SortedSet<string>();
        private string name = "Project1";
        private PageLayout layout = PageLayout.Page;
        // defaults to A3 single page dimensions
        private float maxHeightMM = 297.0f;
        private float maxwidthMM = 420.0f;
        private GlyphLibrary baseGlyphLibrary = GlyphLibrary.Default;
        private ProjectGlyphLibrary glyphLibrary = null;

        private SortedSet<Content> unsavedNewContent = new SortedSet<Content>();
        private SortedSet<Content> contentSources = new SortedSet<Content>();

        private bool bDirty = false;
    }
}
