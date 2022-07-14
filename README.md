# This repo contains a NET6 WinForms MyButtonLibrary2.MyButton example:
- Uses Microsoft's Nuget package microsoft.winforms.designer.sdk (1.1.0-prerelease-preview3.22076.5).
- Uses DesignTools "server only" approach  

# A scenario where DesignMode is incorrectly false from the NET6 WinForms designer for a custom control.
Steps to reproduce this bug:
1) In VS2022 make a new NET6 WinForms project
2) Copy \Pack\packages\MyButtonLibrary2.1.0.122.nupkg to a local Nuget feed and in your NET6 WinForms project add a Nuget reference to it.
3) From the VS2022 tools window drag and drop MyButton control onto Form1
4) SUCCESS: Note that MyButton contains text "DesignMode:False" and "Process:DesignToolsServer"
5) On the Form1 designer, right-click MyButton and select context menu "Dialog scenario showing DesignMode incorrectly false at design-time..."
6) FAIL: Note that the design-time dialog displays text "DesignMode:False" and "Process:DesignToolsServer". DesignMode should be false.

This image displays the result of the above steps:


