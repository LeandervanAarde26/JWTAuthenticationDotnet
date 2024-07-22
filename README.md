
# ASP.NET COre (.NET 8) Authentication with MS Identity. 


An application leveraging C# `dotnet` to provide Authentication and Authorization to a application. 

### Overview
The application is a C# project, reliant on version 8 of the [Microsoft dotnet](https://dotnet.microsoft.com/) framework and makes use of [Nuget](https://www.nuget.org/) for package management.

## Getting Started
#### Tools
The following tools are further **required** for effectively running this project on your local machine:
1. [Dotnet](https://dotnet.microsoft.com/)
   2. The dotnet CLI and SDK are recommended
2. [Postgres](https://www.postgresql.org/)

##### **Text Editor/ IDE**
In order to compile this project solution, it is *recommended* that you use one of the below IDE's/Text editors or editor of your choosing:
- [Visual studio](https://visualstudio.microsoft.com/)
   - Please note that visual studio will no longer be supported on Mac as of August 2024
   - [Visual Studio on Mac](https://visualstudiomagazine.com/articles/2023/08/30/vs-for-mac-retirement.aspx)
- [Rider](https://www.jetbrains.com/rider/)
- [Visual Studio Code](https://code.visualstudio.com/)
   - Please not that dotnet is not supported "out of the box" with visual studio code and will require additional setup
   - [Setting up dotnet in VSCode](https://code.visualstudio.com/docs/languages/dotnet)

### Local Setup
1. Clone the Repository:
   1. Run the following in the command-line to clone the project:
   ```sh
   git clone https://github.com/LeandervanAarde/JWTAuthenticationDotnet.git
   ```
   Open `Software` and select `File | Open...` from the menu. Select cloned directory and press `Open` button
   2. This can also be achieved through Github and Github Desktop : [See Here](https://docs.github.com/en/repositories/creating-and-managing-repositories/cloning-a-repository)

2. Navigate to the project via a terminal of your choice:
   ```shell
   cd <your/path/to/project/JWTAuthenticationDotnet> 
   ```
3. Restore the project locally
   ```shell
   dotnet restore 
   ```
4. Ensure your local Postgres is running and you have a database initialised:
   1. You can use a Db GUI for this such as 
      1. [DataGrip](https://www.jetbrains.com/datagrip/)
      2. [PGAdmin](https://www.pgadmin.org/)
      3. [TablePlus](https://tableplus.com/)
5. Setup [UserSecrets](https://developers.redhat.com/articles/2024/01/11/connect-dotnet-app-external-postgresql-database)

5. Run the Migrations locally: 
   ```shell
      dotnet ef database update
   ```
6. Run the solution and Add data in order to complete CRUD Operations.

## Contributing
For any additions to the project, contact the repo owner [LeandervanAarde](mailto:Leander.vaonline@gmail.com)

### Pull Requests
All changes made to the project are **REQUIRED** to go through a Pull request that needs to be reviewed and signed off on by at least one member.
The title of Pull requests should follow the following convention `What was done: Short description` eg. </br>
`Refactor: Some amazing description`

The content of this Pull requests is a chance for you to explain in detail what has changed in the codebase, this is not only for yourself, but for who-ever is reviewing the pull request.
This allows members who are not familiar with the codebase to gain context and effectively review your PR.
The content should include a description, references (to the ticket or design specs or similar), examples (including, but not limited to screenshots of the completed features or sections) and any other information

Please engage in your pull requests and assess those that belong to others. A good reference for how to do this is https://hugooodias.medium.com/the-anatomy-of-a-perfect-pull-request-567382bb6067.

## Deployments

## License
Distributed under the MIT License. See `LICENSE` for more information.
### Authors:
* **Leander van Aarde** - [Leander.vaonline@gmail.com](mailto:Leander.vaonline@gmail.com) || [Github](https://github.com/LeandervanAarde26)

* **Project Link** - https://github.com/LeandervanAarde26/JWTAuthenticationDotnet

## Acknowledgements
- Dotnet: [Microsoft](https://learn.microsoft.com/en-us/aspnet/core/?view=aspnetcore-8.0&WT.mc_id=dotnet-35129-website)
- Dotnet 8 Authentication and Authorization [Microsoft](https://devblogs.microsoft.com/dotnet/whats-new-with-identity-in-dotnet-8/) || [Milan Jovanovic](https://www.youtube.com/watch?v=S0RSsHKiD6Y)

## Additional information
- Database default ERD when including Identity:
- ![ERD](JWTAuthenticationDotnet/images/ERD.png?raw=true "ERD")
- Default routes added when including Identity:




