---
title: Getting Started
page_title: Getting Started
description: Check our &quot;Getting Started&quot; documentation article for the RadColorPicker {{ site.framework_name }} control.
slug: radcolorpicker-getting-started
tags: getting,started
published: True
position: 1
---

# Getting Started with {{ site.framework_name }} ColorPicker

## Assembly References

To use the __RadColorPicker__ in your projects you have to add references to the following assemblies:

* __Telerik.Licensing.Runtime__
* __Telerik.Windows.Controls__
* __Telerik.Windows.Controls.Input__

You can find the required assemblies for each control from the suite in the {% if site.site_name == 'Silverlight' %}[Controls Dependencies]({%slug installation-installing-controls-dependencies%}){% else %}[Controls Dependencies]({%slug installation-installing-controls-dependencies-wpf%}){% endif %} help article.

>tip With the 2025 Q1 release, the Telerik UI for WPF has a new licensing mechanism. You can learn more about it [here]({%slug installing-license-key%}).

### Adding Telerik Assemblies Using NuGet

To use __RadColorPicker__ when working with NuGet packages, install the `Telerik.Windows.Controls.Input.for.Wpf.Xaml` package. The [package name may vary]({%slug nuget-available-packages%}) slightly based on the Telerik dlls set - [Xaml or NoXaml]({%slug xaml-vs-noxaml%})

Read more about NuGet installation in the [Installing UI for WPF from NuGet Package]({%slug nuget-installation%}) article.

## Selection

__RadColorPicker__ is a control that displays  a set of palettes from which the user can select a single color.		

>In order to use __RadColorPicker__ in your projects you have to add references to the following two assemblies 
>	- __Telerik.Windows.Controls__ 
>	- __Telerik.Windows.Controls.Input__

It has a __SelectedColor__ property, which is of __Color__ type and it is used to store selected color value.		

#### __[XAML] Example 1__
{{region radcolorpicker-getting-started_1}}
	<telerik:RadColorPicker SelectedColor="Red" />
{{endregion}}

#### __[C#] Example 2__
{{region radcolorpicker-getting-started_0}}
	RadColorPicker colorPicker = new RadColorPicker();
	colorPicker.SelectedColor = Colors.Red;
{{endregion}}

#### __[VB.NET] Example 2__
{{region radcolorpicker-getting-started_0}}
	Dim colorPicker As New RadColorPicker()
	colorPicker.SelectedColor = Colors.Red
{{endregion}}
    
Whenever a color is selected the __SelectedColorChanged__ event is raised:		

#### __[C#] Example 3__
{{region radcolorpicker-getting-started_2}}
	colorPicker.SelectedColorChanged += new EventHandler(RadColorPicker_SelectedColorChanged1);
	
	void RadColorPicker_SelectedColorChanged1(object sender, EventArgs e)
	{
	   RadColorPicker colorPicker = sender as RadColorPicker;
	   Color selectedColor = colorPicker.SelectedColor;
	}
{{endregion}}

#### __[VB.NET] Example 3__
{{region radcolorpicker-getting-started_2}}
	colorPicker.SelectedColorChanged += New EventHandler(RadColorPicker_SelectedColorChanged)

	Private Sub RadColorPicker_SelectedColorChanged(ByVal sender As Object, ByVal e As EventArgs)
		Dim colorPicker As RadColorPicker = TryCast(sender, RadColorPicker)
		Dim selectedColor As Color = colorPicker.SelectedColor
	End Sub
{{endregion}}

## Populating

You can populate the __RadColorSelector__  with any of the built-in palettes using the __ColorPreset__ enum . It has __HeaderPalette__, __MainPalette__ and __StandardPalette__ properties, which represent the corresponding parts of the selector.		

* __MainPalette__ property:			

	#### __[XAML] Example 4__
	{{region radcolorpicker-getting-started_4}}
		<telerik:RadColorPicker MainPalette="Grayscale" />
	{{endregion}}

	#### __[C#] Example 4__
	{{region radcolorpicker-getting-started_3}}
		RadColorPicker colorPicker = new RadColorPicker();
		colorPicker.MainPalette = ColorPreset.Grayscale;
	{{endregion}}

	#### __[VB.NET] Example 5__
	{{region radcolorpicker-getting-started_3}}
		Dim colorPicker As New RadColorPicker()
		colorPicker.MainPalette = ColorPreset.Grayscale
	{{endregion}}

* __HeaderPalette__ property:

	#### __[XAML] Example 6__
	{{region radcolorpicker-getting-started_6}}
		<telerik:RadColorPicker HeaderPalette="Office" />
	{{endregion}}

	#### __[C#] Example 7__
	{{region radcolorpicker-getting-started_5}}
		RadColorPicker colorPicker = new RadColorPicker();
		colorPicker.HeaderPalette = ColorPreset.Office;
	{{endregion}}

	#### __[VB.NET] Example 7__
	{{region radcolorpicker-getting-started_5}}
		Dim colorPicker As New RadColorPicker()
		colorPicker.HeaderPalette = ColorPreset.Office
	{{endregion}}

