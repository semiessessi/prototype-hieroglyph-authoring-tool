using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP1
{
    static class Program
    {
        public static string Name = "PP1";
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainWindow = new MainWindow();
            Application.Run(mainWindow);
        }

        public static Project GetProject() { return currentProject; }
        public static string GetProjectPath() { return lastProjectPath; }

        public static void NewProject() { currentProject = new Project(); lastProjectPath = ""; }
        public static void SaveProject()
        {
            if (lastProjectPath != "")
            {
                currentProject.WriteToFile(lastProjectPath);
            }
            else
            {
                SaveProjectAs();
            }
        }

        public static void SaveProjectAs()
        {
            // erm. tell main window to do a thing? :I
            MainWindow.SaveProjectAs();
        }

        public static void CloseProject()
        {
            UpdateProjectPath("");
            currentProject = null;
        }

        public static void UpdateProjectPath(string newPath)
        {
            lastProjectPath = newPath;
        }

        public static bool OpenProject(string path)
        {
            Project newProject = Project.LoadFromFile(path);
            bool success = newProject != null;
            if (success)
            {
                lastProjectPath = path;
                currentProject = newProject;

                mainWindow.AddMostRecentProjectFile(lastProjectPath);
                mainWindow.UpdateRecentFileLists();
            }

            return success;
        }

        private static Project currentProject = null;
        private static string lastProjectPath = "";
        private static MainWindow mainWindow = null;
    }
}
