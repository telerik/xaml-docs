---
title: Set Toolbox Version
page_title: Set Toolbox Version
description: Set Toolbox Version
slug: radcontrols-vs-extensions-toolbox-configurator
tags: toolbox,configurator
published: True
position: 7
---

# Set Toolbox Version



## 

Starting with __Q3 2010__ we introduced the __Toolbox Configuration__ utility. Its purpose is to choose which version of __Telerik UI for {{ site.framework_name }}__ to be populated in the Visual Studio’s Toolbox. The user can select among all versions of __Telerik UI__ that are currently on the machine and have been either installed or downloaded using the __VS Extensions__.

The __Toolbox Configurator__ can be launched from the Telerik menu:

{% if site.site_name == 'Silverlight' %}![VSExtentions SL Toolbox Configurator](images/VSExtentions_SL_ToolboxConfigurator.png){% endif %}{% if site.site_name == 'WPF' %}![VSExtentions WPF Toolbox Configurator](images/VSExtentions_WPF_ToolboxConfigurator.png){% endif %}

After running the Toolbox Configurator it shows the version of the currently installed distribution (if available). The user can make his selection using the dropdown menu which lists all versions discovered on the machine. 

When the Finish button is clicked Visual Studio will be restarted so that the changes can take effect.

>The Toolbox Configurator will overwrite the toolbox registration performed during installation. Additionally, after configuring the toolbox, the 'Add References' dialog will suggest Telerik assemblies from the selected distribution only and you will see the selected controls in the Toolbox | Choose Items context menu.
        

The __Toolbox Configurator__ is supported in Visual Studio 2010, 2012, 2013 and 2015.

