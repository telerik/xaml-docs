---
title: Configure Project
page_title: Configure Project
description: Configure Project
slug: radcontrols-for-wpf-vs-extensions-project-configuration
tags: project,and,configuration
published: True
position: 3
site_name: WPF
---

# Configure Project
 
__Configure Telerik WPF Application__

You can access the Project Configuration Wizard through the Telerik menu when you need to configure your Telerik WPF application:

![VSExtentions WPF Overview Menu Configure](images/VSExtentions_WPF_OverviewMenuConfigure.png)

The wizard could be also reached through the context menu counterparts accessed by right clicking on the project you want to convert. 

The Project Configuration Wizard’s first page lets you:

![Project Configuration Wizard](images/VSExtensions_WPF_ProjectConfigureWizard.png)       

* Specify which assemblies your project would use. When selecting a Telerik UI for WPF assembly all dependent controls are selected automatically and vice-versa.
         
Through the Project Configuration Wizard’s second page you can:

![VSExtensions WPF Project Config Wizard Step 2](images/VSExtensions_WPF_ProjectConfigWizard_Step2.PNG)

* Select which theme will be applied to your project. Check the content of each theme or see the preview of it when select it into the Project Configuration Wizard:

>The Project Configuration Wizard’s second page is only available if you use theming based on implicit styles. ([more information]({%slug styling-apperance-implicit-styles-overview%}))           

When you click the Finish button:
        

* The selected assembly references get added to your project
          

* A default application-wide theme gets set if you use theming based on implicit styles.
          

# See Also

 * [Automatic Dependency Resolving]({%slug radcontrols-for-wpf-vs-extensions-automatic-resolving%})

 * [Upgrade Project]({%slug radcontrols-for-wpf-vs-extensions-upgrading%})

 * [Download New Version]({%slug radcontrols-vs-extensions-project-latest-version-acquirer%})

 * [Setting a Theme]({%slug styling-apperance-implicit-styles-overview%})
