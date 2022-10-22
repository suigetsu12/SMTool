title SPOSetupProcessor
CD ..
call source_config.bat

CD %spo_SPOSetupProcessorOutputUrl%
set ASPNETCORE_ENVIRONMENT=Local
run.cmd
pause 