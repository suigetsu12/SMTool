Title Backup_DB
call config_main.bat
SET INPUT="script_backup.sql"

ECHO 
%SQLCMD% -S %SERVER% -d %DB% -U %LOGIN% -P %PASSWORD% -v path ="N'%PATH%\'" -i %INPUT%

call config_cf.bat
SET INPUT="script_backup_cf.sql"

ECHO 
%SQLCMD% -S %SERVER% -d %DB% -U %LOGIN% -P %PASSWORD% -v path ="N'%PATH%\'" -i %INPUT%

@pause
exit

