title CarryforwardProcessor
CD ..
call source_config.bat

CD %carryforwardProcessorOutputUrl%
set ASPNETCORE_ENVIRONMENT=Local
set AzureWebJobsStorage=UseDevelopmentStorage=true
set AzureWebJobsDashboard=UseDevelopmentStorage=true

%azureFunctionToolPath% host start --port 7072 
pause 
