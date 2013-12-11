using Microsoft.VisualStudio.TemplateWizard;
using EnvDTE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// http://www.develop.com/multiprojectvisualstudiotemplate
namespace MvxPluginTemplateWizard
{
    public class RootWizard : IWizard
    {
        // Use to communicate $saferootprojectname$ to ChildWizard     
        public static Dictionary<string, string> GlobalDictionary =
            new Dictionary<string,string>();

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
        }

        // Add global replacement parameters     
        public void RunStarted(object automationObject,
            Dictionary<string, string> replacementsDictionary,
            WizardRunKind runKind, object[] customParams)
        {
            // Place "$saferootprojectname$ in the global dictionary.         
            // Copy from $safeprojectname$ passed in my root vstemplate         
            GlobalDictionary["$saferootprojectname$"] = replacementsDictionary["$safeprojectname$"];
        }

        // This method is only called for item templates,
        // not for project templates.
        public bool ShouldAddProjectItem(string filePath)
        {
            return true;
        }    
    }
}
