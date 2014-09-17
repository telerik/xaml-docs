---
title: Styling the Chart Title
page_title: Styling the Chart Title
description: Styling the Chart Title
slug: radchart-styling-and-appearance-styling-chart-title
tags: styling,the,chart,title
published: True
position: 2
---

# Styling the Chart Title



The __RadChart Title__can be styled by creating an appropriate __Style__ and setting it to the __TitleStyle__ property of the __RadChart__. 

You have two options:

* To create an empty style and set it up on your own.

* To copy the default style of the control and modify it.

This topic will show you how to perform the second one.

## Modifying the Default Style

>

The __ChartTitle__control is located in the __Telerik.Windows.Controls.Charting__namespace of the __Telerik.Windows.Controls.Charting__assembly. In order to use it you have to declare it in XAML:

#### __XAML__

{{region radchart-styling-and-appearance-styling-chart-title_0}}
	xmlns:telerikCharting="clr-namespace:Telerik.Windows.Controls.Charting;assembly=Telerik.Windows.Controls.Charting"
	{{endregion}}



When working in Expression Blend, the namespaces that are needed will be added automatically.

Load your project in Expression Blend and open the User Control that holds the __RadChart__. You have to use a dummy control in order to get the default style. To create one find the __ChartTitle__control in the 'Assets' pane and draw one on the art board. In the 'Objects and Timeline' pane select the __ChartTitle,__you've drawn and from the menu choose *Object -> Edit Style -> Edit a Copy*. You will be prompted for the name of the style and where to be placed.

>tipIf you choose to define the style in Application, it would be available for the entire application. This allows you to define a style only once and then reuse it where needed.

After clicking 'OK', Expression Blend will generate the default style of the __ChartTitle__control in the __Resources__ section of your User Control. The properties available for the style will be loaded in the 'Properties' pane and you will be able to modify their default values. You can also edit the generated XAML in the XAML View or in Visual Studio.{% if site.site_name == 'Silverlight' %}

If you go to the 'Resources' pane, you will see an editable list of resources generated together with the style and used by it. In this list you will find the brushes, styles and templates needed to change the visual appearance of the __ChartTitle.__Their names indicate to which part of the __ChartTitle__appearance they are assigned.{% endif %}

{% if site.site_name == 'Silverlight' %}

__![](images/RadChart_Styles_and_Templates_Styling_ChartTitle_01.png)__{% endif %}

* __ChartTitleBackground__ - a brush, that represents the background color of the __ChartTitle__.

* __ChartTitleBorderBrush__ - a brush, that represents the inner border color of the __ChartTitle__.

* __ChartTitleOuterBorderBrush__ - a brush, that represents the outer border color of the __ChartTitle__.

* __ChartTitleBorderThicknes__ - represents the thickness of the __ChartTitle's__ inner border.

* __ChartTitleOuterBorderThicknes__ - represents the thickness of the __ChartTitle's__ outer border.

* __ChartTitlePadding__ - represents the padding, applied to the content of the __ChartTitle__.

* __ChartTitleForeground__ - a brush, that represents the foreground color of the __ChartTitle__.

* __ChartTitleFontSize__ - represents the font size of the __ChartTitle's__ content.

* __ChartTitleFontWeight__ - represents the font weight of the __ChartTitle's__ content.

* __ChartTitleStyle__ - the __Style__, applied to the __ChartTitle__ control.

To apply the style to the real control, set it to the __TitleStyle__property of the __RadChart__.

#### __XAML__

{{region radchart-styling-and-appearance-styling-chart-title_1}}
	<telerikChart:RadChart x:Name="radChart"
	                       TitleStyle="{StaticResource ChartTitleStyle}" />
	{{endregion}}



>

Don't forget to delete the dummy __ChartTitle__control, when you finish editing the style.{% if site.site_name == 'Silverlight' %}

Here is an example of the described resources modified.{% endif %}{% if site.site_name == 'Silverlight' %}




         
      ![](images/RadChart_Styles_and_Templates_Styling_ChartTitle_02.png){% endif %}{% if site.site_name == 'Silverlight' %}

And here is the snapshot of the result.{% endif %}{% if site.site_name == 'Silverlight' %}




         
      ![](images/RadChart_Styles_and_Templates_Styling_ChartTitle_03.png){% endif %}

