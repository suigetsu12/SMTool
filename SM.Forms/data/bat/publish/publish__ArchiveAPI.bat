title publish__ArchiveAPI
CD ..
call source_config.bat

cd %archiveApiSourceUrl%
dotnet restore
dotnet publish -c Local -o %archiveApiOutputUrl%
pause
