using Microsoft.VisualStudio.TemplateWizard;
using EnvDTE;
using EnvDTE80;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

// http://www.develop.com/multiprojectvisualstudiotemplate
// http://sharp-architecture.googlecode.com/svn/trunk/src/SharpArch/SharpArch.VsSharpArchTemplate/WizardImplementation.cs
namespace MvxPluginTemplateWizard
{
    public class RootWizard : IWizard
    {
        // Use to communicate $saferootprojectname$ to other Wizards     
        public static Dictionary<string, string> GlobalDictionary =
            new Dictionary<string,string>();

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
            GlobalDictionary.Clear();
        }

        // Add global replacement parameters     
        public void RunStarted(object automationObject,
            Dictionary<string, string> replacementsDictionary,
            WizardRunKind runKind, object[] customParams)
        {
            _dte2 = automationObject as DTE2;
            _runKind = runKind;
            _replacementsDictionary = replacementsDictionary;

            if (runKind == WizardRunKind.AsMultiProject)    // should be
            {
                // Place "$saferootprojectname$ in the global dictionary.         
                // Copy from $safeprojectname$ passed in my root vstemplate         
                GlobalDictionary["$saferootprojectname$"] = replacementsDictionary["$safeprojectname$"];
                
                var solutionPath = _dte2.Solution.Properties.Item("Path").Value.ToString();
                var solutionFi = new FileInfo(solutionPath);
                GlobalDictionary["$solutionpath$"] = solutionPath;
                GlobalDictionary["$solutionrootpath$"] = solutionFi.Directory.FullName;
                GlobalDictionary["$solutionname$"] = solutionFi.Name;
            }
        }

        // This method is only called for item templates,
        // not for project templates.
        public bool ShouldAddProjectItem(string filePath)
        {
            return true;
        }
    }
}
