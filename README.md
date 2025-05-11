# RepositoryPatternTemplate

# Project Name
RepositoryPatternTemplate

A short description of your project.
C# Repository Pattern template since I keep repeating this code

## Features

- The DAL stands for Data Access Layer, you can implement Repository pattern with this template.
- This will provide interfaces and implementation for Repository class, and UnitofWork class.
- Will also include Global Variable class for Constants or any globals needed.
- Include all the EntityFramewokrk packages pre-installed, just need to apply to Models project, once created.
  
## Getting Started

# Clone the repo
git clone [https://github.com/yourusername/yourproject.git]
(https://github.com/kcq218/RepositoryPatternTemplate.git)

# Install dependencies
Install the packages below with latest stable version. Preferably with long term support.
Microsoft.EntityFrameworkCore" 
Microsoft.EntityFrameworkCore.Relational"
Microsoft.EntityFrameworkCore.SqlServer" 
Microsoft.EntityFrameworkCore.Tools" 

# Start the project
Navigate to Nuget Package Manager Console and enter in the below to populate the models the Repository Pattern will follow.
- dotnet ef dbcontext scaffold "Server=[connstring];User ID=[userId];Password=[password];MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30" Microsoft.EntityFrameworkCore.SqlServer --project="[projectName]" --force
- The project output above is optional if you want to put your models in a specific project.
- Start setting up Repository pattern with your new DbContext and Repository tables.
