---
title: Grouping
page_title: Grouping
description: Check our &quot;Grouping&quot; documentation article for the RadDiagram {{ site.framework_name }} control.
slug: raddiagram-features-grouping
tags: grouping
published: True
position: 12
---

# Grouping

__Grouping__ in the __RadDiagram__ is a way of organizing shapes and connections in logical groups. Groups are non-visual, logical collections of shapes and/or connections and/or other groups which can be created in code behind or with Commands.

>Please note that the examples in this tutorial are showcasing Telerik Windows8 theme. In the {% if site.site_name == 'Silverlight' %}[Setting a Theme](http://www.telerik.com/help/silverlight/common-styling-apperance-setting-theme.html#Setting_Application-Wide_Built-In_Theme_in_the_Code-Behind){% endif %}{% if site.site_name == 'WPF' %}[Setting a Theme](http://www.telerik.com/help/wpf/common-styling-apperance-setting-theme-wpf.html#Setting_Application-Wide_Built-In_Theme_in_the_Code-Behind){% endif %} article you can find more information on how to set an application-wide theme.

## Grouping API

__IGroup__, __IShape__ and __IConnection__ implement the __IGroupable__ interface.

IGroup provides a collection of IGroupable Items. This practically means that you can have groups of shapes, connections and other groups. This allows you to have unlimited levels of nested logical groups.

The __IGroupable__ interface has two members:

* __ParentGroup__ - of type IGroup.			

* __ParentGroupChanged__ event- of type EventHandler<PropertyEventArgs<IGroup>>.			

The __IGroup__ has the following members		

* __IsSelected__- of type boolean.			

* __Items__ - IList<IGroupable>.			

* __Name__ - string.			

* __ItemsChanged__ - of type NotifyCollectionChangedEventHandler.			

* __SelectionChanged__ - of type EventHandler.			

The __RadDiagram__ provides the following "grouping" members:		

* __Group__([string groupName], params IGroupable[] items)) - creates an IGroup from a given Array of IGroupable items.			

* __Ungroup__(params IGroup[] items)- removes the logical groups previously created.			

* __Groups__ - IEnumerable<IGroup>. The list of root-level Groups created in the RadDiagram.			

* __GroupsChanged__ - of type EventHandler. Fires when grouping or ungrouping is performed. Does not fire when an Item's ParentGroup is changed.			

* __GroupStyle__ - Style that applies to the Selection Rectangle around the logical groups.			

The __DiagramCommands__ class has __Group__ and __Ungroup__ which are both __RoutedUICommands__. The Group Command groups the selected IGroupable-s and the Ungroup command ungroups the selected IGroups.		

## Grouping In Code Behind

In the next example we will create 20 shapes with contents - "1", "2",... "20" and we will group them by their parity.

Let's first create some random shapes:

#### __C#__
```C#
	private void RadButton_Click_1(object sender, RoutedEventArgs e)
	{
			for (int i = 1; i < 21; i++)
			{
				RadDiagramShape shape = new RadDiagramShape() { Width = 30, Height = 30, Content = i };
				shape.Geometry = ShapeFactory.GetShapeGeometry(CommonShapeType.EllipseShape);
				shape.Position = new Point(random.Next(0, 900), random.Next(0, 200));
				this.diagram.Items.Add(shape);
			}
	}
```

#### __VB.NET__
```VB.NET
	Private Sub RadButton_Click_1(sender As Object, e As RoutedEventArgs)
		For i As Integer = 1 To 20
			Dim shape As New RadDiagramShape() With { 
				 .Width = 30, 
				 .Height = 30, 
				 .Content = i 
				}
			shape.Geometry = ShapeFactory.GetShapeGeometry(CommonShapeType.EllipseShape)
			shape.Position = New Point(random.Next(0, 900), random.Next(0, 200))
			Me.diagram.Items.Add(shape)
		Next
	End Sub
```

Now let's implement some grouping logic on Button's Click:

#### __C#__
```C#
	private void RadButton_Click_3(object sender, RoutedEventArgs e)
	{
		IShape[] evenShapes = this.diagram.Shapes.Where(x => int.Parse(x.Content.ToString()) % 2 == 0).ToArray<IShape>();
		IShape[] oddShapes = this.diagram.Shapes.Where(x => int.Parse(x.Content.ToString()) % 2 == 1).ToArray<IShape>();
		this.diagram.Group("Even", evenShapes);
		this.diagram.Group("Odd", oddShapes);
	}
```

#### __VB.NET__
```VB.NET
	Private Sub RadButton_Click_3(sender As Object, e As RoutedEventArgs)
		Dim evenShapes As IShape() = Me.diagram.Shapes.Where(Function(x) Integer.Parse(x.Content.ToString()) Mod 2 = 0).ToArray(Of IShape)()
		Dim oddShapes As IShape() = Me.diagram.Shapes.Where(Function(x) Integer.Parse(x.Content.ToString()) Mod 2 = 1).ToArray(Of IShape)()
		Me.diagram.Group("Even", evenShapes)
		Me.diagram.Group("Odd", oddShapes)
	End Sub
```

Below you can see how the grouping works:

![raddiagram-features-grouping](images/raddiagram-features-grouping.png)

