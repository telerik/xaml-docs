---
title: Getting Started
page_title: Getting Started
description: This article will walk you through the creation of a sample application that contains a RadTabbedWindow control.
slug: radtabbedwindow-getting-started
tags: getting,started
published: True
position: 1
---

# Getting Started with {{ site.framework_name }} TabbedWindow

This tutorial will walk you through the creation of a sample application that contains a __RadTabbedWindow__ control. 

## Assembly References

In order to use the __RadTabbedWindow__ control in your projects, you have to add references to the following assemblies:

* __Telerik.Licensing.Runtime__
* __Telerik.Windows.Controls__
* __Telerik.Windows.Controls.Navigation__
* __Telerik.Windows.Controls.Data__

>tip With the 2025 Q1 release, the Telerik UI for WPF has a new licensing mechanism. You can learn more about it [here]({%slug installing-license-key%}).

### Adding Telerik Assemblies Using NuGet

To use __RadTabbedWindow__ when working with NuGet packages, install the `Telerik.Windows.Controls.Navigation.for.Wpf.Xaml` package. The [package name may vary]({%slug nuget-available-packages%}) slightly based on the Telerik dlls set - [Xaml or NoXaml]({%slug xaml-vs-noxaml%})

Read more about NuGet installation in the [Installing UI for WPF from NuGet Package]({%slug nuget-installation%}) article.

## Adding RadTabbedWindow to the Project

Start by creating a new WPF window using Visual Studio's item template.

{% figure 1, "Add new WPF Window", "add-new-window.png" %}

After this, replace the generated Window declaration with the following XAML code:

#### __[XAML] Example 1: Defining a RadTabbedWindow in XAML__

{{region xaml-radtabbedwindow-getting-started_0}}
    <telerik:RadTabbedWindow x:Class="GettingStarted.TabbedWindow"
                xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
                xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
                xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation">
    </telerik:RadTabbedWindow>
{{endregion}}

>important Please note that you need to replace the **GettingStarted** namespace with your namespace.

Also in the code-behind file you should inherit the __RadTabbedWindow__ instead of the standard MS __Window__.

#### __[C#] Example 2: Inherit from RadTabbedWindow__

{{region cs-radtabbedwindow-getting-started_1}}
    public partial class TabbedWindow : RadTabbedWindow
    {
        public TabbedWindow()
        {
            InitializeComponent();
        }
    }
{{endregion}}

#### __[VB.NET] Example 2: Inherit from RadTabbedWindow__

{{region vb-radtabbedwindow-getting-started_2}}
	Partial Public Class TabbedWindow
		Inherits RadTabbedWindow

		Public Sub New()
			InitializeComponent()
		End Sub
	End Class
{{endregion}}

Finally, you can remove the **StartupUri** property from the **App.xaml** file and replace the code-behind with the following:

#### __[C#] Example 3: Open RadTabbedWindow on application startup__

{{region cs-radtabbedwindow-getting-started_3}}
    public partial class App : Application
    {
        public App()
        {
            var tabbedWindow = new TabbedWindow();
            tabbedWindow.Header = "My Tabbed Window";
            tabbedWindow.Height = 400;
            tabbedWindow.Width = 600;
            tabbedWindow.Show();
        }
    }
{{endregion}}

#### __[VB.NET] Example 3: Open RadTabbedWindow on application startup__

{{region vb-radtabbedwindow-getting-started_4}}
	Partial Public Class App
		Inherits Application

		Public Sub New()
			Dim tabbedWindow = New TabbedWindow()
			tabbedWindow.Header = "My Tabbed Window"
			tabbedWindow.Height = 400
			tabbedWindow.Width = 600
			tabbedWindow.Show()
		End Sub
	End Class
{{endregion}}

If you run the application, you will see the RadTabbedWindow control illustrated in __Figure 2__. 

{% figure 2, "Empty RadTabbedWindow", "tabbedwindow-getting-started-1.png" %}

>important If you're using the [implicit styles]({%slug styling-apperance-implicit-styles-overview%}) theming mechanism with the [NoXaml binaries]({%slug xaml-vs-noxaml%}), note that the newly created window will not automatically receive the default style. In order for this to happen, you should add the following style after the merged dictionaries:

#### __[XAML] Example 4: Adding the style for the new TabbedWindow__

{{region xaml-radtabbedwindow-getting-started_5}}
    <Application.Resources>
        <ResourceDictionary>
            <ResourceDictionary.MergedDictionaries>
                <ResourceDictionary Source="Themes/System.Windows.xaml" />
                <ResourceDictionary Source="Themes/Telerik.Windows.Controls.xaml" />
                <ResourceDictionary Source="Themes/Telerik.Windows.Controls.Navigation.xaml" />
            </ResourceDictionary.MergedDictionaries>
            <Style TargetType="local:TabbedWindow" BasedOn="{StaticResource RadTabbedWindowStyle}" />
        </ResourceDictionary>
    </Application.Resources>
{{endregion}}

