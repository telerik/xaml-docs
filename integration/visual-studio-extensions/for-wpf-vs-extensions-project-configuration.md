---
title: Configure Project
page_title: Configure Project
description: This article shows how to configure a Telerik project created with the Progress Telerik UI for WPF Extension.
slug: radcontrols-for-wpf-vs-extensions-project-configuration
tags: project,and,configuration
published: True
position: 3
site_name: WPF
---

# Configure Project
 
This article shows how to configure a Telerik project created with the Progress Telerik UI for WPF Extension.

You can access the Project Configuration Wizard through the Telerik menu when you need to configure your Telerik WPF application:

> This wizard is currently not available for {{ site.minimum_net_core_version }} and later projects.

![VSExtentions WPF Overview Menu Configure](images/VSExtentions_WPF_OverviewMenuConfigure.png)

The wizard could be also reached through the context menu counterparts accessed by right clicking on the project you want to convert. 

The Project Configuration Wizard’s __first page__ lets you specify which assemblies your project would use. When selecting a Telerik UI for WPF assembly all dependent controls are selected automatically and vice-versa.

![Project Configuration Wizard](images/VSExtensions_WPF_ProjectConfigureWizard.png)       
	
Through the Project Configuration Wizard’s __second page__ you can select which theme will be applied to your project. Check the content of each theme or see the preview of it when select it into the Project Configuration Wizard.

![VSExtensions WPF Project Config Wizard Step 2](images/VSExtensions_WPF_ProjectConfigWizard_Step2.PNG)

>The Project Configuration Wizard’s second page is only available if you use theming based on implicit styles. ([more information]({%slug styling-apperance-implicit-styles-overview%}))           

When you click the Finish button the selected assembly references get added to the project. If you use the [implicit styles]({%slug styling-apperance-implicit-styles-overview%}) theming mechanism, the resources of the selected theme are merged in the App.xaml Resources collection.          

## See Also  
 * [Automatic Dependency Resolving]({%slug radcontrols-for-wpf-vs-extensions-automatic-resolving%})
 * [Upgrade Project]({%slug radcontrols-for-wpf-vs-extensions-upgrading%})
 * [Download New Version]({%slug radcontrols-vs-extensions-project-latest-version-acquirer%})
 * [Setting a Theme]({%slug styling-apperance-implicit-styles-overview%})
