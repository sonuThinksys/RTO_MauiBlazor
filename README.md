# RTO_MauiBlazor

#Android 

 1. Navigate to /AndroidMauiBindings and in this directory in terminal run ./downloadJarScript.sh. GitBash or   Windows Subsystem for Linux (WSL) should be enabled to run .sh on Windows.
 2. Open MauiBlazorNew/MauiBlazorNew.sln in Visual Studio
 3. Edit MauiBlazorNew/MauiBlazorNew.csproj and set <TargetFrameworks>net7.0-android</TargetFrameworks>.
 4. Select android device/emulator in visual studio and run MauiBlazorNew app. 

#IOS

 1. Navigate to MauiBlazorNew/iOSMauiBindings/ProxyLibs/CommunicationUI-Proxy and in this directory in terminal run ./iOSFramework.sh -d.
 2. Open MauiBlazorNew/MauiBlazorNew.sln in Visual Studio
 3. Edit MauiBlazorNew/MauiBlazorNew.csproj and set <TargetFrameworks>net7.0-ios</TargetFrameworks>.
 4. Select iOS device/simulator in visual studio and run MauiBlazorNew app.