# 一键构建：产物在 dist\BossKey-Lite.exe
# 需要 .NET SDK 6+（https://dotnet.microsoft.com/download），运行目标机只需系统自带的 .NET Framework 4.7.2+。
$ErrorActionPreference = 'Stop'
Push-Location $PSScriptRoot
try {
    dotnet build BossKeyLite.csproj -c Release -o dist --nologo
    if ($LASTEXITCODE -ne 0) { throw "Build failed: $LASTEXITCODE" }
    Write-Host "Built $(Join-Path $PSScriptRoot 'dist\BossKey-Lite.exe')"
}
finally { Pop-Location }
