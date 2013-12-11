using Microsoft.VisualStudio.TemplateWizard;
using EnvDTE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnvDTE80;
using System.IO;

namespace MvxPluginTemplateWizard
{
    public class ChildWizard : IWizard
    {
        private DTE2 _dte2;
        private WizardRunKind _runKind;
        private Dictionary<string, string> _replacementsDictionary;

        // This method is called before opening any item that 
        // has the OpenInEditor attribute.
        public void BeforeOpeningFile(ProjectItem projectItem)
        {
        }

        public void ProjectFinishedGenerating(Project project)
        {
            if (project.Name == RootWizard.GlobalDictionary["$saferootprojectname$"])
            {
                // move nuspec to Solution root
                var projectPath = project.FullName;
                var projectFi = new FileInfo(projectPath);
                var nuspecPath = Path.Combine(projectFi.Directory.FullName, "nuspec");
                var targetPath = Path.Combine(RootWizard.GlobalDictionary["$solutionrootpath$"], "nuspec");                
                MoveDirectory(nuspecPath, targetPath);
            }
        }

        public static void MoveDirectory(string source, string target)
        {
            var stack = new Stack<Folders>();
            stack.Push(new Folders(source, target));

            while (stack.Count > 0)
            {
                var folders = stack.Pop();
                Directory.CreateDirectory(folders.Target);
                foreach (var file in Directory.GetFiles(folders.Source, "*.*"))
                {
                    string targetFile = Path.Combine(folders.Target, Path.GetFileName(file));
                    if (File.Exists(targetFile)) File.Delete(targetFile);
                    File.Move(file, targetFile);
                }

                foreach (var folder in Directory.GetDirectories(folders.Source))
                {
                    stack.Push(new Folders(folder, Path.Combine(folders.Target, Path.GetFileName(folder))));
                }
            }
            Directory.Delete(source, true);
        }

        public class Folders
        {
            public string Source { get; private set; }
            public string Target { get; private set; }

            public Folders(string source, string target)
            {
                Source = source;
                Target = target;
            }
        }

        // This method is only called for item templates,
        // not for project templates.
        public void ProjectItemFinishedGenerating(ProjectItem
            projectItem)
        {
        }

        // This method is called after the project is created.
        public void RunFinished()
        {            
        }

        // Retrieve global replacement parameters     
        public void RunStarted(object automationObject, 
            Dictionary<string, string> replacementsDictionary, 
            WizardRunKind runKind, object[] customParams)
        {
            _dte2 = automationObject as DTE2;
            _runKind = runKind;
            _replacementsDictionary = replacementsDictionary;

            // Add custom parameters.         
            replacementsDictionary.Add("$saferootprojectname$",
                RootWizard.GlobalDictionary["$saferootprojectname$"]);
        }

        // This method is only called for item templates,
        // not for project templates.
        public bool ShouldAddProjectItem(string filePath)
        {
            return true;
        }

    }
}
