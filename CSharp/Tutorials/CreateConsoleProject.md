# How to create console project in Visual Studio 2022

1.Launch Visual Studio 2022 and select "Create new project"

![VSNewProjectWindow](Media/CreateConsoleProject/VSNewProjectWindow.png)

2.Type `Console App` in the search box, select `Console App` template and click `Next` button on the right bottom corner of the window.

![VSNewProjectWindow](Media/CreateConsoleProject/VSSelectConsoleProjectTemplate.png)

3.Select `Playground/Exercises` folder and specify project name (without spaces) and click `Next` button on the right bottom corner of the window.

![VSCreateConsoleProject](Media/CreateConsoleProject/VSCreateConsoleProject.png)

4.Specify the most recent .NET version, today it is .NET 7.0, and enable `Do not use top-level statements`, then click `Create` button.

![VSConsoleProjectSettings](Media/CreateConsoleProject/VSConsoleProjectSettings.png)

5.Launch `File Explorer` and navigate to `playground/CSharp/Template files`, and copy all files from that folder to the solution folder of the project you've just created.

![ProjectTemplateFiles](Media/CreateConsoleProject/CopyingTemplateFiles.png)

Copied files looks like that:

![CopiedProjectTemplateFiles](Media/CreateConsoleProject/TemplateFilesAreCopied.png)

`ForceClean.bat` created to do Visual Studio Build-Clean job, but does it better.

6.Open `Git Bash` window in the just created solution folder.

![OpenGitBashWindow](Media/CreateConsoleProject/OpenGitBashWindow.png)

7.Create new branch with the same name as your task id in JIRA:

![CreateNewBranch](Media/CreateConsoleProject/CreatingNewBranch.png)

8.Return to Visual Studio and start writing code, when it is done, commit changes to the current branch and make pull request to master in [https://github.com/cdefgah/playground](https://github.com/cdefgah/playground)
