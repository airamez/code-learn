# Accessing the Course Content

* Git/GitHub
  * Intro
  * Repository: https://github.com/airamez/code-learn
* Clone with git
  * [Install git](https://github.com/git-guides/install-git)
  * `git clone https://github.com/airamez/code-learn.git`
* Updating the content
  * `git pull`
* We will learn more about git in the future

# IDE - Integrated Development Environment / Code Editor

* Online
    * https://app.coderpad.io/sandbox
    * https://vscode.dev/
* [Visual Studio](https://visualstudio.microsoft.com/downloads/)
    * Community (Free)
* [Visual Studio Code](https://code.visualstudio.com/) (Free)
* [IntelliJ](https://www.jetbrains.com/idea/)
* etc.
* How to setup a project with VSCODE
    1. Install [Visual Studio Code](https://code.visualstudio.com/)
    2. Install the **C# Dev Kit** extension: open VS Code → `Ctrl+Shift+X` → search for `C# Dev Kit` → click **Install**
    3. Install the [.NET SDK](https://dotnet.microsoft.com/download) (version 10 or later)
    4. Open a terminal in VS Code (`Ctrl + `` ` ``)
    5. Run `dotnet new console -n YourProjectName -o YourProjectName` to create a new console project
    6. Run `cd YourProjectName` to navigate into the project folder
    7. Open the project: `code .`
    8. Open `Program.cs` and start coding
    9. Run the app with `dotnet run` in the terminal