Here is the final XAML for the __Style__after the modifications:

#### __XAML__

{{region radchart-styling-and-appearance-styling-chart-title_2}}
	<LinearGradientBrush x:Key="ChartTitleBackground"
	                     EndPoint="0.5,1"
	                     StartPoint="0.5,0">
	    <GradientStop Color="#FFEDEDED"
	                  Offset="1" />
	    <GradientStop Color="White" />
	    <GradientStop Color="#FFE5E5E5"
	                  Offset="0.42" />
	    <GradientStop Color="#FFCACACA"
	                  Offset="0.43" />
	</LinearGradientBrush>
	<SolidColorBrush x:Key="ChartTitleBorderBrush"
	                 Color="#FFB5B5B5" />
	<SolidColorBrush x:Key="ChartTitleOuterBorderBrush"
	                 Color="#FF00ADFF" />
	<Thickness x:Key="ChartTitleBorderThickness">1</Thickness>
	<Thickness x:Key="ChartTitleOuterBorderThickness">1</Thickness>
	<Thickness x:Key="ChartTitlePadding">7</Thickness>
	<SolidColorBrush x:Key="ChartTitleForeground"
	                 Color="#FF3B3B3B" />
	<System:Double x:Key="ChartTitleFontSize">18</System:Double>
	<FontWeight x:Key="ChartTitleFontWeight">Bold</FontWeight>
	<Style x:Key="ChartTitleStyle"
	       TargetType="telerikCharting:ChartTitle">
	    <Setter Property="HorizontalContentAlignment"
	            Value="Center" />
	    <Setter Property="Background"
	            Value="{StaticResource ChartTitleBackground}" />
	    <Setter Property="BorderBrush"
	            Value="{StaticResource ChartTitleBorderBrush}" />
	    <Setter Property="OuterBorderBrush"
	            Value="{StaticResource ChartTitleOuterBorderBrush}" />
	    <Setter Property="BorderThickness"
	            Value="{StaticResource ChartTitleBorderThickness}" />
	    <Setter Property="OuterBorderThickness"
	            Value="{StaticResource ChartTitleOuterBorderThickness}" />
	    <Setter Property="Padding"
	            Value="{StaticResource ChartTitlePadding}" />
	    <Setter Property="Foreground"
	            Value="{StaticResource ChartTitleForeground}" />
	    <Setter Property="FontSize"
	            Value="{StaticResource ChartTitleFontSize}" />
	    <Setter Property="FontWeight"
	            Value="{StaticResource ChartTitleFontWeight}" />
	    <Setter Property="Template">
	        <Setter.Value>
	            <ControlTemplate TargetType="telerikCharting:ChartTitle">
	                <Border BorderBrush="{TemplateBinding OuterBorderBrush}"
	                        BorderThickness="{TemplateBinding OuterBorderThickness}">
	                    <Border Background="{TemplateBinding Background}"
	                            BorderBrush="{TemplateBinding BorderBrush}"
	                            BorderThickness="{TemplateBinding BorderThickness}"
	                            CornerRadius="{TemplateBinding CornerRadius}">
	                        <ContentControl FontFamily="{TemplateBinding FontFamily}"
	                                        FontSize="{TemplateBinding FontSize}"
	                                        FontStyle="{TemplateBinding FontStyle}"
	                                        FontWeight="{TemplateBinding FontWeight}"
	                                        Foreground="{TemplateBinding Foreground}"
	                                        HorizontalAlignment="{TemplateBinding HorizontalContentAlignment}"
	                                        Margin="{TemplateBinding Padding}"
	                                        VerticalAlignment="{TemplateBinding VerticalContentAlignment}"
	                                        Content="{TemplateBinding Content}" />
	                    </Border>
	                </Border>
	            </ControlTemplate>
	        </Setter.Value>
	    </Setter>
	</Style>
	{{endregion}}



# See Also

 * [Styling the Chart Series]({%slug radchart-styling-and-appearance-styling-chart-series%})

 * [Styling the Chart Area]({%slug radchart-styling-and-appearance-styling-chart-area%})

 * [Styling the Chart Legend]({%slug radchart-styling-and-appearance-styling-chart-legend%})
