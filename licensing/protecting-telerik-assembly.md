---
title: Redistributing Telerik Assemblies
page_title: Redistributing Telerik Assemblies
description: This article describes the redistribution process for the Telerik UI for WPF and Silverlight binaries. 
slug: protecting-telerik-radcontrols-assembly
tags: protecting,telerik,ui,assembly,redistribute
published: True
position: 0
---

# Redistributing Telerik Assemblies

The Telerik UI for {{ site.framework_name }} suite includes a limited run time royalty-free license to redistribute the controls in your own solutions subject to the License Agreement. You can use the components in the suite to build your own solutions, and redistribute your solutions to your end users who are not required to purchase a license from Telerik to access your solution.

{% if site.framework_name == 'WPF' %}

## Examples of Permitted Uses

* WPF applications for internal company use.
            
* Commercial WPF applications deployed to Your end users. __In this case, you may deploy the Telerik assemblies together with your application with the sole exception of the assemblies providing the additional design-time support for the Telerik controls. The design-time assemblies may not be deployed to end-users under any circumstance__.

	The design-time assemblies are located in the __Telerik UI for WPF installation folder/Binaries/WPF40/design__ folder.
	
	>tip The location of the design-time assemblies may vary depending on the Xaml or NoXaml binaries usage and also the .NET version of the control dlls. For example, the [NoXaml]({%slug xaml-vs-noxaml%}), .NET 4.5 desing-time assemblies are located in  *Telerik UI for WPF installation folder/Binaries.NoXaml/WPF45/design*.

