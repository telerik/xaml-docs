---
title: Configure Project
page_title: Configure Project
description: This article shows how to configure a Telerik project created with the Progress Telerik UI for WPF Extension.
slug: radcontrols-for-wpf-vs-extensions-project-configuration
tags: project,and,configuration
published: True
position: 3
---

# Configure Project
 
This article shows how to configure a Telerik project created with the Progress Telerik UI for WPF Extension.

You can access the Project Configuration Wizard through the Telerik menu when you need to configure your Telerik WPF application:

> This wizard is currently not available for {{ site.minimum_net_core_version }} and later projects.

![Telerik UI for WPF Visual Studio Extensions menu for configuring a project](images/VSExtentions_WPF_OverviewMenuConfigure.png)

The wizard could be also reached through the context menu counterparts accessed by right clicking on the project you want to convert. 

The Project Configuration Wizard’s __first page__ lets you specify which assemblies your project would use. When selecting a Telerik UI for WPF assembly all dependent controls are selected automatically and vice-versa.

![Telerik UI for WPF Visual Studio project configuration wizard](images/VSExtensions_WPF_ProjectConfigureWizard.png)
	
Through the Project Configuration Wizard’s __second page__ you can select which theme will be applied to your project. Check the content of each theme or see the preview of it when select it into the Project Configuration Wizard.

![Telerik UI for WPF Visual Studio project configuration wizard step two](images/VSExtensions_WPF_ProjectConfigWizard_Step2.PNG)

>The Project Configuration Wizard’s second page is only available if you use theming based on implicit styles. ([Learn how implicit styling works in Telerik UI for WPF]({%slug styling-apperance-implicit-styles-overview%}))           

When you click the Finish button the selected assembly references get added to the project. If you use the [implicit styles]({%slug styling-apperance-implicit-styles-overview%}) theming mechanism, the resources of the selected theme are merged in the App.xaml Resources collection.          

## See Also  
 * [Upgrade an Existing Telerik UI for WPF Project]({%slug radcontrols-for-wpf-vs-extensions-upgrading%})
 * [Download the Latest Telerik UI for WPF Release through Visual Studio Extensions]({%slug radcontrols-vs-extensions-project-latest-version-acquirer%})
 * [Set a Theme by Using Implicit Styles]({%slug styling-apperance-implicit-styles-overview%})
