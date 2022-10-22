title FE
CD ..
call source_config.bat

CD %feOutputUrl%
set ASPNETCORE_ENVIRONMENT=Local
dotnet AuvenirNetCore.dll --server.urls=https://devca.auvenir.com/

pause