title ComponentCreationProcessor
CD ..
call source_config.bat

CD %ComponentCreationProcessorOutputUrl%

set ASPNETCORE_ENVIRONMENT=Local
set AzureWebJobsStorage=UseDevelopmentStorage=true
set AzureWebJobsDashboard=UseDevelopmentStorage=true

%azureFunctionToolPath% host start  --port 7084 -c Local
pause 