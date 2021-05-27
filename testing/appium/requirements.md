---
title: Requirements
page_title: Requirements | Appium
description: This article lists the requirements needed to use Appium, the Microsoft recommended open source test automation framework, with Telerik UI for {{ site.framework_name }}.  
slug: appium-requirements
tags: appium
published: True
position: 1 
---

# Requirements for Using Appium 

1\. **WinAppDriver** is supported on machines running **Windows 10**.

2\. You need to [enable Developer mode](https://docs.microsoft.com/en-us/windows/apps/get-started/enable-your-device-for-development).

3\. Install the Windows [Application Driver](https://github.com/Microsoft/WinAppDriver/releases) required to run tests.

Not mandatory, but may come in use depending on your test scenarios and architecture:

1\. [Appium](http://appium.io/).

2\. [WinAppDriver UI Recorder](https://github.com/Microsoft/WinAppDriver/wiki/WinAppDriver-UI-Recorder) - allows you to record tests at run time. Does not require installation - unzip the [downloaded Source code archive](https://github.com/Microsoft/WinAppDriver/releases). Then open **Tools\UIRecorder\WinAppDriverUIRecorder.sln** in Visual Studio and select **Debug > Start Debugging** or simply **Run**.

##  Useful Resources

Here is a list of resources you may find helpful while creating your Appium tests:

* WinAppDriver [Supported APIs](https://github.com/microsoft/WinAppDriver/wiki/Supported-APIs).

* [When and how to create a Desktop Session](https://github.com/microsoft/WinAppDriver/wiki/Frequently-Asked-Questions#when-and-how-to-create-a-desktop-session) - Desktop session might be useful when you want to automate more than one desktop application.

* [Authoring Your Own Test Script](https://github.com/microsoft/WinAppDriver/blob/master/Docs/AuthoringTestScripts.md).

## See Also

* [Overview]({%slug appium-overview%})
* [Getting Started]({%slug appium-getting-started%})