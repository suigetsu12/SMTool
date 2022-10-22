title IntegrationHubService

CD ..
call source_config.bat

CD %integrationHubOutputUrl%
set ASPNETCORE_ENVIRONMENT=Local
dotnet Auvenir.IntegrationHubService.dll run --urls "http://cacaudintegrationhubapi.auvnpd02.ase.dmchosting.ca:555"

pause