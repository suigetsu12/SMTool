title publish_ContentProcessor
CD ..
call source_config.bat
@echo on
@echo Publishing ContentProcessor project....


@echo Publishing contentProcessorOutputUrl...

CD %contentProcessorSourceUrl%
dotnet restore
dotnet publish -c Local -o %contentProcessorOutputUrl%  
@echo Publish successfully
@echo -----------------------------------------------

pause
