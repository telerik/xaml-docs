---
title: Deploying WPF .NET Application
page_title: Deploying WPF .NET 8 Application
description: This article shows how to deploy Telerik WPF .NET 6 Application using Visual Studio.
slug: netcore-support-deploy-using-visual-studio
tags: get,started,first,steps,net,core,deploy
published: True
position: 3
---

# Deploying WPF .NET Application

This article shows how to deploy a WPF .NET Application using Visual Studio.

## Create an Application

If you already have a WPF project, you can go directly to the [Deploy the Application](#deploy-the-application) section of this article.

1. Create a new WPF project using the [Telerik Visual Studio Extensions]({%slug radcontrols-for-wpf-vs-extensions-overview-wpf%}) (VSX). If the VSX is installed you will see the __Telerik C# WPF Application__ template in the Visual Studio's project templates list.

	![Telerik UI for WPF Visual Studio Extensions with the Telerik C# WPF Application template](images/netcore-support-deploy-using-visual-studio-0.png)
	
2. Select one of the application templates from the New Project Wizard. For this example, use the Calendar template.

	![Telerik UI for WPF New Project Wizard with application templates](images/netcore-support-deploy-using-visual-studio-1.png)
	
#### __Figure 1: Calendar application created with the New Project Wizard__
![Telerik UI for WPF Calendar application created with the New Project Wizard](images/netcore-support-deploy-using-visual-studio-2.png)

## Deploy the Application

1. Right click the project in Visual Studio and select the __Publish__ option. This will open the __Pick a publish target__ dialog.

	![Telerik UI for WPF Visual Studio project menu with the Publish option selected](images/netcore-support-deploy-using-visual-studio-3.png)

2. Choose the publishing approach and location. Then click __Finish__.

	![Telerik UI for WPF Visual Studio publish dialog for choosing a publishing location](images/netcore-support-deploy-using-visual-studio-4.png)
		
	![Telerik UI for WPF Visual Studio local folder publishing option](images/netcore-support-deploy-using-visual-studio-5.png)
	
	![Telerik UI for WPF Visual Studio publish profile setup](images/netcore-support-deploy-using-visual-studio-6.png)

3. In the publish page, you can find the profile settings. Click on __Show all settings__ and change the __Deployment mode__ to __Self-contained__. Then select a __Target Runtime__.

	![Telerik UI for WPF Visual Studio publish profile settings with deployment mode and target runtime](images/netcore-support-deploy-using-visual-studio-7.png)

4. Save the configuration and click the __Publish__ button. This will generate files in the publish location.

	![Telerik UI for WPF published application files in the publish location](images/netcore-support-deploy-using-visual-studio-8.png)

5. Copy the output files from the publish location to your deployment environment.

>tip You can package your application using the MSIX format. Read more, in the [What is MSIX?](https://docs.microsoft.com/en-us/windows/msix/overview) MSDN article.

## See Also

* [Migrating to .NET Core]({%slug netcore-support-migration%})
