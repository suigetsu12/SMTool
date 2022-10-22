title publish__SPOAPI
CD ..
call source_config.bat
@echo on
@echo Publishing SPOAPI...
cd %spoApiSourceUrl%
dotnet restore
dotnet publish -c Local -o %spoApiOutputUrl%   /property:langversion=latest
pause

