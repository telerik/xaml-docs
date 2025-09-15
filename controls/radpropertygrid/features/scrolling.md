---
title: Scrolling into View
page_title: Scrolling into View
description: Check our &quot;Scrolling into View&quot; documentation article for the RadPropertyGrid {{ site.framework_name }} control.
slug: radpropertygrid-scrolling
tags: scrolling,into,view
published: True
position: 10
---

# Scrolling into View

Since __RadPropertyGrid__ utilizes UI virtualization, it only initializes those PropertyGridFields that should be currently displayed in the view port. Thus, if one aims to bring some PropertyDefinition's PropertyGridField into view, a standard visual tree traversal will not do the work. 

## The ScrollIntoViewAsync method

__ScrollIntoViewAsync(PropertyDefinition propertyDefinition, Action<PropertyGridField> finishedCallback)__ handles the mentioned scenario. Invoking it for a certain __PropertyDefinition__ forces RadPropertyGrid to calculate the needed scroll offset to display its PropertyGridField and then scrolls to it.

>tipAfter the scrolling operation is accomplished, the __finishedCallback__ is executed, passing the __newly realized PropertyGridField as a parameter__.

>importantScrollIntoViewAsync is supported only when __RenderMode is set to Flat__. For more information on the different rendering modes, please check the [Layout Rendering Modes]({%slug radpropertygrid-features-layout-rendering-modes%}) article.

You can define RadPropertyGrid similar to:

__Example 1: Defining RadPropertyGrid with manually defined PropertyDefinitions__

	```XAML
	<Grid>
	    <Grid.RowDefinitions>
	        <RowDefinition Height="*"/>
	        <RowDefinition Height="Auto" />
	    </Grid.RowDefinitions>
	    <telerik:RadPropertyGrid Height="200" x:Name="PropertyGrid1" RenderMode="Flat" AutoGeneratePropertyDefinitions="False">
	        <telerik:RadPropertyGrid.PropertyDefinitions>
	            <telerik:PropertyDefinition Binding="{Binding FirstName}" GroupName="Group Name" DisplayName="FirstName"/>
	            <telerik:PropertyDefinition Binding="{Binding LastName}" GroupName="Group Name" DisplayName="LastName"/>
	            <telerik:PropertyDefinition Binding="{Binding Ocupation}" GroupName="Occupation" DisplayName="Occupation"/>
	            <telerik:PropertyDefinition Binding="{Binding Salary}" GroupName="Occupation" DisplayName="Salary"/>
	            <telerik:PropertyDefinition Binding="{Binding IsMarried}" GroupName="Personal" DisplayName="IsMarried"/>
	        </telerik:RadPropertyGrid.PropertyDefinitions>
	    </telerik:RadPropertyGrid>
	    <Button Name="Button1"
	Grid.Row="1"
	Content="Scroll field into view "
	Click="Button1_Click"
	Margin="5"
	HorizontalAlignment="Left"/>
	</Grid>
```

As to assigning the __Item of RadPropertyGrid__, please check the __Binding RadPropertyGrid to an item__ section in [Getting Started with RadPropertyGrid]({%slug radpropertygrid-getting-started-getting-started%}) help article.

You can see the result after starting the application on __Figure 1__:

__Figure 1__: RadPropertyGrid in sorted mode with some fields not currently visible

![Rad Property Grid Scroll Sorted 1](images/RadPropertyGrid_Scroll_Sorted_1.png)

Then, click on __Scroll field into view__ button and execute the following code:

__Example 2: Scrolling to a particular PropertyDefinition and selecting it__

	```C#
	private void Button1_Click(object sender, RoutedEventArgs e)
	{
	    var propertyDefinition = this.PropertyGrid1.PropertyDefinitions.Where(x => x.DisplayName == "IsMarried").FirstOrDefault();
	    if (propertyDefinition != null)
	    {
	        PropertyGrid1.ScrollIntoViewAsync(propertyDefinition, new Action<PropertyGridField>(f => f.IsSelected = true));
	    }
	}
```

__Example 2: Scrolling to a particular PropertyDefinition and selecting it__

	```VB
	Private Sub Button1_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
	    Dim propertyDefinition = Me.PropertyGrid1.PropertyDefinitions.Where(Function(x) x.DisplayName = "IsMarried").FirstOrDefault()
	    If propertyDefinition IsNot Nothing Then
	        PropertyGrid1.ScrollIntoViewAsync(propertyDefinition, New Action(Of PropertyGridField)(Sub(f) f.IsSelected = True))
	    End If
	End Sub
```

You can observe the result on __Figure 2__.

__Figure 2__: RadPropertyGrid after scrolling to a particular PropertyDefinition and selecting it![Rad Property Grid Scroll Sorted 2](images/RadPropertyGrid_Scroll_Sorted_2.png)

## ScrollIntoViewAsync with grouping

__ScrollIntoViewAsync__ can also be used in __grouped scenarios__, to bring given PropertyDefinition’s PropertyGridField in the view port. 
          

>tipInvoking it will scroll to the group, expanding it if needed.

However, this functionality is supported only for groups that have valid Key (PropertyDefinition.GroupName). You can find more information on how to define groups in the article on [Grouping Support]({%slug radpropertygrid-grouping%}).
        

__Figure 3__: RadPropertyGrid in grouped mode with some fields not currently visible![Rad Property Grid Scroll Grouped 1](images/RadPropertyGrid_Scroll_Grouped_1.png)

Then, click on __Scroll field into view__ button and execute the code from **Example 2**.

You can observe the result on __Figure 4__.
        

__Figure 4__: RadPropertyGrid after scrolling to a particular PropertyDefinition and selecting it![Rad Property Grid Scroll Grouped 2](images/RadPropertyGrid_Scroll_Grouped_2.png)

## ScrollIntoViewAsync with nested properties

When ScrollIntoView is invoked for a nested PropertyDefinition, its parent’s field gets expanded. You can find more information on how to define nested PropertyDefinitions in the article on [Nested Properties]({%slug radpropertygrid-nested-properties%}).
        

To guarantee that such operations will be successfully executed, both root and nested PropertyDefinitions should have a valid Binding set.
        

>tipIt works with multiple levels of hierarchy.
          

For sample code on how to perform the scroll please refer to the [ScrollIntoViewAsync section](#the-scrollintoviewasync-method) above.

## See Also

 * [Getting Started]({%slug radpropertygrid-getting-started-getting-started%})

 * [Layout Rendering Modes]({%slug radpropertygrid-features-layout-rendering-modes%})

 * [Grouping Support]({%slug radpropertygrid-grouping%})

 * [Nested Properties]({%slug radpropertygrid-nested-properties%})

 * [Autogenerated Property Definitions]({%slug radpropertygrid-getting-started-autogenerated-property-definitions%})
