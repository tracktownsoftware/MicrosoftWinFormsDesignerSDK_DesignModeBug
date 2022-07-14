set PACKAGEVERSION=1.0.122
msbuild ..\MicrosoftWinFormsDesignerSDK_DesignModeBug.sln -p:Configuration=Release 

rem build MyButtonLibrary2 package
dotnet pack -p:PackageVersion=%PACKAGEVERSION% ..\MyButtonLibrary2\MyButtonLibrary2.csproj --configuration=Release --output Packages
