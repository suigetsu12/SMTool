title AuvenirDuplicateEngCommon
CD ..
call source_config.bat

CD %AuvenirDuplicateEngCommonOutputUrl%
set ASPNETCORE_ENVIRONMENT=Local
set AzureWebJobsStorage=UseDevelopmentStorage=true
set AzureWebJobsDashboard=UseDevelopmentStorage=true

%azureFunctionToolPath% host start --port 7085 -c Local
pause 
