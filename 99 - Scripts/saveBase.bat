@echo off
SetLocal EnableDelayedExpansion
cd C:\wamp64\bin\mysql\mysql5.7.31\data
MKDIR U:\59011-07-05\CDA\~BackupBDD~\Backup_Du_%DATE:~0,2%"-"%DATE:~3,2%"-"%DATE:~6,4%
for /d %%i in (*) do (
if /I %%i NEQ performance_schema if /I %%i NEQ mysql if /I %%i NEQ sys C:\wamp64\bin\mysql\mysql5.7.31\bin\mysqldump --user=root --databases %%i > U:\59011-07-05\CDA\~BackupBDD~\Backup_Du_%DATE:~0,2%"-"%DATE:~3,2%"-"%DATE:~6,4%\____%%i____%DATE:~0,2%"-"%DATE:~3,2%"-"%DATE:~6,4%.sql  
)
EndLocal