## Add Tabs

You can add tabs to the window by directly defining them as its content.

#### __[XAML] Example 5: Adding Tabs to RadTabbedWindow in XAML__

{{region xaml-radtabbedwindow-getting-started_6}}
    <telerik:RadTabbedWindow x:Class="GettingStarted.TabbedWindow"
                xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
                xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
                xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation">
        <telerik:RadTabItem Header="Microsoft">
            <TextBlock Text="Microsoft Content" />
        </telerik:RadTabItem>
        <telerik:RadTabItem Header="Google">
            <TextBlock Text="Google Content" />
        </telerik:RadTabItem>
        <telerik:RadTabItem Header="Progress">
            <TextBlock Text="Progress Content" />
        </telerik:RadTabItem>
    </telerik:RadTabbedWindow>
{{endregion}}

Upon running the application, your RadTabbedWindow should now be populated with tabs as shown on **Figure 3**.

{% figure 3, "RadTabbedWindow with tabs", "tabbedwindow-getting-started-2.png" %}

Alternatively, you can set the **ItemsSource** property of the control or bind it to a collection in your viewmodel. You can find an example of how to do this in the [Data Binding]({%slug radtabbedwindow-data-binding%}) article.

## Setting a Theme

The controls from our suite support different themes. You can see how to apply a theme different than the default one in the [Setting a Theme]({%slug styling-apperance-implicit-styles-overview%}) help article.

>important Changing the theme using implicit styles will affect all controls that have styles defined in the merged resource dictionaries. This is applicable only for the controls in the scope in which the resources are merged. 

To change the theme, you can follow the steps below:
* Choose between the themes and add reference to the corresponding theme assembly (ex: **Telerik.Windows.Themes.Windows8.dll**). You can see the different themes applied in the **Theming** examples from our [WPF Controls Examples](https://demos.telerik.com/wpf/) application.

* Merge the resource dictionaries with the namespace required for the controls that you are using from the theme assembly. For __RadTabbedWindow__, you will need to merge the following resource dictionaries:

	* __System.Windows.xaml__
	* __Telerik.Windows.Controls.xaml__
	* __Telerik.Windows.Controls.Navigation.xaml__

__Example 6__ demonstrates how to merge the resource dictionaries so that they are applied globally for the entire application.

#### __[XAML] Example 6: Merge the ResourceDictionaries__  
{{region xaml-radtabbedwindow-getting-started_7}}
		<Application.Resources>
			<ResourceDictionary>
				<ResourceDictionary.MergedDictionaries>
	                <ResourceDictionary Source="/Telerik.Windows.Themes.Windows8;component/Themes/System.Windows.xaml"/>
	                <ResourceDictionary Source="/Telerik.Windows.Themes.Windows8;component/Themes/Telerik.Windows.Controls.xaml"/>
	                <ResourceDictionary Source="/Telerik.Windows.Themes.Windows8;component/Themes/Telerik.Windows.Controls.Navigation.xaml"/>
				</ResourceDictionary.MergedDictionaries>
	                <Style TargetType="local:TabbedWindow" BasedOn="{StaticResource RadTabbedWindowStyle}" />
			</ResourceDictionary>
		</Application.Resources>
{{endregion}}

__Figure 4__ shows __RadTabbedWindow__ with the **Windows8** theme applied.
	
{% figure 4, "RadTabbedWindow with the Windows8 theme", "tabbedwindow-getting-started-3.png" %}

{% if site.site_name == 'WPF' %}
## Telerik UI for WPF Learning Resources

* [Telerik UI for WPF TabbedWindow Component](https://www.telerik.com/products/wpf/tabbedwindow.aspx)
* [Getting Started with Telerik UI for WPF Components]({%slug getting-started-first-steps%})
* [Telerik UI for WPF Installation]({%slug installation-installing-which-file-do-i-need%})
* [Telerik UI for WPF and WinForms Integration]({%slug winforms-integration%})
* [Telerik UI for WPF Visual Studio Templates]({%slug visual-studio-templates%})
* [Setting a Theme with Telerik UI for WPF]({%slug styling-apperance-implicit-styles-overview%})
* [Telerik UI for WPF Virtual Classroom (Training Courses for Registered Users)](https://learn.telerik.com/learn/course/external/view/elearning/16/telerik-ui-for-wpf) 
* [Telerik UI for WPF License Agreement](https://www.telerik.com/purchase/license-agreement/wpf-dlw-s)
{% endif %}

## See Also

* [Key Properties]({%slug radtabbedwindow-key-properties%})
* [Events]({%slug radtabbedwindow-events%})
* [Styles and Templates]({%slug radtabbedwindow-styles-and-templates%})
