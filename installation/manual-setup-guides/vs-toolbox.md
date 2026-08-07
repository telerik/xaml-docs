---
title: Adding UI for WPF to Visual Studio Toolbox
page_title: Adding UI for WPF to Visual Studio Toolbox
description: Check how you can add Telerik UI for WPF controls in Visual Studio Toolbox.
slug: installation-adding-to-vs-2015-toolbox-wpf
tags: adding,ui,for,wpf,to,visual,studio,toolbox
published: True
position: 11
---

# Adding UI for WPF to Visual Studio Toolbox

The following tutorial will show you how to add UI for WPF controls to the Visual Studio toolbox.

>important This article is relevant for .NET Framework projects. If you use {{ site.minimum_net_core_version }} and later, see the "Design-Time Support" section of the [.NET Overview]({%slug netcore-support-overview%}) article.

## Adding UI for WPF to Visual Studio Toolbox

To manually add Telerik UI for WPF to the Visual Studio Toolbox, follow the steps below:

* Open your application in Visual Studio.

* Expand the Toolbox (View->Toolbox or use the shortcut Ctrl+Alt+X). 

* Right-mouse button click in the toolbox area and choose "Add Tab" from the context menu.

	![Telerik UI for WPF Visual Studio Toolbox with the Add Tab option](images/Common_InstallingAddingToVS2015ToolBox_01.png)

* Add a new tab with name "UI for WPF".

	![Telerik UI for WPF Visual Studio Toolbox added custom tab](images/Common_InstallingAddingToVS2015ToolBox_02.png)

* Select the "UI for WPF" tab in the toolbox. Right-mouse click and select "Choose Items...".

	![Telerik UI for WPF controls selected in the Visual Studio Toolbox Choose Items menu option](images/Common_InstallingAddingToVS2015ToolBox_03.png)

* In the "Choose Toolbox Items" dialog, go to the "WPF Components" tab and click "Browse...".

	![Telerik UI for WPF Visual Studio Choose Toolbox Items dialog](images/Common_InstallingAddingToVS2015ToolBox_04.png)

* Navigate to the folder where the binaries are located. Select the DLL you want to import and click OK or press Enter.

	![Telerik UI for WPF Toolbox assemblies selection in Visual Studio](images/Common_InstallingAddingToVS2015ToolBox_05.png)

	>If you wonder which control belongs to which assembly, take a look at the main topic about [Telerik UI for WPF control-to-assembly dependencies]({%slug installation-installing-controls-dependencies-wpf%}).

* Press OK to include the controls in your toolbox or filter the controls you want to add.

	![Telerik UI for WPF control added from the Visual Studio Toolbox](images/Common_InstallingAddingToVS2015ToolBox_06.png)

* Expand your toolbox. You will see the newly added controls in the "UI for WPF" section.

	![Telerik UI for WPF Visual Studio Toolbox newly added controls to the created tab](images/Common_InstallingAddingToVS2015ToolBox_07.png)

>After clicking the OK button of the "Choose Toolbox Items", it is possible that the "UI for WPF" tab in the toolbox may be __hidden__. If that happens, move the mouse pointer over the Toolbox area and right-click the mouse and then select the __Show All__ command from the shortcut menu.

![Telerik UI for WPF Visual Studio toolbox Show All tabs option](images/Common_InstallingAddingToVS2015ToolBox_08.png)

## See Also  
 * [Configure Namespace Declarations for Telerik UI for WPF]({%slug installation-guide%}) 

