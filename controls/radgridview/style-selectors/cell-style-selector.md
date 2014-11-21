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

This article will show you how to style conditionally RadGridView cells using the __CellStyleSelector__ property.
		

>tipTo learn the basics about __StyleSelectors__ please check [this article]({%slug gridview-style-selectors-overview%}).
		  

Assume we have a __GridView__ bound to a collection of clubs. Each club has a property __StadiumCapacity__. What we want to achieve is to set the background color of the StadiumCapacity cells to Red if the capacity is greater than 50 000 or yellow otherwise:

![](images/gridview_cellstyleselector.png)


To do so follow these steps:

1. Create a new class which inherits the __StyleSelector__ class (which resides in the __Telerik.Windows.Controls__ assembly).

2. Override its __SelectStyle__ method. Based on your conditions - you return the proper Style that will be applied to the framework element (cell in our case).

#### __C#__

{{region gridview-cell-style-selector_0}}

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

#### __VB.NET__

{{region gridview-cell-style-selector_1}}

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

In this case we have two different styles that could be applied - __BigStadiumStyle__ and __SmallStadiumStyle__. Depending on the underlying data we choose / select which style to apply.

3. In the XAML file define the style selector as a resource and set the properties of the __BigStadiumStyle__ and __SmallStadiumStyle__:

#### __XAML__

{{region gridview-cell-style-selector_2}}

	<UserControl x:Class="WpfApplication1.MainWindow"
				 xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
				 xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
				 xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
				 xmlns:my="clr-namespace:CellStyleSelector">
		<Grid>
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
			...
		</Grid>
	</UserControl>
{{endregion}}

>The __"my:"__ prefix before __StadiumCapacityStyle__ specifies the mapping for the namespace of the project: __xmlns:my="__

If you are using our [Implicit Themes]({%slug styling-apperance-implicit-styles-overview%}), you should base the style on the one defined for the corresponding theme:

#### __XAML__

{{region gridview-cell-style-selector_4}}

	<Style TargetType="telerik:GridViewCell" BasedOn="{StaticResource GridViewCellStyle}">
		<Setter Property="Background" Value="Yellow" />
	</Style>
{{endregion}}

4. Finally, set the __CellStyleSelector__ property of the data column which represents the StadiumCapacity field:

#### __XAML__

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

>Since the virtualization of the GridView is turned on by default, it is not recommended to work with the visual elements (i.e. GridViewCell) and their properties. __You should not set properties of the GridViewCell inside the SelectStyle method__. Please check this [help article]({%slug radgridview-features-ui-virtualization%}) for a reference.

>tipYou can download a runnable project of the previous example from our online SDK repository [here](https://github.com/telerik/xaml-sdk/), the example is listed as __GridView__ / __CellStyleSelector__.
          
