---
title: Green Theme
page_title: Green Theme
description: Green Theme
slug: common-styling-appearance-green-theme
tags: green,theme,dynamic,fontsize,fontfamily
published: True
position: 6
---

<style>
.theme-palette-color {
	width:20px;
	height:20px;
	margin: auto;
	border: 1px solid black;
}

.green-strongbrush-dark {	
	background:#646464;
}
.green-strongbrush-ligth {	
	background:#646464;
}
.green-validationbrush-dark {	
	background:#E60000;
}
.green-validationbrush-ligth {	
	background:#E60000;
}
.green-fixedbrush-dark {	
	background:#FFFFFF;
}
.green-fixedbrush-ligth {	
	background:#FFFFFF;
}
.green-accenthighbrush-dark {	
	background:#2B7402;
}
.green-accenthighbrush-ligth {	
	background:#4FA520;
}
.green-accentlowbrush-dark {	
	background:#86B90E;
}
.green-accentlowbrush-ligth {	
	background:#008406;
}
.green-semiaccentlowbrush-dark {	
	background: #CFDF9D;
}
.green-semiaccentlowbrush-ligth {	
	background: #A0CC9A;
}
.green-mouseoverbrush-dark {	
	background: #669933;
}
.green-mouseoverbrush-ligth {	
	background: #8EBC00;
}
.green-mainbrush-dark {	
	background: #1B1B1F;
}
.green-mainbrush-ligth {	
	background: #F1F1F1;
}
.green-primarybrush-dark {	
	background: #2B2C2E;
}
.green-primarybrush-ligth {	
	background: #E8E8E8;
}
.green-alternativebrush-dark {	
	background: #1D1E21;
}
.green-alternativebrush-ligth {	
	background: #E0E0E0;
}
.green-markerbrush-dark {	
	background: #F1F1F1;
}
.green-markerbrush-ligth {	
	background: #000000;
}
.green-basicbrush-dark {	
	background: #474747;
}
.green-basicbrush-ligth {	
	background: #999999;
}
.green-selectedbrush-dark {	
	background: #FFFFFF;
}
.green-selectedbrush-ligth {	
	background: #353535;
}
.green-lowbrush-dark {	
	background: #343434;
}
.green-lowbrush-ligth {	
	background: #8D8D8D;
}
.green-highbrush-dark {	
	background: #131313;
}
.green-highbrush-ligth {	
	background: #ECECEC;
}
.green-complementarybrush-dark {	
	background: #444446;
}
.green-complementarybrush-ligth {	
	background: #CACACA;
}

article table
{
    table-layout: auto;
}
</style>

# Green Theme

The official Q1 2016 release of __UI for WPF__ brought a brand new __Green__ theme with two color variations – __Light__ and __Dark__.

The following topic explains the specifics of the theme's color variations.