Now let's play with grouping and upgrouping. Below are some code examples and the result of the code execution:

#### __C#__
```C#
    this.diagram.Group("123", this.diagram.Shapes[1], this.diagram.Shapes[2], this.diagram.Shapes[3]);
    this.diagram.Group("345", this.diagram.Shapes[3], this.diagram.Shapes[4], this.diagram.Shapes[5]);
```

#### __VB.NET__
```VB.NET
    Me.diagram.Group("123", this.diagram.Shapes[1], this.diagram.Shapes[2], this.diagram.Shapes[3]);
    Me.diagram.Group("345", this.diagram.Shapes[3], this.diagram.Shapes[4], this.diagram.Shapes[5]);
```

This makes group "123" with items __{Shapes[1],Shapes[2]}__ and "345" with items __{Shapes[3], Shapes[4], Shapes[5]}__.		

The creation of the second group excludes Shapes[3] from group "123".

Alternatively if we use one name in the method:

#### __C#__
```C#
	this.diagram.Group("123", this.diagram.Shapes[1], this.diagram.Shapes[2], this.diagram.Shapes[3]);
	this.diagram.Group("123", this.diagram.Shapes[3], this.diagram.Shapes[4], this.diagram.Shapes[5]);
```

#### __VB.NET__
```VB.NET
	Me.diagram.Group("123", this.diagram.Shapes[1], this.diagram.Shapes[2], this.diagram.Shapes[3]);
	Me.diagram.Group("123", this.diagram.Shapes[3], this.diagram.Shapes[4], this.diagram.Shapes[5]);
```

This produces a __single group "123"__ with the 5 elements Shapes[1]-Shapes[5].		

__How To Create SubGroups__

__Subgrouping__ must be done from subgroups to parentgroups. __In other words, creating a parent group, then creating its subgroup is not possible__.		

Below is an example of creating a subgroups and a parent group.

#### __C#__
```C#
    var groupA = this.diagram.Group("1-2", this.diagram.Shapes[1], this.diagram.Shapes[2]);
    var groupB = this.diagram.Group("3-4", this.diagram.Shapes[3], this.diagram.Shapes[4]);
    var parentGroup = this.diagram.Group("1-2-3-4",groupA,groupB);
```

#### __VB.NET__
```VB.NET
    Dim groupA = Me.diagram.Group("1-2", Me.diagram.Shapes(1), Me.diagram.Shapes(2))
    Dim groupB = Me.diagram.Group("3-4", Me.diagram.Shapes(3), Me.diagram.Shapes(4))
    Dim parentGroup = Me.diagram.Group("1-2-3-4", groupA, groupB)
```

In the picture below you can see a how consecutive clicks on a shape reflects the selection of groups.

First click selects the outermost (the biggest group), second click selects the smaller group and the third selects only the shape.The forth click will select the biggest group and so on.

![radiagram-features-grouping-2](images/radiagram-features-grouping-2.png)

> __If you need to select particular items without selecting the whole group, you can use Rectangular Selection.__

What will happen if we try to create parent group then create subgroups?

#### __C#__
```C#
    this.diagram.Group("1-2-3-4", this.diagram.Shapes[1], this.diagram.Shapes[2], this.diagram.Shapes[3], this.diagram.Shapes[4]);
    this.diagram.Group("1-2", this.diagram.Shapes[1], this.diagram.Shapes[2]);
```

#### __VB.NET__
```VB.NET
    Me.diagram.Group("1-2-3-4", this.diagram.Shapes[1], this.diagram.Shapes[2], this.diagram.Shapes[3], this.diagram.Shapes[4]);
    Me.diagram.Group("1-2", this.diagram.Shapes[1], this.diagram.Shapes[2]);
```

This will create two separate groups - "1-2-3-4" with items {Shapes[3], Shapes[4]} and "1-2" with items {Shapes[1], Shapes[2]}.

> __Creating a parent group then creating its subgroup is not possible.__

__Ungrouping__

You can Ungroup one or several groups with the __Ungroup__ method of RadDiagram:		

#### __C#__
```C#
	this.diagram.Ungroup(groupA, groupB, groupC);
	this.diagram.Ungroup(this.diagram.Groups.ToArray());		  
```

#### __VB.NET__
```VB.NET
	Me.diagram.Ungroup(groupA, groupB, groupC);
	Me.diagram.Ungroup(this.diagram.Groups.ToArray());		  
```

## Grouping With Commands

Using the DiagramCommands Group and Ungroup is straightforward. Group applies to the selected IGroupables and Ungroup applies to the selected IGroups.

#### __XAML__
```XAML
    <telerik:RadDiagram IsSnapToItemsEnabled="False" x:Name="diagram" HorizontalAlignment="Stretch" Height="200" Width="800"
    IsBackgroundSurfaceVisible="True"  />
    <telerik:RadButton  Command="telerik:DiagramCommands.Group"
    CommandTarget="{Binding ElementName=diagram}" Content="Group" />
    <telerik:RadButton  Command="telerik:DiagramCommands.Ungroup"
    CommandTarget="{Binding ElementName=diagram}" Content="Ungroup" />		
```

![radiagram-features-grouping-3](images/radiagram-features-grouping-3.png)

## See Also
 * [Commands]({%slug raddiagrams-features-commands%})