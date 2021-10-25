U:
cd 59011-07-05
cd CDA
git add . 
git commit -m "%date% %time%"
git pull
git push

@echo off
call :attente 5       
exit

:attente
call :calcultemps
set /a t1= %j1% + %h1% + %m1% + %s1% + %1
:boucleattente
call :calcultemps
set /a t2= %j1% + %h1% + %m1% + %s1%
if "%t2%" LSS "%t1%" goto boucleattente
goto :eof
:calcultemps
set /a jj="100%DATE:~0,2% %% 100"
set /a mm="100%DATE:~3,2% %% 100"
set /a aa=%DATE:~6,4%

set /a j1="(((1461 * (%aa% + 4800 + (%mm% - 14) / 12)) / 4 + (367 * (%mm% - 2 - 12 * ((%mm% - 14) / 12))) / 12 - (3 * ((%aa% + 4900 + (%mm% - 14) / 12) / 100)) / 4 + %jj% - 32075) - 2455021) * 86400 "

set /a h1= %time:~0,2% * 3600
set /a m1= %time:~3,2% * 60
set s1=%time:~6,2%
