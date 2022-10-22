title ArchivalWebjob
CD ..
call source_config.bat

CD %archiveOutputUrl%
set ASPNETCORE_ENVIRONMENT=Local
dotnet Auvenir.Archiving.WebJob.dll

pause