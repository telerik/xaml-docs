---
title: Styles and Templates
page_title: Styles and Templates
description: Styles and Templates
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

{{region xaml-radtabbedwindow-styles-and-templates_0}}
    <telerik:RadTabbedWindow.AddButtonStyle>
        <Style TargetType="telerik:RadButton">
            <Setter Property="MinWidth" Value="36" />
            <Setter Property="MinHeight" Value="36" />
        </Style>
    </telerik:RadTabbedWindow.AddButtonStyle>
{{endregion}}

>importantIf you're using the [implicit styles]({%slug styling-apperance-implicit-styles-overview%}) mechanism for theming the controls with the [NoXaml binaries]({%slug xaml-vs-noxaml%}), you should base your style on the __AddItemsButtonStyle__.

## ItemContainerStyle

You can use the **ItemContainerStyle** property to style the individual RadTabItem elements.

#### [XAML] Example 2: Specify ItemContainerStyle

{{region xaml-radtabbedwindow-styles-and-templates_1}}
    <telerik:RadTabbedWindow.ItemContainerStyle>
        <Style TargetType="telerik:RadTabItem">
            <Setter Property="MinHeight" Value="40" />
            <Setter Property="Background" Value="Red" />
            <Setter Property="FontWeight" Value="Bold" />
        </Style>
    </telerik:RadTabbedWindow.ItemContainerStyle>
{{endregion}}

>importantIf you're using the [implicit styles]({%slug styling-apperance-implicit-styles-overview%}) mechanism for theming the controls with the [NoXaml binaries]({%slug xaml-vs-noxaml%}), you should base your style on the __RadTabbedWindowTabItemStyle__.

## ItemContainerStyleSelector

You can also define a **StyleSelector** and conditionally style the tab items via the **ItemContainerStyleSelector** property.

#### [C#] Example 3: Create a custom StyleSelector

{{region cs-radtabbedwindow-styles-and-templates_2}}
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
{{endregion}}

#### [VB.NET] Example 3: Create a custom StyleSelector

{{region vb-radtabbedwindow-styles-and-templates_3}}
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
{{endregion}}

#### [XAML] Example 4: Specify ItemContainerStyleSelector property

{{region xaml-radtabbedwindow-styles-and-templates_4}}
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
{{endregion}}

>importantPlease note that to use the ItemContainerStyleSelector property, you need to clear the ItemContainerStyle by setting it to **null**.

## ItemTemplate and ItemTemplateSelector

When binding your **RadTabbedWindow** to a collection, you are able to configure the visualization of the data and the appearance of the tab items via the **ItemTemplate** and the **ItemTemplateSelectior** properties.

#### [XAML] Example 5: Define a custom ItemTemplate

{{region xaml-radtabbedwindow-styles-and-templates_5}}
    <telerik:RadTabbedWindow.ItemTemplate>
        <DataTemplate>
            <StackPanel Orientation="Horizontal">
                <Ellipse Width="10" Height="10" Fill="LightGreen" />
                <TextBlock Text="{Binding Header}" FontWeight="Bold" Margin="5 0 0 0" />
            </StackPanel>
        </DataTemplate>
    </telerik:RadTabbedWindow.ItemTemplate>
{{endregion}}

If you wish to return different templates for the tab items, you can use the **ItemTemplateSelectior** property and pass a custom **DataTemplateSelector** to it.

## ContentTemplate and ContentTemplateSelectior

Similarly, in a data-binding scenario you can control the appearance of the tabs' content via the **ContentTemplate** and the **ContentTemplateSelectior** properties.

#### [XAML] Example 6: Define a custom ContentTemplate

{{region xaml-radtabbedwindow-styles-and-templates_6}}
    <telerik:RadTabbedWindow.ContentTemplate>
        <DataTemplate>
            <TextBlock Text="{Binding Content}" FontWeight="Bold" />
        </DataTemplate>
    </telerik:RadTabbedWindow.ContentTemplate>
{{endregion}}

If you wish to return different templates for the tab items' content, you can use the **ContentTemplateSelectior** property and pass a custom **DataTemplateSelector** to it.

## See Also

* [Key Properties](%slug radtabbedwindow-key-properties%)
* [Events](%slug radtabbedwindow-events%)