* WPF applications that offer a trial or free version of Your application. __If offering a free or trial version of Your Integrated Product, redistribution of the assemblies is not permitted. You are required to protect all Telerik assemblies by using the method in the [Protecting Telerik UI Assemblies](#protecting-telerik-ui-assemblies) section of this article.__

>important The next sections in this article describe how to include additional protection to the Telerik assemblies redistributed with your application when necessary.

{% endif %}

## Protecting Telerik UI Assemblies

Technical guidelines for protecting **Telerik UI for {{ site.framework_name }} by Progress** binaries when redistributed with other applications.
     
There are a couple of approaches that you can take:
* [Use the PowerShell Scripts](#use-the-powershell-scripts)
* [Manually Edit the Source Code](#building-telerik-assemblies-from-source-code)

## Use the PowerShell Scripts

In order to protect the dlls with the powershell scripts you can follow these general steps (the __Instructions__ section below goes into more depth about the steps): 

__1.__	Execute the __AssemblyProtection.ps1__ and __AssemblyProtectionDocumentProcessing.ps1__ (if you are using the Documents Processing library) scripts.  
__2.__	Take the generated Telerik.Windows.Controls and Telerik.Windows.Documents.Core dlls (or their corresponding NuGet packages) and download all of the other assemblies that you need from your [telerik account](https://www.telerik.com/account/my-downloads).  
__3.__	Distribute the dll/NuGet files with your application.  

### Instructions

The Telerik UI source code provides two power shell scripts located in the __Build\BuildInstructions\AssemblyProtection__ folder that will allow you to easily build the Telerik.Windows.Controls and Telerik.Windows.Documents.Core (necessary only if you use the Document Processing library) dlls and include your application name in them. Those assemblies are the only ones that contain the assembly protection mechanism and they are the only ones that need to be built in order to protect the Telerik UI assemblies. After building them, you can download the other dlls that you need from your [telerik account](https://www.telerik.com/account/my-downloads).  
* __AssemblyProtection.ps1__: Changes the ApplicationName in the Core\Controls\Common\AssemblyProtection.cs file with the provided one. Builds the Telerik.Windows.Controls dll and its NuGet package (optionally).  
* __AssemblyProtectionDocumentProcessing.ps1__: Changes the ApplicationName in the Documents\Licensing\AssemblyProtection.cs file with the provided one. Builds the Telerik.Windows.Documents.Core dll and its NuGet package (optionally).  

__1.__	Right click on the needed script and click Run with PowerShell menu item:  
	![run script with PowerShell](images/installation-powershell-image1.png)
> If you don’t have the “Run with PowerShell” option, you can also open the PowerShell console, navigate to the BuildInstructions directory and execute the script(s).

__2.__	When running the scripts, you will be asked to enter the following:

* __Application Name__: This should be the name of your application in which the Telerik UI dlls will be distributed.
* __Target Framework__: You should specify whether you want to build the WPF or the Silverlight dll and Nuget (optionally). Type “wpf” for WPF and “sl” for Silverlight.
* __Binary Type (Xaml or NoXaml)__: The type of dlls that you want to use. For more information about the differences, read the following article: [Xaml vs NoXaml]({%slug xaml-vs-noxaml%}).  

> This option will not be available when building the Telerik.Windows.Documents.Core dll with the __AssemblyProtectionDocumentProcessing.ps1__ script.  

* __Release Date__: You should specify a release date in the following format (MM/DD/YYYY) that matches the release date of the Telerik UI dlls that you are going to distribute. For example, if the version of the dlls is 2019.3.917, you should use 09/17/2019. You can find out how to extract a release date from the version number [here]({%slug installation-installing-lib%}#version-number-breakdown).  

> The version of the Telerik.Windows.Controls dll and the version of the Telerik.Windows.Documents.Core dll can be different. Before building each one, download these dlls from your [telerik account](https://www.telerik.com/account/my-downloads) and check their versions.  

* __Build Nuget package__: If you are distributing NuGet packages, you can build them using the scripts. The nuget packages will be created in the BuildInstructions\AssemblyProtection\NugetOutput directory. Type “y” to create the package and “n” to skip this. 

__3.__	In your application’s resources (App.xaml) create a string resource with key "Telerik.Windows.Controls.Key" and value equal to the value of the Application Name defined in step 2:  

#### __[XAML] Example 1: Merging the application key resource__ 	
{{region protecting-telerik-radcontrols-assembly_5}}
	<Application 
	      xmlns="http://schemas.microsoft.com/client/2007"
	      xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml" 
	      xmlns:system="clr-namespace:System;assembly=mscorlib"
	      x:Class="...">
	        <Application.Resources>
	            <system:String x:Key="Telerik.Windows.Controls.Key">Sample Application Name v2.0 (tm)</system:String>
	        </Application.Resources>
	</Application>
{{endregion}}

__4.__	Once you have executed the script(s) you can take the assemblies generated in the __Binaries__ directory. Here are the locations based on whether WPF/SL and xaml/noxaml was chosen.
* __WPF and xaml__ -> Binaries\WPF40\Dev and Binaries\WPF45\Dev
* __WPF and noxaml__ -> Binaries\WPF40.NoXaml\Dev and Binaries\WPF45.NoXaml\Dev

> Both the .Net 40 and .Net 45 versions will be available when running the AssemblyProtection.ps1 script that builds the Telerik.Windows.Controls dll.

* __Silverlight and xaml__ -> Binaries\Silverlight5\Dev
* __Silverlight and noxaml__ -> Binaries\Silverlight5.NoXaml\Dev

> If you have also rebuilt the NuGet package(s), you can find them in the __BuildInstructions\AssemblyProtection\NugetOutput__ directory.

You can distribute the __Telerik.Windows.Controls__ and __Telerik.Windows.Documents.Core__ dlls after running the scripts along with the other Telerik UI dlls that you need. You can download the other dlls from your [telerik account](https://www.telerik.com/account/my-downloads).  

## Building Telerik Assemblies from Source Code 

__Prerequisites__

All control assemblies should be built from source code due to modifications applied to the source files. The source code of UI for {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} is distributed separately and is bundled with build instructions. Please, read the source code building instructions beforehand. For brevity this document assumes that the source distribution ZIP file is extracted in **C:\Telerik{{ site.framework_name }}Source**
        
__Instructions__

1. Open **C:\Telerik{{ site.framework_name }}Source\Core\Controls\Common\AssemblyProtection.cs** in a text editor (notepad, Visual Studio, etc.)

2. Uncomment the following line:

	#### __[C#] Example 2: Before the change__ 	
	{{region protecting-telerik-radcontrols-assembly_0}}
        public static void Validate()
		{
		    //Uncomment the following line
		    //ValidatePassPhrase();
		}
	{{endregion}}
	
	#### __[C#] Example 3: After the change__ 		
	{{region protecting-telerik-radcontrols-assembly_1}}
        public static void Validate()
		{
		    //Uncomment the following line
		    ValidatePassPhrase();
		}
	{{endregion}}

3. Change the **ApplicationName** constant to match the name of your application:

	#### __[C#] Example 4: Before the change__ 		
	{{region protecting-telerik-radcontrols-assembly_2}}
		internal const string ApplicationName = "MyApp";
	{{endregion}}
	
	#### __[C#] Example 5: After the change__ 		
	{{region protecting-telerik-radcontrols-assembly_3}}
		internal const string ApplicationName = "Sample Application Name v2.0 (tm)";
	{{endregion}}

4. Save __AssemblyProtection.cs__ and rebuild the suite (described separately in the source code build instructions document).
            
5. In your application replace the existing references to the Telerik assemblies with the ones built from the source code.

6. If you run the application now you should get an exception with message **"This version of Telerik UI for {{ site.framework_name }} is licensed only for use by Sample Application Name v2.0 (tm)"**. Note that **"Sample Application Name v2.0 (tm)"** will be replaced with the value of the **ApplicationName** constant.

7. In your application resources **App.xaml** create a string resource with key __"Telerik.Windows.Controls.Key"__ and value equal to the value of the ApplicationName constant from **step 3**:

	#### __[XAML] Example 6: Merging the application key resource__ 	
	{{region protecting-telerik-radcontrols-assembly_4}}
		<Application 
			  xmlns="http://schemas.microsoft.com/client/2007"
			  xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml" 
			  xmlns:system="clr-namespace:System;assembly=mscorlib"
			  x:Class="...">
				<Application.Resources>
					<system:String x:Key="Telerik.Windows.Controls.Key">Sample Application Name v2.0 (tm)</system:String>
				</Application.Resources>
		</Application>
	{{endregion}}

<!-- -->

## Building Telerik Documents Assemblies from Source Code

The instructions in the previous section explain how to build the **Telerik.Windows.Controls** assembly and the assemblies depending on it. The UI for {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} suite contains libraries for processing documents which do not depend on **Telerik.Windows.Controls.dll**. 

If you are building the assemblies needed for one of the components depending on **Telerik.Windows.Documents.Core**, such as the [Telerik Document Processing by Progress libraries](https://docs.telerik.com/devtools/document-processing/introduction), you need to execute the following steps as well.
        
>importantThe following instructions are valid for Telerik UI for {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} version __Q2 2014__ or later.
          
1. Open **C:\Telerik{% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %}Source\Documents\Licensing\AssemblyProtection.cs** in a text editor (notepad, Visual Studio, etc.).

	> In versions of the suite prior to R2 2016, the path is **C:\Telerik{% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %}Source\Documents\Core\Core\Licensing\AssemblyProtection.cs**.            

2. Uncomment the following line:
            
	#### __[C#] Example 7: Before the change__  
	{{region protecting-telerik-radcontrols-assembly_6}}
		public static bool IsValid()
		{
			// Uncomment the following line
			// return ValidatePassPhrase();
			return true;
		}
	{{endregion}}

	#### __[C#] Example 8: After the change__  
	{{region protecting-telerik-radcontrols-assembly_7}}
		public static bool IsValid()
		{
			// Uncomment the following line
			return ValidatePassPhrase();
		}
	{{endregion}}

<!-- -->

3. Execute steps **3-7** from the previous section.

## See Also  
* [Installing Telerik UI on your Computer]({%slug installation-installing-which-file-do-i-need%})
