title FE
CD ..
call source_config.bat

CD %feSourceUrl%
set ASPNETCORE_ENVIRONMENT=Local
call npm i
dotnet run -c local --urls "https://devca.auvenir.com/"
pause