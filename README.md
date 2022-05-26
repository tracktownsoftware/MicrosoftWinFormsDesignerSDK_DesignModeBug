# This repo contains a NET6 WinForms MyButtonLibrary.MyButton example:
- Uses Microsoft's Nuget package microsoft.winforms.designer.sdk (1.1.0-prerelease-preview3.22076.5).
- Uses DesignTools "server only" approach  

# Reading application settings fails in NET6 WinForms designer. Throws exception "Invalid URI: this hostname could not be parsed".
Steps to reproduce this bug using the MyButtonLibrary nuget package from this repo's \pack\packages folder:
1) In VS2022 make a new NET6 WinForms project
2) Copy \Pack\packages\MyButtonLibrary.1.0.102.nupkg to a local Nuget feed and in your NET6 WinForms project add a Nuget reference to it
3) From the VS2022 tools window drag and drop MyButton control onto Form1
4) **Run-time test (SUCCESS):** Run the app and click the MyButton control. The button text changes. This shows that application settings can be accessed at runtime.
5) Stop the app to return to design mode
6) **Design-time hard coded test (SUCCESS)**: In the Form1 window right-click the MyButton control to access the design-time context menu. Select "Change button text using hard coded text - SUCCESS"
7) **Design-time application settings test (FAIL)**: In the Form1 window right-click the MyButton control to access the design-time context menu. Select "Change button text using application setting - This FAILS"
8) For step 7 you may see the exception "Invalid URI: this hostname could not be parsed". 


