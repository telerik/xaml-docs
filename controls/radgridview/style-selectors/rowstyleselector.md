---
title: RowStyleSelectors
page_title: RowStyleSelectors
description: RowStyleSelectors
slug: gridview-rowstyleselector
tags: rowstyleselectors
published: True
position: 2
---

# RowStyleSelectors

This article will show you how to style conditionally RadGridView rows using the __RowStyleSelector__ property.
		
>tipTo learn the basics about __StyleSelectors__ please check [this article]({%slug gridview-style-selectors-overview%}).
		  
Assume we have a GridView bound to a collection of clubs. Each club has a property StadiumCapacity. What we want to achieve is to set the background color of the rows to Red if the capacity is greater than 50 000 or yellow otherwise:
		
![](images/gridview_rowstyleselector.png)

To do so follow these steps:

1. Create a new class which inherits the __StyleSelector__ class (which resides in the 
 {% if site.site_name == 'Silverlight' %}__Telerik.Windows.Controls__{% endif %}{% if site.site_name == 'WPF' %}__System.Windows.Controls__{% endif %} assembly).

2. Override its __SelectStyle__ method. Based on your conditions - you return the proper Style that will be applied to the framework element (row in our case).

#### __C#__

{{region gridview-rowstyleselector_0}}

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

{{region gridview-rowstyleselector_1}}

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

{{region gridview-rowstyleselector_2}}

	<UserControl x:Class="WpfApplication1.MainWindow"
	        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
	        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
	        xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
	        xmlns:my="clr-namespace:RowStyleSelector">
	<Grid>
		<Grid.Resources>
			<my:StadiumCapacityStyle x:Key="stadiumCapacityStyle">
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
		...
	</Grid>
	</UserControl>
{{endregion}}

>The __"my:"__ prefix before __StadiumCapacityStyle__ specifies the mapping for the namespace of the project: __xmlns:my="__

If you are using our [Implicit Themes]({%slug styling-apperance-implicit-styles-overview%}), you should base the style on the one defined for the corresponding theme:

#### __XAML__

{{region gridview-rowstyleselector_4}}

    <Style TargetType="telerik:GridViewRow" BasedOn="{StaticResource GridViewRowStyle}">
    	<Setter Property="Background" Value="Yellow" />
    </Style>
{{endregion}}

4. Finally, set the __RowStyleSelector__ property of the __RadGridView__:

#### __XAML__

{{region gridview-rowstyleselector_3}}

	<telerik:RadGridView Name="clubsGrid" 
	                     ItemsSource="{Binding Clubs}"
	                     RowStyleSelector="{StaticResource stadiumCapacityStyle}" />
{{endregion}}

>Since the virtualization of the __GridView__ is turned on by default, it is not recommended to work with the visual elements (i.e. GridViewRow) and their properties. __You should not set properties of the GridViewRow inside the SelectStyle method__. Please check this [help article]({%slug radgridview-features-ui-virtualization%}) for a reference.
		 
>tipYou can download a runnable project of the previous example from our online SDK repository [here](https://github.com/telerik/xaml-sdk/), the example is listed as __GridView__ / __RowStyleSelector__.
          
