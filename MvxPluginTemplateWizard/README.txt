3/5/2014 TU
May need to add zip file in Visual Studio 2013 if you switch to VS2013.
To create, create a new folder under plugins, e.g., Encryption, right-click create new project
For the location, make sure it has the Plugins folder, the "Encryption" folder will be created

12/18/2013 TU
In order to use the template:
1. Build MvxPluginTemplateWizard - the wizard goes to C:\Temp\
2. Go to C:\Temp from an administrator-level command window
3. gacutil -i MvxPluginTemplateWizard.dll
4. In the templates directory, zip up everything as MvPluginTemplate.zip
Hint: Highlight everything then right-click on MvxPluginTemplate
5. Put the zip file in
\\vmware-host\Shared Folders\Documents\Visual Studio 2012\Templates\ProjectTemplates\CSharp\MvvmCross

You may need the signing key.


C:\Temp>gacutil /l MvxPluginTemplateWizard
Microsoft (R) .NET Global Assembly Cache Utility.  Version 4.0.30319.17929
Copyright (c) Microsoft Corporation.  All rights reserved.

The Global Assembly Cache contains the following assemblies:
  MvxPluginTemplateWizard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=a1d6
6120136bd321, processorArchitecture=MSIL

Number of items = 1


--
http://msdn.microsoft.com/en-us/library/zdc263t0(VS.80).aspx

To get the Shared File references to work out, each vstemplate must have CreateInPlace set to true
If you have the Project in a network share, it will trigger a warning for each project unless
you can trust the network share.

TODO: Add MVX to build so that it is easier to do what we did with the files
