---
title: Adding UI for WPF to Visual Studio Toolbox
page_title: Adding UI for WPF to Visual Studio Toolbox
description: Check how you can add Telerik UI for WPF controls in Visual Studio Toolbox.
slug: installation-adding-to-vs-2015-toolbox-wpf
tags: adding,ui,for,wpf,to,visual,studio,toolbox
published: True
position: 1
site_name: WPF
---

# Adding UI for WPF to Visual Studio Toolbox

The following tutorial will show you how to add UI for WPF controls to the Visual Studio toolbox.

>important This article is relevant for .NET Framework projects. If you use {{ site.minimum_net_core_version }} and later, see the "Design-Time Support" section of the [.NET Overview]({%slug netcore-support-overview%}) article.

## Adding UI for WPF to Visual Studio Toolbox

To manually add Telerik UI for WPF to the Visual Studio Toolbox, follow the steps below:

* Open your application in Visual Studio.

* Expand the Toolbox (View->Toolbox or use the shortcut Ctrl+Alt+X). 

* Right-mouse button click in the toolbox area and choose "Add Tab" from the context menu.

	![Common Installing Adding ToVS 2015 Tool Box 010 WPF](images/Common_InstallingAddingToVS2015ToolBox_01.png)

* Add a new tab with name "UI for WPF".

	![Common Installing Adding ToVS 2015 Tool Box 020 WPF](images/Common_InstallingAddingToVS2015ToolBox_02.png)

* Select the "UI for WPF" tab in the toolbox. Right-mouse click and select "Choose Items...".

	![Common Installing Adding ToVS 2015 Tool Box 030 WPF](images/Common_InstallingAddingToVS2015ToolBox_03.png)

* In the "Choose Toolbox Items" dialog, go to the "WPF Components" tab and click "Browse...".

	![Common Installing Adding ToVS 2015 Tool Box 040 WPF](images/Common_InstallingAddingToVS2015ToolBox_04.png)

* Navigate to the folder where the binaries are located. Select the DLL you want to import and click OK or press Enter.

	![Common Installing Adding ToVS 2015 Tool Box 050 WPF](images/Common_InstallingAddingToVS2015ToolBox_05.png)

	>If you wonder which control belongs to which assembly, take a look at the main topic about [Controls Dependencies]({%slug installation-installing-controls-dependencies-wpf%}).

* Press OK to include the controls in your toolbox or filter the controls you want to add.

	![Common Installing Adding ToVS 2015 Tool Box 060 WPF](images/Common_InstallingAddingToVS2015ToolBox_06.png)

* Expand your toolbox. You will see the newly added controls in the "UI for WPF" section.

	![Common Installing Adding ToVS 2015 Tool Box 070 WPF](images/Common_InstallingAddingToVS2015ToolBox_07.png)

>After clicking the OK button of the "Choose Toolbox Items", it is possible that the "UI for WPF" tab in the toolbox may be __hidden__. If that happens, move the mouse pointer over the Toolbox area and right-click the mouse and then select the __Show All__ command from the shortcut menu.

![Common Installing Adding ToVS 2015 Tool Box 080 WPF](images/Common_InstallingAddingToVS2015ToolBox_08.png)

## See Also  
 * [Namespace Declaration]({%slug installation-adding-application-namespace-declaration%}) 
