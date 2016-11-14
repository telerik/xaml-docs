---
title: CellStyleSelector
page_title: CellStyleSelector
description: CellStyleSelector
slug: gridview-cell-style-selector
tags: cellstyleselector
published: True
position: 1
---

# CellStyleSelector

This article will show you how to style conditionally RadGridView's cells applying __CellStyleSelector__.
		
>tipLearn more about [StyleSelectors]({%slug gridview-style-selectors-overview%}).
		  
Assume we have RadGridView bound to a collection of Clubs. Each Club has a property __StadiumCapacity__. What we want to achieve is to set the background color of the StadiumCapacity cells to __Red if the capacity > 50 000 or Yellow otherwise__:

#### __Figure 1: The expected result__

![The expected result](images/gridview_cellstyleselector.png)

To do so follow these steps:

1. Create a new class which inherits the __StyleSelector__ class.

2. Override its __SelectStyle__ method. Based on your conditions - you return the proper Style that will be applied to the framework element (GridViewCell in our case).

#### __[C#] Example 1: The StadiumCapacityStyle class__

{{region cs-gridview-cell-style-selector_0}}
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

{{region vb-gridview-cell-style-selector_1}}
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

Depending on the underlying data you can select which style to apply.

3.In the XAML file define the style selector as a resource and set the properties of __BigStadiumStyle__ and __SmallStadiumStyle__:

#### __[XAML] Example 2: Set the different styles for the style selector__

{{region gridview-cell-style-selector_2}}
		<Grid.Resources>
			<my:StadiumCapacityStyle x:Key="stadiumCapacityStyle">
				<my:StadiumCapacityStyle.BigStadiumStyle>
					<Style TargetType="telerik:GridViewCell">
						<Setter Property="Background" Value="Red"/>
					</Style>
				</my:StadiumCapacityStyle.BigStadiumStyle>
				<my:StadiumCapacityStyle.SmallStadiumStyle>
					<Style TargetType="telerik:GridViewCell">
						<Setter Property="Background" Value="Yellow" />
					</Style>
				</my:StadiumCapacityStyle.SmallStadiumStyle>
			</my:StadiumCapacityStyle>
		</Grid.Resources>
{{endregion}}

>The __"my:"__ prefix before __StadiumCapacityStyle__ specifies the mapping for the namespace of the project: __xmlns:my="__

If you are using our [Implicit Themes]({%slug styling-apperance-implicit-styles-overview%}), you should base the style on the one defined for the corresponding theme:

#### __[XAML] Example 3: Base the style when using implicit styles__

{{region gridview-cell-style-selector_4}}

	<Style TargetType="telerik:GridViewCell" BasedOn="{StaticResource GridViewCellStyle}">
		<Setter Property="Background" Value="Yellow" />
	</Style>
{{endregion}}

4.Finally, set the __CellStyleSelector__ property of the data column which represents the StadiumCapacity field:

#### __[XAML] Example 4: Set CellStyleSelector for the column__

{{region gridview-cell-style-selector_3}}

	<telerik:RadGridView ItemsSource="{Binding Clubs}"                   
	                     AutoGenerateColumns="False">
	    <telerik:RadGridView.Columns>
	        <telerik:GridViewDataColumn DataMemberBinding="{Binding Name}"/>
	        <telerik:GridViewDataColumn DataMemberBinding="{Binding Established}"
	                                    Header="Est."
	                                    DataFormatString="{}{0:yyyy}"/>
	        <telerik:GridViewDataColumn DataMemberBinding="{Binding StadiumCapacity}"
	                                    Header="Stadium"
	                                    CellStyleSelector="{StaticResource stadiumCapacityStyle}"
	                                    DataFormatString="{}{0:N0}"/>
	    </telerik:RadGridView.Columns>
	</telerik:RadGridView>
{{endregion}}

>tipIf you are using [Implicit Themes]({%slug styling-apperance-implicit-styles-overview%}), you should base the style on the one defined for the corresponding theme.

>Since the virtualization of the GridView is turned on by default, it is not recommended to work with the visual elements (i.e. GridViewCell) and their properties. You should not set properties of GridViewCell inside SelectStyle method. [Read more on UI Virtualization]({%slug radgridview-features-ui-virtualization%}).

>tipYou can download a runnable project of the previous example from our online SDK repository [here](https://github.com/telerik/xaml-sdk/), the example is listed as __GridView/CellStyleSelector__.
          
## See Also

* [Styling Cells]({%slug gridview-styling-cell%})

* [UI Virtualization]({%slug radgridview-features-ui-virtualization%})