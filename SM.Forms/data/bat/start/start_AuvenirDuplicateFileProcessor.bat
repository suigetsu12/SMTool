title AuvenirDuplicateFileProcessor
CD ..
call source_config.bat

CD %AuvenirDuplicateFileProcessorOutputUrl%
set ASPNETCORE_ENVIRONMENT=Local
set AzureWebJobsStorage=UseDevelopmentStorage=true
set AzureWebJobsDashboard=UseDevelopmentStorage=true

%azureFunctionToolPath% host start --port 7083 -c Local
pause 
