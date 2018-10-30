---
title: Styling RadToolBar
page_title: Styling RadToolBar
description: Styling RadToolBar
slug: radtoolbar-style-selector
tags: style,selector
published: True
position: 2
---

# Styling RadToolBar

__RadToolBar__ control uses __StyleSelector__ mechanism to re-style its items. The control has predefined styles for the most commonly used controls as its content. 

#### __[XAML] Example 1: Default predefined styles__
{{region xaml-radtoolbar-style-selector_0}}
	<Style TargetType="telerik:RadToolBar" x:Key="RadToolBarStyle">
		<Setter Property="ItemContainerStyleSelector">
			<Setter.Value>
				<telerik:ToolBarContainerStyleSelector>
					<telerik:ToolBarContainerStyle TypeName="RadToolBarSeparator" ContainerStyle="{StaticResource RadToolBarSeparatorStyle}"/>
					<telerik:ToolBarContainerStyle TypeName="TextBlock" ContainerStyle="{StaticResource ToolBarTextBlockStyle}"/>
					<telerik:ToolBarContainerStyle TypeName="TextBox" ContainerStyle="{StaticResource ToolBarTextBoxStyle}"/>
					<telerik:ToolBarContainerStyle TypeName="Button" ContainerStyle="{StaticResource ToolBarButtonStyle}"/>
					<telerik:ToolBarContainerStyle TypeName="ToggleButton" ContainerStyle="{StaticResource ToolBarToggleButtonStyle}"/>
					<telerik:ToolBarContainerStyle TypeName="CheckBox" ContainerStyle="{StaticResource ToolBarCheckBoxStyle}"/>
					<telerik:ToolBarContainerStyle TypeName="RadioButton" ContainerStyle="{StaticResource ToolBarRadioButtonStyle}"/>
					<telerik:ToolBarContainerStyle TypeName="RadButton" ContainerStyle="{StaticResource ToolBarRadButtonStyle}"/>
					<telerik:ToolBarContainerStyle TypeName="RadToggleButton" ContainerStyle="{StaticResource ToolBarRadToggleButtonStyle}"/>
					<telerik:ToolBarContainerStyle TypeName="RadRadioButton" ContainerStyle="{StaticResource ToolBarRadRadioButtonStyle}"/>
					<telerik:ToolBarContainerStyle TypeName="RadDropDownButton" ContainerStyle="{StaticResource ToolBarRadDropDownButtonStyle}"/>
					<telerik:ToolBarContainerStyle TypeName="RadSplitButton" ContainerStyle="{StaticResource ToolBarRadSplitButtonStyle}"/>
				</telerik:ToolBarContainerStyleSelector>
			</Setter.Value>
		</Setter>
	</Style>
{{endregion}}

To change a predefined style of a given control the __TypeName__ property of the Style need to be set.

