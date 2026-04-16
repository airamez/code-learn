# Course Content

## Accessing the Content

* Version Control: Git and GitHub
  * Git
    * Git: A distributed version control system that tracks changes in files and coordinates work among multiple developers.
    * https://git-scm.com/
  * GitHub
    * A web-based platform for version control and collaboration that hosts Git repositories.
    * https://github.com/
  * Install git
    * https://github.com/git-guides/install-git
  * Repository
    * https://github.com/airamez/code-learn
  * Clone the repository
    ```bash
    git clone https://github.com/airamez/code-learn.git
    ```
  * Updating the content
    ```bash
    git pull
      ```
  >We will learn more about git in the future

### IDE - Integrated Development Environment / Code Editor
* An IDE is software that provides a relatively comprehensive set of features for software development.
  * https://en.wikipedia.org/wiki/Integrated_development_environment
* Online
    * https://app.coderpad.io/sandbox
    * https://vscode.dev/
* Visual Studio
    * https://visualstudio.microsoft.com/downloads/
    * Community (Free)
* Visual Studio Code
    * https://code.visualstudio.com/
    * (Free)
* IntelliJ
    * https://www.jetbrains.com/idea/
* Etc, there are multiple options
* How to setup a project with VSCODE
    1. Install [Visual Studio Code](https://code.visualstudio.com/)
    2. Install the **C# Dev Kit** extension: open VS Code → `Ctrl+Shift+X` → search for `C# Dev Kit` → click **Install**
    3. Install the [.NET SDK](https://dotnet.microsoft.com/download)
    4. Open a terminal
    5. Create a new console project: `dotnet new console -n YourProjectName -o YourProjectName`
    6. Navigate to the project folder:`cd YourProjectName`
    7. Open VS Code and Open the Project Folder
    8. The `Program.cs` is the entry point of the application
    9. Build the Application running: `dotnet build`
    10. Run the app with: `dotnet run` or using the Run Menu option (Run or Debug)
    >Attention: Show the generated files after the build and show how to execute it directly from the prompt

## Content

### Programming Fundamentals (C#)
  * Hello World
  * Comments
  * Variables
    * Declaration
    * Initialization
  * Basic Types
    * https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/built-in-types
    * byte
      * Unsigned whole numbers (0 to 255) without decimal points, e.g., file sizes, image data, network protocols.
      * Range: `0` to `255`.
    * short
      * Smaller whole numbers (positive or negative) without decimal points, e.g., small counts, file sizes, timestamps.
      * Range: `-32,768` to `32,767`.
    * int
      * Whole numbers (positive or negative) without decimal points, e.g., counts, indices, quantities.
      * Range: `-2,147,483,648` to `2,147,483,647`.
    * uint
      * Unsigned whole numbers (0 to 4,294,967,295) without decimal points, e.g., large counts, file sizes, network protocols.
      * Range: `0` to `4,294,967,295`.
    * long
      * Larger whole numbers (positive or negative) without decimal points, e.g., large counts, file sizes, timestamps.
      * Range: `-9,223,372,036,854,775,808` to `9,223,372,036,854,775,807`.
    * float
      * Single-precision floating-point numbers for approximate decimal values where memory is limited and precision is less critical, e.g., graphics, games.
      * Range: `±1.5 x 10⁻⁴⁵` to `±3.4 x 10³⁸`
      * Precision: ~6-9 digits
    * double
      * Double-precision floating-point numbers for scientific calculations requiring wider range but still approximate values, e.g., physics simulations.
      * Range: `±5.0 x 10⁻³²⁴` to `±1.7 x 10³⁰⁸`
      * Precision: ~15-17 digits
    * decimal
      * High-precision decimal values for financial/monetary calculations where exact precision is critical to avoid rounding errors.
      * Range: `±1.0 x 10⁻²⁸` to `±7.9 x 10²⁸`
      * Precision: 28-29 significant digits
    * string
      * Sequence of characters for text data, e.g., names, messages, file paths, user input.
    * char
      * Single Unicode character, e.g., menu options, flags, individual symbols, single letter grades.
    * bool
      * Logical true/false values, e.g., flags, conditions, states (on/off, yes/no, valid/invalid).
  * Conversions
  * Basic Operations
    * Input/Output
    * Arithmetic
    * Comparison
    * Logical
  * Commands
    * Conditional Statements
    * Loops
  * Intro do API
    * Math
    * Random
    * Char
    * String
    * Date
  * Array
  * Functions
  * Object Oriented Programming
  * Exceptions
  * .Net API
  * Date
  * Data Structures Intro
  * Collections

### Unit Testing

### Big O Notation

### GIT

### Leetcode

### Docker

### SQL

### Backend

### Frontend

### Software Architecture
