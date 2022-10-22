title publish_AuvenirIntegrationHubProcessor 
CD ..
call source_config.bat

@echo Publishing AuvenirIntegrationHubProcessor ...
CD %AuvenirIntegrationHubProcessorUrl%
dotnet restore
dotnet publish -c Local -o %AuvenirIntegrationHubProcessorOutputUrl%  
@echo Publish successfully---------------------------------------


pause