* __StandardPalette__ property:			

	#### __[XAML] Example 8__
	{{region radcolorpicker-getting-started_8}}
		<telerik:RadColorPicker StandardPalette="Standard" />
	{{endregion}}

	#### __[C#] Example 9__
	{{region radcolorpicker-getting-started_7}}
		RadColorPicker colorPicker = new RadColorPicker();
		colorPicker.StandardPalette = ColorPreset.Standard;
	{{endregion}}

	#### __[VB.NET] Example 9__
	{{region radcolorpicker-getting-started_7}}
		Dim colorPicker As New RadColorPicker()
		colorPicker.StandardPalette = ColorPreset.Standard
	{{endregion}}

If you prefer to use your own collection of Colors you can always use __HeaderPaletteItemsSource__, __MainPaletteItemsSource__ and __StandardPaletteItemsSource__.		

* __StandardPaletteItemSource__ property			

	#### __[XAML] Example 10__
	{{region radcolorpicker-getting-started_10}}
		<telerik:RadColorPicker StandardPaletteItemsSource="{Binding Source={StaticResource ColorList}}" />
	{{endregion}}

	#### __[C#] Example 11__
	{{region radcolorpicker-getting-started_9}}
		RadColorPicker colorPicker = new RadColorPicker();
		colorPicker.StandardPaletteVisibility = Visibility.Visible;
		Collection<Color> colors = new Collection<Color>();
		colors.Add(Colors.Red);
		colors.Add(Colors.Green);
		colors.Add(Colors.Blue);
		colorPicker.StandardPaletteItemsSource = colors;
	{{endregion}}

	#### __[VB.NET] Example 11__
	{{region radcolorpicker-getting-started_9}}
		Dim colorPicker As New RadColorPicker()
		colorPicker.StandardPaletteVisibility = Visibility.Visible
		Dim colors1 As New Collection(Of Color)()
		colors1.Add(Colors.Red)
		colors1.Add(Colors.Green)
		colors1.Add(Colors.Blue)
		colorPicker.StandardPaletteItemsSource = colors1
	{{endregion}}

* __HeaderPaletteItemSource__ property			

	#### __[XAML] Example 12__
	{{region radcolorpicker-getting-started_12}}
		<telerik:RadColorPicker HeaderPaletteItemsSource="{Binding Source={StaticResource ColorList}}" />
	{{endregion}}

	#### __[C#] Example 13__
	{{region radcolorpicker-getting-started_11}}
		RadColorPicker colorPicker = new RadColorPicker();
		colorPicker.HeaderPaletteVisibility = Visibility.Visible;
		Collection<Color> colors = new Collection<Color>();
		colors.Add(Colors.Red);
		colors.Add(Colors.Green);
		colors.Add(Colors.Blue);
		colorPicker.HeaderPaletteItemsSource = colors;
	{{endregion}}

	#### __[VB.NET] Example 13__

	{{region radcolorpicker-getting-started_11}}
		Dim colorPicker As New RadColorPicker()
		colorPicker.HeaderPaletteVisibility = Visibility.Visible
		Dim colors1 As New Collection(Of Color)()
		colors1.Add(Colors.Red)
		colors1.Add(Colors.Green)
		colors1.Add(Colors.Blue)
		colorPicker.HeaderPaletteItemsSource = colors1
	{{endregion}}

* __MainPaletteItemSource__ property

	#### __[XAML] Example 14__
	{{region radcolorpicker-getting-started_14}}
		<telerik:RadColorPicker MainPaletteItemsSource="{Binding Source={StaticResource ColorList}}" />
	{{endregion}}

	#### __[C#] Example 15__
	{{region radcolorpicker-getting-started_13}}
		RadColorPicker colorPicker = new RadColorPicker();
		Collection<Color> colors = new Collection<Color>();
		colors.Add(Colors.Red);
		colors.Add(Colors.Green);
		colors.Add(Colors.Blue);
		colorPicker.MainPaletteItemsSource = colors;
	{{endregion}}

	#### __[VB.NET] Example 15__
	{{region radcolorpicker-getting-started_13}}
		Dim colorPicker As New RadColorPicker()
		Dim colors1 As New Collection(Of Color)()
		colors1.Add(Colors.Red)
		colors1.Add(Colors.Green)
		colors1.Add(Colors.Blue)
		colorPicker.MainPaletteItemsSource = colors1
	{{endregion}}

## Events

* __SelectedColorChanged__ __RadColorPicker__ has __SelectedColor__ property which is of __Color__ type and is used to store selected color value. Whenever a color is selected __SelectedColorChanged__ event is raised.			

* __DropDownClosed__ Raised when the SplitButton is closed.			

* __DropDownOpening__ Raised when the SplitButton is about to be opened.			

* __DropDownOpened__ Raised when the SplitButton is opened.			