* [RadToolBarSeparator](#radtoolbarseparator)
* [Button](#button)
* [RadButton](#radbutton)
* [ToggleButton](#togglebutton)
* [RadToggleButton](#radtogglebutton)
* [RadioButton](#radiobutton)
* [RadRadioButton](#radradiobutton)
* [RadDropDownButton](#raddropdownbutton)
* [RadSplitButton](#radsplitbutton)
* [CheckBox](#checkbox)
* [TextBlock](#textblock)
* [TextBox](#textbox)

## RadToolBarSeparator

#### __XAML__
{{region xaml-radtoolbar-style-selector_1}}
	<Window.Resources>
         <Style x:Key="CustomRadToolBarSeparatorStyle" TargetType="telerik:RadToolBarSeparator">
            <Setter Property="BorderBrush" Value="Red"/>
            <Setter Property="Width" Value="5"/>
            <Setter Property="Margin" Value="5 5"/>
            <Setter Property="Template">
                <Setter.Value>
                    <ControlTemplate TargetType="telerik:RadToolBarSeparator">
                        <Grid MinWidth="2" MinHeight="2" SnapsToDevicePixels="True">
                            <Rectangle Margin="1 1 0 0" Fill="{TemplateBinding BorderBrush}"/>
                            <Rectangle Margin="0 0 1 1" Fill="{TemplateBinding Background}"/>
                        </Grid>
                    </ControlTemplate>
                </Setter.Value>
            </Setter>
        </Style>        
        <telerik:ToolBarContainerStyleSelector x:Key="selector">
            <telerik:ToolBarContainerStyle TypeName="RadToolBarSeparator" ContainerStyle="{StaticResource CustomRadToolBarSeparatorStyle}" />
        </telerik:ToolBarContainerStyleSelector>
    </Window.Resources>
	<telerik:RadToolBar ItemContainerStyleSelector="{StaticResource selector}">
		<telerik:RadToolBarSeparator />
	</telerik:RadToolBar>
{{endregion}}

## Button

#### __XAML__
{{region xaml-radtoolbar-style-selector_2}}
	<Window.Resources>
        <Style x:Key="CustomButtonStyle" TargetType="Button">
            <Setter Property="Background" Value="Red"/>
        </Style>        
        <telerik:ToolBarContainerStyleSelector x:Key="selector">
            <telerik:ToolBarContainerStyle TypeName="Button" ContainerStyle="{StaticResource CustomButtonStyle}" />
        </telerik:ToolBarContainerStyleSelector>
    </Window.Resources>
	<telerik:RadToolBar ItemContainerStyleSelector="{StaticResource selector}">
		<Button Content="Button" />
	</telerik:RadToolBar>
{{endregion}}
 
## RadButton

#### __XAML__
{{region xaml-radtoolbar-style-selector_3}}
	<Window.Resources>
        <Style x:Key="CustomRadButtonStyle" TargetType="telerik:RadButton">
            <Setter Property="Background" Value="Red"/>
        </Style>        
        <telerik:ToolBarContainerStyleSelector x:Key="selector">
            <telerik:ToolBarContainerStyle TypeName="RadButton" ContainerStyle="{StaticResource CustomRadButtonStyle}" />
        </telerik:ToolBarContainerStyleSelector>
    </Window.Resources>
	<telerik:RadToolBar ItemContainerStyleSelector="{StaticResource selector}">
		<telerik:RadButton Content="RadButton" />
	</telerik:RadToolBar>
{{endregion}}

## ToggleButton

#### __XAML__
{{region xaml-radtoolbar-style-selector_4}}
	<Window.Resources>
        <Style x:Key="CustomToggleButtonStyle" TargetType="ToggleButton">
            <Setter Property="Background" Value="Red"/>
        </Style>        
        <telerik:ToolBarContainerStyleSelector x:Key="selector">
            <telerik:ToolBarContainerStyle TypeName="ToggleButton" ContainerStyle="{StaticResource CustomToggleButtonStyle}" />
        </telerik:ToolBarContainerStyleSelector>
    </Window.Resources>
	<telerik:RadToolBar ItemContainerStyleSelector="{StaticResource selector}">
		<ToggleButton Content="ToggleButton" />
	</telerik:RadToolBar>
{{endregion}}

## RadToggleButton

#### __XAML__
{{region xaml-radtoolbar-style-selector_5}}
	<Window.Resources>
        <Style x:Key="CustomRadToggleButtonStyle" TargetType="telerik:RadToggleButton">
            <Setter Property="Background" Value="Red"/>
        </Style>        
        <telerik:ToolBarContainerStyleSelector x:Key="selector">
            <telerik:ToolBarContainerStyle TypeName="RadToggleButton" ContainerStyle="{StaticResource CustomRadToggleButtonStyle}" />
        </telerik:ToolBarContainerStyleSelector>
    </Window.Resources>
	<telerik:RadToolBar ItemContainerStyleSelector="{StaticResource selector}">
		<telerik:RadToggleButton Content="RadToggleButton" />
	</telerik:RadToolBar>
{{endregion}}

## RadioButton

#### __XAML__
{{region xaml-radtoolbar-style-selector_6}}
	<Window.Resources>
        <Style x:Key="CustomRadioButtonStyle" TargetType="RadioButton">
            <Setter Property="Background" Value="Red"/>
        </Style>        
        <telerik:ToolBarContainerStyleSelector x:Key="selector">
            <telerik:ToolBarContainerStyle TypeName="RadioButton" ContainerStyle="{StaticResource CustomRadioButtonStyle}" />
        </telerik:ToolBarContainerStyleSelector>
    </Window.Resources>
	<telerik:RadToolBar ItemContainerStyleSelector="{StaticResource selector}">
		<RadioButton Content="RadioButton" />
	</telerik:RadToolBar>
{{endregion}}

## RadRadioButton

#### __XAML__
{{region xaml-radtoolbar-style-selector_7}}
	<Window.Resources>
        <Style x:Key="CustomRadRadioButtonStyle" TargetType="telerik:RadRadioButton">
            <Setter Property="Background" Value="Red"/>
        </Style>        
        <telerik:ToolBarContainerStyleSelector x:Key="selector">
            <telerik:ToolBarContainerStyle TypeName="RadRadioButton" ContainerStyle="{StaticResource CustomRadRadioButtonStyle}" />
        </telerik:ToolBarContainerStyleSelector>
    </Window.Resources>
	<telerik:RadToolBar ItemContainerStyleSelector="{StaticResource selector}">
		<telerik:RadRadioButton Content="RadRadioButton" />
	</telerik:RadToolBar>
{{endregion}}

## RadDropDownButton

#### __XAML__
{{region xaml-radtoolbar-style-selector_8}}
	<Window.Resources>
        <Style x:Key="CustomRadDropDownButtonStyle" TargetType="telerik:RadDropDownButton">
            <Setter Property="Background" Value="Red"/>
        </Style>        
        <telerik:ToolBarContainerStyleSelector x:Key="selector">
            <telerik:ToolBarContainerStyle TypeName="RadDropDownButton" ContainerStyle="{StaticResource CustomRadDropDownButtonStyle}" />
        </telerik:ToolBarContainerStyleSelector>
    </Window.Resources>
	<telerik:RadToolBar ItemContainerStyleSelector="{StaticResource selector}">
		<telerik:RadDropDownButton Content="RadDropDownButton" />
	</telerik:RadToolBar>
{{endregion}}

## RadSplitButton

#### __XAML__
{{region xaml-radtoolbar-style-selector_9}}
	<Window.Resources>
        <Style x:Key="CustomRadSplitButtonStyle" TargetType="telerik:RadSplitButton">
            <Setter Property="Background" Value="Red"/>
        </Style>        
        <telerik:ToolBarContainerStyleSelector x:Key="selector">
            <telerik:ToolBarContainerStyle TypeName="RadSplitButton" ContainerStyle="{StaticResource CustomRadSplitButtonStyle}" />
        </telerik:ToolBarContainerStyleSelector>
    </Window.Resources>
	<telerik:RadToolBar ItemContainerStyleSelector="{StaticResource selector}">
		<telerik:RadSplitButton Content="Button" />
	</telerik:RadToolBar>
{{endregion}}

## CheckBox

#### __XAML__
{{region xaml-radtoolbar-style-selector_10}}
	<Window.Resources>
        <Style x:Key="CustomCheckBoxStyle" TargetType="CheckBox">
            <Setter Property="Background" Value="Red"/>
        </Style>        
        <telerik:ToolBarContainerStyleSelector x:Key="selector">
            <telerik:ToolBarContainerStyle TypeName="CheckBox" ContainerStyle="{StaticResource CustomCheckBoxStyle}" />
        </telerik:ToolBarContainerStyleSelector>
    </Window.Resources>
	<telerik:RadToolBar ItemContainerStyleSelector="{StaticResource selector}">
		<CheckBox Content="CheckBox Text" />
	</telerik:RadToolBar>
{{endregion}}

## TextBlock

#### __XAML__
{{region xaml-radtoolbar-style-selector_11}}
	<Window.Resources>
        <Style x:Key="CustomTextBlockStyle" TargetType="TextBlock">
            <Setter Property="Background" Value="Red"/>
        </Style>        
        <telerik:ToolBarContainerStyleSelector x:Key="selector">
            <telerik:ToolBarContainerStyle TypeName="TextBlock" ContainerStyle="{StaticResource CustomTextBlockStyle}" />
        </telerik:ToolBarContainerStyleSelector>
    </Window.Resources>
	<telerik:RadToolBar ItemContainerStyleSelector="{StaticResource selector}">
		<TextBlock Text="Custom Text" />
	</telerik:RadToolBar>
{{endregion}}

## TextBox

#### __XAML__
{{region xaml-radtoolbar-style-selector_12}}
	<Window.Resources>
        <Style x:Key="CustomTextBoxStyle" TargetType="TextBox">
            <Setter Property="Background" Value="Red"/>
        </Style>        
        <telerik:ToolBarContainerStyleSelector x:Key="selector">
            <telerik:ToolBarContainerStyle TypeName="TextBox" ContainerStyle="{StaticResource CustomTextBoxStyle}" />
        </telerik:ToolBarContainerStyleSelector>
    </Window.Resources>
	<telerik:RadToolBar ItemContainerStyleSelector="{StaticResource selector}">
		<TextBox Text="Custom Text" />
	</telerik:RadToolBar>
{{endregion}}

## See Also

* [Overview]({%slug radtoolbar-overview%})
* [Template Structure]({%slug radtoolbar-template-parts%})