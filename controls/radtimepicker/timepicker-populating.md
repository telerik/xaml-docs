---
title: Getting Started
page_title: Getting Started
description: Check our &quot;Getting Started&quot; documentation article for the RadTimePicker {{ site.framework_name }} control.
slug: radtimepicker-timepicker-populating
tags: getting,started
published: True
position: 2
---

# Getting Started

The __RadTimePicker__ is a control that displays a range of times from which the user can select a single time. It essentially inherits [RadDateTimePicker]({%slug raddatetimepicke-getting-started%}) and sets the __InputMode__ property to __TimePicker__.

## Assembly References

In order to use the __RadTimePicker__ control in your projects, you have to add references to the following assemblies:

* __Telerik.Licensing.Runtime__
* __Telerik.Windows.Controls__
* __Telerik.Windows.Controls.Input__

You can find more info {% if site.site_name == 'Silverlight' %}[here]({%slug installation-installing-controls-dependencies%}){% endif %}{% if site.site_name == 'WPF' %}[here]({%slug installation-installing-controls-dependencies-wpf%}){% endif %}.

>tip With the 2025 Q1 release, the Telerik UI for WPF has a new licensing mechanism. You can learn more about it [here]({%slug installing-license-key%}).

### Adding Telerik Assemblies Using NuGet

To use __RadTimePicker__ when working with NuGet packages, install the `Telerik.Windows.Controls.Input.for.Wpf.Xaml` package. The [package name may vary]({%slug nuget-available-packages%}) slightly based on the Telerik dlls set - [Xaml or NoXaml]({%slug xaml-vs-noxaml%})

Read more about NuGet installation in the [Installing UI for WPF from NuGet Package]({%slug nuget-installation%}) article.

## Setting the SelectedTime

The __SelectedTime__ property holds the selected time. Examples 1 and 2 demonstrate how you can set this property in xaml and code behind. For more information, check out the [Selection]({%slug raddatetimepicker-features-selection%}) article of the __RadDateTimePicker__.

#### __[XAML] Example 1: Setting the SelectedTime in xaml__

{{region xaml-radtimepicker-timepicker-populating_0}}
 	<telerik:RadTimePicker x:Name="timePicker" SelectedTime="15:00" />
{{endregion}}

#### __[C#] Example 2: Setting the SelectedTime in code__

{{region cs-radtimepicker-timepicker-populating_1}}
	timePicker.SelectedTime = new TimeSpan(15,0,0);
{{endregion}}

#### __[VB.NET] Example 2: Setting the SelectedTime in code__

{{region vb-radtimepicker-timepicker-populating_2}}
	timePicker.SelectedTime = New TimeSpan(15,0,0)
{{endregion}}

> In order to take some action when the SelectedTime is changed, you can handle the __SelectionChanged__ event. You can check out all of the available events in the [Events]({%slug raddatetimepicker-events%}) article of the RadDateTimePicker.

## StartTime, EndTime and TimeInterval

