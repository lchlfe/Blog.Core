

@echo off
for /f "tokens=5" %%i in ('netstat -aon ^| findstr ":9291"') do (
    set n=%%i
)
taskkill /f /pid %n%




dotnet build

cd Blog.Core.Api



dotnet run

cmd