# ProductCategoryAPP
 Requirements

    .NET 8 SDK or later

    SQL Server or LocalDB

    Visual Studio Code or Visual Studio

    Git




# 1. Clone the project
git clone https://github.com/username/ProductCategoryApp.git
cd ProductCategoryApp/ProductCategoryApp.API

# 2. Restore packages
dotnet restore

# 3. Create the database and apply migrations
dotnet ef database update --project ../ProductCategoryApp.Infrastructure --startup-project ./

# 4. Run the project
dotnet run
