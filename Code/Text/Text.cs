using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace PP1
{
    public class Text
    {
        public class LayoutStateFinal : LayoutState { }
        public enum Layout
        {
            PreviewWordLines,
            VerticalLeftToRight,
            VerticalRightToLeft,
            LeftToRight,
            RightToLeft,
            Mirrored,
            Transliteration,
            Interlinear
        }

        public static void ResetSections()
        {
            sections.Clear();
        }

        public static Text CreateFromFile(string filename, string basePath = "")
        {
            if(File.Exists(filename) == false)
            {
                return null;
            }

            return CreateFromData(File.ReadAllLines(filename), basePath);
        }

        public static Text CreateFromData(IList<string> data, string basePath = "")
        {
            Text text = new Text();
            text.Load(data, basePath);
            return text;
        }

        public string GetSourceString()
        {
            return sourceData;
        }

        public void UpdateSourceString(string newData)
        {
            sourceData = newData;

            // TODO: remove sections that are now missing???
            LoadSections(sourceData.Split('\n'));
        }

        public static IList<Word> GetSectionByName(string name)
        {
            if(sections.ContainsKey(name))
            {
                return sections[name];
            }

            return null;
        }

        public static IReadOnlyCollection<List<Word>> GetAllSections()
        {
            return sections.Values;
        }

        public IList<string> GetSectionNames()
        {
            return ownSections.Keys.ToList();
        }

        public IReadOnlyCollection<List<Word>> GetSections()
        {
            return ownSections.Values;
        }

        public void UpdatePreviewLayout(int selectedIndex, float zoom = 1.0f)
        {
            previewZoom = zoom;
            switch(selectedIndex)
            {
                default:
                case 0:
                {
                    previewLayoutType = Layout.PreviewWordLines;
                    break;
                }
                case 1:
                {
                    previewLayoutType = Layout.VerticalLeftToRight;
                    break;
                }
                case 2:
                {
                    previewLayoutType = Layout.VerticalRightToLeft;
                    break;
                }
                case 3:
                {
                    previewLayoutType = Layout.LeftToRight;
                    break;
                }
                case 4:
                {
                    previewLayoutType = Layout.RightToLeft;
                    break;
                }
                case 5:
                {
                    previewLayoutType = Layout.Mirrored;
                    break;
                }
                case 6:
                {
                    previewLayoutType = Layout.Transliteration;
                    break;
                }
                case 7:
                {
                    previewLayoutType = Layout.Interlinear;
                    break;
                }
            }
        }

        private void Load(IList<string> data, string basePath = "")
        {
            foreach (string line in data)
            {
                sourceData += line + "\n";
            }

            LoadSections(data);
        }

        private void LoadSections(IList<string> data)
        {
            List<Word> lastSection = null;
            ownSections.Clear(); // TODO: use this to keep track of removed ones?
            bool inWordList = false;
            foreach (string line in data)
            {
                string clean = line.Trim();
                if(clean == "")
                {
                    continue;
                }

                if (clean.StartsWith("{"))
                {
                    inWordList = true;
                    continue;
                }
                else if (clean.StartsWith("}"))
                {
                    inWordList = false;
                    continue;
                }
                else if (inWordList)
                {
                    if (lastSection != null)
                    {
                        string[] split = clean.Split('\\');
                        Word newWord = Word.FromMdC(split[0].Trim());
                        lastSection.Add(newWord);
                        for(int i = 1; i < split.Length; ++i)
                        {
                            string test = split[i].Trim();
                            if(test.StartsWith("(")) // translation
                            {
                                // TODO: ...
                            }
                            else // transliteration
                            {
                                newWord.OverrideTransliterationString(test);
                            }
                        }
                    }
                }
                else
                {
                    lastSection = new List<Word>();
                    if (sections.ContainsKey(clean))
                    {
                        sections[clean] = lastSection;
                    }
                    else
                    {
                        sections.Add(clean, lastSection);
                    }

                    if(ownSections.ContainsKey(clean))
                    {
                        ownSections[clean] = lastSection;
                    }
                    else
                    {
                        ownSections.Add(clean, lastSection);
                    }
                }
            }
        }

        public void DrawPreview(Graphics g, int x, int y, int width, int height, GlyphLibrary overrideLibrary = null)
        {
            LayoutState state = new LayoutStateFinal();
            int fontSize = (int)(80 * previewZoom);
            state.ResetFont(HieroglyphicWordImage.GetBaseFont(), fontSize);
            state.ResetLayoutType(previewLayoutType);
            state.ResetPositonAndSize(x, y, width, height);
            foreach (List<Word> wordList in ownSections.Values)
            {
                DrawSectionInternal(g, wordList, state, fontSize, overrideLibrary);

                state.StartNewLine();
            }
        }

        public void DrawSectionPreview(Graphics g, string sectionName, int x, int y, int width, int height, GlyphLibrary overrideLibrary = null)
        {
            if (sections.ContainsKey(sectionName) == false)
            {
                return;
            }

            LayoutState state = new LayoutStateFinal();
            int fontSize = (int)(80 * previewZoom);
            state.ResetFont(HieroglyphicWordImage.GetBaseFont(), fontSize);
            state.ResetLayoutType(previewLayoutType);
            state.ResetPositonAndSize(x, y, width, height);
            DrawSectionInternal(g, sections[sectionName], state, fontSize, overrideLibrary);
        }

        public static void DrawSectionByName(
            Graphics g, string sectionName,
            Layout layoutType,
            int x, int y, int width, int height,
            GlyphLibrary overrideLibrary = null)
        {
            if (sections.ContainsKey(sectionName) == false)
            {
                return;
            }

            LayoutState state = new LayoutStateFinal();
            // TODO: work out font size (!!!)
            int fontSize = (int)(64);
            state.ResetFont(HieroglyphicWordImage.GetBaseFont(), fontSize);
            state.ResetLayoutType(layoutType);
            state.ResetPositonAndSize(x, y, width, height);
            DrawSectionInternal(g, sections[sectionName], state, fontSize, overrideLibrary);
        }

        private static void DrawSectionInternal(Graphics g, List<Word> sectionWords, LayoutState state, int fontSize, GlyphLibrary overrideLibrary = null)
        {
            foreach (Word word in sectionWords)
            {
                HieroglyphicWordImage.DrawWord(g, state, word, fontSize, overrideLibrary);
                state.ResetForNewWord();
            }
        }

        private string sourceData = "";
        private Layout previewLayoutType = Layout.PreviewWordLines;
        private float previewZoom = 1.0f;
        private Dictionary<string, List<Word>> ownSections = new Dictionary<string, List<Word>>();
        private static Dictionary<string, List<Word>> sections = new Dictionary<string, List<Word>>();
    }
}
