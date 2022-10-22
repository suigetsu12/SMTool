title CommonToolService
CD ..
call source_config.bat

CD %pm_snOutputUrl%
set ASPNETCORE_ENVIRONMENT=Local
dotnet Auvenir.CommonToolService.dll --server.urls=http://cacaudcommontools.auvnpd02.ase.dmchosting.ca:200

pause