---
title: How to Customize the Look of the Tick Marks Using TickTemplateSelector
page_title: Change the Appearance of the Tick Marks through the TickTemplateSelector property
description: Check our &quot;How to Customize the Look of the Tick Marks Using TickTemplateSelector&quot; documentation article for the RadSlider {{ site.framework_name }} control.
slug: radslider-tick-templateselector
tags: how,to,customize,the,look,of,the,tick,marks,using,ticktemplateselector
published: True
position: 1
---

# How to Customize the Look of the Tick Marks Using TickTemplateSelector

The __TickTemplateSelector__ property gives you the ability to display ticks with different templates. This tutorial will walk you through the common task of creating and applying __TickTemplateSelector.__

Having the following Slider declaration, every fourth tick will be displayed: 

#### __[XAML] Example 1: Defining the RadSlider__

{{region xaml-radslider-tick-templateselector_0}}
	<telerik:RadSlider x:Name="MySlider" 
	                   HandlesVisibility="Visible"
	                   IsSnapToTickEnabled="True"
	                   Maximum="30"
	                   SmallChange="1"
	                   TickFrequency="1"
	                   TickPlacement="TopLeft" />
{{endregion}}

First, you have to create two DataTemplates in the resources of your application. In the first one the tick marks will be displayed as Ellipses and the second one will be empty. 

#### __[XAML] Example 2: Creating a custom template for the ticks__

{{region xaml-radslider-tick-templateselector_1}}
	<DataTemplate x:Key="EllipseTemplate">
	    <Grid>
	        <Ellipse Width="5" 
	                 Height="5"
	                 Fill="Black" />
	    </Grid>
	</DataTemplate>
	
	<DataTemplate x:Key="EmptyTemplate">
	    <Grid />
	</DataTemplate>
{{endregion}}

The next step is to create the __TickTemplateSelector__ and choose the appropriate template depending on the numeric value of the tick:

>When you create a __TickTemplateSelector__, you must derive from the __DataTemplateSelector__ class.

#### __[C#] Example 3: Defining the custom template selector__

{{region cs-radslider-tick-templateselector_2}}
	public class TickTemplateSelector : DataTemplateSelector
	{
	}
{{endregion}}

#### __[VB.NET] Example 3: Defining the custom template selector__

{{region vb-radslider-tick-templateselector_3}}
	Public Class TickTemplateSelector
	    Inherits DataTemplateSelector
	End Class
{{endregion}}

Override, the __SelectTemplate__ method and implement your custom logic in it. The method accepts the following arguments:

* __object__: The actual object being bound.

* __DependencyObject__: The container for the object argument. 

#### __[C#] Example 4: Overriding the SelectTemplate method__

{{region cs-radslider-tick-templateselector_4}}
	public class TickTemplateSelector : DataTemplateSelector
	{
	    public DataTemplate EllipseTemplate { get; set; }
	    public DataTemplate EmptyTemplate { get; set; }
	    public override DataTemplate SelectTemplate(object item, DependencyObject container)
	    {
	        double tick = Convert.ToDouble(item);
	        if (tick % 4 == 0.0)
	        {
	            return EllipseTemplate;
	        }
	        else
	        {
	            return EmptyTemplate;
	        }
	    }
	}
{{endregion}}

#### __[VB.NET] Example 4: Overriding the SelectTemplate method__

{{region vb-radslider-tick-templateselector_5}}
	Public Class TickTemplateSelector
	Inherits DataTemplateSelector

		Public Property EllipseTemplate() As DataTemplate
		Public Property EmptyTemplate() As DataTemplate
		Public Overrides Function SelectTemplate(ByVal item As Object, ByVal container As DependencyObject) As DataTemplate
			Dim tick As Double = Convert.ToDouble(item)
			If tick Mod 4 = 0.0 Then
				Return EllipseTemplate
			Else
				Return EmptyTemplate
			End If
		End Function
End Class
{{endregion}}

Define the created selector as a resource in the XAML and set it to the __TickTemplateSelector__ property.

#### __[XAML] Example 5: Defining the template selector in XAML__

{{region xaml-radslider-tick-templateselector_6}}
	<local:TickTemplateSelector x:Key="TickTemplateSelector" 
	                            EllipseTemplate="{StaticResource EllipseTemplate}"
	                            EmptyTemplate="{StaticResource EmptyTemplate}" />
{{endregion}}

#### __[XAML] Example 6: Setting the TickTemplate and TickTemplateSelector properties__

{{region xaml-radslider-tick-templateselector_7}}
	<telerik:RadSlider HandlesVisibility="Visible"
	                   IsSnapToTickEnabled="True"
	                   Maximum="30"
	                   SmallChange="1"
	                   TickFrequency="1"
	                   TickPlacement="TopLeft"
	                   TickTemplate="{x:Null}"
	                   TickTemplateSelector="{StaticResource TickTemplateSelector}" />
{{endregion}}

>important Please note that the **TickTemplate** property needs to be set to **null** for the **TickTemplateSelector** property to be respected.

![The RadSlider with the custom TickTemplateSelector](images/SliderTickTemplate.png)

## See Also

* [Styling RadSlider]({%slug radslider-styling-overview%})
* [Tick Template]({%slug radslider-tick-template%})
* [Tick Placement]({%slug radslider-tick-placement%})