title AuvenirDuplicateEngProcessor
CD ..
call source_config.bat

CD %AuvenirDuplicateEngProcessorOutputUrl%
set ASPNETCORE_ENVIRONMENT=Local
set AzureWebJobsStorage=UseDevelopmentStorage=true
set AzureWebJobsDashboard=UseDevelopmentStorage=true

%azureFunctionToolPath% host start --port 8086 -c Local
pause 
