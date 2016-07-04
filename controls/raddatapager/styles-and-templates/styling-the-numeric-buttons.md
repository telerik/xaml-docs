---
title: Styling Numeric Buttons
page_title: Styling Numeric Buttons
description: Styling Numeric Buttons
slug: raddatapager-styles-and-templates-styling-the-numeric-buttons
tags: styling,the,numeric,buttons
published: True
position: 3
---

# Styling Numeric Buttons


__RadDataPager__ exposes a __NumericButtonStyle__ property which allows you to apply a style to it and modify its appearance.

You have two options:

* [To create an empty style and set it up on your own](#creating-an-empty-style).

* [To copy the default style of the control and modify it](#modifying-the-default-style).

## Creating an empty Style

If you want to use this approach you have to create a __Style__ that targets __RadRadioButton__ class. In it you can apply a custom __ControlTemplate__, in which to define the appearance of your button. __Example 1__ shows a __RadDataPager__ with numeric buttons that are represented by ellipses.

#### __[XAML]Example 1: Changing the template of RadDataPager`s numeric buttons__
{{region raddatapager-styles-and-templates-styling-the-numeric-buttons_0}}

	<telerik:BooleanToVisibilityConverter x:Name="BooleanToVisibilityConverter" />
	<Style x:Key="buttonStyle"
	        TargetType="ButtonBase">
	    <Setter Property="Template">
	        <Setter.Value>
	            <ControlTemplate TargetType="telerik:RadRadioButton">
	                <Grid  Width="32"
	                        Background="Black">
	                    <Ellipse StrokeThickness="2"
	                                VerticalAlignment="Center"
	                                Width="15"
	                                Height="15"
	                                HorizontalAlignment="Center"
	                                Fill="Gray" />
	                    <Ellipse Visibility="{Binding IsCurrent, Converter={StaticResource BooleanToVisibilityConverter}}"
	                                VerticalAlignment="Center"
	                                Height="16"
	                                Fill="White"
	                                HorizontalAlignment="Center"
	                                Width="16" />
	                </Grid>
	            </ControlTemplate>
	        </Setter.Value>
	    </Setter>
	</Style>
{{endregion}}

#### __[C#]Example 2: Declare a BooleanToVisibility Converter__
{{region raddatapager-styles-and-templates-styling-the-numeric-buttons_1}}

	public class BooleanToVisibilityConverter : IValueConverter
	{
	  public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
	  {
	     return System.Convert.ToBoolean(value) ? Visibility.Visible : Visibility.Collapsed;
	  }
	  public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
	  {
	     return value;
	  }
	}
{{endregion}}



#### __[VB.NET]Example 2: Declare a BooleanToVisibility Converter__
{{region raddatapager-styles-and-templates-styling-the-numeric-buttons_2}}

	Public Class BooleanToVisibilityConverter
	 Implements IValueConverter
	 Public Function Convert(value As Object, targetType As Type, parameter As Object, culture As System.Globalization.CultureInfo) As Object
	  Return If(System.Convert.ToBoolean(value), Visibility.Visible, Visibility.Collapsed)
	 End Function
	 Public Function ConvertBack(value As Object, targetType As Type, parameter As Object, culture As System.Globalization.CultureInfo) As Object
	  Return value
	 End Function
	End Class
{{endregion}}


>Note that in this template the content of the buttons is not displayed. Because of this, the user cannot make a difference between the auto ellipsis button and a page index button. When not displaying the content, it is recommended not to use auto ellipsis and to display all of the numeric buttons at once. In order to do this just set the __AutoEllipsisMode__ property to __None__ and set the __NumericButtonCount__ property to the respective count of the buttons.

In order to change the appearance of the button when it gets current you bind to the __IsCurrent__ property of the __DataContext__ of the numeric button. This __DataContext__ is of type {% if site.site_name == 'Silverlight' %}[PageViewModel](http://www.telerik.com/help/silverlight/telerik.windows.controls.data-telerik.windows.controls.data.datapager.pageviewmodel_members.html){% endif %}{% if site.site_name == 'WPF' %}[PageViewModel](http://www.telerik.com/help/wpf/telerik.windows.controls.data-telerik.windows.controls.data.datapager.pageviewmodel_members.html){% endif %}.

>Note that for changing the appearance of the button depending on its state, you can also use its __VisualStates__, which can be seen and modified in its default template. To see how to get the default template read the next section of the topic.

[Here](http://www.viddler.com/player/db341ed0/) you can check a short video of an application that uses a __RadDataPager__ with such numeric buttons, in action.

## Modifying the default Style

>You might find it useful to get familiar with the [template structure of the numeric button]({%slug raddatapager-styles-and-templates-template-structure%}).

To modify the default style for the numeric buttons you have to get the default __Style__ for __RadDataPager__. To learn how, read the [Styling the RadDataPager]({%slug raddatapager-styles-and-templates-styling-the-raddatapager%}) topic.

Here is the default XAML for the numeric buttons' __Style__ and its resources.

#### __[XAML]Example 3: Numer buttons` default Style__

	{{region raddatapager-styles-and-templates-styling-the-numeric-buttons_3}}
	<LinearGradientBrush x:Key="RadPager_Page_TopShadow"
	                        EndPoint="0.5,1"
	                        StartPoint="0.5,0">
	    <GradientStop Color="#66000000"
	                    Offset="0" />
	    <GradientStop Offset="0.3" />
	</LinearGradientBrush>
	<LinearGradientBrush x:Key="RadPager_Page_Over"
	                        EndPoint="0.5,0.99"
	                        StartPoint="0.5,0.01">
	    <GradientStop Color="#FFFFFBB7"
	                    Offset="0.216" />
	    <GradientStop Color="#FFBDBDBD" />
	</LinearGradientBrush>
	<LinearGradientBrush x:Key="RadPager_Page_Checked"
	                        EndPoint="0.5,0.99"
	                        StartPoint="0.5,0.01">
	    <GradientStop Color="#FFFFDB7B"
	                    Offset="0.5" />
	    <GradientStop Color="#FFC58124" />
	</LinearGradientBrush>
	<LinearGradientBrush x:Key="RadPager_Page_Disabled"
	                        EndPoint="0.5,0.99"
	                        StartPoint="0.5,0.01">
	    <GradientStop Color="#FFD8D8D8"
	                    Offset="0.216" />
	    <GradientStop Color="#FFBDBDBD" />
	</LinearGradientBrush>
	<ControlTemplate x:Key="RadPageTemplate"
	                    TargetType="telerik:RadRadioButton">
	    <Border x:Name="PageButton"
	            BorderBrush="{TemplateBinding BorderBrush}"
	            BorderThickness="{TemplateBinding BorderThickness}"
	            Background="{TemplateBinding Background}"
	            CornerRadius="0,0,6,1">
	        <VisualStateManager.VisualStateGroups>
	            <VisualStateGroup x:Name="CommonStates">
	                <VisualState x:Name="Normal" />
	                <VisualState x:Name="MouseOver">
	                    <Storyboard>
	                        <ObjectAnimationUsingKeyFrames BeginTime="0"
	                                                        Storyboard.TargetProperty="Background"
	                                                        Storyboard.TargetName="PageButton">
	                            <DiscreteObjectKeyFrame KeyTime="0"
	                                                    Value="{StaticResource RadPager_Page_Over}" />
	                        </ObjectAnimationUsingKeyFrames>
	                    </Storyboard>
	                </VisualState>
	                <VisualState x:Name="Pressed">
	                    <Storyboard>
	                        <ObjectAnimationUsingKeyFrames BeginTime="0"
	                                                        Storyboard.TargetProperty="Background"
	                                                        Storyboard.TargetName="PageButton">
	                            <DiscreteObjectKeyFrame KeyTime="0"
	                                                    Value="{StaticResource RadPager_Page_Checked}" />
	                        </ObjectAnimationUsingKeyFrames>
	                    </Storyboard>
	                </VisualState>
	                <VisualState x:Name="Disabled">
	                    <Storyboard>
	                        <ObjectAnimationUsingKeyFrames BeginTime="0"
	                                                        Storyboard.TargetProperty="Background"
	                                                        Storyboard.TargetName="PageButton">
	                            <DiscreteObjectKeyFrame KeyTime="0"
	                                                    Value="{StaticResource RadPager_Page_Disabled}" />
	                        </ObjectAnimationUsingKeyFrames>
	                    </Storyboard>
	                </VisualState>
	                <VisualState x:Name="Checked">
	                    <Storyboard>
	                        <ObjectAnimationUsingKeyFrames BeginTime="0"
	                                                        Storyboard.TargetProperty="Background"
	                                                        Storyboard.TargetName="PageButton">
	                            <DiscreteObjectKeyFrame KeyTime="0"
	                                                    Value="{StaticResource RadPager_Page_Checked}" />
	                        </ObjectAnimationUsingKeyFrames>
	                    </Storyboard>
	                </VisualState>
	            </VisualStateGroup>
	            <VisualStateGroup x:Name="FocuseStatesGroup">
	                <VisualState x:Name="Unfocused" />
	                <VisualState x:Name="Focused">
	                    <Storyboard>
	                        <ObjectAnimationUsingKeyFrames BeginTime="0"
	                                                        Storyboard.TargetProperty="Background"
	                                                        Storyboard.TargetName="PageButton">
	                            <DiscreteObjectKeyFrame KeyTime="0"
	                                                    Value="{StaticResource RadPager_Page_Over}" />
	                        </ObjectAnimationUsingKeyFrames>
	                    </Storyboard>
	                </VisualState>
	            </VisualStateGroup>
	        </VisualStateManager.VisualStateGroups>
	        <Border Background="{StaticResource RadPager_Page_TopShadow}">
	            <ContentControl Content="{TemplateBinding Content}"
	                            HorizontalAlignment="{TemplateBinding HorizontalContentAlignment}"
	                            IsTabStop="False"
	                            Margin="{TemplateBinding Padding}"
	                            VerticalAlignment="{TemplateBinding VerticalContentAlignment}" />
	        </Border>
	    </Border>
	</ControlTemplate>
	<LinearGradientBrush x:Key="RadPager_Page_Background"
	                        EndPoint="0.5,1"
	                        StartPoint="0.5,0">
	    <GradientStop Color="White"
	                    Offset="0.216" />
	    <GradientStop Color="#FFBDBDBD" />
	</LinearGradientBrush>
	<LinearGradientBrush x:Key="RadPager_Page_Border"
	                        EndPoint="0.5,1"
	                        StartPoint="0.5,0">
	    <GradientStop Color="#FF494949"
	                    Offset="0" />
	    <GradientStop Color="#FF9D9D9D"
	                    Offset="1" />
	</LinearGradientBrush>
	<Style x:Key="RadPageStyle"
	        TargetType="telerik:RadRadioButton">
	    <Setter Property="Template"
	            Value="{StaticResource RadPageTemplate}" />
	    <Setter Property="Background"
	            Value="{StaticResource RadPager_Page_Background}" />
	    <Setter Property="BorderBrush"
	            Value="{StaticResource RadPager_Page_Border}" />
	    <Setter Property="BorderThickness"
	            Value="0,0,1,1" />
	    <Setter Property="MinWidth"
	            Value="21" />
	    <Setter Property="HorizontalContentAlignment"
	            Value="Center" />
	    <Setter Property="VerticalContentAlignment"
	            Value="Center" />
	    <Setter Property="Padding"
	            Value="0" />
	</Style>
{{endregion}}



# See Also

 * [Template Structure]({%slug raddatapager-styles-and-templates-template-structure%})

 * [Styling RadDataPager]({%slug raddatapager-styles-and-templates-styling-the-raddatapager%})

 * [Styling the Other Elements]({%slug raddatapager-styles-and-templates-styling-the-other-elements%})
