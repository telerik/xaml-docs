---
title: Styling the QuickAccessToolbar
page_title: Styling the QuickAccessToolbar
description: Check our &quot;Styling the QuickAccessToolbar&quot; documentation article for the RadRibbonView {{ site.framework_name }} control.
slug: radribbonview-styling-quickaccesstoolbar
tags: styling,the,quickaccesstoolbar
published: True
position: 5
---

# Styling the QuickAccessToolbar

The __RadRibbonView QuickAccessToolBar__ control can be styled by creating an appropriate __Style__ and setting it to the __Style__ property of the control.

You have two options:

* To create an empty style and set it up on your own.
* To copy the default style of the control and modify it.

This topic will show you how to perform the second one.

## Modifying the Default Style

In order to copy the default style, load your project in Expression Blend and open the User Control that holds the __RadRibbonView__. In the 'Objects and Timeline' pane select the __QuickAccessToolBar__ you want to style.
{% if site.site_name == 'Silverlight' %}
![{{ site.framework_name }} RadRibbonView  ](images/RibbonView_Styling_QAT_Locate.png)
{% endif %}
{% if site.site_name == 'WPF' %}
![{{ site.framework_name }} RadRibbonView  ](images/RibbonView_Styling_QAT_LocateWPF.png)
{% endif %}

From the menu choose *Object -> Edit Style -> Edit a Copy*. You will be prompted for the name of the style and where to be placed.
![{{ site.framework_name }} RadRibbonView  ](images/RibbonView_Styling_QAT_CreateStyle.png)

>tip If you choose to define the style in Application, it would be available for the entire application. This allows you to define a style only once and then reuse it where needed.

After clicking 'OK', Expression Blend will generate the default style of the __QuickAccessToolBar__ control in the __Resources__ section of your User Control. The properties available for the style will be loaded in the 'Properties' pane and you will be able to modify their default values.{% if site.site_name == 'Silverlight' %}

If you want to change the __ControlTemplate__ elements of the __QuickAccessToolBar__ select the style in the 'Objects and Timeline' pane, right-click on it and choose Edit Template -> Edit Current. In the same pane the element parts for the __QuickAccessToolBar's__ template will get loaded.{% endif %}

{% if site.site_name == 'WPF' %}
You can modify these properties to achieve the desired appearance. However the most of the visual parts of the __QuickAccessToolBar__ have to be styled in the template of it. To modify it select the style in the 'Objects and Timeline' pane, right-click on it and choose *Edit Template -> Edit Current*. In the same pane the element parts for the __QuickAccessToolBar's__ template will get loaded.
{% endif %}
![{{ site.framework_name }} RadRibbonView  ](images/RibbonView_Styling_QAT_ControlTemplate.png)

{% if site.site_name == 'WPF' %}
Change the elements' properties until you get the desired look.

>You can also modify the trigger defined for the __QuickAccessToolBar__. It is located in the 'Triggers' pane.
>![{{ site.framework_name }} RadRibbonView  ](images/RibbonView_Styling_QAT_Triggers.png)
{% endif %}

{% if site.site_name == 'Silverlight' %}
If you go to the 'Resources' pane, you will see an editable list of resources generated together with the style and used by it. In this list you will find the brushes, styles and templates needed to change the visual appearance of the __QuickAccessToolBar__. Their names indicate to which part of the __QuickAccessToolBar's__ appearance they are assigned.
![{{ site.framework_name }} RadRibbonView  ](images/RibbonView_Styling_QAT_Resources.png)

* QatBelowBackgroundBrush - a brush that represents the background color of the __QuickAccessToolBar__, when it is positioned bellow the RibbonView control						

* QatBelowOuterBorderBrush - a brush that represents the color of the __QuickAccessToolBar__'s border, when it is positioned bellow the RibbonView control						

* QatButtonArrow - a brush that represents the background color of the __Quick Access Menu__ __Button__ indicator						

* QatButtonArrowHighlight - a brush that represents the color of the __Quick Access Menu__ __Button__ indicator's border						

* QuickAccessToolBarStyle - represents the style applied to the __QuickAccessToolBar__

>tip Changing the value of the resources can be done by clicking on the color indicator or the icon next to them.

Modify the resource to bring the desired appearance to the __QuickAccessToolBar__. For more detailed information, please, view the __Example__ section below.

## Example
For the purpure of this example, let's set the __RadRibbonView.QuickAccessToolBarPosition__ to __BelowRibbon__. Then we can modify the __QuickAccessToolBar__ resources like so:
![{{ site.framework_name }} RadRibbonView  ](images/RibbonView_Styling_QAT_ResourcesModified.png)

