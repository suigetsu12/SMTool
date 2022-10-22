title AccountWorkingPaperService
CD ..
call source_config.bat

CD %wpOutputUrl%
set ASPNETCORE_ENVIRONMENT=Local
dotnet Auvenir.WorkingPaper.dll --server.urls=http://cacaudaccountwp.auvnpd02.ase.dmchosting.ca:800

pause