* __Click__ Raised when the left part of the SplitButton is clicked.			

## Properties

* __IsDropDownOpen__ - Opens or closes the drop down content.			

* __DropDownPlacement__ - Sets the DropDownPlacement of the drop down content			

* __ContentTemplate__ - Should be used to define the custom Content of the RadColorPicker. Content property should not be used for this purpose			

* __PaletteItemsTemplate__ - Should be used in MVVM scenarios to get or set the ContentTemplate of the RadColorPaletteViewItems from the MainPalette, HeaderPalette, StandartPalette. It is not applied to RecentPalette items.			

* __ColorPropertyPath__ - the control uses this path to find the property of type __System.Windows.Media.Color__ in the DataContext of the RadColorPaletteViewItems. The behavior of this property mimics the behavior of the __ItemsControl.DisplayMemberPath__ property. 			

* __SelectedItem__ - should be used in MVVM scenarios and it holds the selected ViewModel - the DataContext of the selected RadColorPaletteViewItem.			

* __IsRecentColorsActive__ - defines wether a customized color, not existing in the MainPalette, HeaderPalette, StandartPalette or RecentPalette should be added in the RecentColorsPaletteView. If there is such a color this palette will be visible.			

* __AdditionalContent__ - can be used to add customized content under RadColorPicker control.

## Setting a Theme

The controls from our suite support different themes. You can see how to apply a theme different than the default one in the [Setting a Theme]({%slug styling-apperance-implicit-styles-overview%}) help article.

>important Changing the theme using implicit styles will affect all controls that have styles defined in the merged resource dictionaries. This is applicable only for the controls in the scope in which the resources are merged. 

To change the theme, you can follow the steps below:

* Choose between the themes and add reference to the corresponding theme assembly (ex: **Telerik.Windows.Themes.Windows8.dll**). You can see the different themes applied in the **Theming** examples from our {% if site.site_name == 'WPF' %}[WPF Controls Examples](https://demos.telerik.com/wpf/){% else %}[Silverlight Controls Examples](https://demos.telerik.com/silverlight/#ColorPicker/Theming){% endif %} application.

* Merge the ResourceDictionaries with the namespace required for the controls that you are using from the theme assembly. For the __RadColorPicker__, you will need to merge the following resources:

	* __Telerik.Windows.Controls__
	* __Telerik.Windows.Controls.Input__

__Example 16__ demonstrates how to merge the ResourceDictionaries so that they are applied globally for the entire application.

#### __[XAML] Example 16: Merge the ResourceDictionaries__  
{{region xaml-radcolorpicker-getting-started_14}}
	<Application.Resources>
		<ResourceDictionary>
			<ResourceDictionary.MergedDictionaries>
				<ResourceDictionary Source="/Telerik.Windows.Themes.Windows8;component/Themes/System.Windows.xaml"/>
				<ResourceDictionary Source="/Telerik.Windows.Themes.Windows8;component/Themes/Telerik.Windows.Controls.xaml"/>
				<ResourceDictionary Source="/Telerik.Windows.Themes.Windows8;component/Themes/Telerik.Windows.Controls.Input.xaml"/>
			</ResourceDictionary.MergedDictionaries>
		</ResourceDictionary>
	</Application.Resources>
{{endregion}}

>Alternatively, you can use the theme of the control via the {% if site.site_name == 'WPF' %}[StyleManager](https://docs.telerik.com/devtools/wpf/styling-and-appearance/stylemanager/common-styling-apperance-setting-theme-wpf){% else %}[StyleManager](https://docs.telerik.com/devtools/silverlight/styling-and-appearance/stylemanager/common-styling-apperance-setting-theme){% endif %}.

__Figure 1__ shows a __RadColorPicker__ with the **Windows8** theme applied.
	
#### __Figure 1: RadColorPicker with the Windows8 theme__
![RadColorPicker with Windows8 theme](radcolorpicker-setting-theme.png)


{% if site.site_name == 'WPF' %}
## Telerik UI for WPF Learning Resources

* [Telerik UI for WPF ColorPicker Component](https://www.telerik.com/products/wpf/colorpicker.aspx)
* [Getting Started with Telerik UI for WPF Components]({%slug getting-started-first-steps%})
* [Telerik UI for WPF Installation]({%slug installation-installing-which-file-do-i-need%})
* [Telerik UI for WPF and WinForms Integration]({%slug winforms-integration%})
* [Telerik UI for WPF Visual Studio Templates]({%slug visual-studio-templates%})
* [Setting a Theme with Telerik UI for WPF]({%slug styling-apperance-implicit-styles-overview%})
* [Telerik UI for WPF Virtual Classroom (Training Courses for Registered Users)](https://learn.telerik.com/learn/course/external/view/elearning/16/telerik-ui-for-wpf) 
* [Telerik UI for WPF License Agreement](https://www.telerik.com/purchase/license-agreement/wpf-dlw-s)
{% endif %}

