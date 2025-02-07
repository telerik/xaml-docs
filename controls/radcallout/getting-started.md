---
title: Getting Started
page_title: Getting Started
description: Check our &quot;Getting Started&quot; documentation article for the RadCallout {{ site.framework_name }} control.
slug: radcallout-getting-started
tags: getting,started
published: True
position: 2
---

# Getting Started with {{ site.framework_name }} Callout

This tutorial will walk you through the creation of a sample application that contains a RadCallout control.

## Assembly References

To use RadCallout, you will need to add references to the following assemblies:

* __Telerik.Licensing.Runtime__
* __Telerik.Windows.Controls__

You can find the required assemblies for each control from the suite in the [Controls Dependencies]({%slug installation-installing-controls-dependencies-wpf%}) help article.

>tip With the 2025 Q1 release, the Telerik UI for WPF has a new licensing mechanism. You can learn more about it [here]({%slug installing-license-key%}).

### Adding Telerik Assemblies Using NuGet

To use `RadCallout` when working with NuGet packages, install the `Telerik.Windows.Controls.for.Wpf.Xaml` package. The [package name may vary]({%slug nuget-available-packages%}) slightly based on the Telerik dlls set - [Xaml or NoXaml]({%slug xaml-vs-noxaml%})

Read more about NuGet installation in the [Installing UI for WPF from NuGet Package]({%slug nuget-installation%}) article.

## Defining RadCallout in XAML

The control can be used as a static element to highlight an element from your application. This gives you the freedom to place the control in any type of parent.

#### __[XAML] Example 1: Defining in XAML__
{{region xaml-radcallout-getting-started-0}}
    <Grid>
		<telerik:RadButton Content="My Button" VerticalAlignment="Center" HorizontalAlignment="Center" />
		<telerik:RadCallout Margin="0 0 0 100" Content="Click on the button" />
	</Grid>
{{endregion}}

## Defining as a Popup

The control can be placed inside a Popup element. This way, you can dynamically show/hide the control per your needs. For the purpose of this tutorial, we are going to show the RadCallout on a button click. First, we need to define our RadButton control and subscribe to its __Click__ event.

#### __[XAML] Example 2: Defining RadButton__
{{region xaml-radcallout-getting-started-0}}
    <Grid>        
		<telerik:RadButton Content="My Button" VerticalAlignment="Center" HorizontalAlignment="Center" Click="RadButton_Click" />
	</Grid>
{{endregion}}

In the click event handler, we can declare our RadCallout control. To show the control, we need to use the CalloutPopupService.Show() static method. The third parameter (not required) of this method accepts CalloutPopupSettings object. You can use these settings, for example, to change the position of the control, add animation, etc.

#### __[C#] Example 3: Setting RadCallout in code behind__
{{region csharp-radcallout-getting-started-1}}
    private void RadButton_Click(object sender, RoutedEventArgs e)
	{
		RadCallout callout = new RadCallout() { Background = Brushes.DeepSkyBlue, Content = "My Callout" };

		CalloutPopupSettings settings = new CalloutPopupSettings()
		{
			Placement = System.Windows.Controls.Primitives.PlacementMode.Top,
		};

		CalloutPopupService.Show(callout, sender as FrameworkElement, settings);
	}
{{endregion}}

If you run the application now, you should see the RadCallout control on top of the button when you click it like in __Figure 1__:

#### Figure 1: RadCallout sample
![Telerik Callout Getting-Started 0](images/callout_getting_started_1.png)

## Setting a Theme

The controls from our suite support different themes. You can see how to apply a theme different than the default one in the [Setting a Theme]({%slug styling-apperance-implicit-styles-overview%}) help article.

>important Changing the theme using implicit styles will affect all controls that have styles defined in the merged resource dictionaries. This is applicable only for the controls in the scope in which the resources are merged. 

To change the theme, you can follow the steps below:

* Choose between the themes and add reference to the corresponding theme assembly (ex: **Telerik.Windows.Themes.Fluent.dll**). You can see the different themes applied in the **Theming** examples from our [WPF Controls Examples](https://demos.telerik.com/wpf/) application.

* Merge the ResourceDictionaries with the namespace required for the controls that you are using from the theme assembly. For the __RadCallout__, you will need to merge the following resources:

	* __Telerik.Windows.Controls__
	
__Example 4__ demonstrates how to merge the ResourceDictionaries so that they are applied globally for the entire application.

#### __[XAML] Example 4: Merge the ResourceDictionaries__  
{{region xaml-radcallout-getting-started_2}}
	<Application.Resources>
		<ResourceDictionary>
			<ResourceDictionary.MergedDictionaries>
				<ResourceDictionary Source="/Telerik.Windows.Themes.Fluent;component/Themes/System.Windows.xaml"/>
				<ResourceDictionary Source="/Telerik.Windows.Themes.Fluent;component/Themes/Telerik.Windows.Controls.xaml"/>
			</ResourceDictionary.MergedDictionaries>
		</ResourceDictionary>
	</Application.Resources>
{{endregion}}

>Alternatively, you can use the theme of the control via the {% if site.site_name == 'WPF' %}[StyleManager](https://docs.telerik.com/devtools/wpf/styling-and-appearance/stylemanager/common-styling-apperance-setting-theme-wpf){% else %}[StyleManager](https://docs.telerik.com/devtools/silverlight/styling-and-appearance/stylemanager/common-styling-apperance-setting-theme){% endif %}.

__Figure 4__ shows a __RadCallout__ with the **Fluent** theme applied.
	
#### __Figure 4: RadCallout with the Fluent theme__
![RadCallout with Fluent theme](images/radcallout-setting-theme.png)

{% if site.site_name == 'WPF' %}
## Telerik UI for WPF Learning Resources

* [Telerik UI for WPF Callout Component](https://www.telerik.com/products/wpf/callout-control.aspx)
* [Getting Started with Telerik UI for WPF Components]({%slug getting-started-first-steps%})
* [Telerik UI for WPF Installation]({%slug installation-installing-which-file-do-i-need%})
* [Telerik UI for WPF and WinForms Integration]({%slug winforms-integration%})
* [Telerik UI for WPF Visual Studio Templates]({%slug visual-studio-templates%})
* [Setting a Theme with Telerik UI for WPF]({%slug styling-apperance-implicit-styles-overview%})
* [Telerik UI for WPF Virtual Classroom (Training Courses for Registered Users)](https://learn.telerik.com/learn/course/external/view/elearning/16/telerik-ui-for-wpf) 
* [Telerik UI for WPF License Agreement](https://www.telerik.com/purchase/license-agreement/wpf-dlw-s)
{% endif %}

## See Also

* [Animations]({%slug radcallout-features-animations%})
* [CalloutPopupSettings]({%slug radcallout-features-calloutpopupsettings%})
