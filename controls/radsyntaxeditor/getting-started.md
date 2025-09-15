---
title: Getting Started
page_title: Getting Started
description: This article will walk you through the creation of a sample application that contains a RadSyntaxEditor control.
slug: radsyntaxeditor-getting-started
tags: getting,started,radsyntaxeditor
position: 2
---

# Getting Started with {{ site.framework_name }} SyntaxEditor

This tutorial will walk you through the creation of a sample application that contains a __RadSyntaxEditor__ control.
			
## Adding Telerik Assemblies Using NuGet

To use __RadSyntaxEditor__ when working with NuGet packages, install the `Telerik.Windows.Controls.SyntaxEditor.for.Wpf.Xaml` package. The [package name may vary]({%slug nuget-available-packages%}) slightly based on the Telerik dlls set - [Xaml or NoXaml]({%slug xaml-vs-noxaml%})

Read more about NuGet installation in the [Installing UI for WPF from NuGet Package]({%slug nuget-installation%}) article.

>tip With the 2025 Q1 release, the Telerik UI for WPF has a new licensing mechanism. You can learn more about it [here]({%slug installing-license-key%}).

## Adding Assembly References Manually

If you are not using NuGet packages, you can add a reference to the following assemblies:

* __Telerik.Licensing.Runtime__
* __Telerik.Windows.Controls__
* __Telerik.Windows.Controls.Input__
* __Telerik.Windows.Controls.SyntaxEditor__
* __Telerik.Windows.SyntaxEditor.Core__

You can find the required assemblies for each control from the suite in the [Controls Dependencies]({%slug installation-installing-controls-dependencies-wpf%}) help article.

## Defining RadSyntaxEditor

__Example 1__ demonstrates how you can define a RadSyntaxEditor in XAML.

__Example 1: Defining RadSyntaxEditor__
```XAML

    <telerik:RadSyntaxEditor x:Name="syntaxEditor" />
```

#### __Figure 1: Empty RadSyntaxEditor__
![Empty RadSyntaxEditor](images/syntaxeditor_getting-started-1.png)

## Opening a File

To load a file in the RadSyntaxEditor you need to use its **Document** property.

__Example 2: Opening a File__
```C#

    public MainWindow()
    {
        InitializeComponent();

        using (StreamReader reader = new StreamReader("../../CS_File.txt"))
        {
            this.syntaxEditor.Document = new TextDocument(reader);
        }
    }
```

#### __Figure 2: RadSyntaxEditor with a loaded C# file__
![RadSyntaxEditor with a loaded CS file](images/syntaxeditor_getting-started-2.png)

## Enable Syntax Highlighting

Once you have loaded the code, you need to register an appropriate tagger to enable syntax highlighting for the particular language.

__Example 3: Enable C# code highlighting__
```C#

    var cSharptagger = new CSharpTagger(this.syntaxEditor);
    this.syntaxEditor.TaggersRegistry.RegisterTagger(cSharptagger);
```

#### __Figure 3: RadSyntaxEditor with C# code highlighting__
![RadSyntaxEditor with C# code highlighting](images/syntaxeditor_getting-started-3.png)

## Setting a Theme

The controls from our suite support different themes. You can see how to apply a theme different than the default one in the [Setting a Theme]({%slug styling-apperance-implicit-styles-overview%}) help article.

>important Changing the theme using implicit styles will affect all controls that have styles defined in the merged resource dictionaries. This is applicable only for the controls in the scope in which the resources are merged. 

To change the theme, you can follow the steps below:

* Choose between the themes and add reference to the corresponding theme assembly (ex: **Telerik.Windows.Themes.Windows8.dll**). You can see the different themes applied in the **Theming** examples from our {% if site.site_name == 'WPF' %}[WPF Controls Examples](https://demos.telerik.com/wpf/){% else %}[Silverlight Controls Examples](https://demos.telerik.com/silverlight/#Slider/Theming){% endif %} application.

* Merge the ResourceDictionaries with the namespace required for the controls that you are using from the theme assembly. For the RadSyntaxEditor, you will need to merge the following resources:

	* __Telerik.Windows.Controls__
	* __Telerik.Windows.Controls.Input__
	* __Telerik.Windows.Controls.SyntaxEditor__
	* __Telerik.Windows.SyntaxEditor.Core__

__Example 3__ demonstrates how to merge the ResourceDictionaries so that they are applied globally for the entire application.

__Example 3: Merge the ResourceDictionaries__  
```XAML
	<Application.Resources>
		<ResourceDictionary>
			<ResourceDictionary.MergedDictionaries>
				<ResourceDictionary Source="/Telerik.Windows.Themes.Windows8;component/Themes/System.Windows.xaml"/>
				<ResourceDictionary Source="/Telerik.Windows.Themes.Windows8;component/Themes/Telerik.Windows.Controls.xaml"/>
				<ResourceDictionary Source="/Telerik.Windows.Themes.Windows8;component/Themes/Telerik.Windows.Controls.Input.xaml"/>
				<ResourceDictionary Source="/Telerik.Windows.Themes.Windows8;component/Themes/Telerik.Windows.Controls.SyntaxEditor.xaml"/>
			</ResourceDictionary.MergedDictionaries>
		</ResourceDictionary>
	</Application.Resources>
```

>Alternatively, you can use the theme of the control via the {% if site.site_name == 'WPF' %}[StyleManager](https://docs.telerik.com/devtools/wpf/styling-and-appearance/stylemanager/common-styling-apperance-setting-theme-wpf){% else %}[StyleManager](https://docs.telerik.com/devtools/silverlight/styling-and-appearance/stylemanager/common-styling-apperance-setting-theme){% endif %}.

__Figure 3__ shows a RadSyntaxEditor with the **Windows8** theme applied.

#### __Figure 3: RadSyntaxEditor with the Windows8 theme__
![RadSyntaxEditor with Windows8 theme](images/RadSyntaxEditor-setting-theme.png)

{% if site.site_name == 'WPF' %}
## Telerik UI for WPF Learning Resources

* [Telerik UI for WPF SyntaxEditor Component](https://www.telerik.com/products/wpf/syntaxeditor.aspx)
* [Getting Started with Telerik UI for WPF Components]({%slug getting-started-first-steps%})
* [Telerik UI for WPF Installation]({%slug installation-installing-which-file-do-i-need%})
* [Telerik UI for WPF and WinForms Integration]({%slug winforms-integration%})
* [Telerik UI for WPF Visual Studio Templates]({%slug visual-studio-templates%})
* [Setting a Theme with Telerik UI for WPF]({%slug styling-apperance-implicit-styles-overview%})
* [Telerik UI for WPF Virtual Classroom (Training Courses for Registered Users)](https://learn.telerik.com/learn/course/external/view/elearning/16/telerik-ui-for-wpf) 
* [Telerik UI for WPF License Agreement](https://www.telerik.com/purchase/license-agreement/wpf-dlw-s)
{% endif %}

## See Also 

* [Visual Structure]({%slug radsyntaxeditor-visual-structure%})
