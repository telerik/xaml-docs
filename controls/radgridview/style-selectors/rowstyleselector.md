---
title: RowStyleSelector
page_title: RowStyleSelector
description: RowStyleSelector
slug: gridview-rowstyleselector
tags: rowstyleselector
published: True
position: 2
---

# RowStyleSelector

This article illustrates how to conditionally style rows through RadGridView's [RowStyleSelector](#rowstyleselector) and [AlternateRowStyleSelector](alternaterowstyleselector) properties.
		
>tipLearn more about [StyleSelectors]({%slug gridview-style-selectors-overview%}).

## RowStyleSelector
		  
Assume we have RadGridView bound to a collection of Clubs. Each Club has a property StadiumCapacity. What we want to achieve is to set the background color of the rows to __Red if the capacity > 50 000 or Yellow otherwise__:

#### __Figure 1: The expected result__
		
![The expected result](images/gridview_rowstyleselector.png)

To do so follow these steps:

1. Create a new class which inherits the __StyleSelector__ class (which resides in the 
 {% if site.site_name == 'Silverlight' %}__Telerik.Windows.Controls__{% endif %}{% if site.site_name == 'WPF' %}__System.Windows.Controls__{% endif %} assembly).

2. Override its __SelectStyle__ method. Based on your conditions - you return the proper Style that will be applied to the framework element (row in our case).

#### __[C#] Example 1: The StadiumCapacityStyle class__

{{region cs-gridview-rowstyleselector_0}}
	public class StadiumCapacityStyle : StyleSelector
	{
	    public override Style SelectStyle(object item, DependencyObject container)
	    {
	        if (item is Club)
	        {
	            Club club = item as Club;
	            if (club.StadiumCapacity > 50000)
	            {
	                return BigStadiumStyle;
	            }
	            else
	            {
	                return SmallStadiumStyle;
	            }
	        }
	        return null;
	    }
	    public Style BigStadiumStyle { get; set; }
	    public Style SmallStadiumStyle { get; set; }
	}
{{endregion}}

#### __[VB.NET] Example 1: The StadiumCapacityStyle class__

{{region vb-gridview-rowstyleselector_1}}
	Public Class StadiumCapacityStyle
	    Inherits StyleSelector
	    Public Overrides Function SelectStyle(item As Object, container As DependencyObject) As Style
	        If TypeOf item Is Club Then
	            Dim club As Club = TryCast(item, Club)
	            If club.StadiumCapacity > 50000 Then
	                Return BigStadiumStyle
	            Else
	                Return SmallStadiumStyle
	            End If
	        End If
	        Return Nothing
	    End Function
	    Public Property BigStadiumStyle() As Style
	        Get
	            Return m_BigStadiumStyle
	        End Get
	        Set
	            m_BigStadiumStyle = Value
	        End Set
	    End Property
	    Private m_BigStadiumStyle As Style
	    Public Property SmallStadiumStyle() As Style
	        Get
	            Return m_SmallStadiumStyle
	        End Get
	        Set
	            m_SmallStadiumStyle = Value
	        End Set
	    End Property
	    Private m_SmallStadiumStyle As Style
	End Class
{{endregion}}

In this case we have two different styles that could be applied:

* __BigStadiumStyle__
* __SmallStadiumStyle__. 

Depending on the underlying data you cab select which style to apply.

3.In the XAML file define the style selector as a resource and set the properties of the __BigStadiumStyle__ and __SmallStadiumStyle__:

#### __[XAML] Example 2: Set the different styles for the style selector__

{{region xaml-gridview-rowstyleselector_2}}
	<Grid.Resources>
	    <my:StadiumCapacityStyle x:Key="StadiumCapacityStyle">
	        <my:StadiumCapacityStyle.BigStadiumStyle>
	            <Style TargetType="telerik:GridViewRow">
	                <Setter Property="Background" Value="Red"/>
	            </Style>
	        </my:StadiumCapacityStyle.BigStadiumStyle>
	        <my:StadiumCapacityStyle.SmallStadiumStyle>
	            <Style TargetType="telerik:GridViewRow">
	                <Setter Property="Background" Value="Yellow" />
	            </Style>
	        </my:StadiumCapacityStyle.SmallStadiumStyle>
	    </my:StadiumCapacityStyle>
	</Grid.Resources>
{{endregion}}

>The __"my:"__ prefix before __StadiumCapacityStyle__ specifies the mapping for the namespace of the project: __xmlns:my="__

If you are using our [Implicit Themes]({%slug styling-apperance-implicit-styles-overview%}), you should base the style on the one defined for the corresponding theme:

#### __[XAML] Example 3: Base the style when using implicit styles__

{{region xaml-gridview-rowstyleselector_4}}
	<Style TargetType="telerik:GridViewRow" BasedOn="{StaticResource GridViewRowStyle}">
	    <Setter Property="Background" Value="Yellow" />
	</Style>
{{endregion}}

4.Finally, set the __RowStyleSelector__ property:

#### __[XAML] Example 4: Set RadGridView's RowStyleSelector__

{{region xaml-gridview-rowstyleselector_3}}
	<telerik:RadGridView RowStyleSelector="{StaticResource StadiumCapacityStyle}" />
{{endregion}}

>Since the virtualization of the control is turned on by default, it is not recommended to work with the visual elements (i.e. GridViewRow) and their properties. You should not set properties of GridViewRow inside SelectStyle method. [Read mode on UI Virtualization]({%slug radgridview-features-ui-virtualization%}).
		 
>tipYou can download a runnable project of the previous example from our online SDK repository [here](https://github.com/telerik/xaml-sdk/), the example is listed as __GridView/RowStyleSelector__.

## AlternateRowStyleSelector

If you've set the **AlternationCount** property, you can apply conditional styles only on the [alternating rows]({%slug radgridview-rows-alternating-rows%}) by specifying an **AlternateRowStyleSelector**.

#### __[XAML] Example 5: Set RadGridView's AlternateRowStyleSelector__

{{region gridview-rowstyleselector_5}}

	<telerik:RadGridView AlternateRowStyleSelector="{StaticResource StadiumCapacityStyle}" />
{{endregion}}

**Figure 2** shows the result of using the same StyleSelector from the previous example, but setting it as the AlternateRowStyleSelector for the RadGridView.

#### __Figure 2: The alternating rows styled using the AlternateRowStyleSelector property__

![The alternating rows styled using the AlternateRowStyleSelector property](images/gridview_alternaterowstyleselector.png)

## See Also

* [Styling Rows]({%slug gridview-styling-a-row%})

* [UI Virtualization]({%slug radgridview-features-ui-virtualization%})
          
