---
title: Protecting Telerik UI assembly
page_title: Protecting Telerik UI assembly
description: Protecting Telerik UI assembly
slug: protecting-telerik-radcontrols-assembly
tags: protecting,telerik,ui,assembly
published: True
position: 2
---

# Protecting Telerik UI assembly

Technical guidelines for protecting Telerik UI for {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} binaries when redistributed with other applications.
     
## Building Telerik Assemblies from source Code 

__Prerequisites__

All control assemblies should be built from source code due to modifications applied to the source files. The source code of UI for {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} is distributed separately and is bundled with build instructions. Please, read the source code building instructions beforehand. For brevity this document assumes that the source distribution ZIP file is extracted in C:\Telerik{% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %}Source
        
__Instructions__

1. Open C:\Telerik{% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %}Source\Core\Controls\Common\AssemblyProtection.cs in a text editor (notepad, Visual Studio, etc.)
            
2. Uncomment the following line:

#### __Before__

{{region protecting-telerik-radcontrols-assembly_0}}
	        public static void Validate()
	{
	    //Uncomment the following line
	    //ValidatePassPhrase();
	}
{{endregion}}

#### __After__

{{region protecting-telerik-radcontrols-assembly_1}}
	        public static void Validate()
	{
	    //Uncomment the following line
	    ValidatePassPhrase();
	}
{{endregion}}

3. Change the ApplicationName constant to match the name of your application:

#### __Before__

{{region protecting-telerik-radcontrols-assembly_2}}
	internal const string ApplicationName = "MyApp";
{{endregion}}

#### __After__

{{region protecting-telerik-radcontrols-assembly_3}}
	internal const string ApplicationName = "Sample Application Name v2.0 (tm)";
{{endregion}}


4. Save __AssemblyProtection.cs__ and rebuild UI for Silverlight or WPF (described separately in the source code build instructions document).
            
5. In your application replace the existing references to the Telerik assemblies with the ones built from the source code.

6. If you run the application now you should get an exception with message “This version of Telerik UI for {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} is licensed only for use by Sample Application Name v2.0 (tm)”. Note that “Sample Application Name v2.0 (tm)” will be replaced with the value of the ApplicationName constant.
            
7. In your application resources App.xaml create a string resource with key __"Telerik.Windows.Controls.Key"__ and value equal to the value of the ApplicationName constant from step 3:
            
#### __Before__

{{region protecting-telerik-radcontrols-assembly_4}}
	<Application 
	    xmlns="http://schemas.microsoft.com/client/2007"
	    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml" 
	    x:Class="...">
	</Application>
{{endregion}}

#### __After__

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

## Building Telerik Documents Assemblies from Source Code

The instructions in the previous section explain how to rebuild the Telerik.Windows.Controls assemblies and the assemblies depending on it. The Telerik UI for {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} suite contains libraries for processing documents which do not depend on Telerik.Windows.Controls.dll. If you are building the assemblies needed for one of the components depending on Telerik.Windows.Documents.Core you need to execute the following steps as well.
        
>importantThe following instructions are valid for Telerik UI for {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} version __Q2 2014 or later__.
          
1. Open C:\TelerikSilverlightWPFSource\Documents\Core\Core\Licensing\AssemblyProtection.cs in a text editor (notepad, Visual Studio, etc.).
            

2. Uncomment the following line:
            
#### __Before__

{{region protecting-telerik-radcontrols-assembly_6}}
	public static bool IsValid()
	{
	    // Uncomment the following line
	    // return ValidatePassPhrase();
	    return true;
	}
{{endregion}}

#### __After__

{{region protecting-telerik-radcontrols-assembly_7}}
	public static bool IsValid()
	{
	    // Uncomment the following line
	    return ValidatePassPhrase();
	}
{{endregion}}

3. Execute steps 3-7 from the previous section.
          