Here is a snapshot of the result:
![{{ site.framework_name }} RadRibbonView  ](images/RibbonView_Styling_QAT_Example.png)

{% endif %}

## Styling QuickAccessToolbar items using ItemContainerStyleSelector

> With **R1 2017** we introduced predefined styles inside QuickAccessToolbar, so in order to style its items you can use QuickAccessToolbar's **ItemContainerStyleSelector** property.

First, define a RadRibbonView with a QuickAccessToolbar:

__Example 1: RadRibbonView with QuickAccessToolbar__
```XAML
	 <telerik:RadRibbonView ApplicationButtonContent="File">
        <telerik:RadRibbonView.QuickAccessToolBar>
            <telerik:QuickAccessToolBar>
               <telerik:RadRibbonButton Text="Save" Foreground="White" />
                <telerik:RadRibbonButton Text="Print" Foreground="White"/>
            </telerik:QuickAccessToolBar>
        </telerik:RadRibbonView.QuickAccessToolBar>
    </telerik:RadRibbonView>
```

Then you will need a custom StyleSelector, which will choose a style for the RadRibbonButtons based on their text:

__Example 2: Define ItemContainerStyleSelector__  
```C#
	public class QATItemContainerStyleSelector : StyleSelector
    {
        public Style SaveStyle { get; set; }
        public Style PrintStyle { get; set; }

        public override Style SelectStyle(object item, DependencyObject container)
        {
            var button = item as RadRibbonButton;
            if (button != null)
            {
                if(button.Text == "Save")
                {
                    return this.SaveStyle;
                }
                else if(button.Text == "Print")
                {
                    return this.PrintStyle;
                }
            }

            return base.SelectStyle(item, container);
        }
    }
```
```VB.NET
    Public Class QATItemContainerStyleSelector
        Inherits StyleSelector
        Public Property SaveStyle() As Style
            Get
                Return m_SaveStyle
            End Get
            Set
                m_SaveStyle = Value
            End Set
        End Property
        Private m_SaveStyle As Style
        Public Property PrintStyle() As Style
            Get
                Return m_PrintStyle
            End Get
            Set
                m_PrintStyle = Value
            End Set
        End Property
        Private m_PrintStyle As Style

        Public Overrides Function SelectStyle(item As Object, container As DependencyObject) As Style
            Dim button = TryCast(item, RadRibbonButton)
            If button IsNot Nothing Then
                If button.Text = "Save" Then
                    Return Me.SaveStyle
                ElseIf button.Text = "Print" Then
                    Return Me.PrintStyle
                End If
            End If

            Return MyBase.SelectStyle(item, container)
        End Function
    End Class
```

Finally, you shold define the two custom styles and assign the __QATItemContainerStyleSelector__ to the __ItemContainerStyleSelector__ property of the QuickAccessToolBar.

__Example 3: Define custom styles and set ItemContainerStyleSelector__
```XAML
	<Style x:Key="PrintStyle" TargetType="telerik:RadRibbonButton" BasedOn="{StaticResource RadRibbonButtonStyle}">
            <Setter Property="Background" Value="Red" />
            <Setter Property="Size" Value="Medium" />
    </Style>

    <Style x:Key="SaveStyle" TargetType="telerik:RadRibbonButton" BasedOn="{StaticResource RadRibbonButtonStyle}">
            <Setter Property="Background" Value="Blue" />
            <Setter Property="Size" Value="Medium" />
    </Style>

    <local:QATItemContainerStyleSelector x:Key="QATItemContainerStyleSelector"
                    PrintStyle="{StaticResource PrintStyle}"
                    SaveStyle="{StaticResource SaveStyle}" />

    <Style BasedOn="{StaticResource QuickAccessToolBarStyle}" TargetType="telerik:QuickAccessToolBar">
        <Setter Property="ItemContainerStyleSelector" Value="{StaticResource QATItemContainerStyleSelector}" />
    </Style>
```

> This example is implemented with [NoXaml Binaries]({%slug styling-apperance-implicit-styles-overview%}) and the styles are based on the [default styles]({%slug implicit-styles-styling-the-controls%}) for the theme.

#### __Figure 1: QuickAccessToolBar styled with ItemContainerStyleSelector__ 
 ![QuickAccessToolBar ItemContainerStyleSelector](images/RadRibbonView_QuickAccessToolbar_ItemContainerStyleSelector.png)

## See Also
 * [Styling the RadRibbonView]({%slug radribbonview-styling-ribbonview%})
 * [RadRibbonView Template Structure]({%slug radribbonview-styling-templatestructure%})
 * [Styling the RadRibbonView TitleBar]({%slug radribbonview-styling-titlebar%})
 * [Styling the ApplicationButton]({%slug radribbonview-styling-applicationbutton%})
