title FileIntegrityCheckProcessor
CD ..
call source_config.bat

CD %fileIntegrityCheckProcessorOutputUrl%
set ASPNETCORE_ENVIRONMENT=Local
set AzureWebJobsStorage=UseDevelopmentStorage=true
set AzureWebJobsDashboard=UseDevelopmentStorage=true

%azureFunctionToolPath% host start -c Local --port 7077 

pause 