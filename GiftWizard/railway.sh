#!/bin/bash

# Railway ortamı için environment variables
export NUGET_FALLBACK_PACKAGES=""
export NUGET_PACKAGES=".nuget/packages"
export DOTNET_SKIP_FIRST_TIME_EXPERIENCE=true
export DOTNET_CLI_TELEMETRY_OPTOUT=true

# NuGet cache'i temizle
dotnet nuget locals all --clear

# Paketleri restore et
dotnet restore --configfile NuGet.config --verbosity normal

# Spesifik projeyi publish et (solution değil)
dotnet publish GiftWizard.WebApi/GiftWizard.WebApi.csproj \
    --no-restore \
    --configuration Release \
    --output ./publish \
    --verbosity normal

# Publish edilen dosyaları çalıştırılabilir hale getir
chmod +x ./publish/GiftWizard.WebApi