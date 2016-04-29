SET cwd=%0\..
echo %cwd%

set OPT_CONFIGURATION=Release
IF /I "%1"=="Debug" set OPT_CONFIGURATION=Debug

set OPT_Platform=x64

if %OPT_CONFIGURATION% equ Debug (
  robocopy %cwd%\src\cpp_bin\%OPT_Platform%\%OPT_CONFIGURATION% %cwd%\DynamoAddin_bin *.dll *.lib *.pdb /E
)
if %OPT_CONFIGURATION% equ Release (
  robocopy %cwd%\src\cpp_bin\%OPT_Platform%\%OPT_CONFIGURATION% %cwd%\DynamoAddin_bin *.dll *.lib /E
)
pause