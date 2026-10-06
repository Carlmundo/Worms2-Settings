@echo off
setlocal
pushd "%~dp0"
if errorlevel 1 exit /b 1

set "BUILD_EXIT_CODE=1"
set "BUILD_MSBUILD="
set "BUILD_VSWHERE=%ProgramFiles(x86)%\Microsoft Visual Studio\Installer\vswhere.exe"

if exist "%BUILD_VSWHERE%" (
    for /f "usebackq delims=" %%I in (`"%BUILD_VSWHERE%" -latest -products * -requires Microsoft.Component.MSBuild -find MSBuild\**\Bin\MSBuild.exe`) do (
        if not defined BUILD_MSBUILD set "BUILD_MSBUILD=%%I"
    )
)

if not defined BUILD_MSBUILD (
    for /f "delims=" %%I in ('where msbuild.exe 2^>nul') do (
        if not defined BUILD_MSBUILD set "BUILD_MSBUILD=%%I"
    )
)

if not defined BUILD_MSBUILD (
    echo ERROR: MSBuild was not found. Install Visual Studio or Build Tools with .NET desktop development.
    goto done
)

"%BUILD_MSBUILD%" "Worms2-Settings.csproj" /t:BuildBothFrameworks /nologo /v:minimal
set "BUILD_EXIT_CODE=%ERRORLEVEL%"
if not "%BUILD_EXIT_CODE%"=="0" (
    echo Build failed. See the errors above.
    goto done
)

echo.
echo Build complete:
echo   bin\Release\settings_netf3.exe
echo   bin\Release\settings.exe

:done
popd
if /i not "%~1"=="/nopause" pause
exit /b %BUILD_EXIT_CODE%
