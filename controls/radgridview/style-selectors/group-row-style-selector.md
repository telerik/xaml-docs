---
title: GroupRowStyleSelector
page_title: GroupRowStyleSelector
description: Learn how to style groups of grid rows differently by using the GroupRowStyleSelector property of RadGridView - Telerik's {{ site.framework_name }} DataGrid.
slug: gridview-group-row-style-selector
tags: grouprowstyleselector
published: True
position: 3
---

# GroupRowStyleSelector

You can use RadGridView's **GroupRowStyleSelector** property if you need to style group rows differently based on a specific condition.

>important Bear in mind that the [GroupRowStyle]({%slug gridview-styling-group-row%}) takes precedence over the **GroupRowStyleSelector** and will overwrite it if both are defined simultaneously.

To achieve this, first create a new class that inherits from the **StyleSelector** class and override its **SelectStyle** method:

__Example 1: The GroupRowStyleSelector class__

```C#
	public class GroupRowStyleSelector : StyleSelector
	{
	    public override Style SelectStyle(object item, DependencyObject container)
	    {
	        var group = item as QueryableCollectionViewGroup;
	        if (group.ItemCount > 1)
	        {
	            return BigGroupStyle;
	        }
	        else
	        {
	            return SmallGroupStyle;
	        }
	    }
	
	    public Style BigGroupStyle { get; set; }
	    public Style SmallGroupStyle { get; set; }
	}
```
```VB.NET
	Public Class GroupRowStyleSelector
	    Inherits StyleSelector
	    Public Overrides Function SelectStyle(item As Object, container As DependencyObject) As Style
	        Dim group = TryCast(item, CollectionViewGroup)
	
	        If group IsNot Nothing Then
	            If group.ItemCount > 1 Then
	                Return BigGroupStyle
	            Else
	                Return SmallGroupStyle
	            End If
	        End If
	
	        Return Nothing
	    End Function
	
	    Public Property BigGroupStyle() As Style
	        Get
	            Return m_BigGroupStyle
	        End Get
	        Set
	            m_BigGroupStyle = Value
	        End Set
	    End Property
	    Private m_BigGroupStyle As Style
	
	    Public Property SmallGroupStyle() As Style
	        Get
	            Return m_SmallGroupStyle
	        End Get
	        Set
	            m_SmallGroupStyle = Value
	        End Set
	    End Property
	    Private m_SmallGroupStyle As Style
	End Class
```

In the XAML file, define the style selector as a resource and set the properties of the **BigGroupStyle** and **SmallGroupStyle**:

__Example 2: Setting the BigGroupStyle and SmallGroupStyle__

```XAML
	<Window.Resources>
	    <my:GroupRowStyleSelector x:Key="GroupRowStyleSelector">
	        <my:GroupRowStyleSelector.BigGroupStyle>
	            <Style TargetType="telerik:GroupHeaderRow">
	                <Setter Property="Background" Value="Red" />
	            </Style>
	        </my:GroupRowStyleSelector.BigGroupStyle>
	        <my:GroupRowStyleSelector.SmallGroupStyle>
	            <Style TargetType="telerik:GroupHeaderRow">
	                <Setter Property="Background" Value="Yellow" />
	            </Style>
	        </my:GroupRowStyleSelector.SmallGroupStyle>
	    </my:GroupRowStyleSelector>
	</Window.Resources>
```

>If you're using **GroupRenderMode="Nested"** the style should target the **GridViewGroupRow** element.

>The **"my:"** prefix before **GroupRowStyleSelector** specifies the mapping for the namespace of the project: **xmlns:my="..."**

Finally, set the **GroupRowStyleSelector** property:

__Example 3: Setting the GroupRowStyleSelector property__

```XAML
	<telerik:RadGridView GroupRowStyleSelector="{StaticResource GroupRowStyleSelector}" />
```

And here is the final result:

#### __Figure 1: The group footer rows styled using the GroupRowStyleSelector property__

![Telerik {{ site.framework_name }} DataGrid-grouprowstyleselector](images/gridview-grouprowstyleselector.png)

## See Also

* [Styling Group Row]({%slug gridview-styling-group-row%})

* [CellStyleSelector]({%slug gridview-cell-style-selector%})
