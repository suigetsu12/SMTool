title CarryforwardFileTransferProcessor
CD ..
call source_config.bat

CD %carryforwardFileTransferProcessorOutputUrl%
set ASPNETCORE_ENVIRONMENT=Local
set AzureWebJobsStorage=UseDevelopmentStorage=true
set AzureWebJobsDashboard=UseDevelopmentStorage=true

%azureFunctionToolPath% host start --port 7076
pause 
