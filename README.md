# ProductCategoryAPP
 Requirements

    .NET 8 SDK or later

    SQL Server or LocalDB

    Visual Studio Code or Visual Studio

    Git




# 1. Clone the project
git clone https://github.com/aya22-creat/ProductCategoryApp.git
cd ProductCategoryApp/ProductCategoryApp.API

# 2. Restore packages
dotnet restore

# 3️ (Optional) Install EF Core tools if not already installed
dotnet tool install --global dotnet-ef

# 4. Create the database and apply migrations
dotnet ef database update --project ../ProductCategoryApp.Infrastructure --startup-project ./

# 5. Run the project
dotnet run


