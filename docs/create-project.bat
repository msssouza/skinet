dotnet new sln
mkdir src
mkdir docs
mkdir tests

cd src/
dotnet new webapi -o API -controllers
dotnet new classlib -o Core
dotnet new classlib -o Infrastructure

cd API/
API$ dotnet add reference ../Infrastructure/

API$ cd ../Infrastructure/
dotnet add reference ../Core/
cd ..
cd ..

dotnet sln add src/API/
dotnet sln add src/Infrastructure/
dotnet sln add src/Core/

code .