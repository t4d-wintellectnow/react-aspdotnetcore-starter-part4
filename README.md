# Starter Files for Part 4 of the React 16 + ASP.NET Core 2.2 WintellectNOW Video Course

This project is intended for use with the [WintellectNOW](https://www.wintellectnow.com/) videos on [React 16](https://reactjs.org/) + [ASP.NET Core 2.2](https://docs.microsoft.com/en-us/aspnet/core/?view=aspnetcore-2.2). This project was completed in part 3 of the video course series. This project is for those starting with part 4 and would like to start where part 3 left off.

## Links to the Video Courses

- [React 16 + ASP.NET Core 2.2: Building a Single Page Application - Part 1](#)
- [React 16 + ASP.NET Core 2.2: Integrating React and ASP.NET Core - Part 2](#)
- [React 16 + ASP.NET Core 2.2: Entity Framework Core - Part 3](#)
- [React 16 + ASP.NET Core 2.2: Components and Data - Part 4](#)
- [React 16 + ASP.NET Core 2.2: Advanced Component Techniques - Part 5](#)

## Getting the Project

1. Install [Node.js version 10.16](https://nodejs.org/dist/v10.16.0/) and [.NET Core SDK version 2.2.3](https://dotnet.microsoft.com/download/dotnet-core/2.2) for your computer. Also, install [Visual Studio Code](https://code.visualstudio.com/) on your computer. All three installs are supported on Windows, MacOS and popular Linux distros.

2. Either clone the project or download the source zip. To clone the project [Git](https://git-scm.com/downloads) will need to be installed on your machine. If you download the source zip, you will need to unzip the source with the appropriate program on your computer. If you do not have an unzipping program, click here to download [7-Zip](https://www.7-zip.org) for Windows and Linux or [Keka](https://www.keka.io) for MacOS.

3. After you unzip you will need to restore the dependencies for both the React project and the ASP.NET Core project. Replace the folder name `WidgetsAppStarter` below with the path of the folder which contains the ASP.NET Core project. The folder which contains the ASP.NET Core project has the file `WidgetsApp.csproj` located within it. 

```
cd WidgetsAppStarter

dotnet restore

cd ClientApp

npm install
```

3. With Visual Studio Code, open the folder which contains the ASP.NET Core project.

4. Open the Extensions sidebar window in VSCode using the menu bar (`View` -> `Extensions`). Search for and install the following extensions:

    - C# (ms-vscode.csharp) - supports C# coding (including debugging) in VSCode
    - Debugger for Chrome (msjsdiag.debugger-for-chrome) - supports JavaScript code debugging in VSCode
    - ESLint (dbaeumer.vscode-eslint) - provides linting of JavaScript code in VSCode
    - NuGet Package Manager (jmrog.vscode-nuget-package-manager) - allows NuGet packages to be managed within VSCode
    - SQLite (alexcvzz.vscode-sqlite) - allows querying of SQLite databases within VSCode
    - REST Client (humao.rest-client) - allows the execution of REST service calls from within VSCode

5. Using the menu bar (`View` -> `Terminal`), open the Terminal window (usually appears at the bottom).

6. To start the React Client, change into the `ClientApp` folder and start the React application.

```
cd ClientApp

npm start
```

7. Open a new Terminal window. Start the ASP.NET Core server application.

```
dotnet start
```

1. To learn more about creating and debugging both applications, please watch part 1 of the video course. To learn more about connecting the ASP.NET Core app to the React app as well as how to install NuGet Packages, please watch part 2 of the video course. To learn more about Entity Framework Core, then connecting the React client to the ASP.NET Core REST API, please watch part 3