You can limit the times that can be selected by setting the __StartTime__ and __EndTime__ properties. The __TimeInterval__ property allows user to specify the interval between time slots available for selection. For more information, check out the [Clock Items]({%slug raddatetimepicker-features-clock-items%}#using-the-starttime-endtime-and-timeinterval-features).

#### __[XAML] Example 2: Setting the StartTime, EndTime and TimeInterval__

{{region xaml-radtimepicker-timepicker-populating_3}}
	<telerik:RadTimePicker x:Name="timePicker" TimeInterval="0:30:0" StartTime="0:0:0" EndTime="7:0:0" />
{{endregion}}

## Setting the ClockItemsSource

You can also populate the RadTimePicker from code behind by setting its ClockItemsSource property to a collection of TimeSpan objects. **Example 3** demonstrates how you can achieve this. 

#### __[C#] Example 3: Setting the ClockItemsSource__

{{region cs-radtimepicker-timepicker-populating_4}}
	public DataBinding()
	{
	    this.radTimePicker.ClockItemsSource = this.LoadDataObjects();
	}
	public ObservableCollection<TimeSpan> LoadDataObjects()
	{
	    ObservableCollection<TimeSpan> times = new ObservableCollection<TimeSpan>()
	    { 
	       new TimeSpan(9,0,0),
	       new TimeSpan(10,0,0),
	       new TimeSpan(10,5,0),
	       new TimeSpan(10,22,0),
	    };
	    return times;
	}
{{endregion}}

#### __[VB.NET] Example 3: Setting the ClockItemsSource__

{{region vb-radtimepicker-timepicker-populating_5}}
	Public Sub New()
		Me.radTimePicker.ClockItemsSource = Me.LoadDataObjects()
	End Sub
	Public Function LoadDataObjects() As ObservableCollection(Of TimeSpan)
		Dim times As New ObservableCollection(Of TimeSpan)() From {
			New TimeSpan(9,0,0),
			New TimeSpan(10,0,0),
			New TimeSpan(10,5,0),
			New TimeSpan(10,22,0)
		}
		Return times
	End Function
{{endregion}}

## Setting a Theme

The controls from our suite support different themes. You can see how to apply a theme different than the default one in the [Setting a Theme]({%slug styling-apperance-implicit-styles-overview%}) help article.

>important Changing the theme using implicit styles will affect all controls that have styles defined in the merged resource dictionaries. This is applicable only for the controls in the scope in which the resources are merged. 

To change the theme, you can follow the steps below:

* Choose between the themes and add reference to the corresponding theme assembly (ex: **Telerik.Windows.Themes.Windows8.dll**). You can see the different themes applied in the **Theming** examples from our {% if site.site_name == 'WPF' %}[WPF Controls Examples](https://demos.telerik.com/wpf/){% else %}[Silverlight Controls Examples](https://demos.telerik.com/silverlight/#Slider/Theming){% endif %} application.

* Merge the ResourceDictionaries with the namespace required for the controls that you are using from the theme assembly. For the RadTimePicker, you will need to merge the following resources:

	* __Telerik.Windows.Controls__
	* __Telerik.Windows.Controls.Input__

__Example 4__ demonstrates how to merge the ResourceDictionaries so that they are applied globally for the entire application.

#### __[XAML] Example 4: Merge the ResourceDictionaries__  
{{region radtimepicker-getting-started_7}}
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

__Figure 5__ shows a RadTimePicker with the **Windows8** theme applied.

#### __Figure 5: RadTimePicker with the Windows8 theme__
![RadTimePicker with Windows8 theme](images/RadTimePicker-setting-theme.png)

{% if site.site_name == 'WPF' %}
## Telerik UI for WPF Learning Resources

* [Telerik UI for WPF TimePicker Component](https://www.telerik.com/products/wpf/datetimepicker.aspx)
* [Getting Started with Telerik UI for WPF Components]({%slug getting-started-first-steps%})
* [Telerik UI for WPF Installation]({%slug installation-installing-which-file-do-i-need%})
* [Telerik UI for WPF and WinForms Integration]({%slug winforms-integration%})
* [Telerik UI for WPF Visual Studio Templates]({%slug visual-studio-templates%})
* [Setting a Theme with Telerik UI for WPF]({%slug styling-apperance-implicit-styles-overview%})
* [Telerik UI for WPF Virtual Classroom (Training Courses for Registered Users)](https://learn.telerik.com/learn/course/external/view/elearning/16/telerik-ui-for-wpf) 
* [Telerik UI for WPF License Agreement](https://www.telerik.com/purchase/license-agreement/wpf-dlw-s)
{% endif %}

## See also 

* [Layout Support]({%slug radtimepicker-layout-support%})
* [Keyboard Support]({%slug raddatetimepicker-features-keyboard-support%})
* [Parsing Without Separators]({%slug raddatetimepicker-features-parsing-without-separators%}#parsing-the-time-part)
