using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace PP1
{
    public class CustomGlyphLibrary : DefaultGlyphLibrary
    {
        public override void DrawLetter(Graphics graphics, Letter letter, int x, int y, int width, int height, bool flippedX = false)
        {
            int finalWidth = width;
            int finalHeight = height;
            int finalY = y;
            if(fullSizeImages)
            {
                if(Letters.GetHieroglyphShape(letter, this) == Letters.HieroglyphShape.QuarterSquare)
                {
                    finalWidth >>= 1;
                    finalHeight >>= 1;
                    finalY += finalHeight;
                }
            }

            if(overrides.ContainsKey(letter) == false)
            {
                foreach(CustomGlyphLibrary library in referencedLibraries)
                {
                    if(library.overrides.ContainsKey(letter))
                    {
                        if (library.fullSizeImages)
                        {
                            library.overrides[letter].DrawGlyph(graphics, x, finalY, finalWidth, finalHeight, flippedX);
                        }
                        else
                        {
                            library.overrides[letter].DrawGlyph(graphics, x, y, width, height, flippedX);
                        }
                        return;
                    }
                }
                base.DrawLetter(graphics, letter, x, y, width, height, flippedX);
                return;
            }

            overrides[letter].DrawGlyph(graphics, x, finalY, finalWidth, finalHeight, flippedX);
        }

        public override void Load(string path)
        {
            referencedLibraries.Clear();
            overrideList.Clear();
            overrides.Clear();
            sourceFilePath = "";
            fullSizeImages = false;

            if (File.Exists(path) == false)
            {
                return;
            }

            string basePath = Path.GetDirectoryName(path);
            string[] lines = File.ReadAllLines(path);
            bool inScope = false;
            sourceFilePath = path;
            List<string> currentData = new List<string>();
            foreach (string line in lines)
            {
                string trimmed = line.Trim();
                if (trimmed == "{")
                {
                    // ...
                    if (inScope)
                    {
                        // (!!!) NOPE
                        return;
                    }
                    else
                    {
                        inScope = true;
                    }
                }
                else if (trimmed == "}")
                {
                    if (inScope)
                    {
                        ICustomGlyphSource potential =
                            CustomGlyphSource.CreateFromDataLines(currentData.ToArray(), basePath);
                        if (potential != null)
                        {
                            AddOrUpdateOverride(potential.GetLetter(), potential);
                        }
                        inScope = false;
                        currentData.Clear();
                    }
                    else
                    {
                        // (!!!) NOPE, but just a thing for a warning really.
                    }
                }
                else if (!inScope)
                {
                    // try loading this one
                    bool library = false;
                    if(trimmed.ToLower().StartsWith("#:"))
                    {
                        library = true;
                        trimmed = trimmed.Remove(0, 2);
                    }
                    else if (trimmed.ToLower().StartsWith("library:"))
                    {
                        library = true;
                        trimmed = trimmed.Remove(0, "library:".Length);
                    }
                    else if (trimmed.ToLower().StartsWith("size:"))
                    {
                        trimmed = trimmed.Remove(0, "size:".Length);
                        fullSizeImages = trimmed == "fill";
                        continue;
                    }
                    string fullPath = Path.Combine(basePath, trimmed);
                    if (library)
                    {
                        if(fullPath.EndsWith(".glyphlibrary") == false)
                        {
                            fullPath += ".glyphlibrary";
                        }

                        if(File.Exists(fullPath))
                        {
                            // TODO: make this less destructive?
                            // load the library and merge it
                            CustomGlyphLibrary other = new CustomGlyphLibrary();
                            other.Load(fullPath);
                            referencedLibraries.Add(other);
                            /*foreach(ICustomGlyphSource source in other.overrideList)
                            {
                                AddOrUpdateOverride(source.GetLetter(), source);
                            }
                            */
                        }
                    }
                    else
                    {
                        ICustomGlyphSource potential = CustomGlyphSource.CreateFromFile(fullPath);
                        if (potential == null)
                        {
                            potential = CustomGlyphSource.CreateFromFile(fullPath + ".glyphoverride");
                        }

                        if (potential != null)
                        {
                            AddOrUpdateOverride(potential.GetLetter(), potential);
                        }
                    }
                }
                else
                {
                    currentData.Add(line);
                }
            }
        }

        private string MakeRelativePath(string sourcePath)
        {
            return Path.GetRelativePath(Path.GetDirectoryName(sourceFilePath), sourcePath);
        }

        public override void Save(string path)
        {
            string myData = "";
            string basePath = Path.GetDirectoryName(path);
            foreach(CustomGlyphLibrary library in referencedLibraries)
            {
                string filename = library.GetPath();
                if ((filename.Length > 1) && File.Exists(filename))
                {
                    string relativePath = MakeRelativePath(filename);
                    myData += "library:" + relativePath + "\n";
                }
                //else
                //{
                    /// well ths is a problem (!)
                    
                //}
            }

            foreach(ICustomGlyphSource glyphSource in overrideList)
            {
                string filename = glyphSource.GetSourcePath();
                if ((filename.Length > 1) && File.Exists(filename))
                {
                    string relativePath = MakeRelativePath(filename);
                    myData += relativePath + "\n";
                }
                else
                {
                    myData += "{\n";
                    string[] data = glyphSource.GetData(basePath);
                    myData += glyphSource.GetIdentifierString() + "\n";
                    foreach(string line in data)
                    {
                        myData += line + "\n";
                    }
                    myData += "}\n";
                }
            }

            File.WriteAllText(path, myData);
        }

        public override bool HasPath()
        {
            return sourceFilePath != "";
        }

        public override bool IsReadOnly()
        {
            return false;
        }

        public override string GetPath()
        {
            return sourceFilePath;
        }

        public override int GetOverrideCount()
        {
            return overrideList.Count;
        }

        public override ICustomGlyphSource GetOverride(int index)
        {
            return overrideList[index];
        }

        public override void RemoveOverride(string identifier)
        {
            Letter letter = Letters.LookupGardinerSign(identifier);
            if(letter == null)
            {
                return;
            }

            if(overrides.ContainsKey(letter) == false)
            {
                return;
            }
            ICustomGlyphSource source = overrides[letter];
            overrideList.Remove(source);
            overrides.Remove(letter);
        }

        public void AddOrUpdateOverride(Letter letter, ICustomGlyphSource glyphSource)
        {
            if(overrides.ContainsKey(letter))
            {
                overrideList.Remove(overrides[letter]);
                overrides[letter] = glyphSource;
            }
            else
            {
                overrides.Add(letter, glyphSource);
            }
            overrideList.Add(glyphSource);
        }

        public int GetTotalOverrideCount()
        {
            HashSet<Letter> letters = GetAllLettersOverriden();
            return letters.Count;
        }

        public virtual ICustomGlyphSource GetOverrideForLetter(Letter letter, out bool isSquare)
        {
            isSquare = true;
            if(overrides.ContainsKey(letter))
            {
                isSquare = fullSizeImages == false;
                return overrides[letter];
            }

            foreach(CustomGlyphLibrary reference in referencedLibraries)
            {
                ICustomGlyphSource source =  reference.GetOverrideForLetter(letter, out isSquare);
                if (source != null)
                {
                    //isSquare = reference.fullSizeImages;
                    return source;
                }
            }

            return null;
        }

        public int GetReferenceCount()
        {
            return referencedLibraries.Count;
        }

        public CustomGlyphLibrary GetReference(int index)
        {
            return referencedLibraries[index];
        }

        public virtual bool IsSquareImages()
        {
            return fullSizeImages == false;
        }

        // TODO: cache this.
        private HashSet<Letter> GetAllLettersOverriden()
        {
            HashSet<Letter> letters = new HashSet<Letter>();
            foreach (Letter letter in overrides.Keys)
            {
                letters.Add(letter);
            }
            foreach (CustomGlyphLibrary library in referencedLibraries)
            {
                HashSet<Letter> moreLetters = library.GetAllLettersOverriden();
                foreach (Letter newLetter in moreLetters)
                {
                    letters.Add(newLetter);
                }
            }
            return letters;
        }

        public static CustomGlyphLibrary CreateFromFile(string path)
        {
            CustomGlyphLibrary newLibrary = new CustomGlyphLibrary();
            newLibrary.Load(path);
            return newLibrary;
        }

        private string sourceFilePath = "";
        private Dictionary<Letter, ICustomGlyphSource> overrides = new Dictionary<Letter, ICustomGlyphSource>();
        private List<ICustomGlyphSource> overrideList = new List<ICustomGlyphSource>();
        private List<CustomGlyphLibrary> referencedLibraries = new List<CustomGlyphLibrary>();
        private bool fullSizeImages = false;
    }
}
