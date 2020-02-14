---
title: Troubleshooting
page_title: Troubleshooting
description: Progress Telerik UI Extension troubleshooting list.
slug: radcontrols-vs-extensions-troubleshooting
tags: troubleshooting 
published: True
position: 11
---

# Troubleshooting

## Missing Telerik menu in Visual Studio

__REASON:__

Progress Telerik UI for {{ site.framework_name }} Extension are disabled or not installed correctly.

__Solution 1 - extension is disabled__

* Open Visual Studio

* Go to menu **Tools -> Extensions and Updates...** (for Visual Studio 2019 - **Extensions -> Manage Extensions**)

* Open the **Installed** tab on the left

* Search for **Telerik {{ site.framework_name }} VSExtensions** and make sure they are **Enabled**

![vsextensions-disabled](images/VSExtensions_disabled.png)

__Solution 2 - extension is not installed__

* Open Visual Studio

* Go to menu **Tools -> Extensions and Updates...** (for Visual Studio 2019 - **Extensions -> Manage Extensions**)

* Open the **Online** tab on the left

* Search for **Telerik {{ site.framework_name }} VSExtensions**

* Download and install the extensions

>important If the article does not help in solving your problem, please follow these steps to generate a Visual Studio [ActivityLog](https://docs.microsoft.com/en-us/visualstudio/ide/reference/log-devenv-exe?view=vs-2019) file before contacting our support:
>* Open [Developer Command prompt](https://docs.microsoft.com/en-us/dotnet/framework/tools/developer-command-prompt-for-vs) for Visual Studio 20xx under **Administrative rights**.
>* Execute the command - **devenv /log %userprofile%\desktop\ActivityLog.xml**. This will start Visual Studio and create logs on your Desktop.
>* Reproduce the problem.
>* Attach the **Activitylog** files when you contact our support.
