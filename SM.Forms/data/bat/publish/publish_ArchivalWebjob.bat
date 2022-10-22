title publish__ArchiveWebjob 
CD ..
call source_config.bat

@echo Publishing ArchiveWebjob ...
cd %archiveSourceUrl%
dotnet restore
dotnet publish -c Local -o %archiveOutputUrl%  
@echo Publish successfully
@echo -----------------------------------------------

pause