* [Theme Color Variations](#theme-color-variations)
* [Theme Variation Changing](#theme-variation-changing)
* [Green Palette Brushes](#green-palette-brushes)
* [Theme Palette Brushes Description](#theme-palette-brushes-description)
* [Changing Fonts](#changing-fonts)
* [Changing CornerRadius](#changing-cornerradius)
* [Changing Opacity](#changing-opacity)

## Theme Color Variations

There are two palettes of colors which can be easily set by choosing one of the two default color variations:

#### __[C#] Example 1: The ColorVariation enumeration that determines which color variation should be used__
{{region styling-appearance-green-theme-18}}
	/// <summary>
	/// Represents theme color variations.
	/// </summary>
	public enum ColorVariation
	{
		/// <summary>
		/// Represents Dark Green theme palette.
		/// </summary>
		Dark,

		/// <summary>
		/// Represents Light Green theme palette.
		/// </summary>
		Light
	}
{{endregion}}

>The Dark variation of the theme is designed with a dark background in mind and it is recommended to use such a background in your application when choosing it.

The next screenshot displays RadCalendar in its Light and Dark color variations:  

#### __Figure 1: Light and Dark color variations demonstrated with RadCalendar__
![Green Theme Image 01](../images/Common_Styling_Appearance_Green_Theme_01.png)

## Theme Variation Changing

You can switch between the color palettes by calling the __LoadPreset__ method as shown below:

#### __[C#] Example 2: Changing the color variantion of the theme__
{{region styling-appearance-green-theme-0}}
	//default color variation
	GreenPalette.LoadPreset(GreenPalette.ColorVariation.Dark);	

	//light color variation
	GreenPalette.LoadPreset(GreenPalette.ColorVariation.Light);
{{endregion}}
	
#### __[VB.NET] Example 2: Changing the color variantion of the theme__
{{region styling-appearance-green-theme-1}}
	//default color variation
	GreenPalette.LoadPreset(GreenPalette.ColorVariation.Dark)

	//light color variation
	GreenPalette.LoadPreset(GreenPalette.ColorVariation.Light)
{{endregion}}

## Green Palette Brushes

Below you can find the differences between the two color variations. Every brush has relevant HEX value in the corresponding color variation.

| Brush name | Light | | Dark (default) | |
| ---------- | ----- | --- | -------------- | --- |
| __Brushes, which are same in the two palettes__ |  |  |		
| StrongBrush | #FF646464 | <div class="theme-palette-color green-strongbrush-ligth"></div> | #FF646464 | <div class="theme-palette-color green-strongbrush-dark"></div> |
| ValidationBrush |	 #FFE60000 | <div class="theme-palette-color green-validationbrush-ligth"></div> | #FFE60000 | <div class="theme-palette-color green-validationbrush-dark"></div> |
| FixedBrush | #FFFFFFFF | <div class="theme-palette-color green-fixedbrush-ligth"></div> | #FFFFFFFF | <div class="theme-palette-color green-fixedbrush-dark"></div> |
| ReadOnlyBackgroundBrush | #00FFFFFF | <div class="theme-palette-color green-fixedbrush-ligth"></div> | #00FFFFFF | <div class="theme-palette-color green-fixedbrush-dark"></div> |
| __Brushes, which are different in the two palettes__ |  |  |
| AccentHighBrush | #FF4FA520 | <div class="theme-palette-color green-accenthighbrush-ligth"></div> | #FF2B7402 | <div class="theme-palette-color green-accenthighbrush-dark"></div> |
| AccentLowBrush | #FF008406 | <div class="theme-palette-color green-accentlowbrush-ligth"></div> | #FF86B90E | <div class="theme-palette-color green-accentlowbrush-dark"></div> |
| SemiAccentLowBrush | #59008406 | <div class="theme-palette-color green-semiaccentlowbrush-ligth"></div> | #5986B90E | <div class="theme-palette-color green-semiaccentlowbrush-dark"></div> |
| MouseOverBrush | #FF8EBC00 | <div class="theme-palette-color green-mouseoverbrush-ligth"></div> | #FF669933 | <div class="theme-palette-color green-mouseoverbrush-dark"></div> |
| MainBrush | #FFF1F1F1 | <div class="theme-palette-color green-mainbrush-ligth"></div> | #FF1B1B1F | <div class="theme-palette-color green-mainbrush-dark"></div> |
| PrimaryBrush | #FFE8E8E8 | <div class="theme-palette-color green-primarybrush-ligth"></div> | #FF2B2C2E | <div class="theme-palette-color green-primarybrush-dark"></div> |
| AlternativeBrush | #FFE0E0E0 | <div class="theme-palette-color green-alternativebrush-ligth"></div> | #FF1D1E21 | <div class="theme-palette-color green-alternativebrush-dark"></div> |
| MarkerBrush | #FF000000 | <div class="theme-palette-color green-markerbrush-ligth"></div> | #FFF1F1F1 | <div class="theme-palette-color green-markerbrush-dark"></div> |
| BasicBrush | #FF999999 | <div class="theme-palette-color green-basicbrush-ligth"></div> | #FF474747 | <div class="theme-palette-color green-basicbrush-dark"></div> |
| SelectedBrush | #FF353535	| <div class="theme-palette-color green-selectedbrush-ligth"></div> | #FFFFFFFF | <div class="theme-palette-color green-selectedbrush-dark"></div> |
| LowBrush | #FF8D8D8D | <div class="theme-palette-color green-lowbrush-ligth"></div> | #FF343434 | <div class="theme-palette-color green-lowbrush-dark"></div> |
| HighBrush | #FFECECEC | <div class="theme-palette-color green-highbrush-ligth"></div> | #FF131313 | <div class="theme-palette-color green-highbrush-dark"></div> |
| ComplementaryBrush | #FFCACACA | <div class="theme-palette-color green-strongbrush-ligth"></div> | #FF444446 | <div class="theme-palette-color green-strongbrush-dark"></div> |

>The __ReadOnlyBackgroundBrush__ is available with version 2016.1.125.

## Theme Palette Brushes Description

Below you can find more details about each brush and where it is usually applied.

The first three colors have the same value in both color variations and are commonly used among all controls: 
* __StrongBrush__ is gray by default and it is mainly used for filling paths in elements when they are in Normal state.
* __ValidatonBrush__ is red by default and it is used for validation where such is applicable in our controls.
* __FixedBrush__ is white by default and it is the main color for text or paths which are over elements with validation background.

The colors that have different HEX value can be ordered by purpose.

First, we use four accent brushes which are green by default:
* __AccentHighBrush__
* __AccentLowBrush__
* __SemiAccentLowBrush__: A Brush which has the same value as AccentLowBrush but with 35% alpha opacity.
* __MouseOverBrush__: A Brush used as a background or border brush of controls or elements when they are in MouseOver state.

The default brush used as foreground color is:
* __MarkerBrush__

Brush used for paths’ fill in elements that are in MouseOver, Pressed or Selected state:
* __SelectedBrush__

There are several brushes usually used as background color:
* __MainBrush__: A Brush used as background of controls with direct input such as TextBox, PasswordBox, RadMaskedInput, Editable RadComboBox, RadAutoCompleteBox. Also, used as main background of elements that has different content with unpredictable background.
* __PrimaryBrush__: A Brush used as a background of controls when in their Normal state, excluding controls with direct input.
* __AlternativeBrush__: A Brush used as an alternative background – i.e. for popups or where we want to distinguish one element from another.
* __HighBrush__: A Brush rarely used as a background. For example, in RadMenu and RadTimeline.
* __ComplementaryBrush__: A Brush very rarely used as a background. For example, in RadRadialMenu and RadScheduleView.
* __ReadOnlyBackgroundBrush__ (available with 2016.1.125): A Brush used as a background brush of controls in their ReadOnly state. Its default value is Transparent.

There are two brushes usually used as border brush:
* __BasicBrush__: A Brush used as a border brush of controls in their Normal state.
* __LowBrush__: A Brush used as a border brush of controls in their ReadOnly state.

#### __Figure 2: The theme brushes demonstration__
![Green Theme Image 02](../images/Common_Styling_Appearance_Green_Theme_02.png)

## Changing Fonts 

When using the Green theme you can dynamically change the __FontSize__ and __FontFamily__ properties of all components in the application the same way as you do in Windows8, Windows8Touch, Office2013 and VisualStudio2013 themes.

The FontSize and FontFamily properties are public so you can easily modify the theme resources at one single point. The most commonly used font size in the theme is named __FontSize__ and its default value is __12__. Bigger font sizes are used for headers and footers while smaller ones are used inside complex controls such as RadRibbonView, RadGauge, RadGanttView, etc. As for the __FontFamily__ resource - its default value is __Segoe UI__.

> Please note that for complex scenarios we strongly recommend setting the FontSize property only initially before the application is initialized. Also, we recommend values between 11px and 19px for it.

All available __FontSizes and FontFamily__ as well as their default values are:

#### __[C#] Example 2: Default FontFamily and FontSize values__
{{region styling-appearance-green-theme-2}}
	GreenPalette.Palette.FontSizeXS = 10;
	GreenPalette.Palette.FontSizeS = 11; 
	GreenPalette.Palette.FontSize = 12;
	GreenPalette.Palette.FontSizeL = 13;
	GreenPalette.Palette.FontSizeXL = 14; 
	GreenPalette.Palette.FontFamily = new FontFamily("Segoe UI");
{{endregion}}
	
#### __[VB.NET] Example 2: Default FontFamily and FontSize values__
{{region styling-appearance-green-theme-3}}
	GreenPalette.Palette.FontSizeXS = 10
	GreenPalette.Palette.FontSizeS = 11
	GreenPalette.Palette.FontSize = 12
	GreenPalette.Palette.FontSizeL = 13
	GreenPalette.Palette.FontSizeXL = 14
	GreenPalette.Palette.FontFamily = New FontFamily("Segoe UI");
{{endregion}}

More details regarding the rarely used font sizes can be found below:  
* GreenPalette.Palette.FontSizeXS is used in: 

	* TimeBar's SelectionRangeStyle in Telerik.Windows.Controls.DataVisualization
	* Map’s Scale and MouseLocationIndicator in Telerik.Windows.Controls.DataVisualization
	* AggregateResultsList, GridViewHeaderCell and GridViewGroupPanel in Telerik.Windows.Controls.GridView
	
* GreenPalette.Palette.FontSizeS is used in: 

	* ChartBaseStyle and TrackBallInfoControlStyle in Telerik.Windows.Controls.Chart.xaml
	* HorizontalBulletGraphStyle and VerticalBullerGraphStyle in Telerik.Windows.Controls.DataVisualization	
	* TimeBar's ItemControlStyle in Telerik.Windows.Controls.DataVisualization
	* RibbonView’s GroupChromeStyle in Telerik.Windows.Controls.RibbonView
	* GanttView's EventContainerStyle in Telerik.Windows.Controls.GanntView 
	* ScheduleView TimeRulerItems' styles in Telerik.Windows.Controls.ScheduleView
	* DiagramRulerStyle in Telerik.Windows.Controls.Diagrams.Extensions.xaml
	
* GreenPalette.Palette.FontSizeL is used in: 

	* GanttView's GanttDragResizeVisualCueTemplate in Telerik.Windows.Controls.GanntView 
	* ScheduleView TimeRulerGroupItems' and TimeRulerMonthViewGroupItem’s styles in Telerik.Windows.Controls.ScheduleView 
	
* GreenPalette.Palette.FontSizeXL is used in: 

	* ScheduleView TimeRulerMonthViewItem’s styles in Telerik.Windows.Controls.ScheduleView 

As the following example shows, you can change the default __FontFamily__ from "Segoe UI" to "Comic Sans MS" and the __FontSize__ from 12 to 14 on a click of a button:

#### __[XAML] Example 3: The view of the example__
{{region styling-appearance-green-theme-4}}
	<StackPanel> 
		 <telerik:RadCalendar x:Name="Calendar" Width="250" Height="250" Margin="4 10"/> 
		 <telerik:RadButton x:Name="BtnChangeFontSize"
								   Content="Change Font"
								   HorizontalAlignment="Center" VerticalAlignment="Center" 
								   Click="OnButtonChangeFontSizeClick" />
	</StackPanel>
{{endregion}}

#### __[C#] Example 4: Changing the FontSize and the FontFamily__
{{region styling-appearance-green-theme-5}}
	private void OnButtonChangeFontSizeClick(object sender, RoutedEventArgs e)
	{
		GreenPalette.Palette.FontSize = 14;
		GreenPalette.Palette.FontFamily = new FontFamily("Comic Sans MS");
	}
{{endregion}}

#### __[VB.NET] Example 4: Changing the FontSize and the FontFamily__	
{{region styling-appearance-green-theme-6}}
	Private Sub OnButtonChangeFontSizeClick(sender As Object, e As RoutedEventArgs)
		GreenPalette.Palette.FontSize = 14
		GreenPalette.Palette.FontFamily = New FontFamily("Comic Sans MS")
	End Sub
{{endregion}}

#### __Figure 3: Change in theme fonts__
![Green Theme Image 03](../images/Common_Styling_Appearance_Green_Theme_03.png)
	
## Changing CornerRadius 

A new feature of the Green theme is exposing an easy way to modify the corner radius of many elements in your application. You can use the five new palette properties with default values as shown below:

#### __[C#] Example 5: Default CornerRadius values__	
{{region styling-appearance-green-theme-7}}
	GreenPalette.Palette.CornerRadius = new CornerRadius(1, 1, 1, 1);
	GreenPalette.Palette.CornerRadiusBottom = new CornerRadius(0, 0, 1, 1);
	GreenPalette.Palette.CornerRadiusLeft = new CornerRadius(1, 0, 0, 1);
	GreenPalette.Palette.CornerRadiusRight = new CornerRadius(0, 1, 1, 0);
	GreenPalette.Palette.CornerRadiusTop = new CornerRadius(1, 1, 0, 0);
{{endregion}}

#### __[VB.NET] Example 5: Default CornerRadius values__	
{{region styling-appearance-green-theme-8}}
	GreenPalette.Palette.CornerRadius = New CornerRadius(1, 1, 1, 1)
	GreenPalette.Palette.CornerRadiusBottom = New CornerRadius(0, 0, 1, 1)
	GreenPalette.Palette.CornerRadiusLeft = New CornerRadius(1, 0, 0, 1)
	GreenPalette.Palette.CornerRadiusRight = New CornerRadius(0, 1, 1, 0)
	GreenPalette.Palette.CornerRadiusTop = New CornerRadius(1, 1, 0, 0)
{{endregion}}

As the following example shows, you can change the default __CornerRadius__ from 1 to 5 on a click of a button:

#### __[XAML] Example 6: The view of the example__	
{{region styling-appearance-green-theme-9}}
	<StackPanel>
		 <telerik:RadCalendar x:Name="Calendar" Width="250" Height="250" Margin="4 10"/>
		 <telerik:RadComboBox x:Name="ComboBoxChangeCornerRadius"
							  SelectionChanged="ComboBoxChangeCornerRadius_SelectionChanged" 
							  Width="50"
							  SelectedIndex="1"
							  HorizontalAlignment="Center" />
	</StackPanel>
{{endregion}}

#### __[C#] Example 7: Changing the CornerRadius__	
{{region styling-appearance-green-theme-10}}
	public MainWindow()
	{
		InitializeComponent();
		this.CornerRadiusComboBox.ItemsSource = Enumerable.Range(0, 10);
	}
	
	private void ComboBoxChangeCornerRadius_SelectionChanged(object sender, RoutedEventArgs e)
	{ 
		var selectedCornerSize = sender as RadComboBox;
		if (selectedCornerSize != null && selectedCornerSize.SelectedValue != null)
		{
			double selectedValue = Convert.ToDouble(selectedCornerSize.SelectedValue);
			GreenPalette.Palette.CornerRadius = new CornerRadius(selectedValue, selectedValue, selectedValue, selectedValue);
			GreenPalette.Palette.CornerRadiusBottom = new CornerRadius(0, 0, selectedValue, selectedValue);
			GreenPalette.Palette.CornerRadiusLeft = new CornerRadius(selectedValue, 0, 0, selectedValue);
			GreenPalette.Palette.CornerRadiusRight = new CornerRadius(0, selectedValue, selectedValue, 0);
			GreenPalette.Palette.CornerRadiusTop = new CornerRadius(selectedValue, selectedValue, 0, 0); 
		}
	}
{{endregion}}
	
#### __[VB.NET] Example 7: Changing the CornerRadius__	
{{region styling-appearance-green-theme-11}}
	Public Sub New()
		InitializeComponent()
		Me.CornerRadiusComboBox.ItemsSource = Enumerable.Range(0, 10)
	End Sub

	Private Sub ComboBoxChangeCornerRadius_SelectionChanged(sender As Object, e As RoutedEventArgs)
		Dim selectedCornerSize = TryCast(sender, RadComboBox)
		If selectedCornerSize IsNot Nothing AndAlso selectedCornerSize.SelectedValue IsNot Nothing Then
			Dim selectedValue As Double = Convert.ToDouble(selectedCornerSize.SelectedValue)
			GreenPalette.Palette.CornerRadius = New CornerRadius(selectedValue, selectedValue, selectedValue, selectedValue)
			GreenPalette.Palette.CornerRadiusBottom = New CornerRadius(0, 0, selectedValue, selectedValue)
			GreenPalette.Palette.CornerRadiusLeft = New CornerRadius(selectedValue, 0, 0, selectedValue)
			GreenPalette.Palette.CornerRadiusRight = New CornerRadius(0, selectedValue, selectedValue, 0)
			GreenPalette.Palette.CornerRadiusTop = New CornerRadius(selectedValue, selectedValue, 0, 0)
		End If
	End Sub
{{endregion}}

#### __Figure 4: Changes in corner radius__	
![Green Theme Image 04](../images/Common_Styling_Appearance_Green_Theme_04.png)

## Changing Opacity 

If you need to change the opacity of disabled elements, you can now easily do it by using the __DisabledOpacity__ property of GreenPalette as follows: 

#### __[XAML]:Example 8: The view of the opacity__	
{{region styling-appearance-green-theme-12}}
	<telerik:RadCalendar x:Name="Calendar" Width="250" Height="250" Margin="4 10" IsEnabled="False"/>
{{endregion}}

#### __[C#] Example 9: Changing the DisabledOpacity__	
{{region styling-appearance-green-theme-13}}
	GreenPalette.Palette.DisabledOpacity = 0.5;
{{endregion}}
	
#### __[VB.NET] Example 9: Changing the DisabledOpacity__	
{{region styling-appearance-green-theme-14}}
	GreenPalette.Palette.DisabledOpacity = 0.5
{{endregion}}
	
#### __Figure 5: Changes in the disabled elements opacity__
![Green Theme Image 05](../images/Common_Styling_Appearance_Green_Theme_05.png)
	
The same is applicable for the ReadOnly state of controls by using the exposed __ReadOnlyOpacity__ property of GreenPalette. The default values are 0.2 and 1 for the __DisabledOpacity__ and the __ReadOnlyOpacity__ properties. 

#### __[XAML] Example 10: The view of the example__		
{{region styling-appearance-green-theme-15}}
	<StackPanel Width="200" HorizontalAlignment="Center">
		<TextBox Text="TextBox" Margin="5" />
		<TextBox Text="Disabled TextBox" Margin="5" IsEnabled="False" />
		<TextBox Text="ReadOnly TextBox" Margin="5" IsReadOnly="True" />
	</StackPanel>
{{endregion}}

#### __[C#] Example 11: Changing the opacity__		
{{region styling-appearance-green-theme-16}}
	GreenPalette.Palette.DisabledOpacity = 0.5;
	GreenPalette.Palette.ReadOnlyOpacity = 0.5;
{{endregion}}
	
#### __[VB.NET] Example 11: Changing the opacity__		
{{region styling-appearance-green-theme-17}}
	GreenPalette.Palette.DisabledOpacity = 0.5
	GreenPalette.Palette.ReadOnlyOpacity = 0.5
{{endregion}}

#### __Figure 6: Changes in the readonly elements opacity__
![Green Theme Image 06](../images/Common_Styling_Appearance_Green_Theme_06.png)	

## See Also
* [Setting a Theme (Using Implicit Styles)]({%slug styling-apperance-implicit-styles-overview%})
* [Office2013 Theme]({%slug common-styling-appearance-office2013-theme%})
* [VisualStudio2013 Theme]({%slug common-styling-appearance-visualstudio2013-theme%})
* [Windows8 and Windows8Touch Colors and Fonts]({%slug common-styles-appearance-colorizing-metro-theme%})
