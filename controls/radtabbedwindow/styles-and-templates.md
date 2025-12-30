---
title: Styles and Templates
page_title: Styles and Templates
description: This article explains how to modify the apperance of the RadTabbedWindow control.
slug: radtabbedwindow-styles-and-templates
tags: getting,started
published: True
position: 4
---

# Styles and Templates

RadTabbedWindow allows you to easily modify its appearance by providing some useful properties.

## AddButtonStyle

Via the **AddButtonStyle** property, you can control the appearance of the button which is used to add new tabs to the window.

#### [XAML] Example 1: Specify AddButtonStyle

```XAML
    <telerik:RadTabbedWindow.AddButtonStyle>
        <Style TargetType="telerik:RadButton" BasedOn="{StaticResource AddItemsButtonStyle}">
            <Setter Property="MinWidth" Value="36" />
            <Setter Property="MinHeight" Value="36" />
        </Style>
    </telerik:RadTabbedWindow.AddButtonStyle>
```

>important If you are using the default Office_Black theme (you have not merged a theme assembly) or you've set a different theme with the [StyleManager]({%slug styling-apperance-implicit-styles-overview%}), you should copy the **AddItemsButtonStyle** and all the referenced resources from the **Telerik.Windows.Controls.Navigation.xaml** file into your project.

## ItemContainerStyle

You can use the **ItemContainerStyle** property to style the individual RadTabItem elements.

#### [XAML] Example 2: Specify ItemContainerStyle

```XAML
    <telerik:RadTabbedWindow.ItemContainerStyle>
        <Style TargetType="telerik:RadTabItem" BasedOn="{StaticResource RadTabbedWindowTabItemStyle}">
            <Setter Property="MinHeight" Value="40" />
            <Setter Property="Background" Value="Red" />
            <Setter Property="FontWeight" Value="Bold" />
            <Setter Property="PinButtonVisibility" Value="Visible" />
		    <Setter Property="CloseButtonVisibility" Value="Visible"/>
        </Style>
    </telerik:RadTabbedWindow.ItemContainerStyle>
```

>important If you are using the default Office_Black theme (you have not merged a theme assembly) or you've set a different theme with the [StyleManager]({%slug styling-apperance-implicit-styles-overview%}), you should copy the **RadTabbedWindowTabItemStyle** and all the referenced resources from the **Telerik.Windows.Controls.Navigation.xaml** file into your project.

## ItemContainerStyleSelector

You can also define a **StyleSelector** and conditionally style the tab items via the **ItemContainerStyleSelector** property.

#### [C#] Example 3: Create a custom StyleSelector

```C#
    public class MyTabItemStyleSelector : StyleSelector
    {
        public Style ProgressStyle { get; set; }
        public Style NormalStyle { get; set; }

        public override Style SelectStyle(object item, DependencyObject container)
        {
            var tab = item as Tab;
            if (tab.Header.Contains("Progress"))
            {
                return this.ProgressStyle;
            }

            return this.NormalStyle;
        }
    }
```

#### [VB.NET] Example 3: Create a custom StyleSelector

```VB.NET
	Public Class MyTabItemStyleSelector
		Inherits StyleSelector

		Public Property ProgressStyle() As Style
		Public Property NormalStyle() As Style

		Public Overrides Function SelectStyle(ByVal item As Object, ByVal container As DependencyObject) As Style
			Dim tab = TryCast(item, Tab)
			If tab.Header.Contains("Progress") Then
				Return Me.ProgressStyle
			End If

			Return Me.NormalStyle
		End Function
	End Class
```

#### [XAML] Example 4: Specify ItemContainerStyleSelector property

```XAML
    <telerik:RadTabbedWindow ... ItemContainerStyle="{x:Null}">
        <telerik:RadTabbedWindow.ItemContainerStyleSelector>
            <local:MyTabItemStyleSelector>
                <local:MyTabItemStyleSelector.ProgressStyle>
                    <Style TargetType="telerik:RadTabItem" BasedOn="{StaticResource RadTabbedWindowTabItemStyle}">
                        <Setter Property="Background" Value="LightGreen" />
                        <Setter Property="FontWeight" Value="Bold" />
                    </Style>
                </local:MyTabItemStyleSelector.ProgressStyle>
                <local:MyTabItemStyleSelector.NormalStyle>
                    <Style TargetType="telerik:RadTabItem" BasedOn="{StaticResource RadTabbedWindowTabItemStyle}" />
                </local:MyTabItemStyleSelector.NormalStyle>
            </local:MyTabItemStyleSelector>
        </telerik:RadTabbedWindow.ItemContainerStyleSelector>
    </telerik:RadTabbedWindow>
```

>important Please note that to use the ItemContainerStyleSelector property, you need to clear the ItemContainerStyle by setting it to **null**.

## ItemTemplate and ItemTemplateSelector

When binding your **RadTabbedWindow** to a collection, you are able to configure the visualization of the data and the appearance of the tab items via the **ItemTemplate** and the **ItemTemplateSelector** properties.

#### [XAML] Example 5: Define a custom ItemTemplate

```XAML
    <telerik:RadTabbedWindow.ItemTemplate>
        <DataTemplate>
            <StackPanel Orientation="Horizontal">
                <Ellipse Width="10" Height="10" Fill="LightGreen" />
                <TextBlock Text="{Binding Header}" FontWeight="Bold" Margin="5 0 0 0" />
            </StackPanel>
        </DataTemplate>
    </telerik:RadTabbedWindow.ItemTemplate>
```

If you wish to return different templates for the tab items, you can use the **ItemTemplateSelector** property and pass a custom **DataTemplateSelector** to it.

## ContentTemplate and ContentTemplateSelector

Similarly, in a data-binding scenario you can control the appearance of the tabs' content via the **ContentTemplate** and the **ContentTemplateSelector** properties.

#### [XAML] Example 6: Define a custom ContentTemplate

```XAML
    <telerik:RadTabbedWindow.ContentTemplate>
        <DataTemplate>
            <TextBlock Text="{Binding Content}" FontWeight="Bold" />
        </DataTemplate>
    </telerik:RadTabbedWindow.ContentTemplate>
```

If you wish to return different templates for the tab items' content, you can use the **ContentTemplateSelector** property and pass a custom **DataTemplateSelector** to it.

## See Also

* [Key Properties]({%slug radtabbedwindow-key-properties%})
* [Events]({%slug radtabbedwindow-events%})
