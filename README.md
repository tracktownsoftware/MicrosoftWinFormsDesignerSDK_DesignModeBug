# This MyButtonLibrary.MyButton example:
- Uses Microsoft's Nuget package microsoft.winforms.designer.sdk (1.1.0-prerelease-preview3.22076.5).
- Uses DesignTools "server only" approach

# Reading application settings fails in NET6 WinForms designer
To reproduce using the MyButtonLibrary nuget package:
1) In VS2022 make a new NET6 WinForms project
2) Copy \Pack\packages\MyButtonLibrary.1.0.100.nupkg to a local Nuget feed and in your NET6 WinForms project add a Nuget reference to it
3) From VS2022 tools window drag and drop MyButton control onto Form1
4) Run the app and click the MyButton control. The button text changes. This shows that application settings can be accessed at runtime.
5) Stop the app to return to design mode
6) In the Form1 window right-click the MyButton control to access the design-time context menu. Select "Reading application settings fails in NET6 WinForms designer..."
7) You will get an exception "The settings property 'HelloWorld' was not found. This is caused by MyButton application settings failing in the designer. 
8) The output window contains: REQUEST FAILURES: Designers/InvokeDesignerAction Microsoft.DotNet.DesignTools.Client.DesignToolsServerException: The settings property 'HelloWorld' was not found.


